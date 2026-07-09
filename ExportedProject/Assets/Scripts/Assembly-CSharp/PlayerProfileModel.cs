using System;
using Il2CppDummyDll;

[Token(Token = "0x20005CC")]
public class PlayerProfileModel : DataModel
{
	[Token(Token = "0x4001F29")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PROGRESSION_DATA;

	[Token(Token = "0x4001F2A")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string INITIAL_RANK;

	[Token(Token = "0x4001F2B")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string INITIAL_LEVEL;

	[Token(Token = "0x4001F2C")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string INITIAL_LEVEL_PROGRESSION;

	[Token(Token = "0x4001F2D")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string FINAL_RANK;

	[Token(Token = "0x4001F2E")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string FINAL_LEVEL;

	[Token(Token = "0x4001F2F")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string FINAL_LEVEL_PROGRESSION;

	[NonSerialized]
	[Token(Token = "0x4001F30")]
	[FieldOffset(Offset = "0x48")]
	private LazyPlayerProgressionData _progressionData;

	[NonSerialized]
	[Token(Token = "0x4001F31")]
	[FieldOffset(Offset = "0x50")]
	private int _initialRank;

	[NonSerialized]
	[Token(Token = "0x4001F32")]
	[FieldOffset(Offset = "0x54")]
	private int _initialLevel;

	[NonSerialized]
	[Token(Token = "0x4001F33")]
	[FieldOffset(Offset = "0x58")]
	private int _initialLevelProgression;

	[NonSerialized]
	[Token(Token = "0x4001F34")]
	[FieldOffset(Offset = "0x5C")]
	private int _finalRank;

	[NonSerialized]
	[Token(Token = "0x4001F35")]
	[FieldOffset(Offset = "0x60")]
	private int _finalLevel;

	[NonSerialized]
	[Token(Token = "0x4001F36")]
	[FieldOffset(Offset = "0x64")]
	private int _finalLevelProgression;

	[Token(Token = "0x60024EC")]
	[Address(RVA = "0xAB4504", Offset = "0xAB4504", VA = "0xAB4504", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60024ED")]
	[Address(RVA = "0xAB49B8", Offset = "0xAB49B8", VA = "0xAB49B8")]
	public PlayerProfileModel()
	{
	}

	[Token(Token = "0x60024EF")]
	[Address(RVA = "0xAB4AE8", Offset = "0xAB4AE8", VA = "0xAB4AE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B7A0", Offset = "0x61B7A0")]
	private object _003CBindAllVariables_003Eb__14_0()
	{
		return null;
	}

	[Token(Token = "0x60024F0")]
	[Address(RVA = "0xAB4AF0", Offset = "0xAB4AF0", VA = "0xAB4AF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B7B0", Offset = "0x61B7B0")]
	private void _003CBindAllVariables_003Eb__14_1(object p)
	{
	}

	[Token(Token = "0x60024F1")]
	[Address(RVA = "0xAB4B7C", Offset = "0xAB4B7C", VA = "0xAB4B7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B7C0", Offset = "0x61B7C0")]
	private int _003CBindAllVariables_003Eb__14_2()
	{
		return default(int);
	}

	[Token(Token = "0x60024F2")]
	[Address(RVA = "0xAB4B84", Offset = "0xAB4B84", VA = "0xAB4B84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B7D0", Offset = "0x61B7D0")]
	private void _003CBindAllVariables_003Eb__14_3(int i)
	{
	}

	[Token(Token = "0x60024F3")]
	[Address(RVA = "0xAB4B8C", Offset = "0xAB4B8C", VA = "0xAB4B8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B7E0", Offset = "0x61B7E0")]
	private int _003CBindAllVariables_003Eb__14_4()
	{
		return default(int);
	}

	[Token(Token = "0x60024F4")]
	[Address(RVA = "0xAB4B94", Offset = "0xAB4B94", VA = "0xAB4B94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B7F0", Offset = "0x61B7F0")]
	private void _003CBindAllVariables_003Eb__14_5(int i)
	{
	}

	[Token(Token = "0x60024F5")]
	[Address(RVA = "0xAB4B9C", Offset = "0xAB4B9C", VA = "0xAB4B9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B800", Offset = "0x61B800")]
	private int _003CBindAllVariables_003Eb__14_6()
	{
		return default(int);
	}

	[Token(Token = "0x60024F6")]
	[Address(RVA = "0xAB4BA4", Offset = "0xAB4BA4", VA = "0xAB4BA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B810", Offset = "0x61B810")]
	private void _003CBindAllVariables_003Eb__14_7(int i)
	{
	}

	[Token(Token = "0x60024F7")]
	[Address(RVA = "0xAB4BAC", Offset = "0xAB4BAC", VA = "0xAB4BAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B820", Offset = "0x61B820")]
	private int _003CBindAllVariables_003Eb__14_8()
	{
		return default(int);
	}

	[Token(Token = "0x60024F8")]
	[Address(RVA = "0xAB4BB4", Offset = "0xAB4BB4", VA = "0xAB4BB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B830", Offset = "0x61B830")]
	private void _003CBindAllVariables_003Eb__14_9(int i)
	{
	}

	[Token(Token = "0x60024F9")]
	[Address(RVA = "0xAB4BBC", Offset = "0xAB4BBC", VA = "0xAB4BBC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B840", Offset = "0x61B840")]
	private int _003CBindAllVariables_003Eb__14_10()
	{
		return default(int);
	}

	[Token(Token = "0x60024FA")]
	[Address(RVA = "0xAB4BC4", Offset = "0xAB4BC4", VA = "0xAB4BC4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B850", Offset = "0x61B850")]
	private void _003CBindAllVariables_003Eb__14_11(int i)
	{
	}

	[Token(Token = "0x60024FB")]
	[Address(RVA = "0xAB4BCC", Offset = "0xAB4BCC", VA = "0xAB4BCC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B860", Offset = "0x61B860")]
	private int _003CBindAllVariables_003Eb__14_12()
	{
		return default(int);
	}

	[Token(Token = "0x60024FC")]
	[Address(RVA = "0xAB4BD4", Offset = "0xAB4BD4", VA = "0xAB4BD4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B870", Offset = "0x61B870")]
	private void _003CBindAllVariables_003Eb__14_13(int i)
	{
	}
}
