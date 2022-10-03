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
    public class WatcherCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Watcher Charm");
            Tooltip.SetDefault("Used for simulating flying, because in this stage of a lumiflys live they can’t do that right now... \n Greatly increases fall resistance (Good for trespassing the abyss!)");
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
            player.maxFallSpeed -= 2.9f;
        }
    }
}
