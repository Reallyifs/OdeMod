using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Frosted
{
    public class FrostedThorn : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forsted Thorn");
            DisplayName.AddTranslation(GameCulture.Chinese, "凝霜荆棘");
            Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.crit = 7;
            item.mana = 14;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<ProFrostedThorn>();
            item.magic = true;
            item.value = Item.sellPrice(0, 8, 0, 0);
            item.width = 42;
            item.damage = 75;
            item.height = 46;
            item.noMelee = true;
            item.useTime = 20;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = true;
            item.knockBack = 2.6f;
            item.shootSpeed = 32;
            item.useAnimation = 20;
            item.SetElementDamage(ElementDamageType.ForstDamage);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.FrostCore, 5);
                Ode.AddIngredient(ItemID.ChlorophyteBar, 15);
                Ode.AddIngredient(ItemID.SoulofFright, 11);
                Ode.AddIngredient(ItemID.SoulofMight, 11);
                Ode.AddIngredient(ItemID.SoulofSight, 15);
                Ode.AddTile(TileID.MythrilAnvil);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}