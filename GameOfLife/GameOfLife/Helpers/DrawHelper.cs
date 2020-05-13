using GameOfLife._Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Shapes;

namespace GameOfLife.Helpers
{
	public static class DrawHelper
	{
		public static void DrawEmptyFiled(List<List<Rectangle>> cells)
		{
			foreach (var cell in cells.SelectMany(row => row))
			{
				cell.Fill = CommonVariables.EmptinessColorBrush;
			}
		}

		public static void RedrawFiled(List<List<Rectangle>> cells)
		{
			foreach (var cell in cells.SelectMany(rows => rows
				.Where(cell => cell.Fill != CommonVariables.EmptinessColorBrush)))
			{
				cell.Fill = CommonVariables.LifeColorBrush;
			}
		}

		public static int GetCenterIndex() => (int)Math
			.Round(CommonVariables.Size / 2.0, 0, MidpointRounding.AwayFromZero);
	}
}
