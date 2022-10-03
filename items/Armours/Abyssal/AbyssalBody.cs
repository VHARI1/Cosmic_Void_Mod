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
    [AutoloadEquip(EquipType.Body)]
    public class AbyssalBody : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(silver: 26);
            item.rare = ItemRarityID.Blue;
            item.defense = 11;
        }
        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.005f;
            player.meleeSpeed += 0.15F;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<AbyssalFragments>(), 15);
            recipe.AddIngredient(ItemType<EldritchSoul>(), 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}


