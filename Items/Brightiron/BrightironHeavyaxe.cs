using OdeMod.Items.Brightiron.Armor;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Brightiron
{
    public class BrightironHeavyaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brightiron Heavyaxe");
            DisplayName.AddTranslation(GameCulture.Chinese, "熙铁重斧");
        }

        public override void SetDefaults()
        {
            item.axe = 17;
            item.crit = 6;
            item.rare = ItemRarityID.Green;
            item.melee = true;
            item.value = Item.sellPrice(0, 0, 31, 75);
            item.width = 40;
            item.damage = 41;
            item.height = 34;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.knockBack = 8f;
            item.useAnimation = 30;
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
                Ode.AddIngredient(ModContent.ItemType<BrightironBar>(), 6);
                Ode.AddIngredient(ModContent.ItemType<SpiritPieces>(), 9);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}