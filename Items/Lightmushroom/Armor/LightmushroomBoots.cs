using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Lightmushroom.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class LightmushroomBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightmushroom Boots");
            DisplayName.AddTranslation(GameCulture.Chinese, "光明蘑菇靴");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.LightRed;
            item.value = Item.sellPrice(0, 1, 20, 0);
            item.width = 20;
            item.height = 16;
            item.defense = 11;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemLightmushroom>(), 10);
                Ode.AddIngredient(ItemID.HellstoneBar, 7);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}