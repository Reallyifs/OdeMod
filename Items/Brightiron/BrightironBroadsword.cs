using OdeMod.Items.Brightiron.Armor;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Brightiron
{
    public class BrightironBroadsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brightiron Broadsword");
            DisplayName.AddTranslation(GameCulture.Chinese, "熙铁阔剑");
        }

        public override void SetDefaults()
        {
            item.crit = 6;
            item.rare = ItemRarityID.Blue;
            item.melee = true;
            item.value = Item.sellPrice(0, 0, 30, 0);
            item.width = 40;
            item.damage = 31;
            item.height = 40;
            item.useTime = 22;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.knockBack = 5.9f;
            item.useAnimation = 22;
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
                Ode.AddIngredient(ModContent.ItemType<BrightironBar>(), 7);
                Ode.AddIngredient(ModContent.ItemType<SpiritPieces>(), 10);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}