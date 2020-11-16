using Microsoft.Xna.Framework;
using OdeMod.Projectiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OdeMod.Items
{
    public class ScreamingThunder : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("尖啸之雷");
            Tooltip.SetDefault("当你把幽灵法杖塞到海......" +
                "雨云法杖里会发生什么");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.NimbusRod);
            item.shoot = ModContent.ProjectileType<ProCloud>();
            item.damage = 78;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
            ref float knockBack)
        {
            Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, player.whoAmI, Main.MouseWorld.X,
                Main.MouseWorld.Y);
            return false;
        }
    }
}