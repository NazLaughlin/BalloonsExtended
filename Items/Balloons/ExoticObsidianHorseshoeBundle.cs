using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace BalloonsExtended.Items.Balloons{
    [AutoloadEquip(EquipType.Balloon)]
    public class ExoticObsidianHorseshoeBundle : ModItem{
        public override void SetStaticDefaults() {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults() {
            Item.width = 14;
            Item.height = 28;
            Item.accessory = true;
            Item.value = 150000;
            Item.rare = ItemRarityID.Cyan;
		}
        public override void UpdateAccessory(Player player, bool hideVisual) {
			player.hasJumpOption_Cloud = true;
            player.hasJumpOption_Sandstorm = true;
            player.hasJumpOption_Blizzard = true;
            player.jumpBoost = true;
            player.noFallDmg = true;
            player.fireWalk = true;
        }
        public override void AddRecipes() 
		{
			Recipe recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.ExoticObsidianHorseshoeBundle>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Balloons.ExoticHorseshoeBundle>(), 1);
            recipe.AddIngredient(ItemID.ObsidianSkull, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.ExoticObsidianHorseshoeBundle>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Balloons.ExoticBundle>(), 1);
            recipe.AddIngredient(ItemID.ObsidianHorseshoe, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
    }
}
