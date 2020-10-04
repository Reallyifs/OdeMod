using OdeMod.Tiles.Cemetery;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Cemetery
{
    public class WhiteSoulStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("White Soul Stone");
            DisplayName.AddTranslation(GameCulture.Chinese, "白魄石");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 18;
            item.value = 0;
            item.rare = ItemRarityID.White;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useTurn = true;
            item.createTile = ModContent.TileType<TileWhiteSoulStone>();
            item.autoReuse = true;
            item.consumable = true;
        }
    }
}