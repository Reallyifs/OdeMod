using Terraria;
using Terraria.ModLoader;

namespace OdeMod.Dusts
{
	public class DustLeave : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.noGravity = false;
			dust.noLight = true;
			dust.scale *= 1f;
			dust.alpha = 0;
		}

		public override bool Update(Dust dust)
		{
			dust.rotation += 0.1f;
			dust.scale *= 0.95f;
			if (dust.scale < 0.25f)
				dust.active = false;
			return false;
		}
	}
}