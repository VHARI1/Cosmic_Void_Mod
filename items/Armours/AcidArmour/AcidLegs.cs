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
using CozmicVoidAwakened.Items.Sets.Acid;
using CozmicVoidAwakened.Items.Sets.Acid.Irradiated;

namespace CozmicVoidAwakened.Items.Sets.Armours.AcidArmour
{
    [AutoloadEquip(EquipType.Legs)]
    public class AcidLegs : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Acid Legs");
			Tooltip.SetDefault("Increases Acceleration by 5% and movement speed by 4%");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 22;
            item.value = 10000;
            item.rare = 6;

            item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.maxRunSpeed += 0.04f;
            player.runAcceleration += 0.12f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<AcidicMetal>(), 4);
            recipe.AddIngredient(ItemType<IrradiatedBar>(), 7);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
