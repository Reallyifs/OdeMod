using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using StarlitRainbowCollection;

namespace OdeMod.Projectiles.Sharpsand
{
    public class ProSharpsandFire : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sharpsand Fire");
            DisplayName.AddTranslation(GameCulture.Chinese, "纯砂焰火");
            Main.projFrames[projectile.type] = 3;
        }

        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 12;
            projectile.damage = 75;
            projectile.height = 30;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.timeLeft = 600;
            projectile.knockBack = 3f;
            projectile.penetrate = 1;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.SetElementDamage(ElementDamageType.EarthDamage);
            if (projectile.ai[0] >= 1 && projectile.ai[0] <= 10) { projectile.height = 8; }
        }

        public override void AI()
        {
            projectile.frameCounter++;
            Dust.NewDust(projectile.Center, projectile.width, projectile.height, MyDustId.Fire, projectile.velocity.X / 2,
                projectile.velocity.Y / 2, Main.rand.Next(100, 200), Color.OrangeRed, Main.rand.NextFloat(0.8f, 1.2f));
            if (projectile.frameCounter >= 10)
            {
                projectile.frame++;
                projectile.frameCounter = 0;
            }
            if (projectile.frame >= 3) { projectile.frame = 0; }
        }

        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 3; i++)
            {
                Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width + 2, projectile.height + 2, MyDustId.Fire, 0, 0);
                dust.alpha = Main.rand.Next(100, 200);
                dust.color = Color.Orange;
                dust.scale = Main.rand.NextFloat(0.8f, 1.2f);
                dust.noGravity = true;
            }
        }
    }
}