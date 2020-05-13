using GameOfLife.Constants;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using GameOfLife._Utils;
using GameOfLife.GameLogic;
using GameOfLife.Helpers;

namespace GameOfLife
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private List<List<Rectangle>> _cells;
		public MainWindow()
		{
			InitializeComponent();
			InitializeTimer();
			Initializer.InitializeDrawer();
			Initializer.InitializeSizeSlider(SizeSlider);
			Initializer.InitializeIntervalSlider(IntervalSlider);
			Initializer.InitializeFiguresComboBox(FiguresComboBox);
		}

		private void InitializeGameFiled()
		{
			DrawHelper.DrawEmptyFiled(_cells);
			for (var i = 0; i < CommonVariables.Size; ++i)
			{
				for (var j = 0; j < CommonVariables.Size; ++j)
				{
					Canvas.SetLeft(_cells[i][j], _cells[i][j].Width * j);
					Canvas.SetTop(_cells[i][j], _cells[i][j].Height * i);
					GameField.Children.Add(_cells[i][j]);
				}
			}
		}

		private void InitializeTimer()
		{
			CommonVariables.Timer = new System.Windows.Threading.DispatcherTimer
			{
				Interval = TimeSpan.FromMilliseconds(ValueConstants.DefaultInterval)
			};
			CommonVariables.Timer.Tick += Timer_Tick;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			Algorithms.NextIterationGridCalculate(_cells);
			IterationLabel.Content = CommonVariables.Iteration;
		}
		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			var cellSideLength = GetCellSideLength();
			_cells = CellHelper.InitializeCells(cellSideLength,
				CommonVariables.Size);
			InitializeGameFiled();
		}

		private void SizeSlider_ValueChanged(object sender,
			RoutedPropertyChangedEventArgs<double> e)
		{
			CommonVariables.Size = Convert.ToInt32(SizeSlider.Value);
			GameField.Children.Clear();
			var cellSideLength = GetCellSideLength();
			_cells = CellHelper.InitializeCells(cellSideLength,
				CommonVariables.Size);
			InitializeGameFiled();
		}

		private void IntervalSlider_ValueChanged(object sender,
			RoutedPropertyChangedEventArgs<double> e)
		{
			var boundariesSum = ValueConstants.MaxInterval + ValueConstants.MinInterval;
			CommonVariables.TimerInterval = boundariesSum - Convert.ToInt32(IntervalSlider.Value);
			CommonVariables.Timer.Interval = TimeSpan.FromMilliseconds(CommonVariables.TimerInterval);
		}

		private void StartButton_Click(object sender, RoutedEventArgs e)
		{
			StartButton.Visibility = Visibility.Hidden;
			StopButton.Visibility = Visibility.Visible;
			SizeSlider.IsEnabled = false;
			NextButton.IsEnabled = false;

			CommonVariables.Timer.Start();
		}

		private void StopButton_Click(object sender, RoutedEventArgs e)
		{
			CommonVariables.Timer.Stop();

			StopButton.Visibility = Visibility.Hidden;
			StartButton.Visibility = Visibility.Visible;
			SizeSlider.IsEnabled = true;
			NextButton.IsEnabled = true;
		}

		private void NextButton_Click(object sender, RoutedEventArgs e)
		{
			Algorithms.NextIterationGridCalculate(_cells);
			IterationLabel.Content = CommonVariables.Iteration;
		}

		private void GameField_OnMouseLeftButtonDown(object sender,
			MouseButtonEventArgs e)
		{
			var cursorPosition = Mouse.GetPosition(GameField);
			var cellSideLength = GetCellSideLength();
			var columnIndex = (int)(cursorPosition.X / cellSideLength);
			var rowIndex = (int)(cursorPosition.Y / cellSideLength);
			var cell = _cells[rowIndex][columnIndex];

			cell.Fill = cell.Fill == CommonVariables.EmptinessColorBrush ?
				CommonVariables.LifeColorBrush : CommonVariables.EmptinessColorBrush;
		}

		private double GetCellSideLength()
		{
			var cellSideLength = (GameField.ActualHeight / CommonVariables.Size);
			return cellSideLength;
		}

		private void FiguresComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			CommonVariables.Iteration = 0;
			IterationLabel.Content = CommonVariables.Iteration;
			try
			{
				CommonVariables.Drawers[FiguresComboBox.SelectedIndex].Draw(_cells);
			}
			catch (ArgumentOutOfRangeException exception)
			{
				DrawHelper.DrawEmptyFiled(_cells);
				MessageBox.Show(StringConstants.TooSmallGameFieldMessage);
			}

		}

		private void ColorButton_OnClick(object sender, RoutedEventArgs e)
		{
			var clickedButton = sender as Button;
			if (clickedButton?.Content?.ToString() == StringConstants.RandomColorButtonContent)
			{
				var randomizer = new Random();
				var randomColor = new SolidColorBrush(Color.FromRgb((byte)randomizer
						.Next(ValueConstants.MinColorRandomValue, ValueConstants.MaxColorRandomValue),
					(byte)randomizer
						.Next(ValueConstants.MinColorRandomValue, ValueConstants.MaxColorRandomValue),
					(byte)randomizer
						.Next(ValueConstants.MinColorRandomValue, ValueConstants.MaxColorRandomValue)));
				clickedButton.Background = randomColor;
			}
			CommonVariables.LifeColorBrush = clickedButton?.Background;
			DrawHelper.RedrawFiled(_cells);
		}
	}
}
