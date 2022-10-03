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
using CozmicVoidAwakened.Projectiles.Minions;
using CozmicVoidAwakened.Items.Placeables;
using CozmicVoidAwakened.Items.Sets.Cave;

namespace CozmicVoidAwakened.Items.Sets.Armours.GeoGem
{
    [AutoloadEquip(EquipType.Head)]
    public class GeoGemHood : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("GeoGem Hood");
			Tooltip.SetDefault("Increases Minion Damage by 10%");
		}

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 30;
            item.value = 10000;
            item.rare = 6;

            item.defense = 4;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.5f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("GeoGemPlate") && legs.type == mod.ItemType("GeoGemGreaves");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.statLifeMax2 += 20;
            player.lifeRegen += 3;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<CoreGem>(), 3);
            recipe.AddIngredient(ItemType<GeoRock>(), 6);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
