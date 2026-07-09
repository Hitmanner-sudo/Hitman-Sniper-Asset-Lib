using System;
using Il2CppDummyDll;

[Token(Token = "0x2000615")]
public struct PopupButton : IEquatable<PopupButton>
{
	[Token(Token = "0x4002187")]
	[FieldOffset(Offset = "0x0")]
	public static readonly PopupButton INVALID;

	[Token(Token = "0x4002188")]
	[FieldOffset(Offset = "0x0")]
	public readonly BlinkButtonHandler Button;

	[Token(Token = "0x4002189")]
	[FieldOffset(Offset = "0x8")]
	public readonly Action Callback;

	[Token(Token = "0x400218A")]
	[FieldOffset(Offset = "0x10")]
	public readonly string ButtonText;

	[Token(Token = "0x1700052B")]
	public static PopupButton DefaultOk
	{
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x92D5EC", Offset = "0x92D5EC", VA = "0x92D5EC")]
		get
		{
			return default(PopupButton);
		}
	}

	[Token(Token = "0x6002771")]
	[Address(RVA = "0x92CFC8", Offset = "0x92CFC8", VA = "0x92CFC8")]
	public PopupButton(string text, Action callback)
	{
	}

	[Token(Token = "0x6002772")]
	[Address(RVA = "0x92D714", Offset = "0x92D714", VA = "0x92D714")]
	public PopupButton(BlinkButtonHandler button, string text, Action callback)
	{
	}

	[Token(Token = "0x6002773")]
	[Address(RVA = "0x92D720", Offset = "0x92D720", VA = "0x92D720", Slot = "4")]
	public bool Equals(PopupButton other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002774")]
	[Address(RVA = "0x92D784", Offset = "0x92D784", VA = "0x92D784", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6002775")]
	[Address(RVA = "0x92D820", Offset = "0x92D820", VA = "0x92D820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002776")]
	[Address(RVA = "0x92D900", Offset = "0x92D900", VA = "0x92D900")]
	public static bool operator ==(PopupButton a, PopupButton b)
	{
		return default(bool);
	}

	[Token(Token = "0x6002777")]
	[Address(RVA = "0x92D9A8", Offset = "0x92D9A8", VA = "0x92D9A8")]
	public static bool operator !=(PopupButton a, PopupButton b)
	{
		return default(bool);
	}
}
