using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Projectiles
{
    public class ProTorchOfHeavenFire : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heaven's Holy Torch Fire");
            DisplayName.AddTranslation(GameCulture.Chinese, "ÌìÌÃÊ¥»ðµÄ»ð");
        }

        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 16;
            projectile.damage = 105;
            projectile.height = 16;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.alpha = 255;
            projectile.timeLeft = 90;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.SetElementDamage(ElementDamageType.HallowedDamage);
        }

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            target.AddBuff(BuffID.ShadowFlame, 180);
            Projectile.NewProjectile(projectile.position.X + (float)(projectile.width / 2) - 50,
                projectile.position.Y + (float)(projectile.height / 2) - 55, 0, 0, ModContent.ProjectileType<ProTorchOfHeavenFireBoom>(), 105,
                2, projectile.owner);
            projectile.Kill();
        }

        public override void AI()
        {
            if (projectile.timeLeft < 88)
                Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 55, 0f, 0f, 100, default(Color), 4f).noGravity = true;
        }
    }
}