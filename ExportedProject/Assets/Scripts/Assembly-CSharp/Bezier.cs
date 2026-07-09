using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004EE")]
public static class Bezier
{
	[Token(Token = "0x20004EF")]
	public enum BezierControlPointMode
	{
		[Token(Token = "0x4001A6E")]
		Free = 0,
		[Token(Token = "0x4001A6F")]
		Aligned = 1,
		[Token(Token = "0x4001A70")]
		Mirrored = 2
	}

	[Token(Token = "0x6001E66")]
	[Address(RVA = "0xC103C0", Offset = "0xC103C0", VA = "0xC103C0")]
	public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E67")]
	[Address(RVA = "0xC10480", Offset = "0xC10480", VA = "0xC10480")]
	public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E68")]
	[Address(RVA = "0xC104DC", Offset = "0xC104DC", VA = "0xC104DC")]
	public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E69")]
	[Address(RVA = "0xC105DC", Offset = "0xC105DC", VA = "0xC105DC")]
	public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		return default(Vector3);
	}
}
