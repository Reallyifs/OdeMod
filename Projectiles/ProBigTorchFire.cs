using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using StarlitRainbowCollection;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace OdeMod.Projectiles
{
    public class ProBigTorchFire : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Big Torch Fire");
            DisplayName.AddTranslation(GameCulture.Chinese, "´ó»ð¾æµÄ»ð");
        }
        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 16;
            projectile.damage = 10;
            projectile.height = 16;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.penetrate = 2;
            projectile.alpha = 255;
            projectile.timeLeft = 50;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.SetElementDamage(ElementDamageType.FireDamage);
            aiType = ProjectileID.Flames;
        }
        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (Main.rand.Next(2) < 1)
            {
                target.AddBuff(24, 90);
            }
        }
        public override void AI()
        {
            if (projectile.timeLeft < 48)
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 06, 0f, 0f, 100, default(Color), 6f);
                dust.noGravity = true;
            }
        }
    }
}