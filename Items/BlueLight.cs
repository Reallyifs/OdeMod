using Microsoft.Xna.Framework;
using OdeMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class BlueLight : ModItem
    {
        int timer = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Light");
            DisplayName.AddTranslation(GameCulture.Chinese, "碧蓝之光");
            Tooltip.SetDefault("");
            Tooltip.AddTranslation(GameCulture.Chinese, "‘释放自然’");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 44;
            item.value = Item.sellPrice(0, 1, 25, 0);
            item.rare = ItemRarityID.LightPurple;
            item.useTime = 36;
            item.useAnimation = 6;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.damage = 103;
            item.crit = 25;
            item.knockBack = 0.5f;
            item.melee = true;
            item.shoot = ModContent.ProjectileType<ProBlueLight>();
            item.shootSpeed = 10f;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.Seed, 10);
                Ode.AddIngredient(ItemID.MushroomGrassSeeds, 10);
                Ode.AddIngredient(ItemID.JungleGrassSeeds, 10);
                Ode.AddIngredient(ItemID.SoulofSight, 10);
                Ode.AddTile(TileID.CrystalBall);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            timer++;
            if (timer % 30 == 0)
            {
                Projectile.NewProjectile(hitbox.TopLeft() + new Vector2(Main.rand.Next(15, 30), Main.rand.Next(15, 30)), Vector2.Zero,
                    ProjectileID.SporeTrap, 32, 1.5f, player.whoAmI);
            }
        }
    }
}