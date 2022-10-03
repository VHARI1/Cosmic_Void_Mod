using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria;
using CozmicVoidAwakened.Projectiles.Abyssal;
using CozmicVoidAwakened.Projectiles.Lumi;

namespace CozmicVoidAwakened.Items.Sets.Abyssal
{
    public class WatcherBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Watcher's Book");

            ; Tooltip.SetDefault("Releases homing comments");
        }

        public override void SetDefaults()
        {
            item.damage = 18;
            item.magic = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 3, 20, 14);
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item109;
            item.autoReuse = true;
            item.shoot = ProjectileType<AbyssBook>();
            item.shootSpeed = 0;
            item.mana = 25;
        }
    }
}