using System;
using Il2CppDummyDll;

[Token(Token = "0x20005C3")]
public class MenuOptionsModel : DataModel
{
	[Token(Token = "0x4001EFC")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string SELECTED_QUALITY;

	[Token(Token = "0x4001EFD")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string SHOW_CREDITS;

	[NonSerialized]
	[Token(Token = "0x4001EFE")]
	[FieldOffset(Offset = "0x48")]
	private int _selectedQuality;

	[NonSerialized]
	[Token(Token = "0x4001EFF")]
	[FieldOffset(Offset = "0x4C")]
	private bool _showCredits;

	[Token(Token = "0x6002499")]
	[Address(RVA = "0x9BE878", Offset = "0x9BE878", VA = "0x9BE878", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600249A")]
	[Address(RVA = "0x9BEA88", Offset = "0x9BEA88", VA = "0x9BEA88")]
	public MenuOptionsModel()
	{
	}

	[Token(Token = "0x600249C")]
	[Address(RVA = "0x9BEB20", Offset = "0x9BEB20", VA = "0x9BEB20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B520", Offset = "0x61B520")]
	private int _003CBindAllVariables_003Eb__4_0()
	{
		return default(int);
	}

	[Token(Token = "0x600249D")]
	[Address(RVA = "0x9BEB28", Offset = "0x9BEB28", VA = "0x9BEB28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B530", Offset = "0x61B530")]
	private void _003CBindAllVariables_003Eb__4_1(int i)
	{
	}

	[Token(Token = "0x600249E")]
	[Address(RVA = "0x9BEB30", Offset = "0x9BEB30", VA = "0x9BEB30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B540", Offset = "0x61B540")]
	private bool _003CBindAllVariables_003Eb__4_2()
	{
		return default(bool);
	}

	[Token(Token = "0x600249F")]
	[Address(RVA = "0x9BEB38", Offset = "0x9BEB38", VA = "0x9BEB38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B550", Offset = "0x61B550")]
	private void _003CBindAllVariables_003Eb__4_3(bool b)
	{
	}
}
