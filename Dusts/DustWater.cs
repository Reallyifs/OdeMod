using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OdeMod.Dusts
{
	public class DustWater : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.velocity *= 0.1f;
			dust.noGravity = false;
			dust.noLight = false;
			dust.scale *= 1f;
			dust.alpha = 0;
		}

		public override bool Update(Dust dust)
		{
			dust.position += dust.velocity;
			dust.rotation += 0.1f;
			dust.scale *= 0.95f;
			Lighting.AddLight(dust.position, 0f, 0.75f * dust.scale, 0.8f * dust.scale);
			if (dust.scale < 0.25f)
				dust.active = false;
			return false;
		}

		public override Color? GetAlpha(Dust dust, Color lightColor)
		{
			return new Color(255, 255, 255, 0);
		}
	}
}