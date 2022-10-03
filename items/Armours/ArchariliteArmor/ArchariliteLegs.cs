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

namespace CozmicVoidAwakened.Items.Sets.Armours.ArchariliteArmor
{
    [AutoloadEquip(EquipType.Legs)]
    public class ArchariliteLegs : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Archarilite Legs");
			Tooltip.SetDefault("Increases melee critical strike chance by 8% and movement speed by 10%");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 22;
            item.value = 10000;
            item.rare = ItemRarityID.Blue;

            item.defense = 3;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeCrit += 8;
            player.moveSpeed += 0.6f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ArncharlitPowerCell>(), 2);
            recipe.AddIngredient(ItemType<ArchariliteBar>(), 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
