using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace BalloonsExtended.Items{
    [AutoloadEquip(EquipType.Balloon)]
    public class HorseshoeBundle : ModItem{
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Bundle of Balloons Type H");
			Tooltip.SetDefault("Allows quad jump, increases jump hight, and negates fall damage.");
		}
        public override void SetDefaults() {
            item.width = 14;
            item.height = 28;
            item.accessory = true;
            item.value = 150000;
            item.rare = 9;
		}
        public override void UpdateAccessory(Player player, bool hideVisual) {
			player.doubleJumpCloud = true;
            player.doubleJumpSandstorm = true;
            player.doubleJumpBlizzard = true;
            player.jumpBoost = true;
            player.noFallDmg = true;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BundleofBalloons, 1);
            recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BlueHorseshoeBalloon);
            recipe.AddRecipeGroup("BalloonsExtended:SandBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:CloudBalloons");
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.YellowHorseshoeBalloon);
            recipe.AddRecipeGroup("BalloonsExtended:BlizzardBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:CloudBalloons");
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WhiteHorseshoeBalloon);
            recipe.AddRecipeGroup("BalloonsExtended:SandBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:BlizzardBalloons");
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}
