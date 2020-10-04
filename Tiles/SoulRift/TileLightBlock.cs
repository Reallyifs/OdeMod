using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileLightBlock : ModTile
    {
        public override void SetDefaults()
        {
            drop = mod.ItemType("LightBlock");
            dustType = MyDustId.WhiteLight;
            soundType = SoundID.Tink;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Light Block");
            name.AddTranslation(GameCulture.Chinese, "光芒方块");
            AddMapEntry(new Color(255, 247, 191), name);

            TileObjectData.addTile(Type);
        }
    }
}