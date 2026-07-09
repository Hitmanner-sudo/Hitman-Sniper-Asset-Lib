using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200004B")]
public class BMSymbol
{
	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x10")]
	public string sequence;

	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x18")]
	public string spriteName;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x20")]
	private UISpriteData mSprite;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x28")]
	private bool mIsValid;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x2C")]
	private int mLength;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x30")]
	private int mOffsetX;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x34")]
	private int mOffsetY;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x38")]
	private int mWidth;

	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x3C")]
	private int mHeight;

	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x40")]
	private int mAdvance;

	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x44")]
	private Rect mUV;

	[Token(Token = "0x17000046")]
	public int length
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xC0C914", Offset = "0xC0C914", VA = "0xC0C914")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000047")]
	public int offsetX
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xC0C940", Offset = "0xC0C940", VA = "0xC0C940")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000048")]
	public int offsetY
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xC0C948", Offset = "0xC0C948", VA = "0xC0C948")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000049")]
	public int width
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xC0C950", Offset = "0xC0C950", VA = "0xC0C950")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004A")]
	public int height
	{
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xC0C958", Offset = "0xC0C958", VA = "0xC0C958")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004B")]
	public int advance
	{
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xC0C960", Offset = "0xC0C960", VA = "0xC0C960")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004C")]
	public Rect uvRect
	{
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xC0C968", Offset = "0xC0C968", VA = "0xC0C968")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xC0C974", Offset = "0xC0C974", VA = "0xC0C974")]
	public void MarkAsDirty()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xC0C97C", Offset = "0xC0C97C", VA = "0xC0C97C")]
	public bool Validate(UIAtlas atlas)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xC0CBB4", Offset = "0xC0CBB4", VA = "0xC0CBB4")]
	public BMSymbol()
	{
	}
}
