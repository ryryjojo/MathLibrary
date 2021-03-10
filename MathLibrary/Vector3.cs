using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
	struct Vector3
	{
		public float x;
		public float y;
		public float z;


		// Constructors
		public Vector3(float x = 0.0f, float y = 0.0f, float z = 0.0f)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		// operator overloading
		// V = V + V
		public static Vector3 operator +(Vector3 rhs, Vector3 lhs)
		{
			Vector3 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;
			result.z = lhs.z + rhs.z;

			return result;
		}

		// V = V - V
		public static Vector3 operator -(Vector3 rhs, Vector3 lhs)
		{
			Vector3 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;
			result.z = lhs.z - rhs.z;

			return result;
		}

		// V = V * f
		public static Vector3 operator *(Vector3 lhs, float rhs)
		{
			Vector3 result;

			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;
			result.z = lhs.z * rhs;

			return result;
		}

		// V = f * V
		public static Vector3 operator *(float lhs, Vector3 rhs)
		{
			Vector3 result;

			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;
			result.z = lhs * rhs.z;

			return result;
		}

		// f = V.Magnitude
		public float Magnitude()
		{
			return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
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
			}
		}

		public float Dot(Vector3 rhs)
		{
			return (x * rhs.x) + (y * rhs.y) + (z + rhs.z);
		}

		public Vector3 Cross(Vector3 rhs)
		{
			result.x = (y * rhs.z) - (z * rhs.y);
			result.y = (z * rhs.x) - (x * rhs.z);
			result.z = (x * rhs.y) - (y * rhs.x);

			return result;
		}
	}
}
