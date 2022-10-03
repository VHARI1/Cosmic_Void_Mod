using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria;
using CozmicVoidAwakened.NPCs.Lumi;
using CozmicVoidAwakened.Items.Sets.Skeletron;
using CozmicVoidAwakened.Items.Sets.Shadow;
using CozmicVoidAwakened.Items.Sets.Glich;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
    public class AbyssalLanturn : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Abyssal Lanturn");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 28;
            item.rare = 2;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = 4;
            item.rare = ItemRarityID.LightRed;
        }


        // We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.
        public override bool CanUseItem(Player player)
        {
            return !NPC.AnyNPCs(NPCType<NPCs.Abyssal.BindingAbyss>());
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, Type: NPCType<NPCs.Abyssal.BindingAbyss>());

            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<AbyssalTeslaBar>(), 11);
            recipe.AddIngredient(ItemType<TerrorFragments>(), 5);
            recipe.AddIngredient(ItemType<DreadFoil>(), 10);
            recipe.AddIngredient(ItemType<DriveConstruct>(), 1);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}