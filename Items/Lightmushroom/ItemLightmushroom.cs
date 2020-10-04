using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Lightmushroom
{
    public class ItemLightmushroom : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightmushroom");
            DisplayName.AddTranslation(GameCulture.Chinese, "光明蘑菇");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(0, 0, 2, 10);
            item.width = 22;
            item.height = 24;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.SoulofLight, 1);
                Ode.AddIngredient(ItemID.Mushroom, 2);
                Ode.AddTile(TileID.WorkBenches);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}