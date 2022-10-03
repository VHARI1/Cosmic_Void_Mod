using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using CozmicVoidAwakened.Items.Sets.Luminull;
using CozmicVoidAwakened.Items.Sets.Luminull.LumiW;

namespace CozmicVoidAwakened.Items.Sets.Armours
{
    [AutoloadEquip(EquipType.Head)]
    public class JellyHat : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(silver: 26);
            item.rare = ItemRarityID.Blue;
            item.defense = 2;
        }
        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.06F;
            player.magicCrit += 4;
            player.statManaMax2 += 20;

        }
    }
}