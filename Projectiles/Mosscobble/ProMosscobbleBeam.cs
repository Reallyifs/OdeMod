using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using StarlitRainbowCollection;
namespace OdeMod.Projectiles.Mosscobble
{
    public class ProMosscobbleBeam : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mosscobble Beam");
            DisplayName.AddTranslation(GameCulture.Chinese, "苔石剑气");
            Main.projFrames[projectile.type] = 4;
        }
        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.width = 66;
            projectile.damage = 10;
            projectile.height = 78;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 150;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.SetElementDamage(ElementDamageType.EarthDamage);
        }
        public override void AI()
        {
            projectile.direction = Main.player[projectile.owner].direction;
            projectile.spriteDirection = Main.player[projectile.owner].direction;
        }
    }
}