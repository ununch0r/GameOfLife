using System.Collections.Generic;
using System.Windows.Shapes;

namespace GameOfLife.Interfaces
{
	public interface IDrawable
	{
		void DrawGameField(List<List<Rectangle>> cells);
	}
}
