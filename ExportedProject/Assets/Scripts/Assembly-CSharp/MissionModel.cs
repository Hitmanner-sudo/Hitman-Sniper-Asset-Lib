using System;
using Il2CppDummyDll;

[Token(Token = "0x20005C4")]
public class MissionModel : DataModel
{
	[Token(Token = "0x4001F00")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string MISSION;

	[Token(Token = "0x4001F01")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string PRIMARY_ASSIGNMENT;

	[Token(Token = "0x4001F02")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string SHOULD_SHOW_WEAPON_SUGGESTION;

	[NonSerialized]
	[Token(Token = "0x4001F03")]
	[FieldOffset(Offset = "0x48")]
	private MissionData _mission;

	[NonSerialized]
	[Token(Token = "0x4001F04")]
	[FieldOffset(Offset = "0x50")]
	private AssignmentModel _primaryAssignment;

	[NonSerialized]
	[Token(Token = "0x4001F05")]
	[FieldOffset(Offset = "0x58")]
	private bool _shouldShowWeaponSuggestion;

	[Token(Token = "0x60024A0")]
	[Address(RVA = "0xA1B3E8", Offset = "0xA1B3E8", VA = "0xA1B3E8", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60024A1")]
	[Address(RVA = "0xA1B68C", Offset = "0xA1B68C", VA = "0xA1B68C")]
	public MissionModel()
	{
	}

	[Token(Token = "0x60024A3")]
	[Address(RVA = "0xA1B73C", Offset = "0xA1B73C", VA = "0xA1B73C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B560", Offset = "0x61B560")]
	private object _003CBindAllVariables_003Eb__6_0()
	{
		return null;
	}

	[Token(Token = "0x60024A4")]
	[Address(RVA = "0xA1B744", Offset = "0xA1B744", VA = "0xA1B744")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B570", Offset = "0x61B570")]
	private void _003CBindAllVariables_003Eb__6_1(object m)
	{
	}

	[Token(Token = "0x60024A5")]
	[Address(RVA = "0xA1B7D0", Offset = "0xA1B7D0", VA = "0xA1B7D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B580", Offset = "0x61B580")]
	private object _003CBindAllVariables_003Eb__6_2()
	{
		return null;
	}

	[Token(Token = "0x60024A6")]
	[Address(RVA = "0xA1B7D8", Offset = "0xA1B7D8", VA = "0xA1B7D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B590", Offset = "0x61B590")]
	private void _003CBindAllVariables_003Eb__6_3(object a)
	{
	}

	[Token(Token = "0x60024A7")]
	[Address(RVA = "0xA1B864", Offset = "0xA1B864", VA = "0xA1B864")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B5A0", Offset = "0x61B5A0")]
	private bool _003CBindAllVariables_003Eb__6_4()
	{
		return default(bool);
	}

	[Token(Token = "0x60024A8")]
	[Address(RVA = "0xA1B86C", Offset = "0xA1B86C", VA = "0xA1B86C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B5B0", Offset = "0x61B5B0")]
	private void _003CBindAllVariables_003Eb__6_5(bool b)
	{
	}
}
