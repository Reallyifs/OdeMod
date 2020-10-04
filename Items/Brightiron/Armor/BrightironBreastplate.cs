using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Brightiron.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class BrightironBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brightiron Breastplate");
            DisplayName.AddTranslation(GameCulture.Chinese, "熙铁胸甲");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(0, 0, 10, 35);
            item.width = 30;
            item.height = 18;
            item.defense = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<BrightironBar>(), 12);
                Ode.AddIngredient(ModContent.ItemType<SpiritPieces>(), 20);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}