using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Sharpsand
{
    public class SharpsandStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sharpsand Staff");
            DisplayName.AddTranslation(GameCulture.Chinese, "纯砂法杖");
            Item.staff[item.type] = true;
        }

        //物品属性的书写顺序：宽高 堆叠数 价值 稀有度 使用方式 使用时间 使用音效 伤害 击退 额外暴击 职业 特征属性 抛射物 抛射物速度 杂项属性（是否连击、是否消耗等）
        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 42;
            item.value = Item.sellPrice(0, 6, 50, 0);
            item.rare = ItemRarityID.Pink;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 32;
            item.useAnimation = 32;
            item.damage = 86;
            item.knockBack = 2f;
            item.crit = 9;
            item.magic = true;
            item.mana = 18;
            item.shoot = ModContent.ProjectileType<ProSharpsandFire>();
            item.shootSpeed = 42;
            item.autoReuse = true;
            item.noMelee = true;
            item.useTurn = false;
            item.SetElementDamage(ElementDamageType.EarthDamage);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
            ref float knockBack)
        {
            for (int i = 0; i <= Main.rand.Next(3, 5); i++)
            {
                Vector2 pVEC = new Vector2(Main.MouseWorld.X, Main.screenPosition.Y - Main.rand.Next(50, 100)) +
                    new Vector2(Main.rand.NextFloat(-60, 60), Main.rand.Next(-60, 60));
                Vector2 tVEC = Vector2.Normalize(new Vector2(Main.MouseWorld.X + Main.rand.Next(-40, 40), Main.MouseWorld.Y +
                    Main.rand.NextFloat(-80f, -50f)) - pVEC) * item.shootSpeed;
                Projectile.NewProjectile(pVEC, tVEC, ModContent.ProjectileType<ProSharpsandFire>(), damage, knockBack, player.whoAmI);
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.AncientBattleArmorMaterial, 3);
                Ode.AddIngredient(ItemID.ChlorophyteBar, 20);
                Ode.AddIngredient(ItemID.SoulofFright, 8);
                Ode.AddIngredient(ItemID.SoulofMight, 8);
                Ode.AddIngredient(ItemID.SoulofSight, 15);
                Ode.AddTile(TileID.MythrilAnvil);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}