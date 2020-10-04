using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Items.Californium
{
    public class HallowRadianter : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallow Radianter");
            DisplayName.AddTranslation(GameCulture.Chinese, "神圣放射者");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Cyan;
            item.melee = true;
            item.scale = 1.4f;
            item.value = Item.sellPrice(0, 9, 42, 65);
            item.width = 56;
            item.damage = 85;
            item.height = 56;
            item.useTime = 12;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.knockBack = 7.2f;
            item.useAnimation = 12;
        }

        public override bool UseItem(Player player)
        {
            foreach (NPC npc in Main.npc)
            {
                if (npc.active && !npc.friendly && Collision.CanHit(player.Center, player.width, player.height, npc.Center, 1, 1))
                    npc.AddBuff(ModContent.BuffType<DebuffRadiation>(), 30);
            }
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe Ode = new ModRecipe(mod);
            if (!OdeMod.Developer)
            {
                Ode.AddIngredient(ItemID.Excalibur);
                Ode.AddIngredient(ModContent.ItemType<CaliforniumBar>(), 8);
            }
            Ode.SetResult(this);
            Ode.AddRecipe();
        }
    }
}