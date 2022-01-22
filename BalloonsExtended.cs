using Terraria.ModLoader;
using Terraria;
using Terraria.Localization;
using Terraria.ID;

namespace BalloonsExtended
{
	public class BalloonsExtended : Mod
	{
		// The Terraria.Localization using directive (using Terraria.Localization;) is required for Language methods.
        public override void AddRecipeGroups()
        {
            RecipeGroup blizzardBalloons = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Blue Balloon", new int[]
            {
                ItemID.BlizzardinaBalloon,
				ItemID.BlueHorseshoeBalloon,
            });
            RecipeGroup.RegisterGroup("BalloonsExtended:BlizzardBalloons", blizzardBalloons);

            RecipeGroup sandBalloons = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Yellow Balloon", new int[]
            {
                ItemID.SandstorminaBalloon,
				ItemID.YellowHorseshoeBalloon,
            });
            RecipeGroup.RegisterGroup("BalloonsExtended:SandBalloons", sandBalloons);

            RecipeGroup cloudBalloons = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " White Balloon", new int[]
            {
                ItemID.CloudinaBalloon,
				ItemID.WhiteHorseshoeBalloon,
            });
            RecipeGroup.RegisterGroup("BalloonsExtended:CloudBalloons", cloudBalloons);
        }
	}
}