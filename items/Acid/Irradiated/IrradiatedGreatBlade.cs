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
using Microsoft.Xna.Framework;
using CozmicVoidAwakened.Projectiles.Lumi;
using CozmicVoidAwakened.Projectiles.Acid;

namespace CozmicVoidAwakened.Items.Sets.Acid.Irradiated
{
	public class IrradiatedGreatBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Irradiated Great Blade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			item.damage = 21;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.shoot = ProjectileType<AcidBlast2>();
			item.shootSpeed = 35f;
			item.autoReuse = true;
		}
	}
}