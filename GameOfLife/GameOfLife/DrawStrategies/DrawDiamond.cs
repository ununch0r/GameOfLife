using GameOfLife._Utils;
using GameOfLife.Helpers;
using GameOfLife.Interfaces;
using System.Collections.Generic;
using System.Windows.Shapes;

namespace GameOfLife.DrawStrategies
{
	public class DrawDiamond : IDrawable
	{
		public void DrawGameField(List<List<Rectangle>> cells)
		{
			var centerIndex = DrawHelper.GetCenterIndex();

			cells[centerIndex - 3][centerIndex].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + 4][centerIndex].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 3][centerIndex + 1].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + 4][centerIndex + 1].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 2][centerIndex + 2].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + 3][centerIndex + 2].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 2][centerIndex - 1].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + 3][centerIndex - 1].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 1][centerIndex - 2].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + 2][centerIndex - 2].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 1][centerIndex + 3].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + 2][centerIndex + 3].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex][centerIndex + 4].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + 1][centerIndex + 4].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex][centerIndex - 3].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + 1][centerIndex - 3].Fill = CommonVariables.LifeColorBrush;
		}
	}
}
