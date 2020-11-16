using OdeMod.Projectiles.Mosscobble;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Mosscobble
{
    public class MosscobbleAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mosscobble Axe");
            DisplayName.AddTranslation(GameCulture.Chinese, "苔石斧");
        }
        public override void SetDefaults()
        {
            item.axe = 7;
            item.crit = 4;
            item.rare = ItemRarityID.Orange;
            item.melee = true;
            item.shoot = 0;
            item.value = Item.sellPrice(0, 0, 1, 75);
            item.width = 30;
            item.height = 30;
            item.useTime = 15;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shootSpeed = 20;
            item.useAnimation = 25;
            item.SetElementDamage(ElementDamageType.EarthDamage);
        }

        public override bool AltFunctionUse(Player player) => true;
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse != 2)
            {
                item.shoot = ProjectileID.None;
                item.damage = 3;
                item.useTime = 15;
                item.knockBack = 4.5f;
                item.useAnimation = 15;
            }
            else
            {
                item.shoot = ModContent.ProjectileType<ProMosscobbleAxe>();
                item.damage = 13;
                item.useTime = 30;
                item.knockBack = 8;
                item.useAnimation = 30;
            }
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemMosscobble>(), 9);
                Ode.AddIngredient(ItemID.Gel, 5);
                Ode.AddIngredient(ItemID.Vine, 6);
                Ode.AddTile(TileID.WorkBenches);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}