using System.Collections.Generic;
using System.Windows.Media;
using GameOfLife.Constants;
using GameOfLife.GameLogic;

namespace GameOfLife._Utils
{
	public static class CommonVariables
	{
		public static int Size { get; set; } = ValueConstants.DefaultFieldSize;
		public static System.Windows.Threading.DispatcherTimer Timer { get; set; }
		public static int Iteration { get; set; } = 0;
		public static int TimerInterval { get; set; } = ValueConstants.DefaultInterval;
		public static DrawersCollection Drawers { get; set; } = new DrawersCollection();

		public static Brush LifeColorBrush = Brushes.LimeGreen;
		public static Brush EmptinessColorBrush = Brushes.Gray;
	}
}
