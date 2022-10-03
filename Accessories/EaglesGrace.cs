using CozmicVoidAwakened.Items.Sets.Luminull;
using CozmicVoidAwakened.Items.Sets.Luminull.LumiW;
using CozmicVoidAwakened.Items.Sets.Pharaoh;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CozmicVoidAwakened.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class EaglesGrace : ModItem
	{

		public override void SetDefaults()
		{
			item.Size = new Vector2(25);
			item.accessory = true;
			item.value = Item.sellPrice(gold: 4);
			item.rare = ItemRarityID.Blue;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 25;
			if (Main.rand.Next(4) == 0)
			{

				Dust.NewDust(player.position, player.width, player.height, 74);
			}
		}
		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.35f;
			ascentWhenRising = 0.045f;
			maxCanAscendMultiplier = 1.1f;
			maxAscentMultiplier = 2.3f;
			constantAscend = 0.055f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 5.5f;
			acceleration *= 1f;
		}
	}
}