using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004A6")]
public class InsufficientFundsAdData : ISaveable
{
	[Token(Token = "0x20004A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594C58", Offset = "0x594C58")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x400190D")]
		[FieldOffset(Offset = "0x10")]
		public Wallet.CurrencyAmount amount;

		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0xB27604", Offset = "0xB27604", VA = "0xB27604")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6001C50")]
		[Address(RVA = "0xB2760C", Offset = "0xB2760C", VA = "0xB2760C")]
		internal bool _003CCanBeUsed_003Eb__0(Wallet.CurrencyAmount c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400190A")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private SerializableTimeSpan _cooldownPeriod;

	[Token(Token = "0x400190B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Wallet.CurrencyAmount[] _maxAmounts;

	[Token(Token = "0x400190C")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6DF4", Offset = "0x5B6DF4")]
	private long _lastUsedTicks;

	[Token(Token = "0x6001C4A")]
	[Address(RVA = "0xB141EC", Offset = "0xB141EC", VA = "0xB141EC")]
	public bool CanBeUsed(Wallet.CurrencyAmount amount)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C4B")]
	[Address(RVA = "0xB143E8", Offset = "0xB143E8", VA = "0xB143E8")]
	public void RegisterUse()
	{
	}

	[Token(Token = "0x6001C4C")]
	[Address(RVA = "0xB1446C", Offset = "0xB1446C", VA = "0xB1446C", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001C4D")]
	[Address(RVA = "0xB144F4", Offset = "0xB144F4", VA = "0xB144F4", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001C4E")]
	[Address(RVA = "0xB1456C", Offset = "0xB1456C", VA = "0xB1456C")]
	public InsufficientFundsAdData()
	{
	}
}
