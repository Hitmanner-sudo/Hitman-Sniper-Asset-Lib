using System;
using Il2CppDummyDll;

[Token(Token = "0x200061E")]
public struct SafeAreaRect : IEquatable<SafeAreaRect>
{
	[Token(Token = "0x40021BE")]
	[FieldOffset(Offset = "0x0")]
	private readonly float _x;

	[Token(Token = "0x40021BF")]
	[FieldOffset(Offset = "0x4")]
	private readonly float _y;

	[Token(Token = "0x40021C0")]
	[FieldOffset(Offset = "0x8")]
	private readonly float _width;

	[Token(Token = "0x40021C1")]
	[FieldOffset(Offset = "0xC")]
	private readonly float _height;

	[Token(Token = "0x40021C2")]
	[FieldOffset(Offset = "0x10")]
	private readonly float _ptScale;

	[Token(Token = "0x40021C3")]
	[FieldOffset(Offset = "0x14")]
	private readonly float _screenToReferenceSizeScale;

	[Token(Token = "0x17000531")]
	private float Scale
	{
		[Token(Token = "0x600279D")]
		[Address(RVA = "0xBA895C", Offset = "0xBA895C", VA = "0xBA895C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000532")]
	public float X
	{
		[Token(Token = "0x600279E")]
		[Address(RVA = "0xBA8968", Offset = "0xBA8968", VA = "0xBA8968")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000533")]
	public float Y
	{
		[Token(Token = "0x600279F")]
		[Address(RVA = "0xBA897C", Offset = "0xBA897C", VA = "0xBA897C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000534")]
	public float Width
	{
		[Token(Token = "0x60027A0")]
		[Address(RVA = "0xBA8990", Offset = "0xBA8990", VA = "0xBA8990")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000535")]
	public float Height
	{
		[Token(Token = "0x60027A1")]
		[Address(RVA = "0xBA89A4", Offset = "0xBA89A4", VA = "0xBA89A4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60027A2")]
	[Address(RVA = "0xBA89B8", Offset = "0xBA89B8", VA = "0xBA89B8")]
	public SafeAreaRect(float x, float y, float width, float height, float ptScale, float resHeight)
	{
	}

	[Token(Token = "0x60027A3")]
	[Address(RVA = "0xBA8AB8", Offset = "0xBA8AB8", VA = "0xBA8AB8", Slot = "4")]
	public bool Equals(SafeAreaRect other)
	{
		return default(bool);
	}

	[Token(Token = "0x60027A4")]
	[Address(RVA = "0xBA8B90", Offset = "0xBA8B90", VA = "0xBA8B90", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60027A5")]
	[Address(RVA = "0xBA8C2C", Offset = "0xBA8C2C", VA = "0xBA8C2C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60027A6")]
	[Address(RVA = "0xBA8D18", Offset = "0xBA8D18", VA = "0xBA8D18")]
	public static bool operator ==(SafeAreaRect lhs, SafeAreaRect rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x60027A7")]
	[Address(RVA = "0xBA8D4C", Offset = "0xBA8D4C", VA = "0xBA8D4C")]
	public static bool operator !=(SafeAreaRect lhs, SafeAreaRect rhs)
	{
		return default(bool);
	}
}
