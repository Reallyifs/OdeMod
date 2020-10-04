using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace OdeMod.Tiles.Cemetery
{
    public class TileSoulSoilBlock : ModTile
    {
        public override void SetDefaults()
        {
            drop = mod.ItemType("SoulSoilBlock");
            dustType = MyDustId.BrownDirt;
            soundType = SoundID.Dig;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Soul Soil Block");
            name.AddTranslation(GameCulture.Chinese,"凝魂土");
            AddMapEntry(new Color(95, 61, 75), name);
        }
    }
}
