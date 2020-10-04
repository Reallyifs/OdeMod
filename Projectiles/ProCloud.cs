using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Projectiles
{
    public class ProCloud : ModProjectile
    {
        public override string Texture => "Terraria/Projectile_237";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Smaller Raincloud");
            DisplayName.AddTranslation(GameCulture.Chinese, "小团雨云");
            Main.projFrames[projectile.type] = 4;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(237);
            projectile.aiStyle = -1;
        }

        public override void AI()
        {
            projectile.rotation += projectile.velocity.X * 0.02f;
            Vector2 vector = new Vector2(projectile.ai[0], projectile.ai[1]);
            bool up = (projectile.velocity.X < 0 && projectile.Center.X < vector.X) ||
                (projectile.velocity.X > 0 && projectile.Center.X > vector.X);
            bool down = (projectile.velocity.Y < 0 && projectile.Center.Y < vector.Y) ||
                (projectile.velocity.Y > 0 && projectile.Center.Y > vector.Y);
            if (up && down)
                projectile.Kill();
            projectile.frameCounter++;
            if (projectile.frameCounter > 4)
            {
                projectile.frameCounter = 0;
                projectile.frameCounter++;
                if (projectile.frame > 3)
                {
                    projectile.frame = 0;
                    return;
                }
            }
        }

        public override void Kill(int timeLeft)
        {
            Projectile.NewProjectile(projectile.position, Vector2.Zero, ModContent.ProjectileType<ProCloud1>(), projectile.damage,
                projectile.knockBack, projectile.owner);
        }
    }
}