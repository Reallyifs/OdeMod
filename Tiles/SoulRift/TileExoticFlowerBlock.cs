using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileExoticFlowerBlock : ModTile
    {
        public override void SetDefaults()
        {
            drop = mod.ItemType("ExoticFlower");
            dustType = MyDustId.WhiteParticle;
            soundType = SoundID.Dig;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Exotic Flower");
            name.AddTranslation(GameCulture.Chinese, "异界鲜花");
            AddMapEntry(new Color(207, 171, 171), name);

            TileObjectData.addAlternate(Type);
        }
    }
}