using OdeMod.Tiles.Brightiron;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Brightiron
{
    public class BrightironOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brightiron Ore");
            DisplayName.AddTranslation(GameCulture.Chinese, "熙铁矿");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.width = 14;
            item.height = 16;
            item.useTime = 15;
            item.useTurn = false;
            item.autoReuse = true;
            item.createTile = ModContent.TileType<TileBrightironOre>();
            item.useAnimation = 15;
        }
    }
}