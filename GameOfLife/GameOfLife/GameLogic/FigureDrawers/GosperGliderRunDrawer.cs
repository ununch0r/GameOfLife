using GameOfLife.DrawStrategies;

namespace GameOfLife.GameLogic.FigureDrawers
{
	public class GosperGliderRunDrawer:GameFieldDrawer
	{
		public GosperGliderRunDrawer()
		{
			HowIDraw = new DrawGosperGliderRun();
		}
	}
}
