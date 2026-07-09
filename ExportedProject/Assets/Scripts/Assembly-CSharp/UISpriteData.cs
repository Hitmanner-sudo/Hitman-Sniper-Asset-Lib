using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20000A2")]
public class UISpriteData
{
	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x18")]
	public int x;

	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x1C")]
	public int y;

	[Token(Token = "0x40003D9")]
	[FieldOffset(Offset = "0x20")]
	public int width;

	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x24")]
	public int height;

	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x28")]
	public int borderLeft;

	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x2C")]
	public int borderRight;

	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x30")]
	public int borderTop;

	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0x34")]
	public int borderBottom;

	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x38")]
	public int paddingLeft;

	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x3C")]
	public int paddingRight;

	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x40")]
	public int paddingTop;

	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x44")]
	public int paddingBottom;

	[Token(Token = "0x1700010A")]
	public bool hasBorder
	{
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x116A16C", Offset = "0x116A16C", VA = "0x116A16C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700010B")]
	public bool hasPadding
	{
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x116A18C", Offset = "0x116A18C", VA = "0x116A18C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0x116A1AC", Offset = "0x116A1AC", VA = "0x116A1AC")]
	public void SetRect(int x, int y, int width, int height)
	{
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x116A1B8", Offset = "0x116A1B8", VA = "0x116A1B8")]
	public void SetPadding(int left, int bottom, int right, int top)
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x116A1C4", Offset = "0x116A1C4", VA = "0x116A1C4")]
	public void SetBorder(int left, int bottom, int right, int top)
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x116A1D0", Offset = "0x116A1D0", VA = "0x116A1D0")]
	public void CopyFrom(UISpriteData sd)
	{
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x116A24C", Offset = "0x116A24C", VA = "0x116A24C")]
	public void CopyBorderFrom(UISpriteData sd)
	{
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0x116A280", Offset = "0x116A280", VA = "0x116A280")]
	public UISpriteData()
	{
	}
}
