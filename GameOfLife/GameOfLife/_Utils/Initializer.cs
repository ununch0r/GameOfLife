using System.Collections.Generic;
using System.Windows.Controls;
using GameOfLife.Constants;
using GameOfLife.GameLogic;
using GameOfLife.GameLogic.FigureDrawers;

namespace GameOfLife._Utils
{
	public static class Initializer
	{
		public static void InitializeFiguresComboBox(ComboBox figuresComboBox)
		{
			foreach (var drawerName in CommonVariables.Drawers)
			{
				figuresComboBox.Items
					.Add(drawerName.GetType().Name.Replace("Drawer",""));
			}
		}

		public static void InitializeSizeSlider(Slider sizeSlider)
		{
			sizeSlider.Minimum = ValueConstants.MinFieldSize;
			sizeSlider.Maximum = ValueConstants.MaxFieldSize;
			sizeSlider.Value = ValueConstants.DefaultFieldSize;
		}

		public static void InitializeIntervalSlider(Slider speedSlider)
		{
			speedSlider.Minimum = ValueConstants.MinInterval;
			speedSlider.Maximum = ValueConstants.MaxInterval;
			speedSlider.Value = ValueConstants.DefaultInterval;
		}

		public static void InitializeDrawer()
		{
			CommonVariables.Drawers.AddRange(new List<GameFieldDrawer>
			{
				new EmptinessDrawer(),
				new RandomDrawer(),
				new GliderDrawer(),
				new GosperGliderRunDrawer(),
				new LightWeightSpaceShipDrawer(),
				new DiamondDrawer()
			});
		}
	}
}
