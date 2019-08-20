//using System.Collections.Generic;
//using System.Linq;
//using System;

//namespace ChassisMod.Utilities
//{
//    internal static class FormatUtil
//    {
//        //private static void FixDuplicatedNames(string[] names)
//        //{
//        //    for (var i = 0; i < names.Length; i++)
//        //    {
//        //        for (var j = i + 1; j < names.Length; j++)
//        //        {
//        //            if (names[i] == names[j])
//        //            {
//        //                var name = names[i];
//        //                var counter = 0;
//        //                for (var p = i; p < names.Length; p++)
//        //                    if (names[p] == name)
//        //                    {
//        //                        names[p] += counter;
//        //                        counter++;
//        //                    }
//        //            }
//        //        }
//        //    }
//        //}

//        public static IEnumerable<T> FixDuplicatedNames<T>(IEnumerable<T> names, Func<T, string> getName, Action<T, string> setName)
//        {
//            var data = names.ToArray();

//            for (var i = 0; i < data.Length; i++)
//            {
//                for (var j = i + 1; j < data.Length; j++)
//                {
//                    if (getName(data[i]) == getName(data[j]))
//                    {
//                        var name = getName(data[i]);
//                        var counter = 0;
//                        for (var p = i; p < data.Length; p++)
//                            if (getName(data[p]) == name)
//                            {
//                                setName(data[p], name + counter);
//                                counter++;
//                            }
//                    }
//                }
//            }

//            return data;
//        }
//    }
//}
