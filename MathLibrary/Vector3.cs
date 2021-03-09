using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
	struct Vector3
	{
		public float x;
		public float y;

		// Constructors
		public Vector3(float x = 0.0f, float y = 0.0f)
		{
			this.x = x;
			this.y = y;
		}

		// operator overloading
		// V = V + V
		public static Vector3 operator +(Vector3 rhs, Vector3 lhs)
		{
			Vector3 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;

			return result;
		}

		// V = V - V
		public static Vector3 operator -(Vector3 rhs, Vector3 lhs)
		{
			Vector3 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;

			return result;
		}

		// V = V * f
		public static Vector3 operator *(Vector3 lhs, float rhs)
		{
			Vector3 result;

			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;

			return result;
		}

		// V = f * V
		public static Vector3 operator *(float lhs, Vector3 rhs)
		{
			Vector3 result;

			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;

			return result;
		}
	}
}
