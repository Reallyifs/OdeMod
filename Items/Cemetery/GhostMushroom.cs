using Terraria.ModLoader;

namespace OdeMod.Items.Cemetery
{
    public class GhostMushroom : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ghost Mushroom");
            DisplayName.AddTranslation(Terraria.Localization.GameCulture.Chinese, "幽灵菇");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.maxStack = 99;
            item.value = 25;
            item.rare = 0;
        }
    }
}