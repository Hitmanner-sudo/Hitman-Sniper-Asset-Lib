using System;
using Il2CppDummyDll;

[Token(Token = "0x20005AE")]
public class InsufficientFundsWatchAdModel : DataModel
{
	[Token(Token = "0x4001E58")]
	public const string MISSING_FUNDS = "InsufficientFundsWatchAdModel.MissingFunds";

	[NonSerialized]
	[Token(Token = "0x4001E59")]
	[FieldOffset(Offset = "0x48")]
	private Wallet.CurrencyAmount _missingFunds;

	[Token(Token = "0x60023F4")]
	[Address(RVA = "0xB154BC", Offset = "0xB154BC", VA = "0xB154BC", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60023F5")]
	[Address(RVA = "0xB155CC", Offset = "0xB155CC", VA = "0xB155CC")]
	public InsufficientFundsWatchAdModel()
	{
	}

	[Token(Token = "0x60023F6")]
	[Address(RVA = "0xB155D4", Offset = "0xB155D4", VA = "0xB155D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AC70", Offset = "0x61AC70")]
	private object _003CBindAllVariables_003Eb__2_0()
	{
		return null;
	}

	[Token(Token = "0x60023F7")]
	[Address(RVA = "0xB155DC", Offset = "0xB155DC", VA = "0xB155DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AC80", Offset = "0x61AC80")]
	private void _003CBindAllVariables_003Eb__2_1(object a)
	{
	}
}
