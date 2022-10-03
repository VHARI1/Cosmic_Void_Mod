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
using CozmicVoidAwakened.Items.Sets.Luminull;
using CozmicVoidAwakened.Items.Sets.Acid.Irradiated;
using Microsoft.Xna.Framework;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
    public class VoidMaster : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Shrowder");
            CozmicGlowmask.AddGlowMask(item.type, "CozmicVoidAwakened/Items/Sets/Abyssal/VoidMaster_Glow");
        }

        public override void SetDefaults()
        {
            item.damage = 65;
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 1, 20, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shoot = ProjectileID.WoodenArrowFriendly;
            item.shootSpeed = 50f;
            item.useAmmo = AmmoID.Arrow;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<TheVoid>(), 1);
            recipe.AddIngredient(ItemType<LuminullShadowBow>(), 1);
            recipe.AddIngredient(ItemType<IrradieagleWrath>(), 1);
            recipe.AddIngredient(ItemType<AbyssalFragments>(), 30);
            recipe.AddIngredient(ItemType<AbyssalTeslaBar>(), 10);
            recipe.AddIngredient(ItemType<DarkRocks>(), 50);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}