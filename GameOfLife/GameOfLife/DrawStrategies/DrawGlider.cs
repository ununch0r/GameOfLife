using GameOfLife._Utils;
using GameOfLife.Helpers;
using GameOfLife.Interfaces;
using System.Collections.Generic;
using System.Windows.Shapes;

namespace GameOfLife.DrawStrategies
{
	public class DrawGlider:IDrawable
	{
		public void DrawGameField(List<List<Rectangle>> cells)
		{
			var centerIndex = DrawHelper.GetCenterIndex();

			cells[centerIndex - 1][centerIndex].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex][centerIndex + 1].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + 1][centerIndex + 1].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + 1][centerIndex].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + 1][centerIndex -1].Fill = CommonVariables.LifeColorBrush;
		}
	}
}
