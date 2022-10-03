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
using CozmicVoidAwakened.Projectiles.Abyssal;
using CozmicVoidAwakened.Items.Sets.Acid.Irradiated;
using Microsoft.Xna.Framework;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
	public class PyroPhantom : ModItem
    {
        public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Pyro Phantom");
            CozmicGlowmask.AddGlowMask(item.type, "CozmicVoidAwakened/Items/Sets/Abyssal/PyroPhantom_Glow");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 9;
            item.useAnimation = 9;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = ItemRarityID.LightRed;
            item.UseSound = SoundID.Item91;
            item.autoReuse = true;
            item.shoot = ProjectileType<FallingAbyssGood>();
            item.shootSpeed = 25f;
            item.useAmmo = AmmoID.Bullet;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2, 0);
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = ModContent.ProjectileType<VoidBolt>();
            }
            Terraria.Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0f, 0f);
            return false;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<DarkRocks>(), 60);
            recipe.AddIngredient(ItemType<TerrorFragments>(), 10);
            recipe.AddIngredient(ItemType<AbyssalTeslaBar>(), 15);
            recipe.AddIngredient(ItemType<IrradiatedFlamethrower>(), 1);
            recipe.AddIngredient(ItemType<AbyssalBoltCannon>(), 1);
            recipe.AddIngredient(ItemType<DarkRocks>(), 60);
            recipe.AddIngredient(ItemType<AbyssalFragments>(), 35);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}