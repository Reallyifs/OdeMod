using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OdeMod.Projectiles
{
    public class ProCloud1 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("幽魂云");
            Main.projFrames[projectile.type] = 8;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(238);
            projectile.aiStyle = -1;
        }

        public override void AI()
        {
            projectile.ai[1]++;
            if (projectile.ai[1] >= 3600f)
            {
                projectile.alpha += 5;
                if (projectile.alpha > 255)
                {
                    projectile.alpha = 255;
                    projectile.Kill();
                }
            }
            projectile.ai[0]++;
            if (projectile.ai[0] > 10f)
            {
                projectile.ai[0] = 0f;
                if (projectile.owner == Main.myPlayer)
                {
                    float x = projectile.position.X + 14f + Main.rand.Next(projectile.width - 28);
                    float y = projectile.position.Y + projectile.height + 4f;
                    Projectile.NewProjectile(x, y, 0f, 5f, ProjectileID.LostSoulFriendly, projectile.damage, 0f, projectile.owner, 0f, 0f);
                }
            }
            projectile.frameCounter++;
            if (projectile.frameCounter > 8)
            {
                projectile.frameCounter = 0;
                projectile.frame++;
                if (projectile.frame > 7)
                {
                    projectile.frame = 0;
                }
            }
            float ai = 0;
            int count = 0, i = 0;
            for (int t = 0; t < Main.projectile.Length; t++)
            {
                if (Main.projectile[t].active && Main.projectile[t].type == projectile.type)
                {
                    if (Main.projectile[t].ai[1] > ai)
                    {
                        ai = Main.projectile[t].ai[1];
                        i = t;
                    }
                    count++;
                }
            }
            if (count > 3)
                Main.projectile[i].ai[1] = 3600f;

        }
        public override Color? GetAlpha(Color lightColor)
        {
            if (projectile.timeLeft < 30)
                projectile.alpha += 10;
            return new Color(255 - projectile.alpha, 255 - projectile.alpha, 255 - projectile.alpha, 255 - projectile.alpha);
        }
    }
}