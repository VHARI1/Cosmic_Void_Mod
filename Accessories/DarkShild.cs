using CozmicVoidAwakened.Items.Sets.Abyssal;
using CozmicVoidAwakened.Items.Sets.Skeletron;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CozmicVoidAwakened.Items.Accessories
{
    public class DarkShild : ModItem
    {

        public override void SetDefaults()
        {
            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(gold: 2);
            item.rare = ItemRarityID.Blue;
            item.defense = 6;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 20;
            player.noKnockback = true;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<DungeonBar>(), 10);
            recipe.AddIngredient(ItemType<VoidShield>(), 1);
            recipe.AddIngredient(ItemType<WoodShield>(), 1);
            recipe.AddIngredient(ItemType<AbyssalFragments>(), 5);
            recipe.AddIngredient(ItemID.CobaltShield, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}