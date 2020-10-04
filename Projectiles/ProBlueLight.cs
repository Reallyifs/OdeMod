using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Projectiles
{
    public class ProBlueLight : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Light Beam");
            DisplayName.AddTranslation(GameCulture.Chinese, "碧蓝之光刃气");
            Main.projFrames[projectile.type] = 2;
        }

        public override void SetDefaults()
        {
            projectile.width = 34;
            projectile.height = 34;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.timeLeft = 600;
            projectile.penetrate = -1;
            projectile.ai[0] = -1;
        }

        public override void AI()
        {
            projectile.rotation += 0.1f;
            if (projectile.ai[0] != -1)
            {
                NPC target = Main.npc[(int)projectile.ai[0]];
                projectile.position += target.position - target.oldPosition;
                if (projectile.alpha++ > 240) projectile.Kill();
            }
        }

        public override void PostAI()
        {
            projectile.frameCounter++;
            if (projectile.frameCounter > 2)
            {
                projectile.frame++;
                projectile.frameCounter = 0;
                if (projectile.frame > 1)
                {
                    projectile.frame = 0;
                }
            }
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (projectile.velocity.X != oldVelocity.X) projectile.velocity.X = 0;
            if (projectile.velocity.Y != oldVelocity.Y) projectile.velocity.Y = 0;
            return false;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (projectile.ai[0] == -1)
            {
                projectile.ai[0] = target.whoAmI;
                projectile.velocity *= 0;
            }
        }

        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 3; i++)
            {
                Vector2 pos = Geometry.GetRandomPosInCircle(projectile.Center, 60);
                var proj = projectile.DeriveProjectile(ProjectileID.TruffleSpore, Vector2.Zero, pos, 0.5f);
                proj.noDropItem = true;
                proj.timeLeft = 300;
            }
        }
    }
}