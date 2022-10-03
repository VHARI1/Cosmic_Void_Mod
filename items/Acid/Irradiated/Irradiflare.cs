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
using Microsoft.Xna.Framework;
using CozmicVoidAwakened.Projectiles.Lumi;
using CozmicVoidAwakened.Projectiles.Acid;
using CozmicVoidAwakened.Projectiles.Abyssal;
using CozmicVoidAwakened.Items.Sets.Glich;

namespace CozmicVoidAwakened.Items.Sets.Acid.Irradiated
{
	public class Irradiflare : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Irradiflare"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			item.damage = 31;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item100;
			item.shoot = ProjectileType<TociBolt4>();
            item.shootSpeed = 15f;
			item.autoReuse = true;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 1 + Main.rand.Next(1); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(0)); // 30 degree spread.
																											   // If you want to randomize the speed to stagger the projectiles
				float scale = 1f - (Main.rand.NextFloat() * .4f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			if (Main.rand.Next(2) == 1)
			{
				Main.PlaySound(new Terraria.Audio.LegacySoundStyle(2, 8));
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<AcidFlamethrowerProjec>(), damage, knockBack, player.whoAmI, 0f, 0f);
			}
			return false; // return false because we don't want tmodloader to shoot projectile
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<IrradiatedBar>(), 8);
            recipe.AddIngredient(ItemType<ToxicEmber>(), 15);
			recipe.AddIngredient(ItemType<UnknownCircuitry>(), 5);
			recipe.AddIngredient(ItemType<IrradiatedFlamethrower>(), 1);
			recipe.AddIngredient(ItemType<Tociflare>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}