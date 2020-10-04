using Terraria.ModLoader;
using Terraria.ID;

namespace OdeMod.Items.Cemetery
{
    public class BoneOakWood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bone Oak Wood");
            DisplayName.AddTranslation(Terraria.Localization.GameCulture.Chinese, "骨橡木");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 20;
            item.maxStack = 99;
            item.value = 0;
            item.rare = ItemRarityID.White;
        }
    }
}