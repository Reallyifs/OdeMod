using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Lightmushroom
{
    public class MushroomHolyknife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mushroom Holyknife");
            DisplayName.AddTranslation(GameCulture.Chinese, "蘑菇圣剑");
        }

        public override void SetDefaults()
        {
            item.crit = 18;
            item.rare = ItemRarityID.Pink;
            item.melee = true;
            item.value = Item.sellPrice(0, 5, 10, 20);
            item.width = 42;
            item.damage = 69;
            item.height = 42;
            item.useTime = 18;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.knockBack = 3.7f;
            item.useAnimation = 18;
            item.SetElementDamage(ElementDamageType.HallowedDamage);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemLightmushroom>(), 7);
                Ode.AddIngredient(ItemID.HellstoneBar, 5);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}