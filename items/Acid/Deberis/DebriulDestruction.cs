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
using CozmicVoidAwakened.Items.Sets.Glich;
using CozmicVoidAwakened.Items.Sets.Cave;
using CozmicVoidAwakened.Items.Placeables;
using CozmicVoidAwakened.Items.Sets.Acid.Irradiated;

namespace CozmicVoidAwakened.Items.Sets.Acid.Deberis
{
	public class DebriulDestruction : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Debriul Destruction"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.

		}

		public override void SetDefaults()
		{
			item.damage = 45;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<DebriulDestructionP>();
			item.shootSpeed = 40f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<ToxicDebris>(), 16);
            recipe.AddIngredient(ItemType<UnknownCircuitry>(), 13);
			recipe.AddIngredient(ItemType<IrradiSmasher>(), 1);
			recipe.AddIngredient(ItemType<PrimalTech>(), 5);
			recipe.AddIngredient(ItemType<AcidicMetal>(), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}