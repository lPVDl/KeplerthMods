using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using System;
using Common;

namespace Chassis
{
    public static class SpriteScanner
    {
        public static void ExportAll(string folder)
        {
            if (!Directory.Exists(folder)) { Directory.CreateDirectory(folder); }

            Log.Message("Started exporting sprites");

            ExportSprites(LoadAll<Sprite>("Icon"), Path.Combine(folder, "Icons\\"));
            ExportSprites(LoadAll<Sprite>("Weapon"), Path.Combine(folder, "Weapons\\"));
            ExportSprites(LoadAll<Sprite>("Plant"), Path.Combine(folder, "Plants\\"));
            ExportSprites(LoadAll<Sprite>("Wall"), Path.Combine(folder, "Walls\\"));

            Resources.UnloadUnusedAssets();
        }

        private static IEnumerable<T> LoadAll<T>(string path) where T : UnityEngine.Object
        {
            if (typeof(T) == typeof(Sprite))
            {
                return from obj in Resources.LoadAll<GameObject>(path)
                       let render = obj.GetComponent<SpriteRenderer>()
                       where render != null && render.sprite != null
                       select render.sprite as T;
            }
            else
            {
                throw new NotImplementedException("Unkown type token - " + typeof(T).Name);
            }
        }

        private static void ExportSprites(IEnumerable<Sprite> sprites, string folder)
        {
            if (!Directory.Exists(folder)) { Directory.CreateDirectory(folder); }

            foreach (var sprite in sprites)
            {
                var texture = SpriteTool.Render(sprite);
                var data = texture.EncodeToPNG();
                var path = CreateUniqueFileName(folder, sprite.name, ".png");
                File.WriteAllBytes(path, data);
                File.WriteAllLines(path + ".info", sprite.GetInfo());
            }

        }

        public static void ExportSpriteToPNG(Sprite sprite, string filePath)
        {
            var texture = SpriteTool.Render(sprite);
            var data = texture.EncodeToPNG();
            File.WriteAllBytes(filePath, data);
        }

        private static string CreateUniqueFileName(string folder, string fileName, string extension)
        {
            var path = Path.Combine(folder, fileName + extension);
            while (File.Exists(path))
            {
                fileName = ContinuousEnumeration(fileName);
                path = Path.Combine(folder, fileName + extension);
            }

            return path;
        }

        private static string ContinuousEnumeration(string name)
        {
            var underIndex = name.IndexOf('_');
            if (underIndex < 0) return name + "_0";

            var numberText = name.Substring(underIndex + 1, name.Length - underIndex - 1);
            if (int.TryParse(numberText, out var value))
            {
                value++;
                return name.Substring(0, underIndex) + "_" + value;
            }

            return name + "_0";
        }
    }
}
