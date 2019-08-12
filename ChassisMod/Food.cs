using Common.Reflection;
using ChassisMod.Core;
using DataBase;
using System;

namespace ChassisMod
{
    public sealed class Food : DataWrapper<ConfigFood>
    {
        internal Food(string name, int id) : base (name, id) { }

        internal Food(string assemblyID, string name, int id) : base(assemblyID, name, id) { }

        internal void CopyFrom(Food source)
        {
            if (source == null) throw new ArgumentNullException("source was null");

            AddModification("", food =>
            {               
                var buffInfo = food.GetInstanceFieldValue("eatBuffDescription");

                var data = ConfigFood.Table[source.ID];
                food.CopyInstanceFieldValues(data);

                food.SetInstanceFieldValue("eatBuffDescription", buffInfo);
            });
        }
    }
}
