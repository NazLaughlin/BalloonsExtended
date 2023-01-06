using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace BalloonsExtended.Items.Balloons {
    [AutoloadEquip(EquipType.Balloon)]
    public class UltimateHorseshoeBundle:ModItem {
        public override void SetStaticDefaults () {
            DisplayName.SetDefault("Ultimate Horseshoe Bundle of Balloons");
            Tooltip.SetDefault("Gives the holder 5 extra jumps,\n" +
                "Increases jump hight,\n" +
                "Negates fall damage,\n" +
                "and releases bees when damaged.\n\n" +
                "~We have improved the ultimate bundle, but we can do better.");
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
            player.noFallDmg = true;
        }

        public override void AddRecipes () {
            Recipe recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.UltimateHorseshoeBundle>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Balloons.UltimateBundle>(), 1);
            recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.UltimateHorseshoeBundle>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Balloons.ExoticHorseshoeBundle>(), 1);
            recipe.AddIngredient(ItemID.BundleofBalloons, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.UltimateHorseshoeBundle>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Balloons.ExoticBundle>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Balloons.HorseshoeBundle>(), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}