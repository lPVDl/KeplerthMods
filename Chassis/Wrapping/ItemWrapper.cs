using Chassis.Patching;
using Chassis.Entities;
using UnityEngine;
using Keplerth;
using DataBase;

namespace Chassis.Wrapping
{
    internal sealed class ItemWrapper : Wrapper<ConfigItem>
    {
        public IPatchable<Sprite> Icon { get; }
        public IPatchable<int> Durability { get; }
        public IPatchable<int> Category { get; }
        public IPatchable<int> BuildDamageBonus { get; }
        public IPatchable<int> TreeDamageBonus { get ; }
        public IPatchable<int> WallDamageBonus { get; }

        internal ItemWrapper(IEntity owner) : base(owner)
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

        internal void Initialize(ItemWrapper source, IInvokationAddress patcher, bool log) => Initialize(source, SetTranslationKeys, patcher, log);

        private void SetTranslationKeys(ConfigItem config)
        {
            config.Name = "ItemName" + Owner.ID;
            config.Description = "ItemDes" + Owner.ID;
            config.FunctionDes = "ItemFunctionDes" + Owner.ID;
        }
    }
}
