using System.Reflection;
using UnityEngine;
using System.IO;
using System;
using Common;

namespace ChassisMod.Patching
{
    internal static class PatchLog
    {
        public static bool Ignore { private get; set; }
        public static object Entity { private get; set; }
        public static Assembly Patcher { private get; set; }
        public static object OldValue { private get; set; }
        public static object NewValue { private get; set; }
        public static Exception Error { private get; set; }

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

        public static void Flush()
        {
            if (Ignore)
            {
                Reset();
                return;
            }

            var message = "";

            if (Error != null) message += "ERROR! ";

            message += $"[{Patcher.GetName().Name}] {Entity} = {NewValue} <- {OldValue}";

            if (Error != null) message += $" (\"{Error.Message}\")";

            WriteLine(message);

            Reset();
        }

        private static void Reset()
        {
            Ignore = false;
            Entity = null;
            Patcher = null;
            OldValue = null;
            NewValue = null;
            Error = null;
        }

        private static void WriteLine(string value)
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
