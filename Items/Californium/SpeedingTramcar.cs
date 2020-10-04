using OdeMod.Mounts.Californium;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Californium
{
    public class SpeedingTramcar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Speeding Tramcar");
            DisplayName.AddTranslation(GameCulture.Chinese, "超速矿车");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Lime;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.width = 46;
            item.height = 26;
            item.mountType = ModContent.MountType<MountSpeedingTramcar>();
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<CaliforniumBar>(), 25);
                Ode.AddTile(TileID.LunarCraftingStation);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}