using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.GameContent.Creative;

namespace BalloonsExtended.Items.Balloons{
    [AutoloadEquip(EquipType.Balloon)]
    public class AmberBalloonOH : ModItem{
        public override void SetStaticDefaults() {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
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
            Recipe recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.AmberBalloonOH>(), 1);
            recipe.AddIngredient(ItemID.HoneyBalloon, 1);
            recipe.AddIngredient(ItemID.ObsidianHorseshoe, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
            recipe = Recipe.Create(ModContent.ItemType<Items.Balloons.AmberBalloonOH>(), 1);
            recipe.AddIngredient(ItemID.BalloonHorseshoeHoney, 1);
            recipe.AddIngredient(ItemID.ObsidianSkull, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
		}
    }
}
