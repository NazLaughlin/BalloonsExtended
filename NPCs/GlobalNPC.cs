using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BalloonsExtended
{
    public class BalloonGlobalNPC : GlobalNPC
    {
        public override void OnKill(NPC npc){
            if (npc.type == NPCID.EyeofCthulhu && !Main.expertMode && Main.rand.Next(1,4) == 3) {
				Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ItemID.ShinyRedBalloon, 1);
			}
        }
    } 
}