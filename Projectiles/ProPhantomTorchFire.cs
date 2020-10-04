using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Projectiles
{
    public class ProPhantomTorchFire : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phantom Torch Fire");
            DisplayName.AddTranslation(GameCulture.Chinese, "»ÃÓ°»ð¾æµÄ»ð");
        }

        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 16;
            projectile.damage = 40;
            projectile.height = 16;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.alpha = 255;
            projectile.timeLeft = 75;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.SetElementDamage(ElementDamageType.ShadowFireDamage);
        }

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            target.AddBuff(BuffID.ShadowFlame, 180);
        }

        public override void AI()
        {
            if (projectile.timeLeft < 73)
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 027, 0f, 0f, 100, default(Color), 5f);
                dust.noGravity = true;
            }
        }
    }
}