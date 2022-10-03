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
using CozmicVoidAwakened.Items.Sets.Cozmic;

namespace CozmicVoidAwakened.Items.Sets.Armours.Astrasilk
{
    [AutoloadEquip(EquipType.Head)]
    public class AstrasilkHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astrasilk Hat");
            Tooltip.SetDefault("Increases magic damage by 13%");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(silver: 26);
            item.rare = ItemRarityID.Blue;
            item.defense = 4;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<StarSilk>(), 3);
            recipe.AddIngredient(ItemType<DarkEssence>(), 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.13f;
        }
        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawShadow = true;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<AstrasilkBody>() && legs.type == ItemType<AstrasilkLegs>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.statLifeMax2 += 20;
        }
    }
}