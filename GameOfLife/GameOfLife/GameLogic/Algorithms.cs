using System.Collections.Generic;
using System.Windows.Shapes;
using GameOfLife._Utils;
using GameOfLife.Constants;
using GameOfLife.Helpers;

namespace GameOfLife.GameLogic
{
	public class Algorithms
	{
		public static void NextIterationGridCalculate(List<List<Rectangle>> cells)
		{
			var copyCells = CellHelper.CopyCells(cells);
			for (var i = 0; i < CommonVariables.Size; ++i)
			{
				for (var j = 0; j < CommonVariables.Size; ++j)
				{
					var numberOfNeighbors = CountNeighbors(copyCells, i, j);
					var presentState = (copyCells[i][j].Fill
										== CommonVariables.LifeColorBrush);
					cells[i][j].Fill = IsAliveInNextIteration(numberOfNeighbors, presentState)
						? CommonVariables.LifeColorBrush : CommonVariables.EmptinessColorBrush;
				}
			}

			CommonVariables.Iteration++;
		}

		private static bool IsAliveInNextIteration(int neighborCount, bool presentState)
		{
			if (neighborCount < ValueConstants.MinNeighborsCountToLive
				|| neighborCount > ValueConstants.MaxNeighborsCountToLive)
			{
				return false;
			}

			return neighborCount == ValueConstants.NeighborsCountToBorn || presentState;
		}

		private static int CountNeighbors(IReadOnlyList<List<Rectangle>> cells, int currentRow, int currentColumn)
		{
			var neighborsCount = 0;
			for (var i = -1; i < 2; ++i)
			{
				for (var j = -1; j < 2; ++j)
				{
					var row = (currentRow + i + CommonVariables.Size) % CommonVariables.Size;
					var column = (currentColumn + j + CommonVariables.Size) % CommonVariables.Size;
					var isTempCellAlive = cells[row][column].Fill
										   == CommonVariables.LifeColorBrush;
					if (isTempCellAlive)
					{
						neighborsCount++;
					}
				}
			}

			var isCurrentCellAlive = cells[currentRow][currentColumn].Fill
									  == CommonVariables.LifeColorBrush;
			if (isCurrentCellAlive)
			{
				neighborsCount--;
			}

			return neighborsCount;
		}
	}
}

