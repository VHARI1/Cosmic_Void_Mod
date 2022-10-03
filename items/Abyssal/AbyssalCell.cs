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
using CozmicVoidAwakened.Items.Placeables.Abyss;
using CozmicVoidAwakened.Items.Sets.Luminull;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
    public class AbyssalCell : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Abyssal Cell");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = ItemRarityID.Blue;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
        }
    }
}