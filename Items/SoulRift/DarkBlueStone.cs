using OdeMod.Tiles.SoulRift;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.SoulRift
{
    class DarkBlueStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Blue Stone");
            DisplayName.AddTranslation(GameCulture.Chinese, "暗蓝石");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 22;
            item.value = 0;
            item.rare = ItemRarityID.White;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useTurn = true;
            item.createTile = ModContent.TileType<TileDarkBlueStone>();
            item.autoReuse = true;
            item.consumable = true;
        }
    }
}