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
    public class SpiritPendent : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spirit Pendent");
        }
        public override void SetDefaults()
        {
            item.value = Item.sellPrice(gold: 2);
            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(silver: 12);
            item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetVoidPlayer().SpiritPendent = true;
            Lighting.AddLight(player.position, 1.0f, 1.0f, 2.75f);
        }
    }
}
