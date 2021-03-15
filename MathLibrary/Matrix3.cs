using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
	struct Matrix3
	{
		public float[] m;

		public Matrix3(bool bDefault = true)
		{
			m = new float[9];
			m[0] = 1;
			m[0] = 0;
			m[0] = 0;
			m[0] = 0;
			m[0] = 1;
			m[0] = 0;
			m[0] = 0;
			m[0] = 0;
			m[0] = 1;
		}

		public Matrix3(float m0, float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, )
		{
			m = new float[9];
			m[0] = m0;
			m[0] = m1;
			m[0] = m2;
			m[0] = m3;
			m[0] = m4;
			m[0] = m5;
			m[0] = m6;
			m[0] = m7;
			m[0] = m8;
		}

		public static Vector3 operator*(Matrix3 lhs, Vector3 rhs)
		{
			Vector3 result;
			result.x = (lhs.m[0] * rhs.x) + (lhs.m[3] * rhs.y) + (lhs.m[6] * rhs.z);
			result.y = (lhs.m[1] * rhs.x) + (lhs.m[4] * rhs.y) + (lhs.m[7] * rhs.z);
			result.z = (lhs.m[2] * rhs.x) + (lhs.m[5] * rhs.y) + (lhs.m[8] * rhs.z);

			return result;
		}

		public static Matrix3 operator*(Matrix3 lhs, Matrix3 rhs)
		{
			Matrix3 result = new Matrix3();

			result.m[0] = (lhs.m[0] * rhs.m[0]) + (lhs.m[3] * rhs.m[1]) + (lhs.m[6] * rhs.m[2]);
			result.m[1] = (lhs.m[1] * rhs.m[0]) + (lhs.m[4] * rhs.m[1]) + (lhs.m[7] * rhs.m[2]);
			result.m[2] = (lhs.m[2] * rhs.m[0]) + (lhs.m[5] * rhs.m[1]) + (lhs.m[8] * rhs.m[2]);
			result.m[3] = (lhs.m[0] * rhs.m[3]) + (lhs.m[3] * rhs.m[4]) + (lhs.m[6] * rhs.m[5]);
			result.m[4] = (lhs.m[1] * rhs.m[3]) + (lhs.m[4] * rhs.m[4]) + (lhs.m[7] * rhs.m[5]);
			result.m[5] = (lhs.m[2] * rhs.m[3]) + (lhs.m[5] * rhs.m[4]) + (lhs.m[8] * rhs.m[5]);
			result.m[6] = (lhs.m[0] * rhs.m[6]) + (lhs.m[3] * rhs.m[7]) + (lhs.m[6] * rhs.m[8]);
			result.m[7] = (lhs.m[1] * rhs.m[6]) + (lhs.m[4] * rhs.m[7]) + (lhs.m[7] * rhs.m[8]);
			result.m[8] = (lhs.m[2] * rhs.m[6]) + (lhs.m[5] * rhs.m[7]) + (lhs.m[8] * rhs.m[8]);

			return result;
		}
	}
}
