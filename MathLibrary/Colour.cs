using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
	class Colour
	{
		private uint colour = 0;

		private Colour(byte red, byte green, byte blue, byte alpha)
		{
			colour = (uint)((red << 24) | (green << 16) | (blue << 8) | alpha);
		}

		public void SetRed(byte red)
		{
			colour = colour & 0x00FFFFFF;
			colour = colour | (uint)(red << 24);
		}

		public void GetRed()
		{
			return (byte)(colour >> 24);
		}

		public void GetGreen()
		{
			return (byte)((colour << 8) >> 24);
		}

		public void GetBlue()
		{
			return (byte)(((colour >> 8) << 16) >> 24);
		}
	}
}
