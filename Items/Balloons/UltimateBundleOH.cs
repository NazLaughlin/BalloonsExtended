using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace BalloonsExtended.Items.Balloons {
    [AutoloadEquip(EquipType.Balloon)]
    public class UltimateBundleOH:ModItem {
        public override void SetStaticDefaults () {
            DisplayName.SetDefault("Ultimate Bundle of Balloons Type OH");
            Tooltip.SetDefault("Gives the holder 5 extra jumps,\n" +
                "Increases jump hight,\n" +
                "Negates fall damage,\n" +
                "and releases bees when damaged.\n\n" +
                ">The final evolution, you cannot make a better bundle of balloons.");
        }
        public override void SetDefaults () {
            Item.width = 14;
            Item.height = 28;
            Item.accessory = true;
            Item.value = 300000;
            Item.rare = ItemRarityID.Red;
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
            player.fireWalk = true;
        }

        public override void AddRecipes () {
            Recipe recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.UltimateBundleOH>(), 1);
            recipe.AddIngredient(ModContent.ItemType<UltimateHorseshoeBundle>(), 1);
            recipe.AddIngredient(ItemID.ObsidianSkull, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.UltimateBundleOH>(), 1);
            recipe.AddIngredient(ModContent.ItemType<UltimateBundle>(), 1);
            recipe.AddIngredient(ItemID.ObsidianHorseshoe, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.UltimateBundleOH>(), 1);
            recipe.AddIngredient(ModContent.ItemType<ExoticObsidianHorseshoeBundle>(), 1);
            recipe.AddIngredient(ItemID.BundleofBalloons, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.UltimateBundleOH>(), 1);
            recipe.AddIngredient(ModContent.ItemType<ExoticBundle>(), 1);
            recipe.AddIngredient(ModContent.ItemType<ObsidianHorseshoeBundle>(), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}