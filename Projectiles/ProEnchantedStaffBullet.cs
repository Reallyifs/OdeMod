using StarlitRainbowCollection;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Projectiles
{
    public class ProEnchantedStaffBullet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Staff Bullet");
            DisplayName.AddTranslation(GameCulture.Chinese, "附魔焰弹");
            Main.projFrames[projectile.type] = 10;
        }

        public override void SetDefaults()
        {
            projectile.width = 34;
            projectile.height = 20;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.timeLeft = 600;
            projectile.damage = 10;
            projectile.magic = true;
            projectile.SetElementDamage(ElementDamageType.AranceDamage);
        }

        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + 3.14f;
        }

        public override void PostAI()
        {
            projectile.frameCounter++;
            if (projectile.frameCounter > 10)
            {
                projectile.frameCounter = 0;
                projectile.frame++;
                if (projectile.frame > 9)
                {
                    projectile.frame = 0;
                    return;
                }
            }
        }
    }
}