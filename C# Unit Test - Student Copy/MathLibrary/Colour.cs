using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
	class Colour
	{
		private uint colour = 0;

		public Colour(byte red, byte green, byte blue, byte alpha)
		{
			colour = (uint)((red << 24) | (green << 16) | (blue << 8) | alpha);
		}

		public void SetRed(byte red)
		{
			colour = colour & 0x00FFFFFF;
			colour = colour | (uint)(red << 24);
		}

		public byte GetRed()
		{
			return (byte)(colour >> 24);
		}

		public byte GetGreen()
		{
			return (byte)((colour << 8) >> 24);
		}

		public byte GetBlue()
		{
			return (byte)(((colour >> 8) << 16) >> 24);
		}
	}
}
