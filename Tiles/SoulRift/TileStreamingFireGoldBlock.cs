using Microsoft.Xna.Framework;
using OdeMod.Items.SoulRift;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileStreamingFireGoldBlock : ModTile
    {
        public override void SetDefaults()
        {
            drop = ModContent.ItemType<StreamingFireGoldBlock>();
            dustType = 6;
            soundType = SoundID.Tink;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileShine[Type] = 300;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Streaming Fire Gold Block");
            name.AddTranslation(GameCulture.Chinese, "流火金块");
            AddMapEntry(new Color(255, 193, 94), name);

            TileObjectData.addAlternate(Type);
        }
    }
}