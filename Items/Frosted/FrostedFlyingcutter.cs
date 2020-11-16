using Microsoft.Xna.Framework;
using OdeMod.Projectiles.Frosted;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Frosted
{
    public class FrostedFlyingcutter : ModItem
    {
        private int ThrownTime = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forsted Flyingcutter");
            DisplayName.AddTranslation(GameCulture.Chinese, "凝霜飞刀");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.crit = 6;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<ProFrostedShortcutter>();
            item.value = Item.sellPrice(0, 6, 50, 0);
            item.width = 32;
            item.damage = 52;
            item.height = 32;
            item.ranged = true;
            item.noMelee = true;
            item.useTime = 25;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = true;
            item.knockBack = 4.5f;
            item.shootSpeed = 10;
            item.useAnimation = 25;
            item.SetElementDamage(ElementDamageType.ForstDamage);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
            ref float knockBack)
        {
            Vector2 tVEC = Vector2.Normalize(Main.MouseWorld - player.Center) * item.shootSpeed;
            if (ThrownTime <= 3)
            {
                for (int i = -2; i <= 2; i++)
                {
                    Vector2 tVECL = tVEC + new Vector2(-tVEC.Y * 0.25f, tVEC.X * 0.25f) * i;
                    tVECL.RotatedBy(Main.rand.NextDouble() * 0.05 * i);
                    Projectile.NewProjectile(player.Center, tVECL, ModContent.ProjectileType<ProFrostedShortcutter>(), (int)(item.damage * 1.2),
                        item.knockBack, player.whoAmI);
                }
            }
            if (ThrownTime > 3)
            {
                for (int i = -1; i <= 1; i++)
                {
                    Vector2 tVECL = tVEC + new Vector2(-tVEC.Y * 0.375f, tVEC.X * 0.375f) * i;
                    tVECL.RotatedBy(Main.rand.NextDouble() * 0.05 * i);
                    Projectile.NewProjectile(player.Center, tVECL, ModContent.ProjectileType<ProFrostedLongcutter>(),
                        (int)((item.damage * 1.7) + (item.crit * 0.1)), item.knockBack, player.whoAmI);
                }
            }
            ThrownTime++;
            return false;
        }

        public override void UpdateInventory(Player player)
        {
            if (Main.mouseLeftRelease || !Main.mouseLeft)
                ThrownTime = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.FrostCore, 4);
                Ode.AddIngredient(ItemID.ChlorophyteBar, 16);
                Ode.AddIngredient(ItemID.SoulofFright, 14);
                Ode.AddIngredient(ItemID.SoulofMight, 10);
                Ode.AddIngredient(ItemID.SoulofSight, 10);
                Ode.AddTile(TileID.MythrilAnvil);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}