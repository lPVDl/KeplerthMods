using System.Collections.Generic;
using System.Linq;
using DataBase;
using Common;

namespace ChassisMod.Core.Data
{
    internal sealed class DataDescription
    {
        public string Name { get; private set; }
        public int ID { get; private set; }
        public IEnumerable<string> Comment { get; private set; }

        public static IEnumerable<DataDescription> Create<TConfig>(DataHelper<TConfig> helper) where TConfig : DBBase
        {
            var keys = helper.Keys.ToArray();
            var data = new DataDescription[keys.Length];

            for (var i = 0; i < keys.Length; i++)
            {
                if ((i + 1) % 30 == 0) Log.Message($"{helper.GetType().Name}: {i + 1}/{keys.Length}...");
                data[i] = new DataDescription()
                {
                    Comment = helper.CommentFor(keys[i]),
                    Name = helper.NameFor(keys[i]),
                    ID = keys[i]
                };
            }

            for (var i = 0; i < data.Length; i++)
            {
                for (var j = i + 1; j < data.Length; j++)
                {
                    if (data[i].Name == data[j].Name)
                    {
                        var name = data[i].Name;
                        var counter = 0;
                        for (var p = i; p < data.Length; p++)
                            if (data[p].Name == name)
                            {
                                data[p].Name += counter;
                                counter++;
                            }
                    }
                }
            }

            return data;
        }

        private DataDescription() { }

        public string CreateDefinition(string className)
        {
            return string.Format("public static {0} {1} {{ get; }} = new {0}(\"{1}\", {2});", className, Name, ID);
        }
    }
}
