using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using OdeMod.Tiles.Mosscobble;
namespace OdeMod.Items.Mosscobble
{
    public class ItemMosscobble : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mosscobble");
            DisplayName.AddTranslation(GameCulture.Chinese, "苔石");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(0, 0, 0, 50);
            item.width = 16;
            item.height = 16;
            item.useTime = 20;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<TileMosscobble>();
            item.useAnimation = 20;
        }
    }
}