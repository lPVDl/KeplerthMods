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
        private static class GoogleTranslate
        {
            private static Dictionary<string, Dictionary<string, string>> Cash { get; }
            private static WebClient Client { get; }
            private static Regex Charset { get; }
            private static Regex StringValue { get; }
            private static string CashPath { get; } 

            static GoogleTranslate()
            {             
                Cash = new Dictionary<string, Dictionary<string, string>>();
                CashPath = Path.Combine(Path.GetTempPath(), "GoogleTranslate.cash");
                if (File.Exists(CashPath))
                {
                    try
                    {
                        using (var stream = new FileStream(CashPath, FileMode.Open, FileAccess.Read))
                        using (var zipStream = new GZipStream(stream, CompressionMode.Decompress))
                        {
                            var formatter = new BinaryFormatter();
                            Cash = formatter.Deserialize(zipStream) as Dictionary<string, Dictionary<string, string>>;
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
          
            public static string Translate(string text, string fromLanguage, string toLanguage)
            {
                var languageID = fromLanguage + "->" + toLanguage;
                if (!Cash.ContainsKey(languageID)) { Cash[languageID] = new Dictionary<string, string>(); }
                if (Cash[languageID].TryGetValue(text, out var translated)) { return translated; }

                var uri = string.Format(@"https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", fromLanguage, toLanguage, text);
                var data = Client.DownloadData(uri);
                var encoding = Charset.Match(Client.ResponseHeaders["Content-Type"]).Value;
                var response = Encoding.GetEncoding(encoding).GetString(data);
                Cash[languageID][text] = StringValue.Match(response).Value;

                return Cash[languageID][text];
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

        static void Main(string[] args)
        {
            var text = GoogleTranslate.Translate("木乃伊刷怪蛋", "zh-CN", "en");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
