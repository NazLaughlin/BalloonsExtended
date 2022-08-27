using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace BalloonsExtended
{
    public class BalloonGlobalNPC : GlobalNPC
    {
        public override void ModifyNPCLoot (NPC npc, NPCLoot npcLoot) {
            if(npc.type == NPCID.EyeofCthulhu)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());
                notExpertRule.OnSuccess(ItemDropRule.Common(ItemID.ShinyRedBalloon, 4, 1, 1));
            }
        }
    } 
}