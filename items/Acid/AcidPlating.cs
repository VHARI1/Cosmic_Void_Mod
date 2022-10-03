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
using Steamworks;
using CozmicVoidAwakened.Items.Sets.Acid.Irradiated;

namespace CozmicVoidAwakened.Items.Sets.Acid
{
    class AcidPlating : ModItem
    {
        public static bool spawnLumiOre = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Virulent Plating");
            Tooltip.SetDefault("Radiating within the tocins of entities in the acid");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.value = 10000;
            item.maxStack = 99;
            item.rare = ItemRarityID.Green;
        }


        class MyGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.Hornet)
                {
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                }
                if (npc.type == NPCID.HornetFatty)
                {
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                }
                if (npc.type == NPCID.HornetHoney)
                {
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                }
                if (npc.type == NPCID.BigHornetHoney)
                {
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                }
                if (npc.type == NPCID.BigHornetStingy)
                {
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                }
                if (npc.type == NPCID.JungleBat)
                {
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                    if (Main.rand.Next(3) == 0)
                        Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);

                    if (npc.type == NPCID.JungleSlime)
                    {
                        if (Main.rand.Next(3) == 0)
                            Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                        if (Main.rand.Next(3) == 0)
                            Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                        if (Main.rand.Next(3) == 0)
                            Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);
                        if (Main.rand.Next(3) == 0)
                            Item.NewItem(npc.getRect(), ItemType<AcidPlating>(), 2);

                    }
                }
            }
        }
    }
}
    


