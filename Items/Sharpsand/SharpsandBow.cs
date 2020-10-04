using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Sharpsand
{
    public class SharpsandBow : ModItem
    {
        private int counter = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sharpsand Bow");
            DisplayName.AddTranslation(GameCulture.Chinese, "纯砂弓");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 46;
            item.value = Item.sellPrice(0, 8, 0, 0);
            item.rare = ItemRarityID.Pink;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.damage = 94;
            item.knockBack = 4.5f;
            item.crit = 10;
            item.ranged = true;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 20;
            item.autoReuse = true;
            item.noMelee = true;
            item.useTurn = false;
            item.SetElementDamage(ElementDamageType.EarthDamage);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
            ref float knockBack)
        {
            if (counter++ >= 2)
            {
                counter = 0;
                Projectile.NewProjectile(player.Center, new Vector2(speedX, speedY), ModContent.ProjectileType<ProSharpsandBomb>(), damage,
                    knockBack, player.whoAmI);
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.AncientBattleArmorMaterial, 3);
                Ode.AddIngredient(ItemID.ChlorophyteBar, 18);
                Ode.AddIngredient(ItemID.SoulofFright, 15);
                Ode.AddIngredient(ItemID.SoulofMight, 8);
                Ode.AddIngredient(ItemID.SoulofSight, 8);
                Ode.AddTile(TileID.MythrilAnvil);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}