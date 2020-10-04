using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
namespace OdeMod.Projectiles.Lightmushroom
{
    public class ProLightmushroomSpores : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightmushroom Spores");
            DisplayName.AddTranslation(GameCulture.Chinese, "光明蘑菇孢子");
        }
        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 10;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.timeLeft = 600;
            projectile.penetrate = 3;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.SetElementDamage(ElementDamageType.HallowedDamage);
        }
        public override void AI()
        {
            Lighting.AddLight(projectile.Center, 0.2f, 0.2f, 0.1f);
            if (Main.rand.Next(1, 3) <= 1)
            {
                Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, MyDustId.WhiteLight, 0, 0);
                dust.alpha = Main.rand.Next(100, 200);
                dust.color = Color.White;
                dust.scale = Main.rand.NextFloat(0.8f, 1.2f);
                dust.velocity *= 0;
                dust.noGravity = true;
            }
        }
        public override bool PreKill(int timeLeft)
        {
            projectile.alpha += 51;
            if (projectile.alpha <= 255) { return false; }
            return true;
        }
    }
}