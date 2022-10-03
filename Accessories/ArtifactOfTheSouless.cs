using CozmicVoidAwakened.Items.Sets.Thunder;
using CozmicVoidAwakened.Items.Sets.Thunder.StormBringer;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CozmicVoidAwakened.Items.Accessories
{
    public class ArtifactOfTheSouless : ModItem
    {
        private float f = 0.75f;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Artifact Of The Souless");
            Tooltip.SetDefault("Allows the user to traverse the abyss during the night");
        }
        public override void SetDefaults()
        {

            item.Size = new Vector2(20);
            item.accessory = true;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.Red;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetVoidPlayer().ArtifactOfTheSouless = true;
            Lighting.AddLight(player.position, 1.0f, 1.0f, 2.75f);
        }
    }
}
