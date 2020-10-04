using Microsoft.Xna.Framework;
using OdeMod.Projectiles;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class EnchantedStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Staff");
            DisplayName.AddTranslation(GameCulture.Chinese, "附魔杖");
            Tooltip.SetDefault("Release two lines of parallel magic bullets");
            Tooltip.AddTranslation(GameCulture.Chinese, "放出两行平行的魔弹");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults() //以后SetDefault的属性顺序必须按照这个写！//好好好，知道了
        {
            item.width = 36;
            item.height = 46;
            item.value = Item.sellPrice(0, 0, 33, 0);
            item.rare = ItemRarityID.Green;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.damage = 10;
            item.crit = 6;
            item.knockBack = 1f;
            item.magic = true;
            item.mana = 5;
            item.shoot = ModContent.ProjectileType<ProEnchantedStaffBullet>();
            item.shootSpeed = 10f;
            item.noMelee = true;
            item.autoReuse = true;
            item.SetElementDamage(ElementDamageType.AranceDamage);
        }

        public override void AddRecipes()
        {

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
            ref float knockBack)
        {
            Vector2 v = Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < 2; i++)
            {
                Vector2 position2 = position + new Vector2(v.Y, -v.X) * (i * 30 - 15);
                Projectile.NewProjectile(position2, v, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}