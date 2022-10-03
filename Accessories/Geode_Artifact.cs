
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CozmicVoidAwakened.Items.Accessories
{
	public class Geode_Artifact : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Geode Artifact");
			Tooltip.SetDefault("Increases mana and Decreases mana cost.");
		}
		public override void SetDefaults()
		{
			item.value = Item.sellPrice(gold: 2);
			item.width = 26;
			item.height = 34;
			item.rare = ItemRarityID.Blue;
			item.value = 1200;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statManaMax2 += 20;
			player.manaCost -= 0.2f;
		}
	}
}
