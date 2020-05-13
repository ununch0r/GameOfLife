using GameOfLife.DrawStrategies;

namespace GameOfLife.GameLogic.FigureDrawers
{
	public class DiamondDrawer:GameFieldDrawer
	{
		public DiamondDrawer()
		{
			HowIDraw = new DrawDiamond();
		}
	}
}
