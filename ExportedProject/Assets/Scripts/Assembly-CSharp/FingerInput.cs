using System;
using Il2CppDummyDll;

[Token(Token = "0x2000859")]
public class FingerInput
{
	[Token(Token = "0x200085A")]
	[Flags]
	public enum FingerID
	{
		[Token(Token = "0x4002F04")]
		None = 0,
		[Token(Token = "0x4002F05")]
		One = 1,
		[Token(Token = "0x4002F06")]
		Two = 2,
		[Token(Token = "0x4002F07")]
		Three = 4,
		[Token(Token = "0x4002F08")]
		Four = 8,
		[Token(Token = "0x4002F09")]
		Five = 0x10,
		[Token(Token = "0x4002F0A")]
		Six = 0x20,
		[Token(Token = "0x4002F0B")]
		Seven = 0x40,
		[Token(Token = "0x4002F0C")]
		Eight = 0x80,
		[Token(Token = "0x4002F0D")]
		Nine = 0x100,
		[Token(Token = "0x4002F0E")]
		Ten = 0x200,
		[Token(Token = "0x4002F0F")]
		Max = 0xA,
		[Token(Token = "0x4002F10")]
		Mouse = 0x400,
		[Token(Token = "0x4002F11")]
		All = 0xFFFF
	}

	[Token(Token = "0x4002F02")]
	[FieldOffset(Offset = "0x10")]
	private FingerID _fingers;

	[Token(Token = "0x6003692")]
	[Address(RVA = "0x955FB0", Offset = "0x955FB0", VA = "0x955FB0")]
	public static FingerID TouchIDtoFingerID(int touchID)
	{
		return default(FingerID);
	}

	[Token(Token = "0x6003693")]
	[Address(RVA = "0x955FD4", Offset = "0x955FD4", VA = "0x955FD4")]
	public FingerID GetFingers()
	{
		return default(FingerID);
	}

	[Token(Token = "0x6003694")]
	[Address(RVA = "0x955DD0", Offset = "0x955DD0", VA = "0x955DD0")]
	public void AddFingers(FingerID finger)
	{
	}

	[Token(Token = "0x6003695")]
	[Address(RVA = "0x955E04", Offset = "0x955E04", VA = "0x955E04")]
	public void RemoveFingers(FingerID finger)
	{
	}

	[Token(Token = "0x6003696")]
	[Address(RVA = "0x955D9C", Offset = "0x955D9C", VA = "0x955D9C")]
	public bool HasFingers(FingerID finger)
	{
		return default(bool);
	}

	[Token(Token = "0x6003697")]
	[Address(RVA = "0x955FDC", Offset = "0x955FDC", VA = "0x955FDC")]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x6003698")]
	[Address(RVA = "0x955FEC", Offset = "0x955FEC", VA = "0x955FEC")]
	public void Clear()
	{
	}

	[Token(Token = "0x6003699")]
	[Address(RVA = "0x955C98", Offset = "0x955C98", VA = "0x955C98")]
	public FingerInput()
	{
	}
}
