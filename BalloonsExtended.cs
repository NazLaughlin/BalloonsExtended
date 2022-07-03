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

            RecipeGroup honeyBalloons = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Honey Balloon", new int[]
            {
                ItemID.HoneyBalloon,
                ItemID.BalloonHorseshoeHoney,
            });
            RecipeGroup.RegisterGroup("BalloonsExtended:HoneyBalloons", honeyBalloons);

            RecipeGroup fartBalloons = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Fart Balloon", new int[]
            {
                ItemID.FartInABalloon,
                ItemID.BalloonHorseshoeFart,
            });
            RecipeGroup.RegisterGroup("BalloonsExtended:FartBalloons", fartBalloons);

            RecipeGroup sharkronBalloons = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Sharkron Balloon", new int[]
            {
                ItemID.SharkronBalloon,
                ItemID.BalloonHorseshoeSharkron,
            });
            RecipeGroup.RegisterGroup("BalloonsExtended:SharkronBalloons", sharkronBalloons);
        }
	}
}