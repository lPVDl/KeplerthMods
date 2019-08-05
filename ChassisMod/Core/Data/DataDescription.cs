using System.Collections.Generic;
using System.Linq;
using DataBase;

namespace ChassisMod.Core.Data
{
    internal sealed class DataDescription
    {
        public string Name { get; private set; }
        public int ID { get; private set; }
        public IEnumerable<string> Comment { get; private set; }

        public static IEnumerable<DataDescription> Create<TConfig>(DataHelper<TConfig> helper) where TConfig : DBBase
        {
            var data = from key in helper.Keys
                         select new DataDescription()
                         {
                             Comment = helper.CommentFor(key),
                             Name = helper.NameFor(key),
                             ID = key
                         };

            var result = data.ToArray();
            for (var i = 0; i < result.Length; i++)
            {
                for (var j = i + 1; j < result.Length; j++)
                {
                    if (result[i].Name == result[j].Name)
                    {
                        var name = result[i].Name;
                        var counter = 0;
                        for (var p = i; p < result.Length; p++)
                            if (result[p].Name == name)
                            {
                                result[p].Name += counter;
                                counter++;
                            }
                    }
                }
            }

            return result;
        }

        private DataDescription() { }

        public string CreateDefinition(string className)
        {
            return string.Format("public static {0} {1} {{ get; }} = new {0}(\"{1}\", {2});", className, Name, ID);
        }
    }
}
