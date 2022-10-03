using CozmicVoidAwakened.Items.Sets.Glich;
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
    public class EmptyIrradicell : ModItem
    {
        public bool EIrradicell = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Concentrated Irradicell");

            Tooltip.SetDefault("Increases minion damage and max minions by 1 & minions can deal a Acid debuff when striking foes.");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(gold: 2);
            item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetVoidPlayer().ConcentratedIrradicell = true;
            player.minionDamage += 0.2f;
            player.maxMinions += 2;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ConcentratedStormSample>(), 1);
            recipe.AddIngredient(ItemType<SummoningCell>(), 1);
            recipe.AddIngredient(ItemType<DriveConstruct>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
