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
using CozmicVoidAwakened.Items.Sets.EnchantedWinterI;
using CozmicVoidAwakened.Items.Sets.Glich;

namespace CozmicVoidAwakened.Items.Accessories
{
    [AutoloadEquip(EquipType.Body)]
    public class MetallicOmniPlateArmourChestplate : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(gold: 1);
            item.rare = ItemRarityID.Blue;
            item.defense = 15;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<MetallicOmniPlateArmourChestplate>();
        }
        public override void UpdateArmorSet(Player player)
        {

            player.moveSpeed =+ 10f;
            player.pickSpeed -= 1f;
            player.blockRange += 2222;;
        }
    }
}