using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.GameContent.ItemDropRules;

namespace BalloonsExtended.Items
{
    public class BossBags : GlobalItem
    {
        public override void ModifyItemLoot (Item item, ItemLoot itemLoot) {
            if(item.type == ItemID.EyeOfCthulhuBossBag)
            {
                itemLoot.Add(ItemDropRule.Common(ItemID.ShinyRedBalloon, 4, 1, 1));
            }
        }
    }
}