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
using CozmicVoidAwakened.Projectiles.Arrows;
using Microsoft.Xna.Framework;
using CozmicVoidAwakened.Projectiles.Cryo;
using CozmicVoidAwakened.Items.Sets.Elelamentals.Cloud;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
	public class TheVoid : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Soul Storm");
			CozmicGlowmask.AddGlowMask(item.type, "CozmicVoidAwakened/Items/Sets/Abyssal/TheVoid_Glow");
		}

		public override void SetDefaults() 
		{
			item.damage = 27;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 0, 60, 0);
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = ProjectileType<LuminullArrow2>();
			item.shootSpeed = 36f;
			item.useAmmo = AmmoID.Arrow;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileType<CloudBolt>(), damage, knockBack, player.whoAmI, 0f, 0f);
			int numberProjectiles = 1 + Main.rand.Next(1); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20)); // 30 degree spread.
																												// If you want to randomize the speed to stagger the projectiles
				float scale = 1f - (Main.rand.NextFloat() * .4f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; // return false because we don't want tmodloader to shoot projectile
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<AbyssalTeslaBar>(), 15);
			recipe.AddIngredient(ItemType<AbyssalTeslaDarkBow>(), 1);
			recipe.AddIngredient(ItemType<CloudBow>(), 1);
			recipe.AddIngredient(ItemType<DarkRocks>(), 25);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}