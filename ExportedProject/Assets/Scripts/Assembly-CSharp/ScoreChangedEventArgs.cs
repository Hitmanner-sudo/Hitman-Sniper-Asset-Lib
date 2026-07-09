using System;
using Il2CppDummyDll;

[Token(Token = "0x200028E")]
public class ScoreChangedEventArgs : EventArgs
{
	[Token(Token = "0x4000E69")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B39E4", Offset = "0x5B39E4")]
	private int _003CScore_003Ek__BackingField;

	[Token(Token = "0x4000E6A")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B39F4", Offset = "0x5B39F4")]
	private int _003CPreviousScore_003Ek__BackingField;

	[Token(Token = "0x17000262")]
	public int Score
	{
		[Token(Token = "0x6000F70")]
		[Address(RVA = "0xBB6F7C", Offset = "0xBB6F7C", VA = "0xBB6F7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615444", Offset = "0x615444")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F71")]
		[Address(RVA = "0xBB6F84", Offset = "0xBB6F84", VA = "0xBB6F84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615454", Offset = "0x615454")]
		set
		{
		}
	}

	[Token(Token = "0x17000263")]
	public int PreviousScore
	{
		[Token(Token = "0x6000F72")]
		[Address(RVA = "0xBB6F8C", Offset = "0xBB6F8C", VA = "0xBB6F8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615464", Offset = "0x615464")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F73")]
		[Address(RVA = "0xBB6F94", Offset = "0xBB6F94", VA = "0xBB6F94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615474", Offset = "0x615474")]
		set
		{
		}
	}

	[Token(Token = "0x6000F74")]
	[Address(RVA = "0xBB6F9C", Offset = "0xBB6F9C", VA = "0xBB6F9C")]
	public ScoreChangedEventArgs()
	{
	}
}
