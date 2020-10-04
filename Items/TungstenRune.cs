using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class TungstenRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tungsten Rune");
            DisplayName.AddTranslation(GameCulture.Chinese, "钨符文");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
        }
    }
}