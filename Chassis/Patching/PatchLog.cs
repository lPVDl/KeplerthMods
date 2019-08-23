using System.Reflection;
using Chassis.Entities;
using System.Text;
using UnityEngine;
using System.IO;
using System;
using Common;

namespace Chassis.Patching
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
            public IInvokationAddress Patcher { set { _patcher = value; } }
            public object NewValue { set => _newValue = value; }
            public object OldValue { set => _oldValue = value; }
            public Exception Error { set => _error = value; }

            private Container<object> _target;
            private Container<object> _source;
            private IInvokationAddress _patcher;
            private Container<object> _newValue;
            private Container<object> _oldValue;
            private Container<Exception> _error;

            public void Log()
            {
                if (_error) Write("ERROR! ");

                Write(ToString());

                if (_error)
                {
                    WriteLine($" [{_error.Value.Message}]");
                }
                else
                {
                    WriteLine();
                }
            }

            public override string ToString()
            {
                var sb = new StringBuilder();

                sb.Append('[');
                if (_patcher != null) sb.Append(_patcher.Assembly.GetName().Name);
                sb.Append(']');

                if (_target)
                {
                    sb.Append(' ');
                    sb.Append(_target.Value);

                    if (_newValue || _source)
                    {
                        sb.Append(" = ");

                        if (_newValue && _source && _newValue.ToString() != _source.ToString())
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

        public static void WriteLine() => Write(Environment.NewLine);

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

        public static void ReportInitalization(IEntity entity, IInvokationAddress patcher)
        {
            if (entity == null) throw new ArgumentNullException("entity was null");
            if (patcher == null) throw new ArgumentNullException("patcher was null");

            var message = $"[{patcher.Assembly.GetName().Name}] {entity.GetType().Name}.{entity.Name}({entity.ID})";

            WriteLine(message);
        }
    }
}
