using ChassisMod.Patching;
using UnityEngine;
using Keplerth;
using DataBase;

namespace ChassisMod.Wrapping
{
    internal sealed class ItemWrapper : Wrapper<ConfigItem>
    {
        public IPatchable<Sprite> Icon { get; }
        public IPatchable<int> Durability { get; }
        public IPatchable<int> Category { get; }
        public IPatchable<int> BuildDamageBonus { get; }
        public IPatchable<int> TreeDamageBonus { get ; }
        public IPatchable<int> WallDamageBonus { get; }

        internal ItemWrapper(IWrapperHybrid owner) : base(owner)
        {
            Icon = new Patchable<Sprite>()
            {
                Owner = this,
                Name = nameof(Icon),

                Read = x => CustomResources.Load<Sprite>(x.DropTexture),
                Write = (x, v) => x.DropTexture = SpritePatcher.FindOrAdd(v),
                Validate = x => x != null,
            };

            Durability = new Patchable<int>()
            {
                Owner = this,
                Name = nameof(Durability),

                Read = x => x.Durability,
                Write = (x, v) => x.Durability = v,
                Validate = x => x > 0,
            };

            Category = new Patchable<int>()
            {
                Owner = this,
                Name = nameof(Category),

                Read = x => x.ItemType,
                Write = (x, v) => x.ItemType = v,
                Validate = x => x >= 0,
            };

            BuildDamageBonus = new Patchable<int>()
            {
                Owner = this,
                Name = nameof(BuildDamageBonus),

                Read = x => x.AttBuild,
                Write = (x, v) => x.AttBuild = v,
                Validate = x => x > 0,
            };

            TreeDamageBonus = new Patchable<int>()
            {
                Owner = this,
                Name = nameof(TreeDamageBonus),

                Read = x => x.AttTree,
                Write = (x, v) => x.AttTree = v,
                Validate  = x => x > 0,
            };

            WallDamageBonus = new Patchable<int>()
            {
                Owner = this,
                Name = nameof(WallDamageBonus),

                Read = x => x.AttWall,
                Write = (x, v) => x.AttWall = v,
                Validate = x => x > 0,
            };
        }

        //internal void CopyData(ItemWrapper source, Assembly patcher, bool log = true)
        //{
        //    Action patch = () =>
        //    {
        //        var info = new PatchLog.Message();

        //        try
        //        {
        //            info.Patcher = patcher;
        //            info.Target = this;
        //            info.NewValue = source;

        //            ConfigItem.Table[ID] = new ConfigItem(ConfigItem.Table[source.ID])
        //            {
        //                Name = "ItemName" + ID,
        //                Description = "ItemDes" + ID,
        //                FunctionDes = "ItemFunctionDes" + ID,
        //            };
        //        }
        //        catch(Exception e)
        //        {
        //            info.Error = e;
        //            throw;
        //        }
        //        finally
        //        {
        //            if (log) { info.Log(); }
        //        }
        //    };

        //    ConfigPatcher.Add(patch, patcher);
        //}
    }
}
