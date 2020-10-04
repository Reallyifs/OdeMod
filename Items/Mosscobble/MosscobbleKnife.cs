using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Mosscobble
{
    public class MosscobbleKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mosscobble Knife");
            DisplayName.AddTranslation(GameCulture.Chinese, "苔石剑");
        }

        public override void SetDefaults()
        {
            item.crit = 6;
            item.rare = ItemRarityID.Green;
            item.melee = true;
            item.value = Item.sellPrice(0, 0, 1, 25);
            item.width = 30;
            item.damage = 8;
            item.height = 34;
            item.useTime = 20;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = false;
            item.shootSpeed = 0;
            item.useAnimation = 20;
            item.SetElementDamage(ElementDamageType.EarthDamage);
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse != 2)
            {
                item.shoot = ProjectileID.None;
                item.useTime = 20;
                item.useAnimation = 20;
            }
            else
            {
                item.shoot = ModContent.ProjectileType<ProMosscobbleBeam>();
                item.useTime = 300;
                item.useAnimation = 300;
            }
            return true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
            ref float knockBack)
        {
            Projectile.NewProjectile(player.Center.X + (player.direction * player.width), player.Bottom.Y, 0, 0,
                ModContent.ProjectileType<ProMosscobbleBeam>(), damage, knockBack, player.whoAmI);
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemMosscobble>(), 10);
                Ode.AddIngredient(ItemID.Gel, 7);
                Ode.AddIngredient(ItemID.Vine, 8);
                Ode.AddTile(TileID.WorkBenches);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}