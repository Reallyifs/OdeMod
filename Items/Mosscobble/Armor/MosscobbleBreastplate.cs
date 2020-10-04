using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Mosscobble.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class MosscobbleBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mosscobble Breastplate");
            DisplayName.AddTranslation(GameCulture.Chinese, "苔石胸甲");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(0, 0, 1, 50);
            item.width = 30;
            item.height = 18;
            item.defense = 3;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemMosscobble>(), 6);
                Ode.AddIngredient(ItemID.Gel, 8);
                Ode.AddIngredient(ItemID.Vine, 4);
                Ode.AddTile(TileID.WorkBenches);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}