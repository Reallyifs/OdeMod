using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Brightiron.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class BrightironLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brightiron Leggings");
            DisplayName.AddTranslation(GameCulture.Chinese, "熙铁护腿");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(0, 0, 10, 10);
            item.width = 20;
            item.height = 16;
            item.defense = 9;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<BrightironBar>(), 10);
                Ode.AddIngredient(ModContent.ItemType<SpiritPieces>(), 16);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}