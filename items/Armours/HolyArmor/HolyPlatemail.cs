using System.Collections.Generic;
using CozmicVoidAwakened.Items.Sets.Cave;
using static Terraria.ModLoader.ModContent;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CozmicVoidAwakened.Items.Sets.Cozmic;
namespace CozmicVoidAwakened.Items.Sets.Armours.HolyArmor
{
    [AutoloadEquip(EquipType.Body)]
    public class HolyPlatemail : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Holy Platemail");
			Tooltip.SetDefault("Increases mage damage by 13% and melee speed by 10%");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 22;
            item.value = 80000;
            item.rare = 14;

            item.defense = 16;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.13F;
            player.meleeSpeed += 0.1F;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<GeoRock>(), 10);
            recipe.AddIngredient(ItemType<PixieSilk>(), 15);
            recipe.AddIngredient(ItemID.UnicornHorn, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}