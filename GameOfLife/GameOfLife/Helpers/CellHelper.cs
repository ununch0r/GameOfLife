using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Shapes;
using GameOfLife._Utils;

namespace GameOfLife.Helpers
{
	public static class CellHelper
	{
		public static List<List<Rectangle>> InitializeCells(double sideLength, int size)
		{
			var cells = new List<List<Rectangle>>();
			for (var i = 0; i < size; ++i)
			{
				cells.Add(new List<Rectangle>());
				for (var j = 0; j < size; ++j)
				{
					var cell = CreateCell(sideLength);
					cells[i].Add(cell);
				}
			}
			return cells;
		}

		public static Rectangle CreateCell(double sideLength)
		{
			var cell = new Rectangle
			{
				Width = sideLength,
				Height = sideLength,
				Stroke = new SolidColorBrush(Colors.White),
				StrokeThickness = 0.3,
			};
			return cell;
		}

		public static List<List<Rectangle>> CopyCells(List<List<Rectangle>> cells)
		{
			var copyCells = new List<List<Rectangle>>();
			for (var i = 0; i < CommonVariables.Size; ++i)
			{
				copyCells.Add(new List<Rectangle>());
				for (var j = 0; j < CommonVariables.Size; ++j)
				{
					copyCells[i].Add(cells[i][j].Clone());
				}
			}
			return copyCells;
		}
	}
}
