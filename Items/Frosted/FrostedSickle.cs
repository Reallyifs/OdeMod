using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Frosted
{
    public class FrostedSickle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forsted Sickle");
            DisplayName.AddTranslation(GameCulture.Chinese, "凝霜镰刀");
        }
        public override void SetDefaults()
        {
            item.crit = 16;
            item.rare = ItemRarityID.LightRed;
            item.melee = true;
            item.scale = 1.2f;
            item.shoot = ModContent.ProjectileType<ProFrostedSickle>();
            item.value = Item.sellPrice(0, 8, 0, 0);
            item.width = 50;
            item.damage = 83;
            item.height = 50;
            item.useTime = 28;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.knockBack = 5f;
            item.shootSpeed = 30;
            item.useAnimation = 28;
            item.SetElementDamage(ElementDamageType.ForstDamage);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.FrostCore, 3);
                Ode.AddIngredient(ItemID.ChlorophyteBar, 20);
                Ode.AddIngredient(ItemID.SoulofFright, 8);
                Ode.AddIngredient(ItemID.SoulofMight, 15);
                Ode.AddIngredient(ItemID.SoulofSight, 8);
                Ode.AddTile(TileID.MythrilAnvil);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}