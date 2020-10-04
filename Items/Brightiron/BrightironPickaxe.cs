using OdeMod.Items.Brightiron.Armor;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Brightiron
{
    public class BrightironPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brightiron Pickaxe");
            DisplayName.AddTranslation(GameCulture.Chinese, "熙铁镐");
        }

        public override void SetDefaults()
        {
            item.crit = 10;
            item.pick = 85;
            item.rare = ItemRarityID.Green;
            item.melee = true;
            item.value = Item.sellPrice(0, 0, 40, 0);
            item.width = 32;
            item.damage = 16;
            item.height = 32;
            item.useTime = 18;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.knockBack = 4f;
            item.useAnimation = 18;
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
                Ode.AddIngredient(ModContent.ItemType<BrightironBar>(), 14);
                Ode.AddIngredient(ModContent.ItemType<SpiritPieces>(), 20);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}