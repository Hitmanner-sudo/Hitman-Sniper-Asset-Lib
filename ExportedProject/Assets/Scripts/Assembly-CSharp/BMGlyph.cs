using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200004A")]
public class BMGlyph
{
	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x10")]
	public int index;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x14")]
	public float x;

	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x18")]
	public float y;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x1C")]
	public float width;

	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x20")]
	public float height;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x24")]
	public float offsetX;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x28")]
	public float offsetY;

	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x2C")]
	public int advance;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x30")]
	public int channel;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x38")]
	public List<int> kerning;

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xC0C6C4", Offset = "0xC0C6C4", VA = "0xC0C6C4")]
	public int GetKerning(int previousChar)
	{
		return default(int);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xC0C7B0", Offset = "0xC0C7B0", VA = "0xC0C7B0")]
	public void SetKerning(int previousChar, int amount)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xC0C568", Offset = "0xC0C568", VA = "0xC0C568")]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xC0C3FC", Offset = "0xC0C3FC", VA = "0xC0C3FC")]
	public BMGlyph()
	{
	}
}
