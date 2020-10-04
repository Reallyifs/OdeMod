using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Brightiron.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class BrightironHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brightiron Helmet");
            DisplayName.AddTranslation(GameCulture.Chinese, "熙铁头盔");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(0, 0, 10, 20);
            item.width = 22;
            item.height = 22;
            item.defense = 9;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<BrightironBreastplate>() && legs.type == ModContent.ItemType<BrightironLeggings>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = OLanguage.Get("熙铁套装描述", true);
            player.magicCrit += 10;
            player.meleeCrit += 10;
            player.rangedCrit += 10;
            player.thrownCrit += 10;
            player.OPlayer().BrightironArmorSet = true;
        }
        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ModContent.ItemType<BrightironBar>(), 9);
                Ode.AddIngredient(ModContent.ItemType<SpiritPieces>(), 13);
                Ode.AddTile(TileID.Anvils);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}