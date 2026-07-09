using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

[Token(Token = "0x20003D3")]
public class TargetsLootBoxItem : LootBoxItem
{
	[Serializable]
	[Token(Token = "0x20003D4")]
	public class RogueKillRange
	{
		[Token(Token = "0x400156F")]
		[FieldOffset(Offset = "0x10")]
		public int Min;

		[Token(Token = "0x4001570")]
		[FieldOffset(Offset = "0x14")]
		public int Max;

		[Token(Token = "0x4001571")]
		[FieldOffset(Offset = "0x18")]
		public Wallet.CurrencyAmount[] ExtraDropTable;

		[Token(Token = "0x60017C1")]
		[Address(RVA = "0xA5557C", Offset = "0xA5557C", VA = "0xA5557C")]
		public RogueKillRange()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20003D5")]
	private struct PartDropDistribution
	{
		[Token(Token = "0x4001572")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B4F98", Offset = "0x5B4F98")]
		private float _noItem;

		[Token(Token = "0x4001573")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B4FD8", Offset = "0x5B4FD8")]
		private float _common;

		[Token(Token = "0x4001574")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B5018", Offset = "0x5B5018")]
		[SerializeField]
		private float _uncommon;

		[Token(Token = "0x4001575")]
		[FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B5058", Offset = "0x5B5058")]
		[SerializeField]
		private float _rare;

		[Token(Token = "0x4001576")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B5098", Offset = "0x5B5098")]
		[SerializeField]
		private float _veryRare;

		[NonSerialized]
		[Token(Token = "0x4001577")]
		[FieldOffset(Offset = "0x18")]
		private float[] _distribution;

		[Token(Token = "0x170003CF")]
		public float[] Distribution
		{
			[Token(Token = "0x60017C2")]
			[Address(RVA = "0xA554BC", Offset = "0xA554BC", VA = "0xA554BC")]
			get
			{
				return null;
			}
		}
	}

	[Token(Token = "0x400156D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RogueKillRange[] _ranges;

	[Token(Token = "0x400156E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PartDropDistribution _partsDistribution;

	[Token(Token = "0x60017BA")]
	[Address(RVA = "0xB544EC", Offset = "0xB544EC", VA = "0xB544EC", Slot = "4")]
	public override bool IsValid(bool fromSkip = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60017BB")]
	[Address(RVA = "0xB545EC", Offset = "0xB545EC", VA = "0xB545EC", Slot = "5")]
	public override LootBoxDroppedItem[] ChooseDrop(float roll)
	{
		return null;
	}

	[Token(Token = "0x60017BC")]
	[Address(RVA = "0xB54860", Offset = "0xB54860", VA = "0xB54860")]
	private static void FillRogueParts(ContractData contract, ICollection<Unlockable> parts)
	{
	}

	[Token(Token = "0x60017BD")]
	[Address(RVA = "0xB54ADC", Offset = "0xB54ADC", VA = "0xB54ADC")]
	private Unlockable ChoosePart(float roll, List<Unlockable> parts)
	{
		return null;
	}

	[Token(Token = "0x60017BE")]
	[Address(RVA = "0xB54BFC", Offset = "0xB54BFC", VA = "0xB54BFC")]
	private RogueKillRange FindRange()
	{
		return null;
	}

	[Token(Token = "0x60017BF")]
	[Address(RVA = "0xB54CD4", Offset = "0xB54CD4", VA = "0xB54CD4", Slot = "7")]
	public override void Restore(JSONNode data)
	{
	}

	[Token(Token = "0x60017C0")]
	[Address(RVA = "0xB54D14", Offset = "0xB54D14", VA = "0xB54D14")]
	public TargetsLootBoxItem()
	{
	}
}
