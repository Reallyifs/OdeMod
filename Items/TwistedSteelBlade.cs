using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class TwistedSteelBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Twisted Steel Blade");
            DisplayName.AddTranslation(GameCulture.Chinese, "扭曲的钢刃");
            Tooltip.SetDefault("The steel blade made by carelessness, it contains nature.");
            Tooltip.AddTranslation(GameCulture.Chinese, "阴差阳错地直接熔炼出的刀刃，蕴含了自然的力量");
        }

        public override void SetDefaults()
        {
            item.crit = 6;
            item.rare = ItemRarityID.Blue;
            item.melee = true;
            item.value = Item.sellPrice(0, 0, 30, 0);
            item.width = 28;
            item.damage = 10;
            item.height = 40;
            item.useTime = 10;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.knockBack = 1f;
            item.useAnimation = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod)
            {
                anyIronBar = true
            };
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.IronOre, 20);
                Ode.AddTile(TileID.Furnaces);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}