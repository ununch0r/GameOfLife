using GameOfLife._Utils;
using GameOfLife.Helpers;
using GameOfLife.Interfaces;
using System.Collections.Generic;
using System.Windows.Shapes;

namespace GameOfLife.DrawStrategies
{
	public class DrawGosperGliderRun : IDrawable
	{
		public void DrawGameField(List<List<Rectangle>> cells)
		{
			var centerIndex = DrawHelper.GetCenterIndex();

			cells[centerIndex - 5][centerIndex - 18].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 4][centerIndex - 18].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 5][centerIndex - 17].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 4][centerIndex - 17].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 7][centerIndex + 17].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 6][centerIndex + 17].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 7][centerIndex + 16].Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex - 6][centerIndex + 16].Fill = CommonVariables.LifeColorBrush;
			int offsetToShapeCenterX = -2;
			int offsetToShapeCenterY = -1;
			cells[centerIndex + offsetToShapeCenterX - 1][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX + 1][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX - 1][centerIndex + offsetToShapeCenterY]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX][centerIndex + offsetToShapeCenterY + 1]
				.Fill = CommonVariables.LifeColorBrush;
			offsetToShapeCenterX = 1;
			offsetToShapeCenterY = 18;
			cells[centerIndex + offsetToShapeCenterX - 1][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX + 1][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX - 1][centerIndex + offsetToShapeCenterY]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX][centerIndex + offsetToShapeCenterY + 1]
				.Fill = CommonVariables.LifeColorBrush;
			offsetToShapeCenterX = 6;
			offsetToShapeCenterY = 7;
			cells[centerIndex + offsetToShapeCenterX - 1][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX - 1][centerIndex + offsetToShapeCenterY]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX - 1][centerIndex + offsetToShapeCenterY + 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX + 1][centerIndex + offsetToShapeCenterY]
				.Fill = CommonVariables.LifeColorBrush;
			offsetToShapeCenterX = -4;
			offsetToShapeCenterY = -9;
			cells[centerIndex + offsetToShapeCenterX][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX][centerIndex + offsetToShapeCenterY + 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX + 1][centerIndex + offsetToShapeCenterY]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX - 1][centerIndex + offsetToShapeCenterY]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX + 1][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX - 1][centerIndex + offsetToShapeCenterY + 1]
				.Fill = CommonVariables.LifeColorBrush;
			offsetToShapeCenterX = -6;
			offsetToShapeCenterY = 5;
			cells[centerIndex + offsetToShapeCenterX][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX][centerIndex + offsetToShapeCenterY + 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX + 1][centerIndex + offsetToShapeCenterY]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX - 1][centerIndex + offsetToShapeCenterY]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX + 1][centerIndex + offsetToShapeCenterY - 1]
				.Fill = CommonVariables.LifeColorBrush;
			cells[centerIndex + offsetToShapeCenterX - 1][centerIndex + offsetToShapeCenterY + 1]
				.Fill = CommonVariables.LifeColorBrush;
		}
	}
}
