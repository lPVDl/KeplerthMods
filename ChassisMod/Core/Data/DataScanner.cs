using System.Collections.Generic;
using System.IO;

namespace ChassisMod.Core.Data
{
    public static class DataScanner
    {
        public static void SaveDefinitions(string folder)
        {
            CreateFile(folder, "Item", DataDescription.Create(ItemDataHelper.Instance));
            CreateFile(folder, "Craft", DataDescription.Create(CraftDataHelper.Instance));
            CreateFile(folder, "CraftGroup", DataDescription.Create(CraftGroupDataHelper.Instance));
            CreateFile(folder, "Building", DataDescription.Create(BuildingDataHelper.Instance));
            CreateFile(folder, "CraftTable", DataDescription.Create(CraftTableDataHelper.Instance));
            CreateFile(folder, "Weapon", DataDescription.Create(WeaponDataHelper.Instance));
            CreateFile(folder, "Food", DataDescription.Create(FoodDataHelper.Instance));
            CreateFile(folder, "Effect", DataDescription.Create(EffectDataHelper.Instance));
        }

        private static void CreateFile(string folder, string className, IEnumerable<DataDescription> data)
        {
            var fileName = Path.Combine(folder, className + "DB.cs");

            using (var file = new StreamWriter(fileName))
            {
                file.WriteLine("namespace ChassisMod.KeplerthDatabase");
                file.WriteLine("{");
                file.WriteLine("\tpublic static class " + className + "DB");
                file.WriteLine("\t{");

                foreach (var entity in data)
                {
                    
                    file.WriteLine("\t\t/// <summary>");
                    foreach(var line in entity.Comment)
                        file.WriteLine($"\t\t/// {line}<para/>");
                    file.WriteLine("\t\t/// </summary>");
                    
                    file.Write("\t\t");
                    file.WriteLine(entity.CreateDefinition(className));
                }

                file.WriteLine("\t}");
                file.WriteLine("}");
                file.Write("");
            }
        }       
    }
}
