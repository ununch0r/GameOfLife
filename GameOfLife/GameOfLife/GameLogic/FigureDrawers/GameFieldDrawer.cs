using System.Collections.Generic;
using System.Windows.Shapes;
using GameOfLife.Helpers;
using GameOfLife.Interfaces;

namespace GameOfLife.GameLogic.FigureDrawers
{
	public class GameFieldDrawer
	{
		protected IDrawable HowIDraw;
		public void Draw(List<List<Rectangle>> cells)
		{
			DrawHelper.DrawEmptyFiled(cells);
			HowIDraw.DrawGameField(cells);
		}
	}
}
