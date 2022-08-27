using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace BalloonsExtended.Items.Balloons {
    [AutoloadEquip(EquipType.Balloon)]
    public class UltimateBundle:ModItem {
        public override void SetStaticDefaults () {
            DisplayName.SetDefault("Ultimate Bundle of Balloons");
            Tooltip.SetDefault("Gives the holder 5 extra jumps,\n" +
                "Increases jump hight,\n" +
                "and releases bees when damaged.\n\n" +
                "-Every balloon, in the palm of your hand.\n"+
                "   Try not to kill yourself");
        }
        public override void SetDefaults () {
            Item.width = 14;
            Item.height = 28;
            Item.accessory = true;
            Item.value = 300000;
            Item.rare = ItemRarityID.Cyan;
        }
        public override void UpdateAccessory (Player player, bool hideVisual) {
            player.hasJumpOption_Fart = true;
            player.hasJumpOption_Sail = true;
            player.hasJumpOption_Cloud = true;
            player.hasJumpOption_Sandstorm = true;
            player.hasJumpOption_Blizzard = true;
            player.honeyCombItem = Item;
            player.jumpBoost = true;
        }

        public override void AddRecipes () {
            Recipe recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.UltimateBundle>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Balloons.ExoticBundle>(), 1);
            recipe.AddIngredient(ItemID.BundleofBalloons, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}