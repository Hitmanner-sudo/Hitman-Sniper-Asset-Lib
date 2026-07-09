using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000056")]
public static class NGUIMath
{
	[Token(Token = "0x6000245")]
	[Address(RVA = "0xC4A8C0", Offset = "0xC4A8C0", VA = "0xC4A8C0")]
	public static float Lerp(float from, float to, float factor)
	{
		return default(float);
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xC4A8D8", Offset = "0xC4A8D8", VA = "0xC4A8D8")]
	public static int ClampIndex(int val, int max)
	{
		return default(int);
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xC4A8F4", Offset = "0xC4A8F4", VA = "0xC4A8F4")]
	public static int RepeatIndex(int val, int max)
	{
		return default(int);
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xC4A924", Offset = "0xC4A924", VA = "0xC4A924")]
	public static float WrapAngle(float angle)
	{
		return default(float);
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xC4A970", Offset = "0xC4A970", VA = "0xC4A970")]
	public static float Wrap01(float val)
	{
		return default(float);
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xC4A99C", Offset = "0xC4A99C", VA = "0xC4A99C")]
	public static int HexToDecimal(char ch)
	{
		return default(int);
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xC4A9C8", Offset = "0xC4A9C8", VA = "0xC4A9C8")]
	public static char DecimalToHexChar(int num)
	{
		return default(char);
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xC4A9F0", Offset = "0xC4A9F0", VA = "0xC4A9F0")]
	public static string DecimalToHex(int num)
	{
		return null;
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xC4AA58", Offset = "0xC4AA58", VA = "0xC4AA58")]
	public static int ColorToInt(Color c)
	{
		return default(int);
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xC4AAE8", Offset = "0xC4AAE8", VA = "0xC4AAE8")]
	public static Color IntToColor(int val)
	{
		return default(Color);
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xC4AB44", Offset = "0xC4AB44", VA = "0xC4AB44")]
	public static string IntToBinary(int val, int bits)
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xC4AC40", Offset = "0xC4AC40", VA = "0xC4AC40")]
	public static Color HexToColor(uint val)
	{
		return default(Color);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xC4AC44", Offset = "0xC4AC44", VA = "0xC4AC44")]
	public static Rect ConvertToTexCoords(Rect rect, int width, int height)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xC4AD08", Offset = "0xC4AD08", VA = "0xC4AD08")]
	public static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xC4AE7C", Offset = "0xC4AE7C", VA = "0xC4AE7C")]
	public static Rect MakePixelPerfect(Rect rect)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xC4AF34", Offset = "0xC4AF34", VA = "0xC4AF34")]
	public static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xC4B010", Offset = "0xC4B010", VA = "0xC4B010")]
	public static Vector3 ApplyHalfPixelOffset(Vector3 pos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xC4B07C", Offset = "0xC4B07C", VA = "0xC4B07C")]
	public static Vector3 ApplyHalfPixelOffset(Vector3 pos, Vector3 scale)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xC4B148", Offset = "0xC4B148", VA = "0xC4B148")]
	public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xC4B218", Offset = "0xC4B218", VA = "0xC4B218")]
	public static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xC4B4C0", Offset = "0xC4B4C0", VA = "0xC4B4C0")]
	public static Bounds CalculateRelativeWidgetBounds(Transform trans)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xC4B810", Offset = "0xC4B810", VA = "0xC4B810")]
	public static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xC4B854", Offset = "0xC4B854", VA = "0xC4B854")]
	public static Bounds CalculateRelativeWidgetBounds(Transform root, Transform child)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xC4B504", Offset = "0xC4B504", VA = "0xC4B504")]
	public static Bounds CalculateRelativeWidgetBounds(Transform root, Transform child, bool considerInactive)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xC4B894", Offset = "0xC4B894", VA = "0xC4B894")]
	public static Bounds CalculateRelativeInnerBounds(Transform root, UISprite sprite)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xC4BB18", Offset = "0xC4BB18", VA = "0xC4BB18")]
	public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xC4BBE8", Offset = "0xC4BBE8", VA = "0xC4BBE8")]
	public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xC4BC90", Offset = "0xC4BC90", VA = "0xC4BC90")]
	public static float SpringLerp(float strength, float deltaTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xC4BCD4", Offset = "0xC4BCD4", VA = "0xC4BCD4")]
	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xC4BD18", Offset = "0xC4BD18", VA = "0xC4BD18")]
	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xC4BD9C", Offset = "0xC4BD9C", VA = "0xC4BD9C")]
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xC4BE3C", Offset = "0xC4BE3C", VA = "0xC4BE3C")]
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xC4BEF0", Offset = "0xC4BEF0", VA = "0xC4BEF0")]
	public static float RotateTowards(float from, float to, float maxAngle)
	{
		return default(float);
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xC4BF78", Offset = "0xC4BF78", VA = "0xC4BF78")]
	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		return default(float);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xC4C048", Offset = "0xC4C048", VA = "0xC4C048")]
	public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos)
	{
		return default(float);
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xC4C1B0", Offset = "0xC4C1B0", VA = "0xC4C1B0")]
	public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam)
	{
		return default(float);
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xC4C2AC", Offset = "0xC4C2AC", VA = "0xC4C2AC")]
	public static Vector2 GetPivotOffset(UIWidget.Pivot pv)
	{
		return default(Vector2);
	}
}
