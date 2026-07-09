using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004F0")]
public class BezierCurve : MonoBehaviour
{
	[Token(Token = "0x4001A71")]
	[FieldOffset(Offset = "0x18")]
	public Vector3[] points;

	[Token(Token = "0x6001E6A")]
	[Address(RVA = "0xC106EC", Offset = "0xC106EC", VA = "0xC106EC")]
	public Vector3 GetPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E6B")]
	[Address(RVA = "0xC107A0", Offset = "0xC107A0", VA = "0xC107A0")]
	public Vector3 GetVelocity(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E6C")]
	[Address(RVA = "0xC10890", Offset = "0xC10890", VA = "0xC10890")]
	public Vector3 GetDirection(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E6D")]
	[Address(RVA = "0xC108C0", Offset = "0xC108C0", VA = "0xC108C0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6001E6E")]
	[Address(RVA = "0xC10988", Offset = "0xC10988", VA = "0xC10988")]
	public BezierCurve()
	{
	}
}
