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
using CozmicVoidAwakened.Projectiles.Acid;
using Microsoft.Xna.Framework;

namespace CozmicVoidAwakened.Items.Sets.Acid.Irradiated
{
	public class IrradiatedFlamethrower : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Irradiated Flamethrower"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.

		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item45;
			item.autoReuse = true;
			item.shoot = ProjectileType<AcidFlamethrowerProjec>();
			item.shootSpeed = 10f;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
	}
}