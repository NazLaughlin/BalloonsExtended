using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace BalloonsExtended.Items.Balloons{
    [AutoloadEquip(EquipType.Balloon)]
    public class ExoticHorseshoeBundle : ModItem{
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Exotic Horseshoe Bundle of Balloons");
			Tooltip.SetDefault("Allows the holder to triple jump,\n" +
                "Increases jump hight,\n" +
                "Negates fall damage,\n" +
                "and releases bees when damaged.");
		}
        public override void SetDefaults() {
            Item.width = 14;
            Item.height = 28;
            Item.accessory = true;
            Item.value = 150000;
            Item.rare = ItemRarityID.Cyan;
		}
        public override void UpdateAccessory(Player player, bool hideVisual) {
			player.hasJumpOption_Fart = true;
            player.hasJumpOption_Sail = true;
            player.honeyCombItem = Item;
            player.jumpBoost = true;
            player.noFallDmg = true;
        }

        public override void AddRecipes() 
		{
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod.Find<ModItem>("ExoticBundle").Type, 1);
            recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.BalloonHorseshoeHoney, 1);
            recipe.AddRecipeGroup("BalloonsExtended:FartBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:SharkronBalloons");
            recipe.Register();
            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.BalloonHorseshoeFart);
            recipe.AddRecipeGroup("BalloonsExtended:SharkronBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:HoneyBalloons");
            recipe.Register();
            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.BalloonHorseshoeSharkron);
            recipe.AddRecipeGroup("BalloonsExtended:HoneyBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:FartBalloons");
            recipe.Register();
        }
    }
}
