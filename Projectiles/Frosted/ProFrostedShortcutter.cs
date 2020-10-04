using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
namespace OdeMod.Projectiles.Frosted
{
    public class ProFrostedShortcutter : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shorter-Forstedcutter");
            DisplayName.AddTranslation(GameCulture.Chinese, "凝霜飞刀");
        }

        public override void SetDefaults()
        {
            projectile.scale = 1.5f;
            projectile.width = 8;
            projectile.damage = 52;
            projectile.height = 14;
            projectile.ranged = true;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.timeLeft = 300;
            projectile.knockBack = 4.5f;
            projectile.penetrate = 1;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.SetElementDamage(ElementDamageType.ForstDamage);
        }
        public override void AI()
        {
            projectile.velocity *= 0.98f;
            Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, MyDustId.BlueMagic, projectile.velocity.X / 3,
                projectile.velocity.Y / 3, Main.rand.Next(100, 200), Color.Blue, Main.rand.NextFloat(0.8f, 1.2f));
            dust.noGravity = true;
            OdeModFunctions.GlobalProjectileFunctions.RotationSlowly(projectile);
            if (projectile.rotation >= 6.282f)
                projectile.rotation -= 6.282f;
        }
    }
}