using Il2CppDummyDll;
using SimpleJSON;

[Token(Token = "0x20003C3")]
public class LootBoxDroppedCurrency : LootBoxDroppedItem
{
	[Token(Token = "0x4001554")]
	private const string AMMOUNT_NODE = "Ammount";

	[Token(Token = "0x4001555")]
	private const string CURRENCY_NODE = "Currency";

	[Token(Token = "0x4001556")]
	[FieldOffset(Offset = "0x10")]
	private readonly Wallet.CurrencyAmount _amount;

	[Token(Token = "0x170003C7")]
	public Wallet.CurrencyAmount Amount
	{
		[Token(Token = "0x600176C")]
		[Address(RVA = "0x9E222C", Offset = "0x9E222C", VA = "0x9E222C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600176D")]
	[Address(RVA = "0x9E2234", Offset = "0x9E2234", VA = "0x9E2234")]
	private LootBoxDroppedCurrency()
	{
	}

	[Token(Token = "0x600176E")]
	[Address(RVA = "0x9E22AC", Offset = "0x9E22AC", VA = "0x9E22AC")]
	public LootBoxDroppedCurrency(Wallet.CurrencyAmount amount)
	{
	}

	[Token(Token = "0x600176F")]
	[Address(RVA = "0x9E22D8", Offset = "0x9E22D8", VA = "0x9E22D8", Slot = "7")]
	public override void Claim()
	{
	}

	[Token(Token = "0x6001770")]
	[Address(RVA = "0x9E2340", Offset = "0x9E2340", VA = "0x9E2340", Slot = "8")]
	public override bool Merge(LootBoxDroppedItem other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001771")]
	[Address(RVA = "0x9E2408", Offset = "0x9E2408", VA = "0x9E2408", Slot = "9")]
	public override void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001772")]
	[Address(RVA = "0x9E2558", Offset = "0x9E2558", VA = "0x9E2558", Slot = "10")]
	public override JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001773")]
	[Address(RVA = "0x9E2680", Offset = "0x9E2680", VA = "0x9E2680", Slot = "11")]
	public override string GetAnalyticsName()
	{
		return null;
	}

	[Token(Token = "0x6001774")]
	[Address(RVA = "0x9E2714", Offset = "0x9E2714", VA = "0x9E2714", Slot = "12")]
	public override int GetAnalyticsQuantity()
	{
		return default(int);
	}
}
