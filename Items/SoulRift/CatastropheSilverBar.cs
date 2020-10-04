using OdeMod.Tiles.SoulRift;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace OdeMod.Items.SoulRift
{
    public class CatastropheSilverBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Catastrophe Silver Bar");
            DisplayName.AddTranslation(GameCulture.Chinese, "咒银锭");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.value = 0;
            item.rare = ItemRarityID.White;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<TileCatastropheSilverBar>();
            item.useTurn = true;
        }
    }
}