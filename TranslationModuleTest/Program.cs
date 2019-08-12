using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;
using System.Net;
using System.IO;
using System;

namespace TranslationModuleTest
{
    class Program
    {
        internal static class WebTranslator
        {
            public static bool Available => Limiter.CanUseNow;

            private static Dictionary<int, Dictionary<string, string>> Cash { get; }
            private static WebClient Client { get; }
            private static Regex Charset { get; }
            private static Regex StringValue { get; }
            private static string CashPath { get; }
            private static RateLimiter Limiter { get; }   
            private static bool GotTooManyRequests { get; set; }

            static WebTranslator()
            {
                Limiter = new RateLimiter(3000, 1);
                Cash = new Dictionary<int, Dictionary<string, string>>();
                CashPath = Path.Combine(Path.GetTempPath(), "WebTranslator.cash");
                if (File.Exists(CashPath))
                {
                    try
                    {
                        using (var stream = new FileStream(CashPath, FileMode.Open, FileAccess.Read))
                        using (var zipStream = new GZipStream(stream, CompressionMode.Decompress))
                        {
                            var formatter = new BinaryFormatter();
                            Cash = formatter.Deserialize(zipStream) as Dictionary<int, Dictionary<string, string>>;
                        }
                    }
                    catch (Exception) { }
                }
                

                Client = new WebClient();
                Client.Encoding = Encoding.Default;
                Client.Headers["User-Agent"] = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9";
                Client.Headers["Accept-Language"] = "en-us,en;q=0.5";
                Client.Headers["Accept-Charset"] = "ISO-8859-1,utf-8;q=0.7,*;q=0.7";
                Charset = new Regex("(?<=charset=)[\\w-]+", RegexOptions.Compiled);
                StringValue = new Regex("(?<=\\\").+?(?=\\\")", RegexOptions.Compiled);

                AppDomain.CurrentDomain.ProcessExit += OnProcessExit;
            }

            public static void WaitUntilAvailable() => Limiter.WaitForNextUse();
          
            public static bool TryTranslate(string text, string fromLanguage, string toLanguage, out string result)
            {
                result = null;

                // var languageID = fromLanguage.GetHashCode() + toLanguage.GetHashCode();
                // if (!Cash.ContainsKey(languageID)) { Cash[languageID] = new Dictionary<string, string>(); }
                // if (Cash[languageID].TryGetValue(text, out result)) { return true; }

                if (GotTooManyRequests || !Limiter.TryUse()) return false;

                var uri = string.Format(@"https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", fromLanguage, toLanguage, text);

                byte[] data;
                try
                {
                    data = Client.DownloadData(uri);
                }
                catch (WebException e)
                {
                    Console.WriteLine(e.Message);
                    if ((e.Response as HttpWebResponse).StatusCode == (HttpStatusCode)429) GotTooManyRequests = true;
                    return false;
                }

                var encoding = Charset.Match(Client.ResponseHeaders["Content-Type"]).Value;
                var response = Encoding.GetEncoding(encoding).GetString(data);
                result = StringValue.Match(response).Value;
                // Cash[languageID][text] = result;

                return true;
            }

            private static void OnProcessExit(object sender, EventArgs args)
            {
                try
                {
                    using (var stream = new FileStream(CashPath, FileMode.Create, FileAccess.Write))
                    using (var zipStream = new GZipStream(stream, CompressionMode.Compress))
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(zipStream, Cash);
                    }
                }
                catch (Exception) { }
            }
        }

        internal sealed class RateLimiter
        {
            public bool CanUseNow
            {
                get
                {
                    if (_currentUses < _frameUses) return true;

                    var frame = Environment.TickCount / _frameLength;
                    if (frame != _currentFrame) return true;

                    return false;
                }
            }

            private int _frameLength;
            private int _frameUses;
            private int _currentFrame;
            private int _currentUses;

            public RateLimiter(int frameLength, int frameUses)
            {
                if (frameLength < 1) throw new ArgumentException("frameLength must be greater than zero");
                if (frameUses < 1) throw new ArgumentException("frameUses must be greater than zero");

                _frameUses = frameUses;
                _frameLength = frameLength;
                _currentFrame = Environment.TickCount / _frameLength;
            }

            public bool TryUse()
            {
                var frame = Environment.TickCount / _frameLength;
                if (frame != _currentFrame)
                {
                    _currentFrame = frame;
                    _currentUses = 1;
                    return true;
                }

                if (_currentUses < _frameUses)
                {
                    _currentUses++;
                    return true;
                }

                return false;
            }

            public void WaitForNextUse()
            {
                if (_currentUses < _frameUses) return;

                var tickCount = Environment.TickCount;
                var frame = tickCount / _frameLength;
                if (frame != _currentFrame) return;

                System.Threading.Thread.Sleep(_frameLength);
            }
        }

        static void Main(string[] args)
        {
            var j = 0;
            for (var i = 0; i < 1000; i++)
            {
                if (!WebTranslator.Available) WebTranslator.WaitUntilAvailable();
                if (WebTranslator.TryTranslate("多簇草", "zh-CN", "en", out var translated))
                {
                    j++;
                    Console.WriteLine($"Used {j} times. {translated}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
