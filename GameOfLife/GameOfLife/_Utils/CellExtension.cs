using System.Windows.Shapes;

namespace GameOfLife._Utils
{
	public static class CellExtension
	{
		public static Rectangle Clone(this Rectangle cell)
		{
			if (cell != null)
			{
				var cellCopy = new Rectangle
				{
					Width = cell.Width,
					Height = cell.Height,
					Stroke = cell.Stroke,
					StrokeThickness = cell.StrokeThickness,
					Fill = cell.Fill
				};
				return cellCopy;
			}
			else
			{
				return cell;
			}
		}
	}
}
