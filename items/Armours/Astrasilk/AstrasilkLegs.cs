using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using CozmicVoidAwakened.Items.Sets.Luminull;
using CozmicVoidAwakened.Items.Sets.Cozmic;

namespace CozmicVoidAwakened.Items.Sets.Armours.Astrasilk
{
    [AutoloadEquip(EquipType.Legs)]
    public class AstrasilkLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astrasilk Legs");
            Tooltip.SetDefault("Increases movement Speed 8%");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(silver: 22);
            item.rare = ItemRarityID.Blue;
            item.defense = 4;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.8f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<StarSilk>(), 4);
            recipe.AddIngredient(ItemType<DarkEssence>(), 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
