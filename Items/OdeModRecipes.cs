using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using static OdeMod.OdeModFunctions;
using static OdeMod.OdeModFunctions.ModRecipeFunctions;
namespace OdeMod.Items
{
    public class OdeModRecipes
    {
        public static void AddRecipes()
        {
            VanillaChange();
        }
        public static void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Language.GetTextValue("ItemName.CrimtaneBar")}",
                new int[]
                {
                    ItemID.DemoniteBar,
                    ItemID.CrimtaneBar
                });
            RecipeGroup.RegisterGroup("OdeMod:CrimtaneBar", group);
        }
        private static void VanillaChange()
        {
            ModRecipe recipe;
            #region 火把
            recipe = GetOdeModRecipe();
            // 加、私货
            recipe.AddIngredient(ItemID.WhiteTorch);
            recipe.AddIngredient(ItemID.RedTorch);
            recipe.AddIngredient(ItemID.OrangeTorch);
            recipe.AddIngredient(ItemID.YellowTorch);
            recipe.AddIngredient(ItemID.GreenTorch);
            recipe.AddIngredient(ItemID.BlueTorch);
            recipe.AddIngredient(ItemID.PurpleTorch);
            recipe.AddIngredient(ItemID.PinkTorch);
            recipe.SetResult(ItemID.RainbowTorch);
            recipe.AddRecipe();
            #endregion
        }
    }
}