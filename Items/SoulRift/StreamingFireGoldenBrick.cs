using OdeMod.Tiles.SoulRift;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.SoulRift
{
    public class StreamingFireGoldenBrick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Streaming Fire Golden Brick");
            DisplayName.AddTranslation(GameCulture.Chinese, "流火金砖");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = 0;
            item.rare = ItemRarityID.White;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useTurn = true;
            item.createTile = ModContent.TileType<TileStreamingFireGoldenBrick>();
            item.autoReuse = true;
            item.consumable = true;
        }
    }
}