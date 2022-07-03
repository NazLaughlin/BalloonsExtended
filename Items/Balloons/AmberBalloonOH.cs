using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace BalloonsExtended.Items.Balloons{
    [AutoloadEquip(EquipType.Balloon)]
    public class AmberBalloonOH : ModItem{
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Amber Balloon Type OH");
			Tooltip.SetDefault("Releases Bees when damaged" 
                + "\n Increases jump height and negates fall damage"
                + "\n Grants immunity to fire blocks");
		}
        public override void SetDefaults() {
            Item.width = 20;
            Item.height = 22;
            Item.accessory = true;
            Item.value = 45000;
            Item.rare = ItemRarityID.Pink;
		}
        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.honeyCombItem = Item;
            player.jumpBoost = true;
            player.noFallDmg = true;
            player.fireWalk = true;
        }

        public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HoneyBalloon, 1);
            recipe.AddIngredient(ItemID.ObsidianHorseshoe, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.BalloonHorseshoeHoney, 1);
            recipe.AddIngredient(ItemID.ObsidianSkull, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
		}
    }
}
