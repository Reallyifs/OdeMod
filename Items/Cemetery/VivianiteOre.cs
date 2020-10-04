using OdeMod.Tiles.Cemetery;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Cemetery
{
    public class VivianiteOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vivianite Ore");
            DisplayName.AddTranslation(GameCulture.Chinese, "蓝铁矿");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 26;
            item.value = 100;
            item.rare = 1;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useTurn = true;
            item.createTile = ModContent.TileType<TileVivianiteOre>();
            item.autoReuse = true;
            item.consumable = true;
        }
    }
}