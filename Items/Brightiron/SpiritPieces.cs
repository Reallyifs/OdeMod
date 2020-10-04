using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Brightiron
{
    public class SpiritPieces : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spirit Pieces");
            DisplayName.AddTranslation(GameCulture.Chinese, "异灵体");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(9, 8));
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(0, 0, 1, 20);
            item.width = 5;
            item.height = 10;
        }
    }
}