
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CozmicVoidAwakened.Items.Accessories
{
	public class LeatherGlove : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leather Glove");
			Tooltip.SetDefault("Increases throwing damage and throwing velocity.");
		}
		public override void SetDefaults()
		{
			item.value = Item.sellPrice(gold: 1);
			item.width = 26;
			item.height = 34;
			item.rare = ItemRarityID.Blue;
			item.value = 1200;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.thrownDamage += 0.1f;
			player.thrownVelocity += 2;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Leather, 2);
			recipe.AddRecipeGroup(RecipeGroupID.IronBar, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
