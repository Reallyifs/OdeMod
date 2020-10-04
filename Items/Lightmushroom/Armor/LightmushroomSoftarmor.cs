using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Lightmushroom.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class LightmushroomSoftarmor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightmushroom Softarmor");
            DisplayName.AddTranslation(GameCulture.Chinese, "光明蘑菇软甲");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Pink;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.width = 30;
            item.height = 16;
            item.defense = 14;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemLightmushroom>(), 15);
                Ode.AddIngredient(ItemID.HellstoneBar, 12);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}