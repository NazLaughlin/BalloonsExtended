using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace BalloonsExtended.Items.Balloons{
    [AutoloadEquip(EquipType.Balloon)]
    public class YellowBalloonOH : ModItem{
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Yellow Balloon Type OH");
			Tooltip.SetDefault("Allows the holder to double jump" 
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
            player.hasJumpOption_Sandstorm = true;
            player.jumpBoost = true;
            player.noFallDmg = true;
            player.fireWalk = true;
        }

        public override void AddRecipes() 
		{
			Recipe recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.YellowBalloonOH>(), 1);
            recipe.AddIngredient(ItemID.SandstorminaBalloon, 1);
            recipe.AddIngredient(ItemID.ObsidianHorseshoe, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.YellowBalloonOH>(), 1);
            recipe.AddIngredient(ItemID.YellowHorseshoeBalloon, 1);
            recipe.AddIngredient(ItemID.ObsidianSkull, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
		}
    }
}
