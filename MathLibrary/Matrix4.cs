using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
	public struct Matrix4
	{
		//public float[] m;
		public float m1;
		public float m2;
		public float m3;
		public float m4;
		public float m5;
		public float m6;
		public float m7;
		public float m8;
		public float m9;
		public float m10;
		public float m11;
		public float m12;
		public float m13;
		public float m14;
		public float m15;
		public float m16;

		public Matrix4(bool bDefault = true)
		{
			//m = new float[16];
			m1 = 1;
			m2 = 0;
			m3 = 0;
			m4 = 0;
			m5 = 0;
			m6 = 1;
			m7 = 0;
			m8 = 0;
			m9 = 0;
			m10 = 0;
			m11 = 1;
			m12 = 0;
			m13 = 0;
			m14 = 0;
			m15 = 0;
			m16 = 1;
		}

		public Matrix4(float m00, float m01, float m02, float m03, float m04, float m05, float m06, float m07, float m08, float m09, float m010, float m011, float m012, float m013, float m014, float m015)
		{
			//m = new float[16];
			m1 = m00;
			m2 = m01;
			m3 = m02;
			m4 = m03;
			m5 = m04;
			m6 = m05;
			m7 = m06;
			m8 = m07;
			m9 = m08;
			m10 = m09;
			m11 = m010;
			m12 = m011;
			m13 = m012;
			m14 = m013;
			m15 = m014;
			m16 = m015;
		}

		public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
		{
			Vector4 result;

			result.x = (lhs.m1 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m9 * rhs.z) + (lhs.m13 * rhs.w);
			result.y = (lhs.m2 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m10 * rhs.z) + (lhs.m14 * rhs.w);
			result.z = (lhs.m3 * rhs.x) + (lhs.m7 * rhs.y) + (lhs.m11 * rhs.z) + (lhs.m15 * rhs.w);
			result.w = (lhs.m4 * rhs.x) + (lhs.m8 * rhs.y) + (lhs.m12 * rhs.z) + (lhs.m16 * rhs.w);

			return result;
		}

		public static Matrix4 operator*(Matrix4 lhs, Matrix4 rhs)
		{
			Matrix4 result = new Matrix4();

			result.m1 = (lhs.m1 * rhs.m1) + (lhs.m5 * rhs.m2) + (lhs.m9 * rhs.m3) + (lhs.m13 * rhs.m4);
			result.m2 = (lhs.m2 * rhs.m1) + (lhs.m6 * rhs.m2) + (lhs.m10 * rhs.m3) + (lhs.m14 * rhs.m4);
			result.m3 = (lhs.m3 * rhs.m1) + (lhs.m7 * rhs.m2) + (lhs.m11 * rhs.m3) + (lhs.m15 * rhs.m4);
			result.m4 = (lhs.m4 * rhs.m1) + (lhs.m8 * rhs.m2) + (lhs.m12 * rhs.m3) + (lhs.m16 * rhs.m4);
			result.m5 = (lhs.m1 * rhs.m5) + (lhs.m5 * rhs.m6) + (lhs.m9 * rhs.m7) + (lhs.m13 * rhs.m8);
			result.m6 = (lhs.m2 * rhs.m5) + (lhs.m6 * rhs.m6) + (lhs.m10 * rhs.m7) + (lhs.m14 * rhs.m8);
			result.m7 = (lhs.m3 * rhs.m5) + (lhs.m7 * rhs.m6) + (lhs.m11 * rhs.m7) + (lhs.m15 * rhs.m8);
			result.m8 = (lhs.m4 * rhs.m5) + (lhs.m8 * rhs.m6) + (lhs.m12 * rhs.m7) + (lhs.m16 * rhs.m8);
			result.m9 = (lhs.m1 * rhs.m9) + (lhs.m5 * rhs.m10) + (lhs.m9 * rhs.m11) + (lhs.m13 * rhs.m12);
			result.m10 = (lhs.m2 * rhs.m9) + (lhs.m6 * rhs.m10) + (lhs.m10 * rhs.m11) + (lhs.m14 * rhs.m12);
			result.m11 = (lhs.m3 * rhs.m9) + (lhs.m7 * rhs.m10) + (lhs.m11 * rhs.m11) + (lhs.m15 * rhs.m12);
			result.m12 = (lhs.m4 * rhs.m9) + (lhs.m8 * rhs.m10) + (lhs.m12 * rhs.m11) + (lhs.m16 * rhs.m12);
			result.m13 = (lhs.m1 * rhs.m13) + (lhs.m5 * rhs.m14) + (lhs.m9 * rhs.m15) + (lhs.m13 * rhs.m16);
			result.m14 = (lhs.m2 * rhs.m13) + (lhs.m6 * rhs.m14) + (lhs.m10 * rhs.m15) + (lhs.m14 * rhs.m16);
			result.m15 = (lhs.m3 * rhs.m13) + (lhs.m7 * rhs.m14) + (lhs.m11 * rhs.m15) + (lhs.m15 * rhs.m16);
			result.m16 = (lhs.m4 * rhs.m13) + (lhs.m8 * rhs.m14) + (lhs.m12 * rhs.m15) + (lhs.m16 * rhs.m16);

			return result;
		}

		public void SetRotateX(float fRadians)
		{
			m6 = (float)Math.Cos(fRadians);
			m7 = (float)Math.Sin(fRadians);
			m10 = (float)-Math.Sin(fRadians);
			m11 = (float)Math.Cos(fRadians);
		}

		public void SetRotateY(float fRadians)
		{
			m1 = (float)Math.Cos(fRadians);
			m3 = (float)-Math.Sin(fRadians);
			m9 = (float)Math.Sin(fRadians);
			m11 = (float)Math.Cos(fRadians);
		}

		public void SetRotateZ(float fRadians)
		{
			m1 = (float)Math.Cos(fRadians);
			m2 = (float)Math.Sin(fRadians);
			m5 = (float)-Math.Sin(fRadians);
			m6 = (float)Math.Cos(fRadians);
		}
	}
}
