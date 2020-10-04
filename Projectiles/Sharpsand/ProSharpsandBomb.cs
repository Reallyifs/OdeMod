using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using StarlitRainbowCollection;

namespace OdeMod.Projectiles.Sharpsand
{
    public class ProSharpsandBomb : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sharpsand Bomb");
            DisplayName.AddTranslation(GameCulture.Chinese, "纯砂炸弹");
        }
        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.damage = 75;
            projectile.height = 20;
            projectile.ranged = true;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.timeLeft = 300;
            projectile.knockBack = 3.5f;
            projectile.penetrate = 1;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.SetElementDamage(ElementDamageType.EarthDamage);
        }
        public override void AI()
        {
            Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, MyDustId.Fire, projectile.velocity.X / 4,
                projectile.velocity.Y / 4);
            dust.alpha = Main.rand.Next(100, 200);
            dust.color = Color.OrangeRed;
            dust.scale = Main.rand.NextFloat(0.8f, 1.2f);
            dust.noGravity = true;
        }
        public override void Kill(int timeLeft)
        {
            Projectile.NewProjectile(projectile.Center, Vector2.Zero, ModContent.ProjectileType<ProSharpsandExplode>(), projectile.damage,
                projectile.knockBack, projectile.owner);
        }
    }
}