using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using StarlitRainbowCollection;

namespace OdeMod.Projectiles.Sharpsand
{
    public class ProSharpsandBeam : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sharpsand Beam");
            DisplayName.AddTranslation(GameCulture.Chinese, "纯砂剑气");
        }
        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.width = 24;
            projectile.damage = 10;
            projectile.height = 24;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.SetElementDamage(ElementDamageType.EarthDamage);
        }
        public override void AI()
        {
            Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, MyDustId.Fire, projectile.velocity.X / 2,
                projectile.velocity.Y / 2, Main.rand.Next(100, 200), Color.OrangeRed, Main.rand.NextFloat(0.8f, 1.2f));
            dust.noGravity = true;
        }
        public override void Kill(int timeLeft)
        {
            Projectile.NewProjectile(projectile.Center, Vector2.Zero, ModContent.ProjectileType<ProSharpsandExplode>(), projectile.damage,
                projectile.knockBack, projectile.owner);
        }
    }
}