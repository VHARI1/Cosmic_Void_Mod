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
using CozmicVoidAwakened.Items.Sets.Acid.Irradiated;
using CozmicVoidAwakened.Items.Sets.Acid;


namespace CozmicVoidAwakened.Items.Sets.Armours.AcidArmour
{
    [AutoloadEquip(EquipType.Body)]
    public class AcidBody : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("AcidBody");
			Tooltip.SetDefault("Increases ranged damage by 13% and ranged speed by 10%");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 22;
            item.value = 80000;
            item.rare = 8;

            item.defense = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.lifeRegen += 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<AcidicMetal>(), 3);
            recipe.AddIngredient(ItemType<IrradiatedBar>(), 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
