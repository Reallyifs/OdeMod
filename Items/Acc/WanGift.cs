using Terraria;
using Terraria.ModLoader;

namespace OdeMod.Items.Acc
{
	public class WanGift : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("WanWan大礼包");
			Tooltip.SetDefault("可以把你变成Wan!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.accessory = true;
			item.rare = -12;
			item.expert = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.OPlayer().Wan = !hideVisual;
		}
	}
}