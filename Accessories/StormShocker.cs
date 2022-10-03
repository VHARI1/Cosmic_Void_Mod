using CozmicVoidAwakened.Items.Sets.Thunder;
using CozmicVoidAwakened.Items.Sets.Thunder.StormBringer;
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
    public class StormShocker : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storm Shocker");
            Tooltip.SetDefault("Increases throwing damage and throwing velocity.");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(silver: 12);
            item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if(Main.raining || player.wet)
            {
                player.allDamage += 0.2f;
            }
        }
    }
}
