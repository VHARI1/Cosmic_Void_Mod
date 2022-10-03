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
using CozmicVoidAwakened.Items.Sets.Glich;
using CozmicVoidAwakened.Items.Sets.Cave;
using CozmicVoidAwakened.Items.Sets.Ocean;
using Microsoft.Xna.Framework;
using CozmicVoidAwakened.Projectiles.Aqua;

namespace CozmicVoidAwakened.Items.Sets.Acid.Deberis
{
	public class Irradishark : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Irradishark"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

        public override void SetDefaults()
        {
            item.damage = 28;
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 35f;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.useAmmo = AmmoID.Bullet;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-4, 0);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 1 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // 30 degree spread.
																												// If you want to randomize the speed to stagger the projectiles
				float scale = 1f - (Main.rand.NextFloat() * .4f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			if (Main.rand.Next(6) == 1)
			{
				Main.LocalPlayer.GetModPlayer<VoidAwakenedPlayer>().ShakeAtPosition(base.item.Center, 512f, 32f);
				speedY = speedY / 2;
				damage = item.damage * 3;
				speedX = speedX / 2;
				Main.PlaySound(SoundID.Item, (int)player.position.X, (int)player.position.Y, 84);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileType<SharkAcid>(), damage, knockBack, player.whoAmI, -8f, -8f);
			}
			return false; // return false because we don't want tmodloader to shoot projectile
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ToxicDebris>(), 8);
            recipe.AddIngredient(ItemID.Megashark, 1);
            recipe.AddIngredient(ItemID.ClockworkAssaultRifle, 1);
			recipe.AddIngredient(ItemType<TychineGun>(), 1);
			recipe.AddIngredient(ItemType<PrimalTech>(), 10);
			recipe.AddIngredient(ItemType<UnknownCircuitry>(), 15);
			recipe.AddIngredient(ItemType<AcidicMetal>(), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}