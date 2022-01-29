using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace BalloonsExtended.Items.Balloons{
    [AutoloadEquip(EquipType.Balloon)]
    public class PinkBalloonOH : ModItem{
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Pink Balloon Type OH");
			Tooltip.SetDefault("Allows the holder to double jump" 
                + "\n Increases jump height and negates fall damage"
                + "\n Grants immunity to fire blocks");
		}
        public override void SetDefaults() {
            item.width = 20;
            item.height = 22;
            item.accessory = true;
            item.value = 45000;
            item.rare = 5;
		}
        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.doubleJumpSail = true;
            player.jumpBoost = true;
            player.noFallDmg = true;
            player.fireWalk = true;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SharkronBalloon, 1);
            recipe.AddIngredient(ItemID.ObsidianHorseshoe, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BalloonHorseshoeSharkron, 1);
            recipe.AddIngredient(ItemID.ObsidianSkull, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}
