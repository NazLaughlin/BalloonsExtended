using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.Localization;

namespace BalloonsExtended.Items{
    [AutoloadEquip(EquipType.Balloon)]
    public class ObsidianHorseshoeBundle : ModItem{
        public override void SetStaticDefaults() {
			Tooltip.SetDefault("Allows triple jump, increases jump hight, and negates fall damage, and grants immunity to fire blocks.");
		}
        public override void SetDefaults() {
            item.width = 14;
            item.height = 28;
            item.accessory = true;
            item.value = 150000;
            item.rare = 10;
		}
        public override void UpdateAccessory(Player player, bool hideVisual) {
			player.doubleJumpCloud = true;
            player.doubleJumpSandstorm = true;
            player.doubleJumpBlizzard = true;
            player.jumpBoost = true;
            player.noFallDmg = true;
            player.fireWalk = true;
        }
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("HorseshoeBundle"), 1);
            recipe.AddIngredient(ItemID.ObsidianSkull, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BundleofBalloons, 1);
            recipe.AddIngredient(ItemID.ObsidianHorseshoe, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
