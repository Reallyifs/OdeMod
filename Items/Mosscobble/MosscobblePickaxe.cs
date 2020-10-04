using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Mosscobble
{
    public class MosscobblePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mosscobble Pickaxe");
            DisplayName.AddTranslation(GameCulture.Chinese, "苔石镐");
        }

        public override void SetDefaults()
        {
            item.crit = 5;
            item.rare = ItemRarityID.Green;
            item.melee = true;
            item.value = Item.sellPrice(0, 0, 1, 0);
            item.width = 28;
            item.damage = 4;
            item.height = 30;
            item.useTime = 23;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.tileBoost = 1;
            item.knockBack = 3.5f;
            item.useAnimation = 23;
            item.SetElementDamage(ElementDamageType.EarthDamage);
        }

        public override bool AltFunctionUse(Player player) => true;

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse != 2)
            {
                item.pick = 35;
                item.hammer = 0;
                item.useTime = 23;
                item.useAnimation = 23;
            }
            else
            {
                item.pick = 0;
                item.hammer = 35;
                item.useTime = 33;
                item.useAnimation = 33;
            }
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemMosscobble>(), 12);
                Ode.AddIngredient(ItemID.Gel, 7);
                Ode.AddIngredient(ItemID.Vine, 10);
                Ode.AddTile(TileID.WorkBenches);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}