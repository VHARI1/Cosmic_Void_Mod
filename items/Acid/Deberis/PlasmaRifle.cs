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
using CozmicVoidAwakened.Items.Placeables;
using CozmicVoidAwakened.Projectiles.Lumi;
using CozmicVoidAwakened.Items.Sets.Glich;
using CozmicVoidAwakened.Items.Sets.Cave;
using Microsoft.Xna.Framework;

namespace CozmicVoidAwakened.Items.Sets.Acid.Deberis
{
	public class PlasmaRifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plasma Rifle"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			item.damage = 64;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
            item.rare = 2;
			item.shoot = ProjectileType<PlasmaLazer>();
			item.shootSpeed = 45f;
			item.UseSound = SoundID.Item91;
            item.autoReuse = true;
			item.mana = 10;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-4, 0);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ToxicDebris>(), 16);
            recipe.AddIngredient(ItemID.LaserRifle, 1);
			recipe.AddIngredient(ItemID.SpaceGun, 1);
			recipe.AddIngredient(ItemType<UnknownCircuitry>(), 13);
			recipe.AddIngredient(ItemType<PrimalTech>(), 5);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.AddIngredient(ItemType<AcidicMetal>(), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}