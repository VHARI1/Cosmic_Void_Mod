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
using CozmicVoidAwakened.Projectiles.Acid;
using CozmicVoidAwakened.Items.Sets.Acid;
using CozmicVoidAwakened.Items.Sets.Acid.Irradiated;
using CozmicVoidAwakened.Items.Placeables;
using CozmicVoidAwakened.Items.Sets.Glich;
using CozmicVoidAwakened.Items.Sets.Cave;

namespace CozmicVoidAwakened.Items.Sets.Acid.Deberis
{
	public class SearingSythe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Searing Sythe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			item.damage = 49;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<SearingSythePROG>();
			item.shootSpeed = 15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<ToxicDebris>(), 15);
            recipe.AddIngredient(ItemType<IrradiatedBar>(), 10);
			recipe.AddIngredient(ItemType<PrimalTech>(), 8);
			recipe.AddIngredient(ItemType<AcidicMetal>(), 15);
			recipe.AddIngredient(ItemType<UnknownCircuitry>(), 15);
			recipe.AddIngredient(ItemType<AcidalSlicer>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}