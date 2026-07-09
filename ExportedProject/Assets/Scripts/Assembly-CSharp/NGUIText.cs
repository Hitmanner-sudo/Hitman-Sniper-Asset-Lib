using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000057")]
public static class NGUIText
{
	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x0")]
	private static Color mInvisible;

	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x10")]
	private static BetterList<Color> mColors;

	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x18")]
	private static CharacterInfo mTempChar;

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xC4C304", Offset = "0xC4C304", VA = "0xC4C304")]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xC4C404", Offset = "0xC4C404", VA = "0xC4C404")]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xC4C41C", Offset = "0xC4C41C", VA = "0xC4C41C")]
	public static int ParseSymbol(string text, int index)
	{
		return default(int);
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xC4C568", Offset = "0xC4C568", VA = "0xC4C568")]
	public static bool ParseSymbol(string text, ref int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xC4C5F4", Offset = "0xC4C5F4", VA = "0xC4C5F4")]
	public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply)
	{
		return default(bool);
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xC4C8C4", Offset = "0xC4C8C4", VA = "0xC4C8C4")]
	public static string StripSymbols(string text)
	{
		return null;
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xC4C9A4", Offset = "0xC4C9A4", VA = "0xC4C9A4")]
	public static void Align(BetterList<Vector3> verts, int indexOffset, TextAlignment alignment, int pos, int lineWidth)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xC4CAB0", Offset = "0xC4CAB0", VA = "0xC4CAB0")]
	public static void EndLine(ref StringBuilder s)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xC4CB3C", Offset = "0xC4CB3C", VA = "0xC4CB3C")]
	public static Vector2 CalculatePrintedSize(string text, Font font, int size, FontStyle style, bool encoding)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xC4CD58", Offset = "0xC4CD58", VA = "0xC4CD58")]
	public static int CalculateOffsetToFit(string text, Font font, int size, FontStyle style, int lineWidth)
	{
		return default(int);
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xC4CF0C", Offset = "0xC4CF0C", VA = "0xC4CF0C")]
	public static bool WrapText(string text, Font font, int size, FontStyle style, int width, int height, int maxLines, bool encoding, out string finalText)
	{
		return default(bool);
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xC4D43C", Offset = "0xC4D43C", VA = "0xC4D43C")]
	public static void Print(string text, Font font, int size, FontStyle style, Color32 color, bool encoding, TextAlignment alignment, int lineWidth, bool premultiply, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
