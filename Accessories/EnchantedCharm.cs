using CozmicVoidAwakened.Items.Sets.EnchantedWinterI;
using CozmicVoidAwakened.Items.Accessories;
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
    public class EnchantedCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Charm");
            Tooltip.SetDefault("Lights up in dark Biomes");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(gold: 1);
            item.rare = ItemRarityID.Blue;
            item.defense = 3;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<EnchantedTreeSample>(), 7);
            recipe.AddIngredient(ItemType<EnchantedWood>(), 20);
            recipe.AddIngredient(ItemType<WoodShield>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (!Main.dayTime)
            {			
                Lighting.AddLight(player.position, 1.0f, 1.0f, 2.75f);
            }
        }
    }
}
