using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileHolyLeavesBlock : ModTile
    {
        public override void SetDefaults()
        {
            drop = mod.ItemType("HolyLeaves");
            dustType = MyDustId.OrangeMaterial;
            soundType = SoundID.Dig;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Holy Leaves");
            name.AddTranslation(GameCulture.Chinese, "神圣树叶");
            AddMapEntry(new Color(248, 149, 79), name);

            TileObjectData.addAlternate(Type);
        }
    }
}