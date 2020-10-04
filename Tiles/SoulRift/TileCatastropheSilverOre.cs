using Microsoft.Xna.Framework;
using OdeMod.Items.SoulRift;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileCatastropheSilverOre : ModTile
    {
        public override void SetDefaults()
        {
            drop = ModContent.ItemType<CatastropheSilverOre>();
            dustType = MyDustId.Silver;
            soundType = SoundID.Tink;

            Main.tileSolid[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Catastrophe Silver Ore");
            name.AddTranslation(GameCulture.Chinese, "灾银矿");
            AddMapEntry(new Color(151, 161, 180), name);

            TileObjectData.addTile(Type);
        }
    }
}