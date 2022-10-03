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
using CozmicVoidAwakened.Items.Sets.Blood;
using CozmicVoidAwakened.Items.Sets.Luminull;
using CozmicVoidAwakened.Items.Sets.Cozmic;

namespace CozmicVoidAwakened.Items.Sets.Armours.Astrasilk
{
    [AutoloadEquip(EquipType.Body)]
    public class AstrasilkBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astrasilk Vest");

        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(silver: 26);
            item.rare = ItemRarityID.Blue;
            item.defense = 5;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<StarSilk>(), 6);
            recipe.AddIngredient(ItemType<DarkEssence>(), 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}


