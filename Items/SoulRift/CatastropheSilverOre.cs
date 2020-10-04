using OdeMod.Tiles.SoulRift;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.SoulRift
{
    public class CatastropheSilverOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Catastrophe Silver Ore");
            DisplayName.AddTranslation(GameCulture.Chinese, "咒银矿");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 0;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useTurn = true;
            item.createTile = ModContent.TileType<TileCatastropheSilverOre>();
            item.autoReuse = true;
            item.consumable = true;
        }
    }
}