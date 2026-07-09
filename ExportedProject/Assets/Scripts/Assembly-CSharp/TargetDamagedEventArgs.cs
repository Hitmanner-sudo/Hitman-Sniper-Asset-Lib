using System;
using Il2CppDummyDll;

[Token(Token = "0x20002AA")]
public class TargetDamagedEventArgs : EventArgs
{
	[Token(Token = "0x4000EF8")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3B34", Offset = "0x5B3B34")]
	private Damage _003CDamage_003Ek__BackingField;

	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3B44", Offset = "0x5B3B44")]
	private bool _003CKilled_003Ek__BackingField;

	[Token(Token = "0x4000EFA")]
	[FieldOffset(Offset = "0x1C")]
	public int WitnessCount;

	[Token(Token = "0x4000EFB")]
	[FieldOffset(Offset = "0x20")]
	public bool ResetExclusionBitArray;

	[Token(Token = "0x1700027F")]
	public Damage Damage
	{
		[Token(Token = "0x6001046")]
		[Address(RVA = "0xB544C0", Offset = "0xB544C0", VA = "0xB544C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615994", Offset = "0x615994")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001047")]
		[Address(RVA = "0xB544C8", Offset = "0xB544C8", VA = "0xB544C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6159A4", Offset = "0x6159A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000280")]
	public bool Killed
	{
		[Token(Token = "0x6001048")]
		[Address(RVA = "0xB544D0", Offset = "0xB544D0", VA = "0xB544D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6159B4", Offset = "0x6159B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001049")]
		[Address(RVA = "0xB544D8", Offset = "0xB544D8", VA = "0xB544D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6159C4", Offset = "0x6159C4")]
		set
		{
		}
	}

	[Token(Token = "0x600104A")]
	[Address(RVA = "0xB53858", Offset = "0xB53858", VA = "0xB53858")]
	public TargetDamagedEventArgs()
	{
	}
}
