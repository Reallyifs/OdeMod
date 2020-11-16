using OdeMod.Projectiles.Lightmushroom;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Lightmushroom
{
    public class LightmushroomStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightmushroom Staff");
            DisplayName.AddTranslation(GameCulture.Chinese, "光明菇杖");
        }

        public override void SetDefaults()
        {
            item.crit = 12;
            item.mana = 4;
            item.rare = ItemRarityID.Orange;
            item.magic = true;
            item.shoot = ModContent.ProjectileType<ProLightmushroomSpores>();
            item.value = Item.sellPrice(0, 4, 90, 30);
            item.width = 34;
            item.damage = 52;
            item.height = 40;
            item.useTime = 20;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = true;
            item.knockBack = 2.6f;
            item.shootSpeed = 0;
            item.useAnimation = 20;
            item.SetElementDamage(ElementDamageType.HallowedDamage);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemLightmushroom>(), 10);
                Ode.AddIngredient(ItemID.HellstoneBar, 6);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}