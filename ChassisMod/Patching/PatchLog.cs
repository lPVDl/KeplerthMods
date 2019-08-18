using System.Reflection;
using System.Text;
using UnityEngine;
using System.IO;
using System;
using Common;

namespace ChassisMod.Patching
{
    internal static class PatchLog
    {
        public sealed class Message
        {
            public object Entity { get; set; }
            public Assembly Patcher { get; set; }
            public object OldValue { get; set; }
            public object NewValue { get; set; }
            public Exception Exception { get; set; }

            public void Log() => Write(ToString());

            public override string ToString()
            {
                var sb = new StringBuilder();

                if (Exception != null) { sb.Append("[ERROR] "); }

                sb.Append("[");
                sb.Append(Patcher.GetName().Name);
                sb.Append("] ");

                sb.Append(Entity);
                sb.Append(" = ");
                sb.Append(NewValue);
                sb.Append(" <- ");
                sb.Append(OldValue);
                
                if (Exception != null)
                {
                    sb.Append(" (");
                    sb.Append(Exception.Message);
                    sb.Append(")");
                }

                return sb.ToString();
            }            
        }

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
