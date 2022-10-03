
using CozmicVoidAwakened.Items.Sets.Crim;
using CozmicVoidAwakened.Items.Sets.Corrupt;
using CozmicVoidAwakened.Items.Sets.Luminull;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CozmicVoidAwakened.Items.Accessories
{
	public class BloodEye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blooded Eye");
			Tooltip.SetDefault("Increases Arrow damage by 5%, Increases ranged Crit by 10%");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 34;
			item.rare = ItemRarityID.Blue;
			item.value = 12000;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.rangedCrit += 2;
			player.arrowDamage += 0.3f;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<DarkEssence>(), 5);
            recipe.AddIngredient(ItemType<GreyMatterEnengy>(), 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemType<DarkEssence>(), 5);
			recipe2.AddIngredient(ItemType<VileEnengy>(), 5);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}
