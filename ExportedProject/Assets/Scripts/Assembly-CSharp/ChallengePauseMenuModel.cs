using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200058F")]
public class ChallengePauseMenuModel : DataModel
{
	[Token(Token = "0x2000590")]
	public enum ChallengePauseMenuState
	{
		[Token(Token = "0x4001D47")]
		SHOP = 0,
		[Token(Token = "0x4001D48")]
		SETTINGS = 1
	}

	[Token(Token = "0x4001D42")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string CHALLENGE_PAUSE_STATE;

	[Token(Token = "0x4001D43")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string UPGRADE_PAGE_PREFAB;

	[NonSerialized]
	[Token(Token = "0x4001D44")]
	[FieldOffset(Offset = "0x48")]
	private ChallengePauseMenuState _state;

	[Token(Token = "0x4001D45")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UpgradeView _upgradeView;

	[Token(Token = "0x60022C8")]
	[Address(RVA = "0xAF582C", Offset = "0xAF582C", VA = "0xAF582C", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60022C9")]
	[Address(RVA = "0xAF59C0", Offset = "0xAF59C0", VA = "0xAF59C0")]
	public ChallengePauseMenuModel()
	{
	}

	[Token(Token = "0x60022CB")]
	[Address(RVA = "0xAF5A50", Offset = "0xAF5A50", VA = "0xAF5A50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A060", Offset = "0x61A060")]
	private object _003CBindAllVariables_003Eb__5_0()
	{
		return null;
	}

	[Token(Token = "0x60022CC")]
	[Address(RVA = "0xAF5AB0", Offset = "0xAF5AB0", VA = "0xAF5AB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A070", Offset = "0x61A070")]
	private void _003CBindAllVariables_003Eb__5_1(object s)
	{
	}

	[Token(Token = "0x60022CD")]
	[Address(RVA = "0xAF5B34", Offset = "0xAF5B34", VA = "0xAF5B34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A080", Offset = "0x61A080")]
	private object _003CBindAllVariables_003Eb__5_2()
	{
		return null;
	}
}
