using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Mosscobble.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class MosscobbleLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mosscobble Leggings");
            DisplayName.AddTranslation(GameCulture.Chinese, "苔石护腿");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(0, 0, 1, 0);
            item.width = 20;
            item.height = 16;
            item.defense = 1;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemMosscobble>(), 5);
                Ode.AddIngredient(ItemID.Gel, 10);
                Ode.AddIngredient(ItemID.Vine, 6);
                Ode.AddTile(TileID.WorkBenches);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}