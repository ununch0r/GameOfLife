using GameOfLife.DrawStrategies;

namespace GameOfLife.GameLogic.FigureDrawers
{
	public class RandomDrawer:GameFieldDrawer
	{
		public RandomDrawer()
		{
			HowIDraw = new DrawRandomField();	
		}
	}
}
