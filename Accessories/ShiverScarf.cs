
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CozmicVoidAwakened.Items.Accessories
{
	public class ShiverScarf : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Shiver Scarf");
			Tooltip.SetDefault("When you strike an enemy you have a chance to Frostburn the target");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(gold: 1);
			item.width = 24;
			item.height = 28;
			item.expert = true;
			item.value = 50000;
			item.melee = true;
			item.accessory = true;
			item.defense = 3;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetVoidPlayer().ShiverScarf = true;
		}
	}
}