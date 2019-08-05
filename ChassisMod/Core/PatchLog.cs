using UnityEngine;
using System.IO;
using System;
using Common;

namespace ChassisMod.Core
{
    internal static class PatchLog
    {
        private static string FileName { get; }

        static PatchLog()
        {
            try
            {
                var path = Path.GetDirectoryName(Application.consoleLogPath);
                FileName = Path.Combine(path, "ChassisPatch.log");
                File.Delete(FileName);
            }
            catch (Exception e) { Log.Exception(e); }
        }

        public static void Write(string value)
        {
            try
            {
                File.AppendAllText(FileName, value);
            }
            catch (Exception e) { Log.Exception(e); }
        }

        public static void WriteLine(string value)
        {
            try
            {
                var writer = File.AppendText(FileName);
                writer.Write(value);
                writer.WriteLine();
                writer.Close();
            }
            catch (Exception e) { Log.Exception(e); }
        }
    }
}
