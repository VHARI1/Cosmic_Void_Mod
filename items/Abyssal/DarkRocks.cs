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

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
    public class DarkRocks : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Rocks");
            Tooltip.SetDefault("This is a modded item.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = 2;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
        }
    }
}
