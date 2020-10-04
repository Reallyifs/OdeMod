using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class Graphite : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Graphite");
            DisplayName.AddTranslation(GameCulture.Chinese, "石墨");
        }
        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 12;
        }
    }
}