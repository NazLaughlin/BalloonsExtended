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
            player.doubleJumpCloud = true;
            player.doubleJumpSandstorm = true;
            player.doubleJumpBlizzard = true;
            player.honeyCombItem = Item;
            player.jumpBoost = true;
            player.noFallDmg = true;
        }

        public override void AddRecipes () {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod.Find<ModItem>("UltimateBundle").Type, 1);
            recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.Register();
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod.Find<ModItem>("ExoticHorseshoeBundle").Type, 1);
            recipe.AddIngredient(ItemID.BundleofBalloons, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.Register();
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod.Find<ModItem>("ExoticBundle").Type, 1);
            recipe.AddIngredient(Mod.Find<ModItem>("HorseshoeBundle").Type, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.Register();
        }
    }
}