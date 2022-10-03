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
    public class StormShard : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storm Shard");
            Tooltip.SetDefault("Increases all damage when wet or raining.");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(gold: 2);
            item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (Main.raining || player.wet)
            {
                player.allDamage += 0.2f;
                player.moveSpeed += 0.8f;
            }
        }
    }
}
