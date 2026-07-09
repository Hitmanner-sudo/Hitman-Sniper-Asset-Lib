using System;
using Il2CppDummyDll;

[Token(Token = "0x200057D")]
public class AssignmentModel : DataModel
{
	[Token(Token = "0x4001CEF")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ASSIGNMENT;

	[Token(Token = "0x4001CF0")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string MISSION;

	[Token(Token = "0x4001CF1")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string UI_FINISHED;

	[NonSerialized]
	[Token(Token = "0x4001CF2")]
	[FieldOffset(Offset = "0x48")]
	private AssignmentData _assignment;

	[NonSerialized]
	[Token(Token = "0x4001CF3")]
	[FieldOffset(Offset = "0x50")]
	private MissionData _mission;

	[NonSerialized]
	[Token(Token = "0x4001CF4")]
	[FieldOffset(Offset = "0x58")]
	private bool _uiFinished;

	[Token(Token = "0x600227F")]
	[Address(RVA = "0xC01F6C", Offset = "0xC01F6C", VA = "0xC01F6C", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002280")]
	[Address(RVA = "0xC02210", Offset = "0xC02210", VA = "0xC02210")]
	public AssignmentModel()
	{
	}

	[Token(Token = "0x6002282")]
	[Address(RVA = "0xC022C0", Offset = "0xC022C0", VA = "0xC022C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619E60", Offset = "0x619E60")]
	private object _003CBindAllVariables_003Eb__6_0()
	{
		return null;
	}

	[Token(Token = "0x6002283")]
	[Address(RVA = "0xC022C8", Offset = "0xC022C8", VA = "0xC022C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619E70", Offset = "0x619E70")]
	private void _003CBindAllVariables_003Eb__6_1(object a)
	{
	}

	[Token(Token = "0x6002284")]
	[Address(RVA = "0xC02354", Offset = "0xC02354", VA = "0xC02354")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619E80", Offset = "0x619E80")]
	private object _003CBindAllVariables_003Eb__6_2()
	{
		return null;
	}

	[Token(Token = "0x6002285")]
	[Address(RVA = "0xC0235C", Offset = "0xC0235C", VA = "0xC0235C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619E90", Offset = "0x619E90")]
	private void _003CBindAllVariables_003Eb__6_3(object m)
	{
	}

	[Token(Token = "0x6002286")]
	[Address(RVA = "0xC023E8", Offset = "0xC023E8", VA = "0xC023E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619EA0", Offset = "0x619EA0")]
	private bool _003CBindAllVariables_003Eb__6_4()
	{
		return default(bool);
	}

	[Token(Token = "0x6002287")]
	[Address(RVA = "0xC023F0", Offset = "0xC023F0", VA = "0xC023F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619EB0", Offset = "0x619EB0")]
	private void _003CBindAllVariables_003Eb__6_5(bool b)
	{
	}
}
