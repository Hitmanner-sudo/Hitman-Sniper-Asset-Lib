using Il2CppDummyDll;
using SimpleJSON;

[Token(Token = "0x200061D")]
public static class SafeAreaUtil
{
	[Token(Token = "0x40021B4")]
	private const string ORIGIN_KEY = "origin";

	[Token(Token = "0x40021B5")]
	private const string X_KEY = "x";

	[Token(Token = "0x40021B6")]
	private const string Y_KEY = "y";

	[Token(Token = "0x40021B7")]
	private const string SIZE_KEY = "size";

	[Token(Token = "0x40021B8")]
	private const string WIDTH_KEY = "width";

	[Token(Token = "0x40021B9")]
	private const string HEIGHT_KEY = "height";

	[Token(Token = "0x40021BA")]
	private const string SCALE_KEY = "scale";

	[Token(Token = "0x40021BB")]
	private const string RES_HEIGHT_KEY = "resHeight";

	[Token(Token = "0x40021BC")]
	[FieldOffset(Offset = "0x0")]
	private static SafeAreaRect _defaultSafeArea;

	[Token(Token = "0x40021BD")]
	[FieldOffset(Offset = "0x18")]
	private static SafeAreaRect _safeArea;

	[Token(Token = "0x6002798")]
	[Address(RVA = "0xBA8D98", Offset = "0xBA8D98", VA = "0xBA8D98")]
	public static SafeAreaRect GetSafeAreaRect()
	{
		return default(SafeAreaRect);
	}

	[Token(Token = "0x6002799")]
	[Address(RVA = "0xBA943C", Offset = "0xBA943C", VA = "0xBA943C")]
	public static void ClearCache()
	{
	}

	[Token(Token = "0x600279A")]
	[Address(RVA = "0xBA92E0", Offset = "0xBA92E0", VA = "0xBA92E0")]
	private static string GetSafeArea()
	{
		return null;
	}

	[Token(Token = "0x600279C")]
	[Address(RVA = "0xBA92E8", Offset = "0xBA92E8", VA = "0xBA92E8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D330", Offset = "0x61D330")]
	internal static bool _003CGetSafeAreaRect_003Eg__TryParseFloatNodeValue_007C10_0(JSONNode nodeToParse, out float floatValue)
	{
		return default(bool);
	}
}
