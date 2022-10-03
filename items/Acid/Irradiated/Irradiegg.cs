
using CozmicVoidAwakened.Items.Sets.Divine;
using CozmicVoidAwakened.Items.Sets.Shadow;
using CozmicVoidAwakened.Items.Sets.Glich;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace CozmicVoidAwakened.Items.Sets.Acid.Irradiated
{
    public class Irradiegg : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Electronic Death Remote");
            Tooltip.SetDefault("'that big red button probably will do something you’ll regret... \n Your conscience advises you to press it and see what happens!'");
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
            item.rare = ItemRarityID.Orange;
        }


        // We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.
        public override bool CanUseItem(Player player)
        {
            return !NPC.AnyNPCs(NPCType<NPCs.Acid.IrradiatedNest>()) && player.GetVoidPlayer().ZoneAcidic;
            
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, Type: NPCType<NPCs.Acid.IrradiatedNest>());
            int TextToSpawn = Main.rand.Next(1, 6 + 1);

            if (TextToSpawn == 1)
            {
                CombatText.NewText(new Rectangle((int)player.position.X, (int)player.position.Y, player.width, player.height), new Color(152, 208, 113, 44), "Initiate death protocol");
            }
            if (TextToSpawn == 2)
            {
                CombatText.NewText(new Rectangle((int)player.position.X, (int)player.position.Y, player.width, player.height), new Color(152, 208, 113, 44), "The end is nigh…");
            }
            if (TextToSpawn == 3)
            {
                CombatText.NewText(new Rectangle((int)player.position.X, (int)player.position.Y, player.width, player.height), new Color(152, 208, 113, 44), "Tactical nuke incoming…");
            }
            if (TextToSpawn == 4)
            {
                CombatText.NewText(new Rectangle((int)player.position.X, (int)player.position.Y, player.width, player.height), new Color(152, 208, 113, 44), "We’re here to contact you about your deaths extended warranty");
            }
            if (TextToSpawn == 5)
            {
                CombatText.NewText(new Rectangle((int)player.position.X, (int)player.position.Y, player.width, player.height), new Color(152, 208, 113, 44), "Brace for impact…");
            }
            if (TextToSpawn == 6)
            {
                CombatText.NewText(new Rectangle((int)player.position.X, (int)player.position.Y, player.width, player.height), new Color(152, 208, 113, 44), "You’re going to have a bad time…");
            }
            Main.PlaySound(SoundLoader.customSoundType, player.position, mod.GetSoundSlot(SoundType.Custom, "Sounds/Button"));

            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<DriveConstruct>(), 1);
            recipe.AddIngredient(ItemType<AcidPlating>(), 11);
            recipe.AddIngredient(ItemType<DreadFoil>(), 15);
            recipe.AddIngredient(ItemType<AcidicMetal>(), 12);
            recipe.AddIngredient(ItemType<GoldenClaw>(), 5);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}