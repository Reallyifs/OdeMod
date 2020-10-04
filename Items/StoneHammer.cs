using OdeMod.Projectiles;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class StoneHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Hammer");
            DisplayName.AddTranslation(GameCulture.Chinese, "石锤");
            Tooltip.SetDefault("He's in Cheat, Stone-Hammer already.");
            Tooltip.AddTranslation(GameCulture.Chinese, "木锤粗制滥造，铁锤浪费材料");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.EnchantedBoomerang);
            item.shoot = ModContent.ProjectileType<ProStoneHammer>();
            item.damage = 9;
            item.useTime = 10;
            item.useAnimation = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.StoneBlock, 35);
                Ode.AddIngredient(ItemID.Wood, 10);
                Ode.AddIngredient(ItemID.Cobweb, 30);
                Ode.AddTile(TileID.WorkBenches);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}