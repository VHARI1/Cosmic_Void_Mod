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
using CozmicVoidAwakened.Projectiles.Abyssal;

namespace CozmicVoidAwakened.Items.Sets.Acid.Irradiated
{
	public class Tociflare : ModItem
	{
		public override void SetStaticDefaults()
        {
            CozmicGlowmask.AddGlowMask(item.type, "CozmicVoidAwakened/Items/Sets/Acid/Irradiated/Tociflare_Glow");
            DisplayName.SetDefault("Tociflare"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

        public override void SetDefaults()
        {
            item.damage = 20;
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 27;
            item.useAnimation = 27;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item73;
            item.shoot = ProjectileType<TociBolt4>();
            item.useAmmo = AmmoID.Gel;
            item.shootSpeed = 25f;
            item.autoReuse = true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-5, 0);
        }
    }
}