using CozmicVoidAwakened.Items.Sets.Arnchar;
using CozmicVoidAwakened.Items.Sets.Thunder.StormBringer;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
    public class ArncharMagazine : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arnchar Magazine");
            Tooltip.SetDefault("Increases ranged critical strike chance by 5%");
        } 
        public override void SetDefaults()
        {
            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(silver: 80);
            item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.rangedCrit += 5;
        }
        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Lighting.AddLight(item.position, 0.08f, .28f, .38f);
            Texture2D texture;
            texture = Main.itemTexture[item.type];
            spriteBatch.Draw
            (
                ModContent.GetTexture("CozmicVoidAwakened/Items/Accessories/ArncharMagazine_Glow"),
                new Vector2
                (
                    item.position.X - Main.screenPosition.X + item.width * 0.5f,
                    item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.White,
                rotation,
                texture.Size() * 0.5f,
                scale,
                SpriteEffects.None,
                0f
            );
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ArncharlitPowerCell>(), 5);
            recipe.AddIngredient(ItemType<ArchariliteBar>(), 15);
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
