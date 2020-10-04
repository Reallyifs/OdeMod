using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.Brightiron
{
    public class TileBrightironBar : ModTile
    {
        public override void SetDefaults()
        {
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);

            drop = ModContent.ItemType<BrightironOre>();
            minPick = 60;
            dustType = MyDustId.LightGreyStone;
            soundType = SoundID.Dig;
            mineResist = 2f;

            Main.tileSolid[Type] = false;
            Main.tileValue[Type] = 30;
            Main.tileMergeDirt[Type] = false;
            Main.tileSpelunker[Type] = true;
            Main.tileBlockLight[Type] = false;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Brightiron Bar");
            name.AddTranslation(GameCulture.Chinese, "熙铁锭");
            AddMapEntry(new Color(195, 195, 195), name);

            TileObjectData.addTile(Type);
        }

        public override bool CanExplode(int i, int j) => true;
    }
}