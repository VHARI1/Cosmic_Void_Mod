using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria;
using CozmicVoidAwakened.Items.Placeables;
using CozmicVoidAwakened.Items.Sets.Shadow;

namespace CozmicVoidAwakened.Items.Sets.Acid.Irradiated
{
    class IrradiatedBar : ModItem
    {
        public static bool spawnLumiOre = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("IrradiatedBar");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.value = 10000;
            item.maxStack = 99;
            item.rare = ItemRarityID.Green;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<AcidPlating>(), 2);
            recipe.AddIngredient(ItemType<AcidOre>(), 1);
            recipe.AddIngredient(ItemType<DreadFoil>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }
}
