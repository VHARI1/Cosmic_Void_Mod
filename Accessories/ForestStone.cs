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
    public class ForestStone : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forest Stone");
            Tooltip.SetDefault("Getting hit occasionally inflicts poison on nearby enemies");

        }


        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.value = Item.buyPrice(0, 1, 0, 0);
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetVoidPlayer().ForestStone = true;
        }
    }
}