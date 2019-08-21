//using System.Collections.Generic;
//using ChassisMod.Core.Data.Util;
//using UnityEngine;
//using System.Linq;
//using System.IO;
//using System;

//namespace ChassisMod.Core.Data
//{
//    public static class SpriteScanner
//    {
//        public static void ExportAll(string folder)
//        {
//            if (!Directory.Exists(folder)) { Directory.CreateDirectory(folder); }

//            ExportSprites(LoadAll<Sprite>("Icon"), Path.Combine(folder, "Icons\\"));
//            ExportSprites(LoadAll<Sprite>("Weapon"), Path.Combine(folder, "Weapons\\"));
//            // ExportSprites(LoadAll<Sprite>("Plant"), Path.Combine(folder, "Plants\\"));
//            // ExportSprites(LoadAll<Sprite>("Wall"), Path.Combine(folder, "Walls\\"));

//            Resources.UnloadUnusedAssets();
//        }

//        private static IEnumerable<T> LoadAll<T>(string path) where T : UnityEngine.Object
//        {
//            if (typeof(T) == typeof(Sprite))
//            {
//                return from obj in Resources.LoadAll<GameObject>(path)
//                       let render = obj.GetComponent<SpriteRenderer>()
//                       where render != null && render.sprite != null
//                       select render.sprite as T;
//            }
//            else
//            {
//                throw new NotImplementedException("Unkown type token - " + typeof(T).Name);
//            }
//        }

//        private static void ExportSprites(IEnumerable<Sprite> sprites, string folder)
//        {
//            if (!Directory.Exists(folder)) { Directory.CreateDirectory(folder); }

//            foreach (var sprite in sprites)
//            {
//                var texture = sprite.Render();
//                var data = texture.EncodeToPNG();
//                var path = PathUtil.CreateUniqueFileName(folder, sprite.name, ".png");
//                File.WriteAllBytes(path, data);
//                File.WriteAllLines(path + ".info", sprite.GetInfo());
//            }
                
//        }
//    }
//}
