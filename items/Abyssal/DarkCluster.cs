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
using CozmicVoidAwakened.Projectiles;
using CozmicVoidAwakened.Projectiles.Plant;
using CozmicVoidAwakened.Projectiles.Abyssal;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
	public class DarkCluster : ModItem
	{
        private Vector2 newVect;

        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dark Cluster"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.

		}

        public override void SetDefaults()
        {
            item.noUseGraphic = true;
            item.damage = 5;
            item.thrown = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 35;
            item.useAnimation = 35;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = ProjectileType<DarkClusterP>();
            item.shootSpeed = 18f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 15);
            recipe.AddIngredient(ItemType<DarkRocks>(), 10);
            recipe.AddIngredient(ItemType<AbyssalCell>(), 2);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}