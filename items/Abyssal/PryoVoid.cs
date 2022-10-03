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
using CozmicVoidAwakened.Projectiles.Abyssal;
using CozmicVoidAwakened.Items.Sets.Acid.Deberis;
using CozmicVoidAwakened.Items.Sets.Cave;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
	public class PryoVoid : ModItem
    {
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("PryoVoid");
		}

        public override void SetDefaults()
        {
            item.damage = 60;
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 6;
            item.useAnimation = 6;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = ItemRarityID.Lime;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = ProjectileType<FallingAbyssGood>();
            item.shootSpeed = 25f;
            item.useAmmo = AmmoID.Bullet;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<AbyssalTeslaBar>(), 25);
            recipe.AddIngredient(ItemType<PyroPhantom>(), 1);
            recipe.AddIngredient(ItemType<Irradishark>(), 1);
            recipe.AddIngredient(ItemType<DarkRocks>(), 60);
            recipe.AddIngredient(ItemType<GeoTech>(), 10);
            recipe.AddIngredient(ItemType<EldritchSoul>(), 25);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}