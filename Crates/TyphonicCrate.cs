using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CozmicVoidAwakened.Items.Crates   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class TyphonicCrate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Typhonic Crate");
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
                int Choose = Main.rand.Next(10);
                if (Choose == 10)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.Flipper, Main.rand.Next(1, 1));
                }
                if (Choose == 2)                                                  // 1 item
                {
                    player.QuickSpawnItem(mod.ItemType("AquariuliteBar"), Main.rand.Next(3, 9));
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
                    player.QuickSpawnItem(mod.ItemType("HeartOfTheSea"));
                }
                if (Choose == 7)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.AdamantiteBar, Main.rand.Next(1, 20));
                }
                if (Choose == 7)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.PalladiumBar, Main.rand.Next(1, 20));
                }
                if (Choose == 8)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.CobaltBar, Main.rand.Next(1, 20));
                }
                if (Choose == 9)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.TitaniumBar, Main.rand.Next(1, 15));
                }
                if (Choose == 10)                                                  // 1 item
                {
                    player.QuickSpawnItem(ItemID.MythrilBar, Main.rand.Next(1, 10));
                }

                player.QuickSpawnItem(mod.ItemType("TyphonicShard"), Main.rand.Next(1, 15));
                player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(1, 2));

            }
            else        //else if it's prehard mode then only this items will drop
            {
            }

        }

    }
}