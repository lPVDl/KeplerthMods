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
            private struct Container<T>
            {
                public T Value { get; set; }
                public bool HasValue { get; set; }

                public static implicit operator Container<T>(T value) => new Container<T>() { Value = value, HasValue = true };

                public static implicit operator bool (Container<T> container) => container.HasValue;
            }

            public object Target { set => _target = value; }
            public object Source { set => _source = value; }
            public Assembly Patcher { set => _patcher = value; }
            public object NewValue { set => _newValue = value; }
            public object OldValue { set => _oldValue = value; }
            public Exception Error { set => _error = value; }

            private Container<object> _target;
            private Container<object> _source;
            private Container<Assembly> _patcher;
            private Container<object> _newValue;
            private Container<object> _oldValue;
            private Container<Exception> _error;

            public void Log() => Write(ToString());

            public override string ToString()
            {
                var sb = new StringBuilder();

                if (_error) { sb.Append("[ERROR]"); }

                sb.Append('[');
                if (_patcher) sb.Append(_patcher.Value.GetName().Name);
                sb.Append(']');

                if (_target)
                {
                    sb.Append(' ');
                    sb.Append(_target.Value);

                    if (_newValue || _source)
                    {
                        sb.Append(" = ");

                        if (_newValue && _source)
                        {
                            sb.Append(_newValue.Value).Append('(').Append(_source.Value).Append(')');
                        }
                        else if (_newValue)
                        {
                            sb.Append(_newValue.Value);
                        }
                        else
                        {
                            sb.Append(_source.Value);
                        }

                        if (_oldValue)
                        {
                            sb.Append(" <- ");
                            sb.Append(_oldValue.Value);
                        }
                    }
                }

                if (_error)
                {
                    sb.Append(' ');
                    sb.Append('[');
                    sb.Append(_error.Value.Message);
                    sb.Append(']');
                }

                sb.Append('\n');

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
