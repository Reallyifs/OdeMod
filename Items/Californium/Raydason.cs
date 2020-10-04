using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Californium
{
    public class Raydason : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Raydason");
            DisplayName.AddTranslation(GameCulture.Chinese, "瑞达森");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Cyan;
            item.melee = true;
            item.value = Item.sellPrice(0, 9, 60, 10);
            item.width = 34;
            item.damage = 118;
            item.height = 30;
            item.channel = true;
            item.useTime = 32;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = true;
            item.knockBack = 5;
            item.shootSpeed = 50;
            item.useAnimation = 32;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<CaliforniumBar>(), 16);
                Ode.AddTile(TileID.LunarCraftingStation);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}