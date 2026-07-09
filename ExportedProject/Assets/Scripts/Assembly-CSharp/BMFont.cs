using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000049")]
public class BMFont
{
	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[HideInInspector]
	private int mSize;

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[HideInInspector]
	private int mBase;

	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private int mWidth;

	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	[SerializeField]
	private int mHeight;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[HideInInspector]
	private string mSpriteName;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[HideInInspector]
	private List<BMGlyph> mSaved;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, BMGlyph> mDict;

	[Token(Token = "0x1700003F")]
	public bool isValid
	{
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xC0C130", Offset = "0xC0C130", VA = "0xC0C130")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000040")]
	public int charSize
	{
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xC0C184", Offset = "0xC0C184", VA = "0xC0C184")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xC0C18C", Offset = "0xC0C18C", VA = "0xC0C18C")]
		set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public int baseOffset
	{
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xC0C194", Offset = "0xC0C194", VA = "0xC0C194")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xC0C19C", Offset = "0xC0C19C", VA = "0xC0C19C")]
		set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public int texWidth
	{
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xC0C1A4", Offset = "0xC0C1A4", VA = "0xC0C1A4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xC0C1AC", Offset = "0xC0C1AC", VA = "0xC0C1AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public int texHeight
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xC0C1B4", Offset = "0xC0C1B4", VA = "0xC0C1B4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xC0C1BC", Offset = "0xC0C1BC", VA = "0xC0C1BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public int glyphCount
	{
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xC0C1C4", Offset = "0xC0C1C4", VA = "0xC0C1C4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000045")]
	public string spriteName
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xC0C224", Offset = "0xC0C224", VA = "0xC0C224")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xC0C22C", Offset = "0xC0C22C", VA = "0xC0C22C")]
		set
		{
		}
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xC0C234", Offset = "0xC0C234", VA = "0xC0C234")]
	public BMGlyph GetGlyph(int index, bool createIfMissing)
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xC0C404", Offset = "0xC0C404", VA = "0xC0C404")]
	public BMGlyph GetGlyph(int index)
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xC0C40C", Offset = "0xC0C40C", VA = "0xC0C40C")]
	public void Clear()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xC0C484", Offset = "0xC0C484", VA = "0xC0C484")]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xC0C60C", Offset = "0xC0C60C", VA = "0xC0C60C")]
	public BMFont()
	{
	}
}
