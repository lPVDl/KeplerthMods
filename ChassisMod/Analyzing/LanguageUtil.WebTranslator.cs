using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;
using UnityEngine;
using System.Net;
using System.IO;
using System;
using Common;

namespace ChassisMod.Analyzing
{
    partial class LanguageUtil
    {
        private static partial class WebTranslator
        {
            public static bool Available => Limiter.CanUseNow;

            private static Dictionary<int, Dictionary<string, string>> Cash { get; }
            private static WebClient Client { get; set; }
            private static Regex Charset { get; }
            private static Regex StringValue { get; }
            private static string CashPath { get; }
            private static RateLimiter Limiter { get; }
            private static bool GotTooManyRequests { get; set; }

            static WebTranslator()
            {
                Limiter = new RateLimiter(8000, 1);
                Cash = new Dictionary<int, Dictionary<string, string>>();
                CashPath = Path.Combine(Path.GetDirectoryName(Application.consoleLogPath), "WebTranslator.cash");
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
                    catch (Exception e) { Log.ExceptionOnce(e); }
                }

                Charset = new Regex("(?<=charset=)[\\w-]+", RegexOptions.Compiled);
                StringValue = new Regex("(?<=\\\").+?(?=\\\")", RegexOptions.Compiled);

                AppDomain.CurrentDomain.ProcessExit += OnProcessExit;
            }

            private static void RecreateWebClient()
            {
                if (Client != null) Client.Dispose();

                Client = new WebClient();
                Client.Encoding = Encoding.Default;
                Client.Headers["User-Agent"] = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9";
                Client.Headers["Accept-Language"] = "en-us,en;q=0.5";
                Client.Headers["Accept-Charset"] = "ISO-8859-1,utf-8;q=0.7,*;q=0.7";
            }

            public static void WaitUntilAvailable() => Limiter.WaitForNextUse();

            public static bool TryTranslate(string text, string fromLanguage, string toLanguage, out string result)
            {
                result = null;

                var languageID = fromLanguage.GetHashCode() + toLanguage.GetHashCode();
                if (!Cash.ContainsKey(languageID)) { Cash[languageID] = new Dictionary<string, string>(); }
                if (Cash[languageID].TryGetValue(text, out result)) { return true; }

                if (GotTooManyRequests || !Limiter.TryUse()) return false;

                var uri = string.Format(@"https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", fromLanguage, toLanguage, text);

                RecreateWebClient();
                byte[] data;
                try
                {
                    data = Client.DownloadData(uri);
                }
                catch (WebException e)
                {
                    Log.ExceptionOnce(e);
                    if ((e.Response as HttpWebResponse).StatusCode == (HttpStatusCode)429) GotTooManyRequests = true;
                    return false;
                }

                var encoding = Charset.Match(Client.ResponseHeaders["Content-Type"]).Value;
                var response = Encoding.GetEncoding(encoding).GetString(data);

                result = StringValue.Match(response).Value;

                Log.Message($"WebTranslator: '{text}' => '{result}'");

                Cash[languageID][text] = result;

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
                catch (Exception e) { Log.Exception(e); }
            }
        }
    }
}
