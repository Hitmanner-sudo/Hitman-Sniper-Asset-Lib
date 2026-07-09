using System;
using Il2CppDummyDll;

[Token(Token = "0x20005E2")]
public class SlowMotionModel : DataModel
{
	[Token(Token = "0x4002003")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string SLOW_MOTION;

	[Token(Token = "0x4002004")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string IS_IN_SLOW_MOTION;

	[Token(Token = "0x4002005")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string SLOW_MOTION_PROGRESS;

	[Token(Token = "0x4002006")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string SLOW_MOTION_MINIMUM_PROGRESS_FOR_ACTIVATION;

	[Token(Token = "0x4002007")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string SLOW_MOTION_ENABLED;

	[NonSerialized]
	[Token(Token = "0x4002008")]
	[FieldOffset(Offset = "0x48")]
	private bool _slowMotion;

	[NonSerialized]
	[Token(Token = "0x4002009")]
	[FieldOffset(Offset = "0x49")]
	private bool _isInSlowMotion;

	[NonSerialized]
	[Token(Token = "0x400200A")]
	[FieldOffset(Offset = "0x4C")]
	private float _slowMotionProgress;

	[NonSerialized]
	[Token(Token = "0x400200B")]
	[FieldOffset(Offset = "0x50")]
	private float _slowMotionMinimumProgressForActivation;

	[NonSerialized]
	[Token(Token = "0x400200C")]
	[FieldOffset(Offset = "0x54")]
	private bool _slowMotionEnabled;

	[Token(Token = "0x60025DD")]
	[Address(RVA = "0x847A9C", Offset = "0x847A9C", VA = "0x847A9C", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60025DE")]
	[Address(RVA = "0x847E6C", Offset = "0x847E6C", VA = "0x847E6C")]
	public SlowMotionModel()
	{
	}

	[Token(Token = "0x60025E0")]
	[Address(RVA = "0x847F64", Offset = "0x847F64", VA = "0x847F64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C220", Offset = "0x61C220")]
	private bool _003CBindAllVariables_003Eb__10_0()
	{
		return default(bool);
	}

	[Token(Token = "0x60025E1")]
	[Address(RVA = "0x847F6C", Offset = "0x847F6C", VA = "0x847F6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C230", Offset = "0x61C230")]
	private void _003CBindAllVariables_003Eb__10_1(bool b)
	{
	}

	[Token(Token = "0x60025E2")]
	[Address(RVA = "0x847F78", Offset = "0x847F78", VA = "0x847F78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C240", Offset = "0x61C240")]
	private bool _003CBindAllVariables_003Eb__10_2()
	{
		return default(bool);
	}

	[Token(Token = "0x60025E3")]
	[Address(RVA = "0x847F80", Offset = "0x847F80", VA = "0x847F80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C250", Offset = "0x61C250")]
	private void _003CBindAllVariables_003Eb__10_3(bool b)
	{
	}

	[Token(Token = "0x60025E4")]
	[Address(RVA = "0x847F8C", Offset = "0x847F8C", VA = "0x847F8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C260", Offset = "0x61C260")]
	private float _003CBindAllVariables_003Eb__10_4()
	{
		return default(float);
	}

	[Token(Token = "0x60025E5")]
	[Address(RVA = "0x847F94", Offset = "0x847F94", VA = "0x847F94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C270", Offset = "0x61C270")]
	private void _003CBindAllVariables_003Eb__10_5(float i)
	{
	}

	[Token(Token = "0x60025E6")]
	[Address(RVA = "0x847F9C", Offset = "0x847F9C", VA = "0x847F9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C280", Offset = "0x61C280")]
	private float _003CBindAllVariables_003Eb__10_6()
	{
		return default(float);
	}

	[Token(Token = "0x60025E7")]
	[Address(RVA = "0x847FA4", Offset = "0x847FA4", VA = "0x847FA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C290", Offset = "0x61C290")]
	private void _003CBindAllVariables_003Eb__10_7(float f)
	{
	}

	[Token(Token = "0x60025E8")]
	[Address(RVA = "0x847FAC", Offset = "0x847FAC", VA = "0x847FAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C2A0", Offset = "0x61C2A0")]
	private bool _003CBindAllVariables_003Eb__10_8()
	{
		return default(bool);
	}

	[Token(Token = "0x60025E9")]
	[Address(RVA = "0x847FB4", Offset = "0x847FB4", VA = "0x847FB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C2B0", Offset = "0x61C2B0")]
	private void _003CBindAllVariables_003Eb__10_9(bool b)
	{
	}
}
