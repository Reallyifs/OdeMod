using OdeMod.Tiles.Brightiron;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Brightiron
{
    public class BrightironBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brightiron Bar");
            DisplayName.AddTranslation(GameCulture.Chinese, "熙铁锭");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(0, 0, 12, 0);
            item.width = 28;
            item.height = 16;
            item.useTime = 22;
            item.useTurn = false;
            item.autoReuse = true;
            item.createTile = ModContent.TileType<TileBrightironBar>();
            item.useAnimation = 15;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<BrightironOre>(), 3);
                Ode.AddTile(TileID.Furnaces);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}