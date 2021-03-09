using System;

namespace MathLibrary
{
	public struct Vector2
	{
		public float x;
		public float y;

		// Constructors
		public Vector2(float x = 0.0f, float y = 0.0f)
		{
			this.x = x;
			this.y = y;
		}

		// operator overloading
		// V = V + V
		public static Vector2 operator + (Vector2 rhs, Vector2 lhs)
		{
			Vector2 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;

			return result;
		}

		// V = V - V
		public static Vector2 operator - (Vector2 rhs, Vector2 lhs)
		{
			Vector2 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;

			return result;
		}

		// V = V * f
		public static Vector2 operator * (Vector2 lhs, float rhs)
		{
			Vector2 result;

			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;

			return result;
		}

		// V = f * V
		public static Vector2 operator * (float lhs, Vector2 rhs)
		{
			Vector2 result;

			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;

			return result;
		}

		// f = V.Magnitude
		public float Magnitude()
		{
			return (float)Math.Sqrt((x * x) + (y * y));
		}
	}
}
