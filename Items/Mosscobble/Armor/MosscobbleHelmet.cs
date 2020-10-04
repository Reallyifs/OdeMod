using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Mosscobble.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MosscobbleHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mosscobble Helmet");
            DisplayName.AddTranslation(GameCulture.Chinese, "苔石头盔");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(0, 0, 1, 0);
            item.width = 24;
            item.height = 20;
            item.defense = 1;
            item.maxStack = 1;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<MosscobbleBreastplate>() && legs.type == ModContent.ItemType<MosscobbleLeggings>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = OLanguage.Get("苔石套装描述", true);
            player.OPlayer().MosscobbleArmorSet = true;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<ItemMosscobble>(), 5);
                Ode.AddIngredient(ItemID.Gel, 8);
                Ode.AddIngredient(ItemID.Vine, 5);
                Ode.AddTile(TileID.WorkBenches);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}