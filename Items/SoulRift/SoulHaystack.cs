using OdeMod.Tiles.SoulRift;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.SoulRift
{
    public class SoulHaystack : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Haystack");
            DisplayName.AddTranslation(GameCulture.Chinese, "灵魂草堆");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 24;
            item.value = 0;
            item.rare = ItemRarityID.White;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useTurn = true;
            item.createTile = ModContent.TileType<TileSoulHaystack>();
            item.autoReuse = true;
            item.consumable = true;
        }
    }
}