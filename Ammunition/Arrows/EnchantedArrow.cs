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
using CozmicVoidAwakened.Items.Sets.Luminull;
using CozmicVoidAwakened.Projectiles.Arrows;
using CozmicVoidAwakened.Items.Sets.EnchantedWinterI;

namespace CozmicVoidAwakened.Ammunition.Arrows
{
    public class EnchantedArrow : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(8);
            item.value = Item.buyPrice(copper: 20);
            item.rare = ItemRarityID.Blue;
            item.consumable = true;
            item.maxStack = 999;
            item.ranged = true;
            item.damage = 4;
            item.knockBack = 3.25f;
            item.shoot = ProjectileType<EnchantedArrowProg>();
            item.shootSpeed = 40f;
            item.ammo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<EnchantedWood>(), 1);
            recipe.AddIngredient(ItemType<EnchantedTreeSample>(), 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this,25);
            recipe.AddRecipe();
        }
    }
}