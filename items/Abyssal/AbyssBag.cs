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
using CozmicVoidAwakened.Projectiles.Minions;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
    class AbyssBag : ModItem
    {
        public static bool spawnLumiOre = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TreasureBag");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.value = 10000;
            item.maxStack = 99;
            item.rare = ItemRarityID.LightRed;
        }
        public override bool CanRightClick() //this make so you can right click this item
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            if (Main.rand.Next(2) == 0)
                player.QuickSpawnItem(ItemType<AbyssalBoltCannon>(), Main.rand.Next(1, 1));
            if (Main.rand.Next(2) == 0)
                player.QuickSpawnItem(ItemType<BindingFlameBook>(), Main.rand.Next(1, 1));
            if (Main.rand.Next(2) == 0)
                player.QuickSpawnItem(ItemType<CleavingAbyss>(), Main.rand.Next(1, 1));
            if (Main.rand.Next(2) == 0)
                player.QuickSpawnItem(ItemType<PlanetStaff>(), Main.rand.Next(1, 1));
            if (Main.rand.Next(1) == 0)
                player.QuickSpawnItem(ItemType<AbyssalFragments>(), Main.rand.Next(20, 60));
            {

            }
        }
    }
}
