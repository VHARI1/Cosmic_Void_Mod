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
    [AutoloadEquip(EquipType.Body)]
    public class GeoGemPlate : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("GeoGemPlate");
			Tooltip.SetDefault("Increases Max minions by 1");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 22;
            item.value = 80000;
            item.rare = 14;

            item.defense = 3;
        }

        public override void UpdateEquip(Player player)
        {
            player.maxMinions += 1;
            player.maxTurrets += 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<CoreGem>(), 3);
            recipe.AddIngredient(ItemType<GeoRock>(), 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
