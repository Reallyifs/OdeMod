using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.Californium
{
    public class TileCaliforniumBar : ModTile
    {
        public override void SetDefaults()
        {
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);

            drop = ModContent.ItemType<CaliforniumBar>();
            minPick = 200;
            dustType = MyDustId.GreyParticle;
            soundType = SoundID.Dig;
            mineResist = 2f;

            Main.tileSolid[Type] = false;
            Main.tileValue[Type] = 300;
            Main.tileMergeDirt[Type] = false;
            Main.tileSpelunker[Type] = true;
            Main.tileBlockLight[Type] = false;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Californium Bar");
            name.AddTranslation(GameCulture.Chinese, "锎锭");
            AddMapEntry(new Color(40, 40, 40), name);

            TileObjectData.addTile(Type);
        }

        public override bool CanExplode(int i, int j) => true;
    }
}