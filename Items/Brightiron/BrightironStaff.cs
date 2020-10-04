using OdeMod.Items.Brightiron.Armor;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Brightiron
{
    public class BrightironStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brightiron Staff");
            DisplayName.AddTranslation(GameCulture.Chinese, "熙铁法杖");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Green;
            item.mana = 6;
            item.magic = true;
            item.shoot = ModContent.ProjectileType<ProBrightironSpiritPieces>();
            item.value = Item.sellPrice(0, 2, 10, 0);
            item.width = 40;
            item.damage = 41;
            item.height = 40;
            item.noMelee = true;
            item.useTime = 14;
            item.UseSound = SoundID.Item43;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = true;
            item.knockBack = 5f;
            item.shootSpeed = 10f;
            item.useAnimation = 14;
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
                Ode.AddIngredient(ModContent.ItemType<BrightironBar>(), 10);
                Ode.AddIngredient(ModContent.ItemType<SpiritPieces>(), 15);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}