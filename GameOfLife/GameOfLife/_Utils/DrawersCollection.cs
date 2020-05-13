using GameOfLife.GameLogic.FigureDrawers;
using System.Collections;
using System.Collections.Generic;

namespace GameOfLife._Utils
{
	public class DrawersCollection : IEnumerable
	{
		private List<GameFieldDrawer> _drawers = new List<GameFieldDrawer>();

		public GameFieldDrawer this[int i]
		{
			get => _drawers[i];
			set => _drawers[i] = value;
		}

		public void Add(GameFieldDrawer drawer) => _drawers.Add(drawer);

		public void RemoveAt(int index) => _drawers.RemoveAt(index);

		public void AddRange(IEnumerable<GameFieldDrawer> drawers) => _drawers.AddRange(drawers);

		public int Count => _drawers.Count;

		IEnumerator IEnumerable.GetEnumerator() => _drawers.GetEnumerator();
	}
}
