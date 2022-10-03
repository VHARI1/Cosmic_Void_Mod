using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CozmicVoidAwakened.Items.Crates   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class AcidCrate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acid Crate");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;     //This defines the items max stack
            item.consumable = true;  //Tells the game that this should be used up once opened
            item.width = 34;  //The size in width of the sprite in pixels.
            item.height = 34;    //The size in height of the sprite in pixels.      
            item.rare = 9; //The color the title of your Weapon when hovering over it ingame  
            item.placeStyle = 0;
            item.useAnimation = 10; //How long the item is used for.
            item.useTime = 10;  //How fast the item is used.
            item.useStyle = 1; //The way your item will be used, 1 is the regular sword swing for example

        }
        public override bool CanRightClick() //this make so you can right click this item
        {
            return true;
        }

        public override void RightClick(Player player)  //this make so when you right click this item, then one of these items will drop
        {


            if (Main.hardMode) // if it's hardmode this itams will drop  
            {
                int Choose = Main.rand.Next(11);
                if (Choose == 1)                                                  // 1 item
                {
                    player.QuickSpawnItem(mod.ItemType("JellyHat"));
                }
                if (Choose == 2)                                                  // 1 item
                {
                    player.QuickSpawnItem(mod.ItemType("JellyLance"));
                }
                if (Choose == 3)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.MasterBait, Main.rand.Next(1, 5));
                }
                if (Choose == 4)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.JourneymanBait, Main.rand.Next(3, 9));
                }
                if (Choose == 5)                                                  // 1 item
                {
                    player.QuickSpawnItem(mod.ItemType("JellySlaff"));
                }
                if (Choose == 6)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.JellyfishNecklace, Main.rand.Next(1, 1));
                }
                if (Choose == 7)                                                  // 1 item
                {
                    player.QuickSpawnItem(mod.ItemType("TyphonicShard"), Main.rand.Next(3, 9));
                }
                if (Choose == 8)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.LeadBar, Main.rand.Next(1, 20));
                }
                if (Choose == 9)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.TungstenBar, Main.rand.Next(1, 15));
                }
                if (Choose == 10)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.GoldBar, Main.rand.Next(1, 10));
                }
                if (Choose == 11)                                                  // 1 item
                {
                    player.QuickSpawnItem(mod.ItemType("JellyBow"));
                }

                //and these are items that will drop 100% + the one itam from the top
                player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(10, 20));        //this is an example of how to add a vanilla terraria itam, Change ItemID.GoldCoin with what item u want

            }
            else        //else if it's prehard mode then only this items will drop
            {
                int Choose = Main.rand.Next(8);
                if (Choose == 1)                                                  // 1 item
                {
                    player.QuickSpawnItem(mod.ItemType("AcidPlating"), Main.rand.Next(00, 10));
                }
                if (Choose == 2)                                                  // 1 item 
                {
                    player.QuickSpawnItem(ItemID.MasterBait, Main.rand.Next(1, 5));
                }
                if (Choose == 3)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.JourneymanBait, Main.rand.Next(3, 9));
                }
                if (Choose == 4)                                                  // 1 item
                {
                    player.QuickSpawnItem(mod.ItemType("ToxicShuriken"), Main.rand.Next(30, 60));
                }
                if (Choose == 5)                                                  // 1 item
                {
                    player.QuickSpawnItem(mod.ItemType("AcidHatchit"));
                }
                if (Choose == 6)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.LeadBar, Main.rand.Next(1, 20));
                }
                if (Choose == 7)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.TungstenBar, Main.rand.Next(1, 15));
                }
                if (Choose == 8)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.GoldBar, Main.rand.Next(1, 10));
                }
                player.QuickSpawnItem(mod.ItemType("AcidicBar"), Main.rand.Next(1, 5));
                player.QuickSpawnItem(mod.ItemType("AcidicMetal"), Main.rand.Next(5, 24));
                player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(1, 2));

            }


        }

    }
}