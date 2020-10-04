using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Lightmushroom
{
    public class MushroomHolybow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mushroom Holybow");
            DisplayName.AddTranslation(GameCulture.Chinese, "蘑菇圣弓");
        }

        public override void SetDefaults()
        {
            item.crit = 18;
            item.rare = ItemRarityID.Pink;
            item.value = Item.sellPrice(0, 4, 10, 65);
            item.width = 30;
            item.damage = 41;
            item.height = 42;
            item.ranged = true;
            item.useAmmo = AmmoID.Arrow;
            item.useTime = 19;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = true;
            item.knockBack = 3.7f;
            item.shootSpeed = 52;
            item.useAnimation = 19;
            item.SetElementDamage(ElementDamageType.HallowedDamage);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemLightmushroom>(), 9);
                Ode.AddIngredient(ItemID.HellstoneBar, 8);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}