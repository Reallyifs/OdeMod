using Microsoft.Xna.Framework;
using OdeMod.Items.SoulRift;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileCatastropheSilverBar : ModTile
    {
        public override void SetDefaults()
        {
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;

            drop = ModContent.ItemType<CatastropheSilverBar>();
            dustType = MyDustId.Silver;

            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileShine[Type] = 300;
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Catastrophe Silver Bar");
            name.AddTranslation(GameCulture.Chinese, "咒银锭");
            AddMapEntry(new Color(151, 161, 180), name);

            TileObjectData.addTile(Type);
        }
    }
}