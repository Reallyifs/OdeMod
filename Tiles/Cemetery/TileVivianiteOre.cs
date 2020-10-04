using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.ID;

namespace OdeMod.Tiles.Cemetery
{
    public class TileVivianiteOre : ModTile
    {
        public override void SetDefaults()
        {
            drop = ModContent.ItemType<Items.Cemetery.VivianiteOre>();
            dustType = MyDustId.Lead;
            soundType = SoundID.Tink;

            Main.tileSolid[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Vivianite Ore");
            name.AddTranslation(Terraria.Localization.GameCulture.Chinese, "蓝铁矿");
            AddMapEntry(new Color(103, 137, 188), name);

            TileObjectData.addTile(Type);
        }
    }
}