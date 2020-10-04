using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.Mosscobble
{
    public class TileMosscobble : ModTile
    {
        public override void SetDefaults()
        {
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.Width = 16;
            TileObjectData.newTile.Height = 15;
            TileObjectData.newTile.CoordinateHeights = OFunctions.SetCoordinateHeights(TileObjectData.newTile.Height);

            drop = ModContent.ItemType<Items.Mosscobble.ItemMosscobble>();
            minPick = 20;
            dustType = DustID.Stone;
            soundType = SoundID.Dig;
            mineResist = 2f;

            Main.tileSolid[Type] = true;
            Main.tileValue[Type] = 10;
            Main.tileMergeDirt[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileBlockLight[Type] = false;

            AddMapEntry(new Color(75, 75, 75));

            TileObjectData.addTile(Type);
        }

        public override void NumDust(int i, int j, bool fail, ref int num) => num = fail ? 4 : 3;

        public override bool CanExplode(int i, int j) => true;
    }
}