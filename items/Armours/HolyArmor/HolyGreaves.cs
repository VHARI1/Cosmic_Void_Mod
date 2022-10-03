using System.Collections.Generic;
using CozmicVoidAwakened.Items.Sets.Cave;
using static Terraria.ModLoader.ModContent;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CozmicVoidAwakened.Items.Sets.Cozmic;
namespace CozmicVoidAwakened.Items.Sets.Armours.HolyArmor
{
    [AutoloadEquip(EquipType.Legs)]
    public class HolyGreaves : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Holy Greaves");
			Tooltip.SetDefault("Increases mage critical strike chance by 8% and movement speed by 10%");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 22;
            item.value = 10000;
            item.rare = 6;

            item.defense = 9;
        }

        public override void UpdateEquip(Player player)
        {
            player.magicCrit += 8;
            player.moveSpeed += 0.8F;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<GeoRock>(), 7);
            recipe.AddIngredient(ItemType<PixieSilk>(), 8);
            recipe.AddIngredient(ItemID.UnicornHorn, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}