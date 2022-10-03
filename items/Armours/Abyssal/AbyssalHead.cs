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
using CozmicVoidAwakened.Items.Sets.Blood;
using CozmicVoidAwakened.Items.Sets.Abyssal;

namespace CozmicVoidAwakened.Items.Sets.Armours.Abyssal
{
    [AutoloadEquip(EquipType.Head)]
    public class AbyssalHead : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(silver: 26);
            item.rare = ItemRarityID.Blue;
            item.defense = 16;

        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<AbyssalFragments>(), 10);
            recipe.AddIngredient(ItemType<EldritchSoul>(), 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.13F;
            player.meleeCrit += 6;
        }
        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawShadow = true;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<AbyssalBody>() && legs.type == ItemType<AbyssalLegs>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.statLifeMax2 += 40;
        }
    }
}