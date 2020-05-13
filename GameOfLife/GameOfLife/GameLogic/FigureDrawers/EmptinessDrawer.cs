using GameOfLife.DrawStrategies;

namespace GameOfLife.GameLogic.FigureDrawers
{
	public class EmptinessDrawer : GameFieldDrawer
	{
		public EmptinessDrawer()
		{
			HowIDraw = new DrawEmptyField();
		}
	}
}
