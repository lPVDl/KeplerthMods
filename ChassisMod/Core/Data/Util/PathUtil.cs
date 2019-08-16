//using System.IO;

//namespace ChassisMod.Core.Data.Util
//{
//    internal static class PathUtil
//    {
//        public static string CreateUniqueFileName(string folder, string fileName, string extension)
//        {
//            var path = Path.Combine(folder, fileName + extension);
//            while (File.Exists(path))
//            {
//                fileName = FormatUtil.ContinuousEnumeration(fileName);
//                path = Path.Combine(folder, fileName + extension);
//            }

//            return path;
//        }

//    }
//}
