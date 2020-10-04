using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Projectiles
{
    public class ProStoneHammer : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Hammer");
            DisplayName.AddTranslation(GameCulture.Chinese, "石锤");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(6);
        }
    }
}