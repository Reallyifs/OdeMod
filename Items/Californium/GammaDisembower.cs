using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Californium
{
    public class GammaDisembower : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gamma Disembower");
            DisplayName.AddTranslation(GameCulture.Chinese, "伽马开膛者");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Red;
            item.shoot = ProjectileID.BulletHighVelocity;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.width = 92;
            item.damage = 412;
            item.height = 28;
            item.ranged = true;
            item.useAmmo = AmmoID.Bullet;
            item.useTime = 32;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = true;
            item.knockBack = 9;
            item.shootSpeed = 50;
            item.useAnimation = 32;
        }

        public override Vector2? HoldoutOffset() => new Vector2(-10, -10);

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
            ref float knockBack)
        {
            type = ProjectileID.BulletHighVelocity;
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.SniperRifle);
                Ode.AddIngredient(ModContent.ItemType<CaliforniumBar>(), 14);
                Ode.AddTile(TileID.LunarCraftingStation);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}