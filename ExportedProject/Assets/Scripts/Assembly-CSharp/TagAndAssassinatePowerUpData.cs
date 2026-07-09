using System;
using Il2CppDummyDll;

[Token(Token = "0x20005D0")]
public class TagAndAssassinatePowerUpData : PowerUpData
{
	[Token(Token = "0x4001F59")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string IS_ASSASSINATING_TARGETS;

	[Token(Token = "0x4001F5A")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string HAS_TARGET_TAGS;

	[NonSerialized]
	[Token(Token = "0x4001F5B")]
	[FieldOffset(Offset = "0x8C")]
	private bool _isAssassinatingTargets;

	[NonSerialized]
	[Token(Token = "0x4001F5C")]
	[FieldOffset(Offset = "0x8D")]
	private bool _hasTargetTags;

	[Token(Token = "0x600252C")]
	[Address(RVA = "0xB4A3EC", Offset = "0xB4A3EC", VA = "0xB4A3EC", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600252D")]
	[Address(RVA = "0xB4A5C8", Offset = "0xB4A5C8", VA = "0xB4A5C8")]
	private void SetBlockedBySelfControlVariable(ref bool controlVar, bool value)
	{
	}

	[Token(Token = "0x600252E")]
	[Address(RVA = "0xB4A668", Offset = "0xB4A668", VA = "0xB4A668", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600252F")]
	[Address(RVA = "0xB4A8CC", Offset = "0xB4A8CC", VA = "0xB4A8CC")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6002530")]
	[Address(RVA = "0xB4AA14", Offset = "0xB4AA14", VA = "0xB4AA14")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6002531")]
	[Address(RVA = "0xB4AA90", Offset = "0xB4AA90", VA = "0xB4AA90")]
	private void OnGameEnded(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002532")]
	[Address(RVA = "0xB4AB20", Offset = "0xB4AB20", VA = "0xB4AB20")]
	private void OnTagged(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002533")]
	[Address(RVA = "0xB4AB24", Offset = "0xB4AB24", VA = "0xB4AB24")]
	private void OnUntagged(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002534")]
	[Address(RVA = "0xB4A778", Offset = "0xB4A778", VA = "0xB4A778")]
	private void TestEnable()
	{
	}

	[Token(Token = "0x6002535")]
	[Address(RVA = "0xB4AB28", Offset = "0xB4AB28", VA = "0xB4AB28")]
	public TagAndAssassinatePowerUpData()
	{
	}

	[Token(Token = "0x6002537")]
	[Address(RVA = "0xB4AC14", Offset = "0xB4AC14", VA = "0xB4AC14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BA60", Offset = "0x61BA60")]
	private bool _003CBindAllVariables_003Eb__4_0()
	{
		return default(bool);
	}

	[Token(Token = "0x6002538")]
	[Address(RVA = "0xB4AC1C", Offset = "0xB4AC1C", VA = "0xB4AC1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BA70", Offset = "0x61BA70")]
	private void _003CBindAllVariables_003Eb__4_1(bool a)
	{
	}

	[Token(Token = "0x6002539")]
	[Address(RVA = "0xB4AC2C", Offset = "0xB4AC2C", VA = "0xB4AC2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BA80", Offset = "0x61BA80")]
	private bool _003CBindAllVariables_003Eb__4_2()
	{
		return default(bool);
	}

	[Token(Token = "0x600253A")]
	[Address(RVA = "0xB4AC34", Offset = "0xB4AC34", VA = "0xB4AC34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BA90", Offset = "0x61BA90")]
	private void _003CBindAllVariables_003Eb__4_3(bool a)
	{
	}
}
