using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace BalloonsExtended.Items.Balloons{
    [AutoloadEquip(EquipType.Balloon)]
    public class HorseshoeBundle : ModItem{
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Bundle of Balloons Type H");
			Tooltip.SetDefault("Allows quad jump, increases jump hight, and negates fall damage.");
		}
        public override void SetDefaults() {
            Item.width = 14;
            Item.height = 28;
            Item.accessory = true;
            Item.value = 150000;
            Item.rare = ItemRarityID.Yellow;
		}
        public override void UpdateAccessory(Player player, bool hideVisual) {
			player.hasJumpOption_Cloud = true;
            player.hasJumpOption_Sandstorm = true;
            player.hasJumpOption_Blizzard = true;
            player.jumpBoost = true;
            player.noFallDmg = true;
        }

        public override void AddRecipes() 
		{
			Recipe recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.HorseshoeBundle>(), 1);
            recipe.AddIngredient(ItemID.BundleofBalloons, 1);
            recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.HorseshoeBundle>(), 1);
            recipe.AddIngredient(ItemID.BlueHorseshoeBalloon);
            recipe.AddRecipeGroup("BalloonsExtended:SandBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:CloudBalloons");
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.HorseshoeBundle>(), 1);
            recipe.AddIngredient(ItemID.YellowHorseshoeBalloon);
            recipe.AddRecipeGroup("BalloonsExtended:BlizzardBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:CloudBalloons");
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.HorseshoeBundle>(), 1);
            recipe.AddIngredient(ItemID.WhiteHorseshoeBalloon);
            recipe.AddRecipeGroup("BalloonsExtended:SandBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:BlizzardBalloons");
            recipe.Register();
		}
    }
}
