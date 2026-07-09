using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x20003CF")]
public class MissionRewardLootBoxItem : LootBoxItem
{
	[Serializable]
	[Token(Token = "0x20003D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59367C", Offset = "0x59367C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001568")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x8C7F3C", Offset = "0x8C7F3C", VA = "0x8C7F3C")]
		public _003C_003Ec()
		{
		}
	}

	[Token(Token = "0x4001564")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string REWARD_BASE_FIELD_NAME;

	[Token(Token = "0x4001565")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string REWARD_STEP_FIELD_NAME;

	[Token(Token = "0x4001566")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SecureIntWrapper _rewardBase;

	[Token(Token = "0x4001567")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SecureIntWrapper _rewardStep;

	[Token(Token = "0x60017AB")]
	[Address(RVA = "0xA1BC20", Offset = "0xA1BC20", VA = "0xA1BC20", Slot = "4")]
	public override bool IsValid(bool fromSkip = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60017AC")]
	[Address(RVA = "0xA1BDDC", Offset = "0xA1BDDC", VA = "0xA1BDDC", Slot = "5")]
	public override LootBoxDroppedItem[] ChooseDrop(float roll)
	{
		return null;
	}

	[Token(Token = "0x60017AD")]
	[Address(RVA = "0xA1BF9C", Offset = "0xA1BF9C", VA = "0xA1BF9C", Slot = "7")]
	public override void Restore(JSONNode data)
	{
	}

	[Token(Token = "0x60017AE")]
	[Address(RVA = "0xA1C160", Offset = "0xA1C160", VA = "0xA1C160")]
	public MissionRewardLootBoxItem()
	{
	}
}
