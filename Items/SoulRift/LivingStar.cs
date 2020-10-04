using OdeMod.Tiles.SoulRift;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace OdeMod.Items.SoulRift
{
    class LivingStar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Living Star");
            DisplayName.AddTranslation(GameCulture.Chinese, "生命之星");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.value = 0;
            item.rare = ItemRarityID.White;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useTurn = true;
            item.createTile = ModContent.TileType<TileLivingStarBlock>();
            item.autoReuse = true;
            item.consumable = true;
        }
    }
}