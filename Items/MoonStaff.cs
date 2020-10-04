/*天空怪物皆有5%几率掉落
伤害10
速度快
射出旋转的月轮
肉后会自动升级*/

using OdeMod.Projectiles;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class MoonStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Staff");
            DisplayName.AddTranslation(GameCulture.Chinese, "清月法杖");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.height = 20;
            item.width = 40;
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.rare = ItemRarityID.Green;
            item.magic = true;
            item.shoot = ModContent.ProjectileType<ProMoonStaff>();
            item.shootSpeed = 10f;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = true;
            item.noMelee = true;
            item.UseSound = SoundID.Item43;
            item.SetElementDamage(ElementDamageType.ClimateDamage);
        }

        public override bool CanUseItem(Player player)
        {
            if (Main.hardMode)
            {
                item.damage = 10;
                item.knockBack = 3f;
                item.mana = 3;
                item.useTime = 20;
                item.useAnimation = 20;
            }
            else
            {
                item.damage = 45;
                item.knockBack = 3.5f;
                item.mana = 7;
                item.useTime = 15;
                item.useAnimation = 15;
            }
            return true;
        }
    }
}