using Microsoft.Xna.Framework;
using OdeMod.Items.SoulRift;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileDarkBlueStone : ModTile
    {
        public override void SetDefaults()
        {
            drop = ModContent.ItemType<DarkBlueStone>();
            dustType = MyDustId.BlueDrakParticle;
            soundType = SoundID.Tink;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Dark Blue Stone");
            name.AddTranslation(GameCulture.Chinese, "暗蓝石");
            AddMapEntry(new Color(68, 58, 134), name);

            TileObjectData.addAlternate(Type);
        }
    }
}