using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria;
using CozmicVoidAwakened.Projectiles.Abyssal;
using CozmicVoidAwakened.Items.Sets.Acid;
using CozmicVoidAwakened.Items.Sets.Luminull.LumiW;
using CozmicVoidAwakened.Items.Sets.Galactic;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
	public class TheCeaseless : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The Ceaseless");

;
		}

		public override void SetDefaults() 
		{
			item.damage = 80;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(1, 30, 20, 14);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<BindingScytheOfDestructionProc>();
			item.shootSpeed = 35f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<AbyssalRockDarkSword>(), 1);
			recipe.AddIngredient(ItemType<AcidicSaber>(), 1);
			recipe.AddIngredient(ItemType<TheSpiritSlicer>(), 1);
			recipe.AddIngredient(ItemType<AbyssalFragments>(), 30);
			recipe.AddIngredient(ItemType<AbyssalTeslaBar>(), 10);
			recipe.AddIngredient(ItemType<DarkRocks>(), 50);
			recipe.AddIngredient(ItemType<GalacticFragments>(), 35);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}