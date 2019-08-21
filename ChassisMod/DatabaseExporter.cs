using System.Collections.Generic;
using ChassisMod.Patching;
using System.IO;
using System;
using Common;

namespace ChassisMod
{
    public static class DatabaseExporter
    {
        private static List<string> ExportRequests = new List<string>();

        public static void AddRequest(string folder) => ExportRequests.Add(folder);

        static DatabaseExporter()
        {
            ConfigPatcher.PatchingStarted += OnPatchingStarted;
        }

        private static void OnPatchingStarted()
        {
            foreach (var folder in ExportRequests)
                foreach (var manager in Entity.Managers)
                {
                    try
                    {
                        ExportEntities(manager, folder);
                    }
                    catch (Exception e) { Log.Exception(e); }
                }
                    
        }

        private static void ExportEntities(IEntityManager manager, string folder)
        {
            if (!Directory.Exists(folder)) { Directory.CreateDirectory(folder); }

            var @class = manager.GetType().Name;

            var fileName = Path.Combine(folder, @class + "DB.cs");

            using (var file = new StreamWriter(fileName))
            {
                file.WriteLine("namespace " + nameof(ChassisMod));
                file.WriteLine("{");
                file.WriteLine("\tpartial class " + @class);
                file.WriteLine("\t{");

                var entities = manager.RuntimeInstances;

                foreach (var entity in entities)
                {
                    var info = manager.GetProperties(entity);

                    file.WriteLine("\t\t/// <summary>");
                    file.WriteLine($"\t\t/// ID: {entity.ID}<para/>");
                    foreach (var i in info)
                    {
                        if (i.ValueIsDefault) continue;
                        file.Write("\t\t/// ");
                        file.Write(i.Name);
                        file.Write(": ");
                        file.Write(i.Value);
                        
                        file.WriteLine("<para/>");
                    }
                    file.WriteLine("\t\t/// </summary>");

                    file.WriteLine($"\t\tpublic static readonly {@class} {entity.Name} = new {@class}({entity.ID}, \"{ entity.Name}\");");
                }

                file.WriteLine("\t}");
                file.WriteLine("}");
            }
        }
    }
}
