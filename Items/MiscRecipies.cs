using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BalloonsExtended.Items {
    internal class MiscRecipies : GlobalItem {
        public override void AddRecipes () {
            // Whoopee Cushion
            Recipe recipe = Recipe.Create(ItemID.WhoopieCushion, 1);
            recipe.AddIngredient(ItemID.BeachBall, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
