using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using OdeMod.Tiles.Cemetery;

namespace OdeMod.Items.Cemetery
{
    public class SoulDirt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Dirt");
            DisplayName.AddTranslation(GameCulture.Chinese, "凝魂土");
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
            item.createTile = ModContent.TileType<TileSoulSoilBlock>();
            item.autoReuse = true;
            item.consumable = true;
        }
    }
}