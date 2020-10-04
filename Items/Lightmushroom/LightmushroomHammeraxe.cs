using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Lightmushroom
{
    public class LightmushroomHammeraxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightmushroom Hammeraxe");
            DisplayName.AddTranslation(GameCulture.Chinese, "光明蘑菇锤斧");
        }

        public override void SetDefaults()
        {
            item.axe=
            item.crit = 8;
            item.rare = ItemRarityID.Orange;
            item.melee = true;
            item.value = Item.sellPrice(0, 4, 30, 0);
            item.width = 38;
            item.damage = 34;
            item.height = 36;
            item.useTime = 17;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.knockBack = 7.2f;
            item.useAnimation = 17;
            item.SetElementDamage(ElementDamageType.HallowedDamage);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemLightmushroom>(), 8);
                Ode.AddIngredient(ItemID.HellstoneBar, 5);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}