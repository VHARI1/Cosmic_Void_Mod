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
using CozmicVoidAwakened.Projectiles.Acid;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
	public class GhostThorwer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ghost Thorwer");
		}

		public override void SetDefaults() 
		{
			item.damage = 19;
			item.thrown = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = ItemRarityID.LightRed;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<GhostThorwerProg>();
			item.shootSpeed = 16f;
		}
	}
}