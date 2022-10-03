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
using Microsoft.Xna.Framework;
using CozmicVoidAwakened.Items.Sets.Galactic;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
	public class DarkVoidOfTheAbyss : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dark Void Of The Abyss");

;
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Starfury);
			item.shootSpeed *= 1.75f;
			item.damage = 45;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.autoReuse = true;
            item.mana = 15;
			item.rare = ItemRarityID.Lime;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ProjectileType<AbyssFlameGood2>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<AbyssalTeslaBar>(), 20);
			recipe.AddIngredient(ItemType<DarkRocks>(), 30);
			recipe.AddIngredient(ItemType<AbyssalFragments>(), 35);
			recipe.AddIngredient(ItemType<AbyssalCharge>(), 1);
			recipe.AddIngredient(ItemType<BindingFlameBook>(), 1);
			recipe.AddIngredient(ItemType<GalacticFragments>(), 25);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}