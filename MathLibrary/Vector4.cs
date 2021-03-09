using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
	struct Vector4
	{
		public float x;
		public float y;
		public float z;
		public float w;

		// Constructors
		public Vector4(float x = 0.0f, float y = 0.0f, float z = 0.0f, float w = 0.0f)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;

		}

		// operator overloading
		// V = V + V
		public static Vector4 operator +(Vector4 rhs, Vector4 lhs)
		{
			Vector4 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;
			result.z = lhs.z + rhs.z;
			result.w = lhs.w + rhs.w;


			return result;
		}

		// V = V - V
		public static Vector4 operator -(Vector4 rhs, Vector4 lhs)
		{
			Vector4 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;
			result.z = lhs.z - rhs.z;
			result.w = lhs.w - rhs.w;

			return result;
		}

		// V = V * f
		public static Vector4 operator *(Vector4 lhs, float rhs)
		{
			Vector4 result;

			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;
			result.z = lhs.z * rhs;
			result.w = lhs.w * rhs;

			return result;
		}

		// V = f * V
		public static Vector4 operator *(float lhs, Vector4 rhs)
		{
			Vector4 result;

			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;
			result.z = lhs * rhs.z;
			result.w = lhs * rhs.w;

			return result;
		}

		// f = V.Magnitude
		public float Magnitude()
		{
			return (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w);
		}

		// normalise
		public void Normalise()
		{
			float magnitude = Magnitude();
			if (magnitude != 0)
			{
				x /= magnitude;
				y /= magnitude;
				z /= magnitude;
				w /= magnitude;
			}
		}
	}
}
