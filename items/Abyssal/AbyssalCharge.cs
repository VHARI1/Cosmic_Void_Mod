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

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
	public class AbyssalCharge : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Abyssal Charge");
			Tooltip.SetDefault("Fires charged dark energy that explodes on impact");
		}

		public override void SetDefaults()
		{
			item.damage = 32;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 0, 80, 0);
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.NPCHit53;
			item.autoReuse = true;
			item.shoot = ProjectileType<AbyssalChargeProjectile>();
			item.shootSpeed = 10f;
			item.mana = 20;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<AbyssalTeslaBar>(), 20);
            recipe.AddIngredient(ItemType<DarkRocks>(), 30);
			recipe.AddIngredient(ItemType<AbyssalCell>(), 5);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}