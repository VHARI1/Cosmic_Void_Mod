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
    public class DreadGlove : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dread Glove");
            Tooltip.SetDefault("Increases critical strike chance the lower your health is.");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(gold: 2);
            item.rare = ItemRarityID.Green;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.statLife <= player.statLifeMax2 / 2)
            {
                player.thrownCrit += 2;
                player.rangedCrit += 2;
                player.magicCrit += 2;
                player.meleeCrit += 2;
            }
            if (player.statLife <= player.statLifeMax2 / 3)
            {
                player.thrownCrit += 3;
                player.rangedCrit += 3;
                player.magicCrit += 3;
                player.meleeCrit += 3;
            }
            if (player.statLife <= player.statLifeMax2 / 4)
            {
                player.thrownCrit += 4;
                player.rangedCrit += 4;
                player.magicCrit += 4;
                player.meleeCrit += 4;
            }
        }
    }
}