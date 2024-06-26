using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.GameContent.Creative;

namespace BalloonsExtended.Items.Balloons{
    [AutoloadEquip(EquipType.Balloon)]
    public class ExoticHorseshoeBundle : ModItem{
        public override void SetStaticDefaults() {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults() {
            Item.width = 14;
            Item.height = 28;
            Item.accessory = true;
            Item.value = 150000;
            Item.rare = ItemRarityID.Yellow;
		}
        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetJumpState(ExtraJump.FartInAJar).Enable();
            player.GetJumpState(ExtraJump.TsunamiInABottle).Enable();
            player.honeyCombItem = Item;
            player.jumpBoost = true;
            player.noFallDmg = true;
        }

        public override void AddRecipes() 
		{
            Recipe recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.ExoticHorseshoeBundle>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Balloons.ExoticBundle>(), 1);
            recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.ExoticHorseshoeBundle>(), 1);
            recipe.AddIngredient(ItemID.BalloonHorseshoeHoney, 1);
            recipe.AddRecipeGroup("BalloonsExtended:FartBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:SharkronBalloons");
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.ExoticHorseshoeBundle>(), 1);
            recipe.AddIngredient(ItemID.BalloonHorseshoeFart);
            recipe.AddRecipeGroup("BalloonsExtended:SharkronBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:HoneyBalloons");
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.ExoticHorseshoeBundle>(), 1);
            recipe.AddIngredient(ItemID.BalloonHorseshoeSharkron);
            recipe.AddRecipeGroup("BalloonsExtended:HoneyBalloons");
            recipe.AddRecipeGroup("BalloonsExtended:FartBalloons");
            recipe.Register();
        }
    }
}
