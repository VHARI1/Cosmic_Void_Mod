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
    [AutoloadEquip(EquipType.Body)]
    public class ArchariliteArmor : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Archarilite Armor");
			Tooltip.SetDefault("Increases melee damage by 13% and melee speed by 10%");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 22;
            item.value = 80000;
            item.rare = ItemRarityID.Blue;

            item.defense = 7;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.003f;
            player.meleeSpeed += 0.1F;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ArncharlitPowerCell>(), 3);
            recipe.AddIngredient(ItemType<ArchariliteBar>(), 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
