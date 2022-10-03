using CozmicVoidAwakened.Items.Sets.Cave;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;
using CozmicVoidAwakened.Items.Sets.Cozmic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CozmicVoidAwakened.Items.Sets.Armours.HolyArmor
{
    [AutoloadEquip(EquipType.Head)]
    public class HolyFaceplate : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Holy Faceplate");
			Tooltip.SetDefault("Increases mage damage by 10% and melee critical strike chance by 8%");
		}

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 30;
            item.value = 10000;
            item.rare = 6;

            item.defense = 10;
        }

        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.1F;
            player.magicCrit += 8;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("HolyPlatemail") && legs.type == mod.ItemType("HolyGreaves");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.statManaMax2 += 20;
            player.jumpAgainUnicorn = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<GeoRock>(), 5);
            recipe.AddIngredient(ItemType<PixieSilk>(), 10);
            recipe.AddIngredient(ItemID.UnicornHorn, 7);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}