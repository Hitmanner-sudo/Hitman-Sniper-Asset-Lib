using System;
using Il2CppDummyDll;

[Token(Token = "0x20005D5")]
public class BlueprintItemModel : DataModel
{
	[Token(Token = "0x4001F76")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string UNLOCKABLE;

	[Token(Token = "0x4001F77")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string UNLOCKABLE_INDEX;

	[Token(Token = "0x4001F78")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string COMPLETED;

	[Token(Token = "0x4001F79")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string UPGRADE_PURCHASED;

	[Token(Token = "0x4001F7A")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string REFRESH_EQUIPPED_WEAPON;

	[Token(Token = "0x4001F7B")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string SELECTED_CUSTOMIZABLE_ICON;

	[Token(Token = "0x4001F7C")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string MASTERY_UPGRADED;

	[Token(Token = "0x4001F7D")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string IS_JUST_CAUSE_WEAPON;

	[NonSerialized]
	[Token(Token = "0x4001F7E")]
	[FieldOffset(Offset = "0x48")]
	private WeaponUnlockable _unlockable;

	[NonSerialized]
	[Token(Token = "0x4001F7F")]
	[FieldOffset(Offset = "0x50")]
	private int _unlockableIndex;

	[NonSerialized]
	[Token(Token = "0x4001F80")]
	[FieldOffset(Offset = "0x54")]
	private bool _completed;

	[NonSerialized]
	[Token(Token = "0x4001F81")]
	[FieldOffset(Offset = "0x55")]
	private bool _upgradePurchased;

	[NonSerialized]
	[Token(Token = "0x4001F82")]
	[FieldOffset(Offset = "0x56")]
	private bool _refreshEquippedWeapon;

	[NonSerialized]
	[Token(Token = "0x4001F83")]
	[FieldOffset(Offset = "0x58")]
	private SelectedSlot _selectedIcon;

	[NonSerialized]
	[Token(Token = "0x4001F84")]
	[FieldOffset(Offset = "0x60")]
	private bool _masteryUpgraded;

	[NonSerialized]
	[Token(Token = "0x4001F85")]
	[FieldOffset(Offset = "0x61")]
	private bool _isJustCauseWeapon;

	[Token(Token = "0x600255F")]
	[Address(RVA = "0xC6E2C8", Offset = "0xC6E2C8", VA = "0xC6E2C8", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002560")]
	[Address(RVA = "0xC6E868", Offset = "0xC6E868", VA = "0xC6E868")]
	public BlueprintItemModel()
	{
	}

	[Token(Token = "0x6002562")]
	[Address(RVA = "0xC6E9B8", Offset = "0xC6E9B8", VA = "0xC6E9B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BC50", Offset = "0x61BC50")]
	private object _003CBindAllVariables_003Eb__16_0()
	{
		return null;
	}

	[Token(Token = "0x6002563")]
	[Address(RVA = "0xC6E9C0", Offset = "0xC6E9C0", VA = "0xC6E9C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BC60", Offset = "0x61BC60")]
	private void _003CBindAllVariables_003Eb__16_1(object a)
	{
	}

	[Token(Token = "0x6002564")]
	[Address(RVA = "0xC6EA4C", Offset = "0xC6EA4C", VA = "0xC6EA4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BC70", Offset = "0x61BC70")]
	private int _003CBindAllVariables_003Eb__16_2()
	{
		return default(int);
	}

	[Token(Token = "0x6002565")]
	[Address(RVA = "0xC6EA54", Offset = "0xC6EA54", VA = "0xC6EA54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BC80", Offset = "0x61BC80")]
	private void _003CBindAllVariables_003Eb__16_3(int a)
	{
	}

	[Token(Token = "0x6002566")]
	[Address(RVA = "0xC6EA5C", Offset = "0xC6EA5C", VA = "0xC6EA5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BC90", Offset = "0x61BC90")]
	private bool _003CBindAllVariables_003Eb__16_4()
	{
		return default(bool);
	}

	[Token(Token = "0x6002567")]
	[Address(RVA = "0xC6EA64", Offset = "0xC6EA64", VA = "0xC6EA64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BCA0", Offset = "0x61BCA0")]
	private void _003CBindAllVariables_003Eb__16_5(bool a)
	{
	}

	[Token(Token = "0x6002568")]
	[Address(RVA = "0xC6EA70", Offset = "0xC6EA70", VA = "0xC6EA70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BCB0", Offset = "0x61BCB0")]
	private bool _003CBindAllVariables_003Eb__16_6()
	{
		return default(bool);
	}

	[Token(Token = "0x6002569")]
	[Address(RVA = "0xC6EA78", Offset = "0xC6EA78", VA = "0xC6EA78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BCC0", Offset = "0x61BCC0")]
	private void _003CBindAllVariables_003Eb__16_7(bool a)
	{
	}

	[Token(Token = "0x600256A")]
	[Address(RVA = "0xC6EA84", Offset = "0xC6EA84", VA = "0xC6EA84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BCD0", Offset = "0x61BCD0")]
	private bool _003CBindAllVariables_003Eb__16_8()
	{
		return default(bool);
	}

	[Token(Token = "0x600256B")]
	[Address(RVA = "0xC6EA8C", Offset = "0xC6EA8C", VA = "0xC6EA8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BCE0", Offset = "0x61BCE0")]
	private void _003CBindAllVariables_003Eb__16_9(bool a)
	{
	}

	[Token(Token = "0x600256C")]
	[Address(RVA = "0xC6EA98", Offset = "0xC6EA98", VA = "0xC6EA98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BCF0", Offset = "0x61BCF0")]
	private object _003CBindAllVariables_003Eb__16_10()
	{
		return null;
	}

	[Token(Token = "0x600256D")]
	[Address(RVA = "0xC6EAA0", Offset = "0xC6EAA0", VA = "0xC6EAA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BD00", Offset = "0x61BD00")]
	private void _003CBindAllVariables_003Eb__16_11(object a)
	{
	}

	[Token(Token = "0x600256E")]
	[Address(RVA = "0xC6EB2C", Offset = "0xC6EB2C", VA = "0xC6EB2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BD10", Offset = "0x61BD10")]
	private bool _003CBindAllVariables_003Eb__16_12()
	{
		return default(bool);
	}

	[Token(Token = "0x600256F")]
	[Address(RVA = "0xC6EB34", Offset = "0xC6EB34", VA = "0xC6EB34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BD20", Offset = "0x61BD20")]
	private void _003CBindAllVariables_003Eb__16_13(bool a)
	{
	}

	[Token(Token = "0x6002570")]
	[Address(RVA = "0xC6EB40", Offset = "0xC6EB40", VA = "0xC6EB40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BD30", Offset = "0x61BD30")]
	private bool _003CBindAllVariables_003Eb__16_14()
	{
		return default(bool);
	}

	[Token(Token = "0x6002571")]
	[Address(RVA = "0xC6EB48", Offset = "0xC6EB48", VA = "0xC6EB48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BD40", Offset = "0x61BD40")]
	private void _003CBindAllVariables_003Eb__16_15(bool a)
	{
	}
}
