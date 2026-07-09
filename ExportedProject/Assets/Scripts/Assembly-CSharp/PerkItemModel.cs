using Il2CppDummyDll;

[Token(Token = "0x20005CA")]
public class PerkItemModel : DataModel
{
	[Token(Token = "0x4001F1D")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PERK;

	[Token(Token = "0x4001F1E")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string CLAIMED;

	[Token(Token = "0x4001F1F")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string PRICE;

	[Token(Token = "0x4001F20")]
	[FieldOffset(Offset = "0x48")]
	private Perk _perk;

	[Token(Token = "0x4001F21")]
	[FieldOffset(Offset = "0x50")]
	private bool _claimed;

	[Token(Token = "0x4001F22")]
	[FieldOffset(Offset = "0x54")]
	private int _price;

	[Token(Token = "0x60024DA")]
	[Address(RVA = "0x8FFA84", Offset = "0x8FFA84", VA = "0x8FFA84", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60024DB")]
	[Address(RVA = "0x8FFD68", Offset = "0x8FFD68", VA = "0x8FFD68")]
	public PerkItemModel()
	{
	}

	[Token(Token = "0x60024DD")]
	[Address(RVA = "0x8FFE18", Offset = "0x8FFE18", VA = "0x8FFE18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B6E0", Offset = "0x61B6E0")]
	private object _003CBindAllVariables_003Eb__6_0()
	{
		return null;
	}

	[Token(Token = "0x60024DE")]
	[Address(RVA = "0x8FFE20", Offset = "0x8FFE20", VA = "0x8FFE20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B6F0", Offset = "0x61B6F0")]
	private void _003CBindAllVariables_003Eb__6_1(object a)
	{
	}

	[Token(Token = "0x60024DF")]
	[Address(RVA = "0x8FFEAC", Offset = "0x8FFEAC", VA = "0x8FFEAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B700", Offset = "0x61B700")]
	private bool _003CBindAllVariables_003Eb__6_2()
	{
		return default(bool);
	}

	[Token(Token = "0x60024E0")]
	[Address(RVA = "0x8FFEB4", Offset = "0x8FFEB4", VA = "0x8FFEB4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B710", Offset = "0x61B710")]
	private void _003CBindAllVariables_003Eb__6_3(bool a)
	{
	}

	[Token(Token = "0x60024E1")]
	[Address(RVA = "0x8FFEC0", Offset = "0x8FFEC0", VA = "0x8FFEC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B720", Offset = "0x61B720")]
	private int _003CBindAllVariables_003Eb__6_4()
	{
		return default(int);
	}

	[Token(Token = "0x60024E2")]
	[Address(RVA = "0x8FFEC8", Offset = "0x8FFEC8", VA = "0x8FFEC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B730", Offset = "0x61B730")]
	private void _003CBindAllVariables_003Eb__6_5(int a)
	{
	}
}
