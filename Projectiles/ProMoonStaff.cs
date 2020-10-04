using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Projectiles
{
    public class ProMoonStaff : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon");
            DisplayName.AddTranslation(GameCulture.Chinese, "清月");
        }

        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 16;
            projectile.height = 16;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.alpha = 25;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.SetElementDamage(ElementDamageType.ClimateDamage);
            if (!Main.hardMode)
            {
                projectile.damage = 10;
                projectile.timeLeft = 540;
            }
            else
            {
                projectile.damage = 45;
                projectile.timeLeft = 600;
            }
        }

        public override void AI()
        {
            if (projectile.timeLeft < 597)
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 198, 0f, 0f, 100, default(Color), 2f);
                dust.noGravity = true;
            }
        }
    }
}