using OdeMod.Tiles.Californium;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Californium
{
    public class CaliforniumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Californium Bar");
            DisplayName.AddTranslation(GameCulture.Chinese, "锎锭");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.LightPurple;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.width = 28;
            item.height = 22;
            item.useTime = 18;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.createTile = ModContent.TileType<TileCaliforniumBar>();
            item.useAnimation = 18;
        }
    }
}