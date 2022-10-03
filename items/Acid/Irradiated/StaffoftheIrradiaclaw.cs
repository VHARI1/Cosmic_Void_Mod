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
	public class StaffoftheIrradiaclaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Staff of the Irradiaclaw"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			Item.staff[item.type] = true;
			item.damage = 21;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item100;
			item.shoot = ProjectileType<AcidBolt2>();
            item.shootSpeed = 15f;
			item.mana = 15;
			item.autoReuse = true;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
	}
}