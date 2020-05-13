
using GameOfLife.DrawStrategies;

namespace GameOfLife.GameLogic.FigureDrawers
{
	public class GliderDrawer:GameFieldDrawer
	{
		public GliderDrawer()
		{
			HowIDraw = new DrawGlider();
		}
	}
}
