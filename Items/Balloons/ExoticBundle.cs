using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.GameContent.Creative;

namespace BalloonsExtended.Items.Balloons{
    [AutoloadEquip(EquipType.Balloon)]
    public class ExoticBundle : ModItem{
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
        }

        public override void AddRecipes() 
		{
			Recipe recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.ExoticBundle>(), 1);
            recipe.AddIngredient(ItemID.SharkronBalloon, 1);
            recipe.AddIngredient(ItemID.HoneyBalloon, 1);
            recipe.AddIngredient(ItemID.FartInABalloon, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
    }
}
