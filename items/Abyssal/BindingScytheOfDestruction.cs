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
using CozmicVoidAwakened.Items.Sets.Galactic;
using CozmicVoidAwakened.Items.Sets.Galactic;
using Microsoft.Xna.Framework;
using CozmicVoidAwakened.Projectiles.Lumi;
using CozmicVoidAwakened.Projectiles.Acid;
using CozmicVoidAwakened.Items.Sets.Luminull.LumiW;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
	public class BindingScytheOfDestruction : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Binding Scythe Of Destruction");

;
		}

		public override void SetDefaults() 
		{
			item.damage = 80;
			item.thrown = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(1, 30, 20, 14);
			item.rare = ItemRarityID.Lime;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<BindingScytheOfDestructionProc>();
			item.shootSpeed = 35f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
			type = Main.rand.Next(new int[] { type, ProjectileType<BindingScytheOfDestructionProc>(), ProjectileType<AcidalSlicerProc>(), ProjectileType<LuminullSlasherProj>(), ProjectileType<AbyssalScytheProjectile>()});
			float numberProjectiles = 3 + Main.rand.Next(3); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(45);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<AbyssalScythe>(), 1);
			recipe.AddIngredient(ItemType<AcidalSlicer>(), 1);
			recipe.AddIngredient(ItemType<LuminullSlasher>(), 1);
			recipe.AddIngredient(ItemType<AbyssalFragments>(), 30);
			recipe.AddIngredient(ItemType<AbyssalTeslaBar>(), 10);
			recipe.AddIngredient(ItemType<DarkRocks>(), 50);
			recipe.AddIngredient(ItemType<GalacticFragments>(), 15);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}