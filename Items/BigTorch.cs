using OdeMod.Projectiles;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class BigTorch : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Big Torch");
            DisplayName.AddTranslation(GameCulture.Chinese, "大火炬");
        }

        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 40;
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(0, 0, 70, 0);
            item.damage = 15;
            item.knockBack = 0f;
            item.mana = 2;
            item.magic = true;
            item.useTime = 30;
            item.useAnimation = 30;
            item.UseSound = SoundID.Item43;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shoot = ModContent.ProjectileType<ProBigTorchFire>();
            item.shootSpeed = 10f;
            item.autoReuse = false;
            item.noMelee = true;
            item.SetElementDamage(ElementDamageType.FireDamage);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.Torch, 40);
                Ode.AddTile(TileID.HeavyWorkBench);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}