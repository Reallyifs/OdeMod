using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class StarLocker : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Locker");
            DisplayName.AddTranslation(GameCulture.Chinese, "星锁");
        }

        public override void SetDefaults()
        {
            item.crit = 1;
            item.mana = 8;
            item.rare = ItemRarityID.Blue;
            item.magic = true;
            item.shoot = ProjectileID.Starfury;
            item.value = Item.sellPrice(0, 1, 10, 0);
            item.width = 36;
            item.damage = 35;
            item.height = 42;
            item.noMelee = true;
            item.useTime = 11;
            item.UseSound = SoundID.Item43;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = true;
            item.knockBack = 5f;
            item.shootSpeed = 11f;
            item.useAnimation = 20;
            item.SetElementDamage(ElementDamageType.AranceDamage);
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(1.0f, -0.8f);
        }

        public void UseItemEffect(Player player)
        {
            Projectile.NewProjectile(Main.mouseX + Main.screenPosition.X + +Main.rand.Next(20) - 10, Main.mouseY + Main.screenPosition.Y - 500,
                Main.rand.Next(5), 10, 9, 18, 0, Main.myPlayer);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.ManaCrystal, 3);
                //Ode.AddRecipeGroup("OdeMod:CrimtaneBar", 10);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();

        }
    }
}