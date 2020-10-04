using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using StarlitRainbowCollection;
namespace OdeMod.Projectiles.Mosscobble
{
    public class ProStoneCone : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Cone");
            DisplayName.AddTranslation(GameCulture.Chinese, "石锥");
            Main.projFrames[projectile.type] = 8;
        }
        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.width = 44;
            projectile.damage = 10;
            projectile.height = 40;
            projectile.timeLeft = 96;
            projectile.knockBack = 5f;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.SetElementDamage(ElementDamageType.EarthDamage);
        }
        public override void AI()
        {
            projectile.velocity *= 0;
            projectile.frameCounter++;
            if (projectile.frameCounter >= 12) { projectile.frame++; }
            if (projectile.frame >= 9) { projectile.Kill(); }
        }
    }
}