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

namespace CozmicVoidAwakened.Items.Sets.Acid.Irradiated
{
	public class IrradiSmasher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("IrradiSmasher"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			item.damage = 32;
			item.thrown = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 11;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.shoot = ProjectileType<IrradiSmasherP>();
			item.shootSpeed = 35f;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ToxicEmber>(), 10);
			recipe.AddIngredient(ItemType<UnknownCircuitry>(), 5);
			recipe.AddIngredient(ItemType<IrradiatedBar>(), 8);
            recipe.AddIngredient(ItemType<TheIrradiaspear>(), 1);
			recipe.AddIngredient(ItemType<PlaugeDagger>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}