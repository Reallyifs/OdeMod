using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Sharpsand
{
    public class SharpsandGiantblade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sharpsand Giantblade");
            DisplayName.AddTranslation(GameCulture.Chinese, "纯砂巨刃");
        }

        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 52;
            item.value = Item.sellPrice(0, 7, 50, 0);
            item.rare = ItemRarityID.Pink;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.damage = 86;
            item.knockBack = 5f;
            item.crit = 10;
            item.melee = true;
            item.shoot = ModContent.ProjectileType<ProSharpsandBeam>();
            item.shootSpeed = 30;
            item.autoReuse = true;
            item.useTurn = false;
            item.SetElementDamage(ElementDamageType.EarthDamage);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.AncientBattleArmorMaterial, 3);
                Ode.AddIngredient(ItemID.ChlorophyteBar, 16);
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