using OdeMod.Items.Brightiron.Armor;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Brightiron
{
    public class BrightironShortbow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brightiron Shortbow");
            DisplayName.AddTranslation(GameCulture.Chinese, "熙铁短弓");
        }
        public override void SetDefaults()
        {
            item.crit = 5;
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(0, 0, 42, 0);
            item.width = 24;
            item.damage = 25;
            item.height = 44;
            item.ranged = true;
            item.noMelee = true;
            item.useAmmo = AmmoID.Arrow;
            item.useTime = 24;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = true;
            item.knockBack = 2.3f;
            item.shootSpeed = 41;
            item.useAnimation = 24;
        }
        public override void ModifyWeaponDamage(Player player, ref float add, ref float mult, ref float flat)
        {
            if (player.Armor<BrightironHelmet, BrightironBreastplate, BrightironLeggings>())
                mult = 1.3f;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<BrightironBar>(), 9);
                Ode.AddIngredient(ModContent.ItemType<SpiritPieces>(), 13);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}