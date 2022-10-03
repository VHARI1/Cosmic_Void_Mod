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
using CozmicVoidAwakened.Items.Sets.EnchantedWinterI;
using CozmicVoidAwakened.Items.Sets.Arnchar;
using CozmicVoidAwakened.Items.Placeables;
using CozmicVoidAwakened.Items.Sets.Cave;

namespace CozmicVoidAwakened.Items.Sets.Armours.GeoGem
{
    [AutoloadEquip(EquipType.Legs)]
    public class GeoGemGreaves : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("GeoGem Greaves");
			Tooltip.SetDefault("Increases Minion damage by 5% and movement speed by 8%");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 22;
            item.value = 10000;
            item.rare = 4;

            item.defense =  2;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.5f;
            player.moveSpeed += 0.8f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<CoreGem>(), 2);
            recipe.AddIngredient(ItemType<GeoRock>(), 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
