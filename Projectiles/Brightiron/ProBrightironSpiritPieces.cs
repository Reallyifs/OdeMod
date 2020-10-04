using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Projectiles.Brightiron
{
    public class ProBrightironSpiritPieces : ModProjectile
    {
        public override string Texture => "OdeMod/Items/Brightiron/SpiritPieces";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spirit Pieces");
            DisplayName.AddTranslation(GameCulture.Chinese, "异灵体");
            Main.projFrames[projectile.type] = 8;
        }

        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 29;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.penetrate = 2;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
        }

        public override void AI()
        {
            projectile.frameCounter++;
            if (projectile.frameCounter >= 5)
            {
                projectile.frame++;
                projectile.frameCounter = 0;
                if (projectile.frame >= 8)
                    projectile.frame = 0;
            }
            for (int i = 0; i <= 3; i++)
            {
                Dust dust = Dust.NewDustDirect(projectile.Center, (int)(projectile.width * 1.2), (int)(projectile.height * 1.2),
                    MyDustId.YellowFx, projectile.velocity.X / 3, projectile.velocity.Y / 3, Main.rand.Next(100, 200), Color.LightYellow,
                    Main.rand.NextFloat(0.8f, 1.2f));
                dust.noLight = false;
                dust.noGravity = true;
            }
        }
    }
}