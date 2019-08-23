using System;

namespace Chassis.Wrapping
{
    public interface ILocalization
    {
        void Set(string defaultText);
        void Set(Language language, string text);
        void Edit(Func<string, string> converter);
        void Copy(ILocalization source);
    }
}
