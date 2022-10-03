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

namespace CozmicVoidAwakened.Items.Sets.Acid
{
    class AcidicMetal : ModItem
    {
        public static bool spawnLumiOre = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acidic Metal");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.value = 1000;
            item.maxStack = 99;
            item.rare = ItemRarityID.Green;
        }
    }
}
