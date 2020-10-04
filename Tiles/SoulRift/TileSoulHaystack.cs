using Microsoft.Xna.Framework;
using OdeMod.Items.SoulRift;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileSoulHaystack : ModTile
    {
        public override void SetDefaults()
        {
            drop = ModContent.ItemType<SoulHaystack>();
            dustType = MyDustId.BlueThin;
            soundType = SoundID.Dig;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Soul Haystack");
            name.AddTranslation(GameCulture.Chinese, "灵魂草堆");
            AddMapEntry(new Color(40, 78, 88), name);

            TileObjectData.addTile(Type);
        }
    }
}