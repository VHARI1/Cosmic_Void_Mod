using CozmicVoidAwakened.Items.Sets.Luminull;
using CozmicVoidAwakened.Items.Sets.Luminull.LumiW;
using CozmicVoidAwakened.Items.Sets.Pharaoh;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CozmicVoidAwakened.Items.Accessories
{
    public class AccuraEye : ModItem
    {
        public bool SScarf = false;

        public override void SetDefaults()
        {
            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.Blue;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<BloodEye>(), 1);
            recipe.AddIngredient(ItemType<OmniSeeker>(), 1);
            recipe.AddIngredient(ItemType<LumiSpiritBar>(), 10);
            recipe.AddIngredient(ItemID.DemoniteBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe()
                ;
            ModRecipe recipeB = new ModRecipe(mod);
            recipeB.AddIngredient(ItemType<BloodEye>(), 1);
            recipeB.AddIngredient(ItemType<OmniSeeker>(), 1);
            recipeB.AddIngredient(ItemType<LumiSpiritBar>(), 10);
            recipeB.AddIngredient(ItemID.CrimtaneBar, 10);
            recipeB.AddTile(TileID.Anvils);
            recipeB.SetResult(this);
            recipeB.AddRecipe();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.rangedCrit += 2;
            player.arrowDamage += 0.4f;
            player.GetVoidPlayer().Seeker = true;
        }
    }
}
