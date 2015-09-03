using System;
using UnityEngine;

namespace Application
{
	public class Board
	{
		private float blenderUnit = 1f;

		public Board ()
		{
		}

		public Vector3 positionForIndex(int row, int column) {
			float evenRowAdjustment = column % 2 == 0 ? 1f/2 : 0;
			float row3Adjustment = column == 2 ? -1f : 0;

			return new Vector3(row*blenderUnit + evenRowAdjustment + row3Adjustment,
			                   0,
			                   column * 0.87f);
		}
	}
}
