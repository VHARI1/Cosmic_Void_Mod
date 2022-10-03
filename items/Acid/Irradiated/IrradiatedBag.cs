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
using CozmicVoidAwakened.Projectiles.Arrows;
using CozmicVoidAwakened.Items.Accessories;

namespace CozmicVoidAwakened.Items.Sets.Acid.Irradiated
{
    [AutoloadBossHead]
    class IrradiatedBag : ModItem
    {
        public static bool spawnLumiOre = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = ItemRarityID.Expert;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override bool CanRightClick() //this make so you can right click this item
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            if (Main.rand.Next(2) == 0)
                player.QuickSpawnItem(ItemType<IrradiatedFlamethrower>(), Main.rand.Next(1, 1));
            if (Main.rand.Next(2) == 0)
                player.QuickSpawnItem(ItemType<IrradiatedGreatBlade>(), Main.rand.Next(1, 1));
            if (Main.rand.Next(2) == 0)
                player.QuickSpawnItem(ItemType<IrradieagleWrath>(), Main.rand.Next(1, 1));
            if (Main.rand.Next(2) == 0)
                player.QuickSpawnItem(ItemType<TheIrradiaspear>(), Main.rand.Next(1, 1));
            if (Main.rand.Next(1) == 0)
                player.QuickSpawnItem(ItemType<AcidPlating>(), Main.rand.Next(10, 30));
            if (Main.rand.Next(1) == 0)
                player.QuickSpawnItem(ItemType<EaglesGrace>(), Main.rand.Next(1, 1));
            if (Main.rand.Next(1) == 0)
                player.QuickSpawnItem(ItemType<StaffoftheIrradiaclaw>(), Main.rand.Next(1, 1));
            if (Main.rand.Next(1) == 0)
                player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 20));
            {

            }
        }
    }
}
