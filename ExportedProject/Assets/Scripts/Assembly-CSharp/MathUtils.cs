using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008D0")]
public static class MathUtils
{
	[Token(Token = "0x40030CF")]
	[FieldOffset(Offset = "0x0")]
	public static readonly double Cos0;

	[Token(Token = "0x40030D0")]
	[FieldOffset(Offset = "0x8")]
	public static readonly double Cos1;

	[Token(Token = "0x40030D1")]
	[FieldOffset(Offset = "0x10")]
	public static readonly double Cos5;

	[Token(Token = "0x40030D2")]
	[FieldOffset(Offset = "0x18")]
	public static readonly double Cos10;

	[Token(Token = "0x40030D3")]
	[FieldOffset(Offset = "0x20")]
	public static readonly double Cos15;

	[Token(Token = "0x40030D4")]
	[FieldOffset(Offset = "0x28")]
	public static readonly double Cos30;

	[Token(Token = "0x40030D5")]
	[FieldOffset(Offset = "0x30")]
	public static readonly double Cos45;

	[Token(Token = "0x40030D6")]
	[FieldOffset(Offset = "0x38")]
	public static readonly double Cos90;

	[Token(Token = "0x40030D7")]
	[FieldOffset(Offset = "0x40")]
	public static readonly double Cos180;

	[Token(Token = "0x40030D8")]
	[FieldOffset(Offset = "0x48")]
	public static readonly double Sin0;

	[Token(Token = "0x40030D9")]
	[FieldOffset(Offset = "0x50")]
	public static readonly double Sin1;

	[Token(Token = "0x40030DA")]
	[FieldOffset(Offset = "0x58")]
	public static readonly double Sin5;

	[Token(Token = "0x40030DB")]
	[FieldOffset(Offset = "0x60")]
	public static readonly double Sin10;

	[Token(Token = "0x40030DC")]
	[FieldOffset(Offset = "0x68")]
	public static readonly double Sin15;

	[Token(Token = "0x40030DD")]
	[FieldOffset(Offset = "0x70")]
	public static readonly double Sin30;

	[Token(Token = "0x40030DE")]
	[FieldOffset(Offset = "0x78")]
	public static readonly double Sin45;

	[Token(Token = "0x40030DF")]
	[FieldOffset(Offset = "0x80")]
	public static readonly double Sin90;

	[Token(Token = "0x40030E0")]
	[FieldOffset(Offset = "0x88")]
	public static readonly double Sin180;

	[Token(Token = "0x40030E1")]
	[FieldOffset(Offset = "0x90")]
	public static readonly double Sin270;

	[Token(Token = "0x40030E2")]
	[FieldOffset(Offset = "0x98")]
	private static readonly string[] _sizePrefix;

	[Token(Token = "0x60038A9")]
	[Address(RVA = "0x9B4F50", Offset = "0x9B4F50", VA = "0x9B4F50")]
	public static double Radians(double degrees)
	{
		return default(double);
	}

	[Token(Token = "0x60038AA")]
	[Address(RVA = "0x9B4F6C", Offset = "0x9B4F6C", VA = "0x9B4F6C")]
	public static double Degrees(double radians)
	{
		return default(double);
	}

	[Token(Token = "0x60038AB")]
	[Address(RVA = "0x9B4F88", Offset = "0x9B4F88", VA = "0x9B4F88")]
	public static float GetDegreesBetweenTransforms2d(Transform transform1, Transform testTransform)
	{
		return default(float);
	}

	[Token(Token = "0x60038AC")]
	[Address(RVA = "0x9B4FE4", Offset = "0x9B4FE4", VA = "0x9B4FE4")]
	public static float GetDegreesBetweenTransformAndPosition2d(Transform transform1, Vector3 testPos)
	{
		return default(float);
	}

	[Token(Token = "0x60038AD")]
	[Address(RVA = "0x9B5020", Offset = "0x9B5020", VA = "0x9B5020")]
	public static bool IsAngleBetween(float angle, float a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x60038AE")]
	[Address(RVA = "0x9B50C8", Offset = "0x9B50C8", VA = "0x9B50C8")]
	public static Quaternion GetAverageAngle(Quaternion first, Quaternion second)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60038AF")]
	[Address(RVA = "0x9B50F0", Offset = "0x9B50F0", VA = "0x9B50F0")]
	public static Quaternion GetAverageAngleEuler(Quaternion first, Quaternion second)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60038B0")]
	[Address(RVA = "0x9B52B4", Offset = "0x9B52B4", VA = "0x9B52B4")]
	private static float GetValueForAngleAverage(float sourceValue)
	{
		return default(float);
	}

	[Token(Token = "0x60038B1")]
	[Address(RVA = "0x9B52D4", Offset = "0x9B52D4", VA = "0x9B52D4")]
	private static float RevertValueForAngleAverage(float sourceValue)
	{
		return default(float);
	}

	[Token(Token = "0x60038B2")]
	[Address(RVA = "0x9B52EC", Offset = "0x9B52EC", VA = "0x9B52EC")]
	public static bool IsValid(this Vector3 v)
	{
		return default(bool);
	}

	[Token(Token = "0x60038B3")]
	[Address(RVA = "0x9B5380", Offset = "0x9B5380", VA = "0x9B5380")]
	public static bool IsValid(this Quaternion q)
	{
		return default(bool);
	}

	[Token(Token = "0x60038B4")]
	[Address(RVA = "0x9B543C", Offset = "0x9B543C", VA = "0x9B543C")]
	public static float Sin(this Vector2 v0, Vector2 v1)
	{
		return default(float);
	}

	[Token(Token = "0x60038B5")]
	[Address(RVA = "0x9B544C", Offset = "0x9B544C", VA = "0x9B544C")]
	public static int Count(this Enum enumType)
	{
		return default(int);
	}

	[Token(Token = "0x60038B6")]
	[Address(RVA = "0x9B54D8", Offset = "0x9B54D8", VA = "0x9B54D8")]
	public static Vector3 PointSegmentProjection(Vector3 point, Vector3 segmentStart, Vector3 segmentEnd)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60038B7")]
	[Address(RVA = "0x9B55B8", Offset = "0x9B55B8", VA = "0x9B55B8")]
	public static Vector3 PointLineProjection(Vector3 point, Vector3 lineStart, Vector3 lineEnd)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60038B8")]
	[Address(RVA = "0x9B5658", Offset = "0x9B5658", VA = "0x9B5658")]
	public static float PointSegmentDistance(Vector3 point, Vector3 segmentStart, Vector3 segmentEnd)
	{
		return default(float);
	}

	[Token(Token = "0x60038B9")]
	[Address(RVA = "0x9B578C", Offset = "0x9B578C", VA = "0x9B578C")]
	public static float PointSegmentDistanceSqr(Vector3 point, Vector3 segmentStart, Vector3 segmentEnd)
	{
		return default(float);
	}

	[Token(Token = "0x60038BA")]
	[Address(RVA = "0x9B5880", Offset = "0x9B5880", VA = "0x9B5880")]
	public static float DotXZNormalized(this Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[Token(Token = "0x60038BB")]
	[Address(RVA = "0x9B58E4", Offset = "0x9B58E4", VA = "0x9B58E4")]
	public static float DotXZ(this Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[Token(Token = "0x60038BC")]
	[Address(RVA = "0x9B58F4", Offset = "0x9B58F4", VA = "0x9B58F4")]
	public static Vector2 ToHorizontal(this Vector3 v)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60038BD")]
	[Address(RVA = "0x9B58FC", Offset = "0x9B58FC", VA = "0x9B58FC")]
	public static float GetPitchDegrees(this Vector3 a)
	{
		return default(float);
	}

	[Token(Token = "0x60038BE")]
	[Address(RVA = "0x9B594C", Offset = "0x9B594C", VA = "0x9B594C")]
	public static float GetYawDegrees(this Vector3 a)
	{
		return default(float);
	}

	[Token(Token = "0x60038BF")]
	[Address(RVA = "0x9B5974", Offset = "0x9B5974", VA = "0x9B5974")]
	public static bool TryIsPointInside(this Collider c, Vector3 point, out bool inside)
	{
		return default(bool);
	}

	[Token(Token = "0x60038C0")]
	[Address(RVA = "0x9B5B38", Offset = "0x9B5B38", VA = "0x9B5B38")]
	public static bool IsPointInside(this BoxCollider box, Vector3 point)
	{
		return default(bool);
	}

	[Token(Token = "0x60038C1")]
	[Address(RVA = "0x9B5C90", Offset = "0x9B5C90", VA = "0x9B5C90")]
	public static bool IsPointInside(this SphereCollider sphere, Vector3 point)
	{
		return default(bool);
	}

	[Token(Token = "0x60038C2")]
	[Address(RVA = "0x9B5DCC", Offset = "0x9B5DCC", VA = "0x9B5DCC")]
	public static float Max(this Vector3 a)
	{
		return default(float);
	}

	[Token(Token = "0x60038C3")]
	[Address(RVA = "0x9B5DF8", Offset = "0x9B5DF8", VA = "0x9B5DF8")]
	public static float GetFraction(float number, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x60038C4")]
	[Address(RVA = "0x9B5E08", Offset = "0x9B5E08", VA = "0x9B5E08")]
	public static Vector3 ParseVector3(string str)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60038C5")]
	[Address(RVA = "0x9B5F30", Offset = "0x9B5F30", VA = "0x9B5F30")]
	public static Quaternion ParseQuaternion(string str)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60038C6")]
	[Address(RVA = "0x9B60A0", Offset = "0x9B60A0", VA = "0x9B60A0")]
	public static Vector2 Clamp(this Vector2 v, Vector2 min, Vector2 max)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60038C7")]
	[Address(RVA = "0x9B60FC", Offset = "0x9B60FC", VA = "0x9B60FC")]
	public static long Factorial(this int n)
	{
		return default(long);
	}

	[Token(Token = "0x60038C8")]
	[Address(RVA = "0x9B615C", Offset = "0x9B615C", VA = "0x9B615C")]
	public static long Factorial(this long n)
	{
		return default(long);
	}

	[Token(Token = "0x60038C9")]
	[Address(RVA = "0x9B6208", Offset = "0x9B6208", VA = "0x9B6208")]
	public static string ToRomanNumeral(this int value)
	{
		return null;
	}

	[Token(Token = "0x60038CA")]
	[Address(RVA = "0x9B6568", Offset = "0x9B6568", VA = "0x9B6568")]
	public static string ToHumanReadableSize(this long value)
	{
		return null;
	}

	[Token(Token = "0x60038CB")]
	[Address(RVA = "0x9B6834", Offset = "0x9B6834", VA = "0x9B6834")]
	public static void SetScissorRect(this Camera cam, Rect r)
	{
	}

	[Token(Token = "0x60038CC")]
	[Address(RVA = "0x9B6BD4", Offset = "0x9B6BD4", VA = "0x9B6BD4")]
	public static bool ApproximatelyF(this float a, float b, float epsilon = float.Epsilon)
	{
		return default(bool);
	}

	[Token(Token = "0x60038CD")]
	[Address(RVA = "0x9B6BE4", Offset = "0x9B6BE4", VA = "0x9B6BE4")]
	public static bool ApproximatelyFNaNProof(this float a, float b, float epsilon = float.Epsilon)
	{
		return default(bool);
	}

	[Token(Token = "0x60038CE")]
	[Address(RVA = "0x9B6CE8", Offset = "0x9B6CE8", VA = "0x9B6CE8")]
	public static bool ApproximatelyD(this double a, double b, double epsilon = double.Epsilon)
	{
		return default(bool);
	}

	[Token(Token = "0x60038CF")]
	[Address(RVA = "0x9B6D68", Offset = "0x9B6D68", VA = "0x9B6D68")]
	public static bool IsNearlyZeroF(this float f, float epsilon = float.Epsilon)
	{
		return default(bool);
	}

	[Token(Token = "0x60038D0")]
	[Address(RVA = "0x9B6DDC", Offset = "0x9B6DDC", VA = "0x9B6DDC")]
	public static bool IsNearlyZeroD(this double d, double epsilon = double.Epsilon)
	{
		return default(bool);
	}

	[Token(Token = "0x60038D1")]
	[Address(RVA = "0x9B6E50", Offset = "0x9B6E50", VA = "0x9B6E50")]
	public static int LerpInt(int from, int to, float ratio)
	{
		return default(int);
	}

	[Token(Token = "0x60038D2")]
	[Address(RVA = "0x9B6F18", Offset = "0x9B6F18", VA = "0x9B6F18")]
	public static Vector3 CombinedVelocity(this Vector3 vel1, Vector3 vel2)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60038D3")]
	[Address(RVA = "0x9B702C", Offset = "0x9B702C", VA = "0x9B702C")]
	public static Vector2 Perpendicular(this Vector2 vector)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60038D4")]
	[Address(RVA = "0x9B7040", Offset = "0x9B7040", VA = "0x9B7040")]
	public static Vector3 Perpendicular(this Vector3 vector)
	{
		return default(Vector3);
	}
}
