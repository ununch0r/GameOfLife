using GameOfLife.DrawStrategies;

namespace GameOfLife.GameLogic.FigureDrawers
{
	public class LightWeightSpaceShipDrawer:GameFieldDrawer
	{
		public LightWeightSpaceShipDrawer()
		{
			HowIDraw = new DrawLightweightSpaceship();
		}
	}
}
