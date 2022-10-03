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
    [AutoloadEquip(EquipType.Head)]
    public class AcidMask : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Acid Mask");
			Tooltip.SetDefault("Increases ranged ranged by 5% and ranged critical strike chance by 8%");
		}

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 30;
            item.value = 10000;
            item.rare = 6;

            item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.05F;
            player.rangedCrit += 8;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("AcidBody") && legs.type == mod.ItemType("AcidLegs");
        }
        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawShadow = true;
        }
        public override void UpdateArmorSet(Player player)
        {
            player.moveSpeed += 8f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<AcidicMetal>(), 5);
            recipe.AddIngredient(ItemType<IrradiatedBar>(), 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
