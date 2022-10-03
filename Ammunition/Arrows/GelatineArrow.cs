using Microsoft.Xna.Framework;
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
using CozmicVoidAwakened.Items.Sets.Ocean;
using CozmicVoidAwakened.Items.Sets.Shadow;
using CozmicVoidAwakened.Projectiles.Arrows;

namespace CozmicVoidAwakened.Ammunition.Arrows
{
    public class GelatineArrow : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(8);
            item.value = Item.buyPrice(copper: 20);
            item.rare = ItemRarityID.Blue;
            item.consumable = true;
            item.maxStack = 999;
            item.ranged = true;
            item.damage = 8;
            item.knockBack = 3.25f;
            item.shoot = ProjectileType<GelatineArrow2>();
            item.shootSpeed = 40f;
            item.ammo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<DreadFoil>(), 1);
            recipe.AddIngredient(ItemType<GelatinOzze>(), 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this,20);
            recipe.AddRecipe();
        }
    }
}