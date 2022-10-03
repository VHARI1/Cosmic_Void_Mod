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
using CozmicVoidAwakened.Projectiles.Abyssal;
using Microsoft.Xna.Framework;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
	public class BindingFlameBook : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Binding Flame Book");

			;
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item45;
			item.autoReuse = true;
			item.shoot = ProjectileType<AbyssFlameGood>();
			item.shootSpeed = 15;
			item.mana = 20;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
	}
}