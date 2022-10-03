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

namespace CozmicVoidAwakened.Items.Sets.Acid.Irradiated
{
	public class TheIrradiaspear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Irradiaspear"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.thrown = true;
			item.width = 40;
            item.height = 40;
			item.noUseGraphic = true;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.shoot = ProjectileType<TheIrradiaspearProj>();
			item.shootSpeed = 35f;
			item.autoReuse = true;
		}

	}
}