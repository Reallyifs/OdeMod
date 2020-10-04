using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Californium
{
    public class Plaguebatter : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plaguebatter");
            DisplayName.AddTranslation(GameCulture.Chinese, "瘟疫打击者");
        }
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Yellow;
            item.shoot = ProjectileID.BulletHighVelocity;
            item.value = Item.sellPrice(0, 9, 25, 60);
            item.width = 68;
            item.damage = 48;
            item.height = 26;
            item.ranged = true;
            item.useAmmo = AmmoID.Bullet;
            item.useTime = 9;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = true;
            item.knockBack = 6;
            item.shootSpeed = 37;
            item.useAnimation = 9;
        }

        public override Vector2? HoldoutOffset() => new Vector2(-10, -8);

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
            ref float knockBack)
        {
            for (int i = -1; i <= 1; i++)
            {
                Vector2 tVEC = Vector2.Normalize(Main.MouseWorld - player.Center) * item.shootSpeed;
                tVEC.RotatedBy(Main.rand.NextFloat(-0.2f, 0.2f) * i);
                Projectile.NewProjectile(player.Center, tVEC,
                    Main.rand.Next(1, 10) <= 1 ? ProjectileID.ChlorophyteBullet : ProjectileID.BulletHighVelocity,
                    damage, knockBack, player.whoAmI);
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.VenusMagnum);
                Ode.AddIngredient(ModContent.ItemType<CaliforniumBar>(), 12);
                Ode.AddTile(TileID.LunarCraftingStation);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}