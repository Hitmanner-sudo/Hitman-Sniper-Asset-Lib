using Il2CppDummyDll;

[Token(Token = "0x20005FE")]
public class ToggledModItemModel : DataModel
{
	[Token(Token = "0x400209B")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string UNLOCKED;

	[Token(Token = "0x400209C")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string TOGGLED_MOD;

	[Token(Token = "0x400209D")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string COST;

	[Token(Token = "0x400209E")]
	[FieldOffset(Offset = "0x48")]
	private ToggledMod _toggled_Mod;

	[Token(Token = "0x400209F")]
	[FieldOffset(Offset = "0x50")]
	private bool _unlocked;

	[Token(Token = "0x40020A0")]
	[FieldOffset(Offset = "0x54")]
	private int _cost;

	[Token(Token = "0x600268B")]
	[Address(RVA = "0xAD117C", Offset = "0xAD117C", VA = "0xAD117C", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600268C")]
	[Address(RVA = "0xAD1460", Offset = "0xAD1460", VA = "0xAD1460")]
	public ToggledModItemModel()
	{
	}

	[Token(Token = "0x600268E")]
	[Address(RVA = "0xAD1510", Offset = "0xAD1510", VA = "0xAD1510")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C760", Offset = "0x61C760")]
	private object _003CBindAllVariables_003Eb__6_0()
	{
		return null;
	}

	[Token(Token = "0x600268F")]
	[Address(RVA = "0xAD1518", Offset = "0xAD1518", VA = "0xAD1518")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C770", Offset = "0x61C770")]
	private void _003CBindAllVariables_003Eb__6_1(object a)
	{
	}

	[Token(Token = "0x6002690")]
	[Address(RVA = "0xAD15A4", Offset = "0xAD15A4", VA = "0xAD15A4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C780", Offset = "0x61C780")]
	private bool _003CBindAllVariables_003Eb__6_2()
	{
		return default(bool);
	}

	[Token(Token = "0x6002691")]
	[Address(RVA = "0xAD15AC", Offset = "0xAD15AC", VA = "0xAD15AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C790", Offset = "0x61C790")]
	private void _003CBindAllVariables_003Eb__6_3(bool a)
	{
	}

	[Token(Token = "0x6002692")]
	[Address(RVA = "0xAD15B8", Offset = "0xAD15B8", VA = "0xAD15B8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C7A0", Offset = "0x61C7A0")]
	private int _003CBindAllVariables_003Eb__6_4()
	{
		return default(int);
	}

	[Token(Token = "0x6002693")]
	[Address(RVA = "0xAD15C0", Offset = "0xAD15C0", VA = "0xAD15C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C7B0", Offset = "0x61C7B0")]
	private void _003CBindAllVariables_003Eb__6_5(int a)
	{
	}
}
