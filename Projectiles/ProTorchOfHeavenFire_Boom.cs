using StarlitRainbowCollection;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Projectiles
{
    public class ProTorchOfHeavenFireBoom : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heaven's Holy Torch Fire Boom");
            DisplayName.AddTranslation(GameCulture.Chinese, "ÌìÌÃÊ¥»ðµÄ»ðµÄ±¬Õ¨");
            Main.projFrames[projectile.type] = 10;
        }

        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 20;
            projectile.damage = 105;
            projectile.height = 20;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.alpha = 0;
            projectile.timeLeft = 90;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.scale = 1.5f;
            projectile.SetElementDamage(ElementDamageType.HallowedDamage);
        }

        public override void AI()
        {
            projectile.frameCounter++;
            if (projectile.frameCounter > 1)
            {
                projectile.frame++;
                projectile.frameCounter = 0;
            }
            if (projectile.frame >= 11)
            {
                projectile.Kill();
                return;
            }
        }
    }
}