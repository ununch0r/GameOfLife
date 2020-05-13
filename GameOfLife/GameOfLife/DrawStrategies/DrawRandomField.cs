using GameOfLife._Utils;
using GameOfLife.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Shapes;

namespace GameOfLife.DrawStrategies
{
	public class DrawRandomField : IDrawable
	{
		public void DrawGameField(List<List<Rectangle>> cells)
		{
			var randomizer = new Random();

			for (int i = 0; i < CommonVariables.Size; i++)
			{
				for (int j = 0; j < CommonVariables.Size; j++)
				{
					cells[i][j].Fill = randomizer.Next() % 2 == 0 ?
						CommonVariables.LifeColorBrush : CommonVariables.EmptinessColorBrush;
				}
			}
		}
	}
}
