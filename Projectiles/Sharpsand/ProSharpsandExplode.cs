using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using StarlitRainbowCollection;
namespace OdeMod.Projectiles.Sharpsand
{
    public class ProSharpsandExplode : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sharpsand Bomb");
            DisplayName.AddTranslation(GameCulture.Chinese, "纯砂炸弹");
            Main.projFrames[projectile.type] = 10;
        }

        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.width = 120;
            projectile.damage = 312;
            projectile.height = 120;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.timeLeft = 100;
            projectile.knockBack = 3f;
            projectile.penetrate = 1;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.SetElementDamage(ElementDamageType.EarthDamage);
        }

        public override void AI()
        {
            projectile.frameCounter++;
            if (projectile.frameCounter >= 10)
            {
                projectile.frame++;
                projectile.frameCounter = 0;
            }
            if (projectile.frame >= 10) { projectile.Kill(); }
        }
    }
}