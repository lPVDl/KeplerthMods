using System.Collections.Generic;
using ChassisMod.Patching;
using ChassisMod.Wrapping;
using Common.Reflection;
using System.Linq;
using System.IO;
using System;

namespace ChassisMod.Analyzing
{
    public static class EntityExporter
    {
        private static List<string> ExportRequests = new List<string>();

        public static void AddRequest(string folder) => ExportRequests.Add(folder);

        static EntityExporter()
        {
            ConfigPatcher.PatchingStarted += OnPatchingStarted;
        }

        private static void OnPatchingStarted()
        {
            foreach (var folder in ExportRequests) { Export(folder); }
        }

        private static void Export(string folder)
        {
            if (!Directory.Exists(folder)) { Directory.CreateDirectory(folder); }

            var entities = EntityIdentifier.GetAll();

            var groups = from e in entities
                         group e by e.GetType();

            foreach (var g in groups) { Export(g, folder); }
        }     

        private static void Export(IEnumerable<Entity> entities, string folder)
        {
            if (entities.Count() == 0) return;

            var className = entities.First().GetType().Name;

            var fileName = Path.Combine(folder, className + "_DB.cs");

            var resolved = ResolveDuplicatedNames(entities);

            using (var file = new StreamWriter(fileName))
            {
                file.WriteLine("namespace " + nameof(ChassisMod));
                file.WriteLine("{");
                file.WriteLine("\tpartial class " + className);
                file.WriteLine("\t{");

                foreach(var (newName, entity) in resolved)
                {
                    var info = GetInfo(entity);

                    file.WriteLine("\t\t/// <summary>");
                    foreach(var i in info)
                    {
                        file.Write("\t\t/// ");
                        file.Write(i);
                        file.WriteLine("<para/>");
                    }
                    file.WriteLine("\t\t/// </summary>");

                    file.WriteLine($"\t\tpublic static {className} {newName} {{ get; }} = new {className}() {{ ID = {entity.ID}, Name = \"{newName}\" }};");
                }

                file.WriteLine("\t}");
                file.WriteLine("}");
            }
        }

        private static IEnumerable<Tuple<string, Entity>> ResolveDuplicatedNames(IEnumerable<Entity> entities)
        {
            var data = (from e in entities select e.Name).ToArray();

            for (var i = 0; i < data.Length; i++)
            {
                for (var j = i + 1; j < data.Length; j++)
                {
                    if (data[i] == data[j])
                    {
                        var name = data[i];
                        var counter = 0;
                        for (var p = i; p < data.Length; p++)
                            if (data[p] == name)
                            {
                                data[p] += counter;
                                counter++;
                            }
                    }
                }
            }

            return data.Zip(entities, Tuple.Create);
        }

        private static IEnumerable<string> GetInfo(Entity entity)
        {
            var result = new List<string>() { "ID: " + entity.ID };

            var props = entity.GetType().GetProperties();

            var info = from p in props
                       let v = p.GetValue(entity) where v != null
                       let i = (v as IEntityInfo) where i != null && i.Display
                       select p.Name + ": " + i.Info;

            result.AddRange(info);

            return result;
        }

        //private static IEnumerable<string> AnalizeProperties(Entity entity)
        //{
        //    Container<object> _;

        //    var props = entity.GetType().GetProperties();

        //    var result = new List<string>() { "ID: " + entity.ID };

        //    var containers = from p in props
        //                     let value = p.GetValue(entity)
        //                     where value != null && value.IsDerivedFromGeneric(typeof(Container<>))
        //                     where value is IEntityInfo
        //                     // let data = value.InvokeMethod(nameof(_.Read))
        //                     // let str = value.InvokeMethod(nameof(_.Format), data)
        //                     let str = (value as IEntityInfo).Info
        //                     select $"{p.Name}: {str}";

        //    result.AddRange(containers);

        //    return result;
        //}

        
    }
}
