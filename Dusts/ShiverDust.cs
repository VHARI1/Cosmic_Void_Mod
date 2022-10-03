using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CozmicVoidAwakened.Dusts
{
	public class ShiverDust : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.noLight = false;
			dust.scale = 0.9f;
			dust.noGravity = true;
			dust.velocity /= 2f;
		}

		public override bool Update(Dust dust)
		{
			dust.position += dust.velocity;
			dust.rotation += dust.velocity.X;

			Lighting.AddLight((int)(dust.position.X / 16f), (int)(dust.position.Y / 16f), .225f, .90f, 1.9125f);

			dust.scale -= 0.03f;
			if (dust.scale < 0.5f) {
				dust.active = false;
			}

			return false;
		}
	}
}