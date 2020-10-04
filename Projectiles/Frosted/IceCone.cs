using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OdeMod.Projectiles.Frosted
{
    public class IceCone : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.AddTranslation(Terraria.Localization.GameCulture.Chinese, "冰锥");
		}

		public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 28;
            projectile.timeLeft = 600;
            projectile.aiStyle = -1;
            projectile.magic = true;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.penetrate = 1;
            projectile.light = 0.7f;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.SetElementDamage(5);
        }

        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + 1.57f;
            if(projectile.timeLeft % 2 == 0)
            {
                projectile.EmergeDust(197, projectile.velocity * 0.1f, 1.2f, 100);
            }
        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Item27, projectile.position);
            for (int i = 0; i < 8; i++)
            {
                int id = Dust.NewDust(projectile.position, projectile.width, projectile.height, 197, 0f, 0f, 100, default(Color), 1.2f);
                Main.dust[id].noGravity = true;
            }
        }
    }
}
