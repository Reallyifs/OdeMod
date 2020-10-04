using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileRottenMeatBlock : ModTile
    {
        public override void SetDefaults()
        {
            drop = mod.ItemType("RottenMeatBlock");
            dustType = MyDustId.PinkBubble;
            soundType = SoundID.Tink;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Rotten Meat");
            name.AddTranslation(GameCulture.Chinese, "烂肉块");
            AddMapEntry(new Color(128, 51, 80), name);

            TileObjectData.addAlternate(Type);
        }
    }
}