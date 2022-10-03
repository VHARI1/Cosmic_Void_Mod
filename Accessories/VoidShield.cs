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
    public class VoidShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Void Shield");
            Tooltip.SetDefault("Increases Movement Speed and Life Regen at Night");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(gold: 2);
            item.rare = ItemRarityID.Blue;
            item.defense = 2;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (!Main.dayTime)
            {
                player.moveSpeed += 1f;
                player.lifeRegen += 3;
            }

        }
    }
}