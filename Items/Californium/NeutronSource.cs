using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Californium
{
    public class NeutronSource : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Neutron Source");
            DisplayName.AddTranslation(GameCulture.Chinese, "中子源");
            Tooltip.SetDefault("You can watch the location of treasure and ore\n" +
                "Your defense increase 10%");
            Tooltip.AddTranslation(GameCulture.Chinese, "你可以看到宝藏和矿石的位置\n" +
                "你的防御增加10%");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Cyan;
            item.width = 34;
            item.height = 30;
            item.defense = 10;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense = (int)(player.statDefense * 1.1f);
            player.AddBuff(BuffID.Spelunker, 1);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<CaliforniumBar>(), 14);
                Ode.AddTile(TileID.LunarCraftingStation);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}