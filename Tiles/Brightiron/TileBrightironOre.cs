using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.Brightiron
{
    public class TileBrightironOre : ModTile
    {
        public override void SetDefaults()
        {
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.Width = 16;
            TileObjectData.newTile.Height = 15;
            TileObjectData.newTile.CoordinateHeights = OFunctions.SetCoordinateHeights(TileObjectData.newTile.Height);

            drop = ModContent.ItemType<BrightironOre>();
            dustType = MyDustId.LightGreyStone;
            mineResist = 2f;
            minPick = 65;
            soundType = SoundID.Dig;

            Main.tileSolid[Type] = true;
            Main.tileValue[Type] = 25;
            Main.tileMergeDirt[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileBlockLight[Type] = false;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Brightiron Ore");
            name.AddTranslation(GameCulture.Chinese, "熙铁矿");
            AddMapEntry(new Color(170, 170, 170), name);

            TileObjectData.addTile(Type);
        }

        public override bool CanExplode(int i, int j) => true;
    }
}