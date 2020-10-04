using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OdeMod.Tiles.Cemetery
{
    public class TileSoulGrass : ModTile
    {
        public override void SetDefaults()
        {
            dustType = MyDustId.DarkGrass;
            soundType = SoundID.Dig;
            drop = mod.ItemType("SoulSoilBlock");
            SetModTree(new TileBoneOakTree());
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileBrick[Type] = true;
            Main.tileMergeDirt[Type] = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Soul Grass");
            name.AddTranslation(Terraria.Localization.GameCulture.Chinese, "Äý»ê²Ý");
            AddMapEntry(new Color(95, 61, 75), name);
            TileID.Sets.Grass[Type] = true;
            TileID.Sets.Conversion.Grass[Type] = true;
            TileID.Sets.NeedsGrassFraming[Type] = true;
            TileID.Sets.NeedsGrassFramingDirt[Type] = ModContent.TileType<TileSoulSoilBlock>();
        }
    }
}