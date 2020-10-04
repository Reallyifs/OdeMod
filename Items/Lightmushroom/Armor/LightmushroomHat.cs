using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Lightmushroom.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class LightmushroomHat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightmushroom Hat");
            DisplayName.AddTranslation(GameCulture.Chinese, "光明蘑菇帽");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.LightRed;
            item.value = Item.sellPrice(0, 1, 20, 0);
            item.width = 30;
            item.height = 20;
            item.defense = 10;
            item.maxStack = 1;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<LightmushroomSoftarmor>() && legs.type == ModContent.ItemType<LightmushroomBoots>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = OLanguage.Get("光明蘑菇套装描述", true);
            player.OPlayer().LightmushroomArmorSet = true;
            Lighting.AddLight(player.Center, 0.5f, 0.5f, 0.5f);
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemLightmushroom>(), 12);
                Ode.AddIngredient(ItemID.HellstoneBar, 6);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}