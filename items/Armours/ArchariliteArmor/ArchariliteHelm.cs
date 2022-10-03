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
    [AutoloadEquip(EquipType.Head)]
    public class ArchariliteHelm : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Archarilite Helm");
			Tooltip.SetDefault("Increases melee damage by 10% and melee critical strike chance by 8%");
		}

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 30;
            item.value = 10000;
            item.rare = ItemRarityID.Blue;

            item.defense = 4;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.15F;
            player.meleeCrit += 8;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ArchariliteArmor") && legs.type == mod.ItemType("ArchariliteLegs");
        }
        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawShadow = true;
        }
        public override void UpdateArmorSet(Player player)
        {
            player.statLifeMax2 += 20;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ArncharlitPowerCell>(), 3);
            recipe.AddIngredient(ItemType<ArchariliteBar>(), 6);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
