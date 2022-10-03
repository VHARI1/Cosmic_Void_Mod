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
using CozmicVoidAwakened.Items.Sets.EnchantedWinterI;

namespace CozmicVoidAwakened.Items.Sets.Armours
{
    [AutoloadEquip(EquipType.Head)]
    public class WizardHat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wizard Hat");
            Tooltip.SetDefault("Increases mana regen by 5% and Decreases mana cost by 30%");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(silver: 26);
            item.rare = ItemRarityID.Blue;
            item.defense = 2;
        }
        public override void UpdateEquip(Player player)
        {
            player.manaCost -= 0.3F;
            player.manaRegen += 5;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Leather, 3);
            recipe.AddRecipeGroup(RecipeGroupID.IronBar, 2);
            recipe.AddIngredient(ItemType<EnchantedSoulFragments>(), 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
