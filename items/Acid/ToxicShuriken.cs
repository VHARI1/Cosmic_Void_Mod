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
using CozmicVoidAwakened.Projectiles.Lumi;

namespace CozmicVoidAwakened.Items.Sets.Acid
{
	public class ToxicShuriken : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("ToxicS huriken");
			Tooltip.SetDefault("releases flames upon colliding with a tile");
		}

		public override void SetDefaults()
		{
			item.damage = 35;
			item.thrown = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item1;
			item.shoot = ProjectileType<ToxicShurikenP>();
			item.autoReuse = true;
			item.shootSpeed = 15f;
			item.consumable = true;
			item.maxStack = 99;
		}
	}
}