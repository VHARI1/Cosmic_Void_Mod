using CozmicVoidAwakened.Items.Sets.EnchantedWinterI;
using CozmicVoidAwakened.Items.Placeables;
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
	public class SummoningCell : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Summoning Cell");
			Tooltip.SetDefault("Increases minion damage and max minions by 1");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 34;
			item.rare = ItemRarityID.Blue;
			item.value = 1200;
			item.accessory = true;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.minionDamage += 0.2f;
			player.maxMinions += 1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<EnchantedTreeSample>(), 7);
			recipe.AddIngredient(ItemType<EnchantedWood>(), 20);
			recipe.AddIngredient(ItemType<BaysaltChunk>(), 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
