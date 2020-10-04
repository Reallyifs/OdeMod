using OdeMod.Projectiles;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class TorchOfHeaven : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heaven's Holy Torch");
            DisplayName.AddTranslation(GameCulture.Chinese, "天堂圣火");
        }

        public override void SetDefaults()
        {
            item.crit = 23;
            item.rare = ItemRarityID.Cyan;
            item.mana = 12;
            item.magic = true;
            item.shoot = ModContent.ProjectileType<ProTorchOfHeavenFire>();
            item.value = Item.sellPrice(0, 1, 20, 0);
            item.width = 36;
            item.damage = 105;
            item.height = 40;
            item.noMelee = true;
            item.useTime = 20;
            item.UseSound = SoundID.Item43;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.knockBack = 0f;
            item.shootSpeed = 12f;
            item.useAnimation = 20;
            item.SetElementDamage(ElementDamageType.HallowedDamage);
        }
        /*public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Cheat)
            {
                Ode.AddIngredient(ModContent.ItemType<BigTorch>(), 1);
                Ode.AddIngredient(ItemID.SoulofLight, 10);
                Ode.AddIngredient(ItemID.SoulofNight, 10);
                Ode.AddTile(TileID.MythrilAnvil);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }*/
        // 为什么被注释了？
    }
}