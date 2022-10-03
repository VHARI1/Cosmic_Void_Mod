using CozmicVoidAwakened.Items.Sets.EnchantedWinterI;
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
    public class SunEmblum : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sun Emblum");
            Tooltip.SetDefault("Getting hit occasionally inflicts Onfire on nearby enemies");

        }


        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.value = Item.sellPrice(gold: 1);
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<FlareGem>(), 20);
            recipe.AddIngredient(ItemID.GoldBar, 2);
            recipe.AddIngredient(ItemType<SunEmber>(), 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetVoidPlayer().SunEmblum = true;
        }
    }
}