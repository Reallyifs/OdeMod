using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Lightmushroom
{
    public class LightmushroomClaw : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightmushroom Claw");
            DisplayName.AddTranslation(GameCulture.Chinese, "明菇爪套");
        }

        public override void SetDefaults()
        {
            item.crit = 12;
            item.pick = 130;
            item.rare = ItemRarityID.Orange;
            item.melee = true;
            item.value = Item.sellPrice(0, 5, 0, 10);
            item.width = 28;
            item.damage = 34;
            item.height = 24;
            item.useTime = 18;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.knockBack = 3.2f;
            item.useAnimation = 18;
            item.SetElementDamage(ElementDamageType.HallowedDamage);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemLightmushroom>(), 10);
                Ode.AddIngredient(ItemID.HellstoneBar, 6);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}