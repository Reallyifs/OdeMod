using OdeMod.Projectiles;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class PhantomTorch : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phantom Torch");
            DisplayName.AddTranslation(GameCulture.Chinese, "幻影火炬");
        }

        public override void SetDefaults()
        {
            item.crit = 5;
            item.rare = ItemRarityID.Blue;
            item.mana = 8;
            item.magic = true;
            item.shoot = ModContent.ProjectileType<ProPhantomTorchFire>();
            item.value = Item.sellPrice(0, 1, 20, 0);
            item.width = 36;
            item.damage = 56;
            item.height = 40;
            item.noMelee = true;
            item.useTime = 25;
            item.UseSound = SoundID.Item43;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.knockBack = 0f;
            item.shootSpeed = 11f;
            item.useAnimation = 25;
            item.SetElementDamage(ElementDamageType.ShadowFireDamage);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<BigTorch>(), 1);
                Ode.AddIngredient(ItemID.SoulofLight, 10);
                Ode.AddIngredient(ItemID.SoulofNight, 10);
                Ode.AddTile(TileID.MythrilAnvil);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}