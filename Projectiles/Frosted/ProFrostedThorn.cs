using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
namespace OdeMod.Projectiles.Frosted
{
    public class ProFrostedThorn : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forsted Thorn");
            DisplayName.AddTranslation(GameCulture.Chinese, "凝霜荆棘");
            Main.projFrames[projectile.type] = 3;
        }
        public override void SetDefaults()
        {
            projectile.alpha = 255;
            projectile.magic = true;
            projectile.width = 22;
            projectile.damage = 75;
            projectile.height = 16;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.timeLeft = 120;
            projectile.knockBack = 2.6f;
            projectile.penetrate = -1;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.SetElementDamage(ElementDamageType.ForstDamage);
        }
        public override void AI()
        {
            float xFLOAT = projectile.Center.X + projectile.velocity.X + projectile.width / 2;
            float yFLOAT = projectile.Center.Y + projectile.velocity.Y + projectile.height / 2;
            projectile.ai[1]++;
            projectile.alpha -= 40;
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            if (projectile.ai[0] == 0)
            {
                projectile.frame = 2;
                if (projectile.ai[1] == 10)
                {
                    Projectile.NewProjectile(xFLOAT, yFLOAT, projectile.velocity.X, projectile.velocity.Y, projectile.type, projectile.damage,
                        projectile.knockBack, projectile.owner, 1);
                }
            }
            else if (projectile.ai[0] >= 1 && projectile.ai[0] <= 10)
            {
                projectile.frame = 1;
                projectile.height = 8;
                if (projectile.ai[1] == 10)
                {
                    Projectile.NewProjectile(xFLOAT, yFLOAT, projectile.velocity.X, projectile.velocity.Y, projectile.type, projectile.damage,
                        projectile.knockBack, projectile.owner, projectile.ai[0] + 1);
                }
            }
            else { projectile.frame = 0; }
            if (projectile.alpha < 0) { projectile.alpha = 0; }
        }
        public override bool ShouldUpdatePosition() => false;
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (projectile.velocity.X != oldVelocity.X) { projectile.velocity.X = -oldVelocity.X; }
            if (projectile.velocity.Y != oldVelocity.Y) { projectile.velocity.Y = -oldVelocity.Y; }
            return false;
        }
    }
}