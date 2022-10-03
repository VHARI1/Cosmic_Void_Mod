using CozmicVoidAwakened.Items.Placeables;
using CozmicVoidAwakened.Items.Sets.Living;
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
    public class GiftOfLife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gift Of Life");
            Tooltip.SetDefault("Increases Mana Regen and Max Mana Count");
        }
        public override void SetDefaults()
        {
            item.value = Item.sellPrice(gold: 4);
            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(silver: 12);
            item.rare = ItemRarityID.Blue;
            item.defense = 2;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetVoidPlayer().ForestStone = true;
            player.manaRegen += 3;
            player.statManaMax2 += 20;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<WoodShield>(), 1);
            recipe.AddIngredient(ItemType<ForestStone>(), 1);
            recipe.AddIngredient(ItemType<LivingAlloy>(), 10);
            recipe.AddIngredient(ItemType<CoreGem>(), 3);
            recipe.AddIngredient(ItemID.NaturesGift, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}