using System;
using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

[Token(Token = "0x20003BB")]
public class CurrencyLootBoxItem : LootBoxItem
{
	[Serializable]
	[Token(Token = "0x20003BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59361C", Offset = "0x59361C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400153B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x6001743")]
		[Address(RVA = "0x865684", Offset = "0x865684", VA = "0x865684")]
		public _003C_003Ec()
		{
		}
	}

	[Token(Token = "0x4001537")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string COUNT_FIELD_NAME;

	[Token(Token = "0x4001538")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string REWARDS_FIELD_NAME;

	[Token(Token = "0x4001539")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int _count;

	[Token(Token = "0x400153A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Wallet.CurrencyAmount[] _rewards;

	[Token(Token = "0x600173D")]
	[Address(RVA = "0xD8A9C0", Offset = "0xD8A9C0", VA = "0xD8A9C0", Slot = "4")]
	public override bool IsValid(bool fromSkip = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600173E")]
	[Address(RVA = "0xD8A9C8", Offset = "0xD8A9C8", VA = "0xD8A9C8", Slot = "5")]
	public override LootBoxDroppedItem[] ChooseDrop(float roll)
	{
		return null;
	}

	[Token(Token = "0x600173F")]
	[Address(RVA = "0xD8AB20", Offset = "0xD8AB20", VA = "0xD8AB20", Slot = "7")]
	public override void Restore(JSONNode data)
	{
	}

	[Token(Token = "0x6001740")]
	[Address(RVA = "0xD8AD78", Offset = "0xD8AD78", VA = "0xD8AD78")]
	public CurrencyLootBoxItem()
	{
	}
}
