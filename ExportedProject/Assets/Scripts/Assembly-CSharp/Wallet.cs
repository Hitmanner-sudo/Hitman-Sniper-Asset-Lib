using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using Technology.Shop;

[Token(Token = "0x20004CB")]
public static class Wallet
{
	[Token(Token = "0x20004CC")]
	public enum Currency
	{
		[Token(Token = "0x400199B")]
		Gold = 0,
		[Token(Token = "0x400199C")]
		ChallengeToken = 1,
		[Token(Token = "0x400199D")]
		NONE = -1
	}

	[Token(Token = "0x20004CD")]
	public class OnCreditsInventoryArgs : EventArgs
	{
		[Token(Token = "0x400199E")]
		[FieldOffset(Offset = "0x10")]
		public List<Credit> Credits;

		[Token(Token = "0x6001D65")]
		[Address(RVA = "0xA41B74", Offset = "0xA41B74", VA = "0xA41B74")]
		public OnCreditsInventoryArgs()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20004CE")]
	public class CurrencyAmount : ISaveable
	{
		[Serializable]
		[Token(Token = "0x20004CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594DF8", Offset = "0x594DF8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40019A3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x6001D6C")]
			[Address(RVA = "0xA477AC", Offset = "0xA477AC", VA = "0xA477AC")]
			public _003C_003Ec()
			{
			}
		}

		[Token(Token = "0x400199F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string CURRENCY_FIELD_NAME;

		[Token(Token = "0x40019A0")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string AMMOUNT_FIELD_NAME;

		[Token(Token = "0x40019A1")]
		[FieldOffset(Offset = "0x10")]
		public Currency Currency;

		[Token(Token = "0x40019A2")]
		[FieldOffset(Offset = "0x14")]
		public int Ammount;

		[Token(Token = "0x6001D66")]
		[Address(RVA = "0xA4158C", Offset = "0xA4158C", VA = "0xA4158C")]
		public CurrencyAmount(Currency currency = Currency.NONE, int ammount = 0)
		{
		}

		[Token(Token = "0x6001D67")]
		[Address(RVA = "0xA415C4", Offset = "0xA415C4", VA = "0xA415C4")]
		public CurrencyAmount(CurrencyAmount amount)
		{
		}

		[Token(Token = "0x6001D68")]
		[Address(RVA = "0xA41604", Offset = "0xA41604", VA = "0xA41604", Slot = "4")]
		public void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x6001D69")]
		[Address(RVA = "0xA41768", Offset = "0xA41768", VA = "0xA41768", Slot = "5")]
		public JSONNode OnSaveableSerialization()
		{
			return null;
		}
	}

	[Token(Token = "0x4001997")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string SOFT_CURRENCY_UI_TAG;

	[Token(Token = "0x4001998")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string CHALLENGE_TOKEN_UI_TAG;

	[Token(Token = "0x14000072")]
	public static event EventHandler<OnCreditsInventoryArgs> OnCreditsInventory
	{
		[Token(Token = "0x6001D53")]
		[Address(RVA = "0x97CB14", Offset = "0x97CB14", VA = "0x97CB14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6187B8", Offset = "0x6187B8")]
		add
		{
		}
		[Token(Token = "0x6001D54")]
		[Address(RVA = "0x97CC0C", Offset = "0x97CC0C", VA = "0x97CC0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6187C8", Offset = "0x6187C8")]
		remove
		{
		}
	}

	[Token(Token = "0x6001D55")]
	[Address(RVA = "0x97CD04", Offset = "0x97CD04", VA = "0x97CD04")]
	public static string GetCurrencyUIString(CurrencyAmount currencyAmount)
	{
		return null;
	}

	[Token(Token = "0x6001D56")]
	[Address(RVA = "0x97CE5C", Offset = "0x97CE5C", VA = "0x97CE5C")]
	public static string GetCurrencyUIString(string currencyType)
	{
		return null;
	}

	[Token(Token = "0x6001D57")]
	[Address(RVA = "0x97CD98", Offset = "0x97CD98", VA = "0x97CD98")]
	public static string GetCurrencyUIString(Currency currencyType)
	{
		return null;
	}

	[Token(Token = "0x6001D58")]
	[Address(RVA = "0x97CFCC", Offset = "0x97CFCC", VA = "0x97CFCC")]
	public static void CreditInventory(CurrencyAmount currencyAmount)
	{
	}

	[Token(Token = "0x6001D59")]
	[Address(RVA = "0x97D044", Offset = "0x97D044", VA = "0x97D044")]
	public static void CreditInventory(Currency currency, int ammount)
	{
	}

	[Token(Token = "0x6001D5A")]
	[Address(RVA = "0x97D1C8", Offset = "0x97D1C8", VA = "0x97D1C8")]
	public static void CreditInventory(List<Credit> credits)
	{
	}

	[Token(Token = "0x6001D5B")]
	[Address(RVA = "0x97D360", Offset = "0x97D360", VA = "0x97D360")]
	public static int GetCurrencyTotal(List<Credit> credits, Currency currencyType)
	{
		return default(int);
	}

	[Token(Token = "0x6001D5C")]
	[Address(RVA = "0x97D52C", Offset = "0x97D52C", VA = "0x97D52C")]
	public static string GetIAPCostFormat(Offer offer)
	{
		return null;
	}

	[Token(Token = "0x6001D5D")]
	[Address(RVA = "0x97D678", Offset = "0x97D678", VA = "0x97D678")]
	public static string GetIAPCostFormat(string currencyCode, string formattedPrice)
	{
		return null;
	}

	[Token(Token = "0x6001D5E")]
	[Address(RVA = "0x97D6D8", Offset = "0x97D6D8", VA = "0x97D6D8")]
	public static string GetInGameCostFormat(CurrencyAmount currencyAmount)
	{
		return null;
	}

	[Token(Token = "0x6001D5F")]
	[Address(RVA = "0x97D748", Offset = "0x97D748", VA = "0x97D748")]
	public static string GetInGameCostFormat(string currencyUIString, int amount)
	{
		return null;
	}

	[Token(Token = "0x6001D60")]
	[Address(RVA = "0x97D5EC", Offset = "0x97D5EC", VA = "0x97D5EC")]
	public static string GetIAPPriceFormat(float price)
	{
		return null;
	}

	[Token(Token = "0x6001D61")]
	[Address(RVA = "0x97D7D4", Offset = "0x97D7D4", VA = "0x97D7D4")]
	public static void SetWeaponSaleFormat(string onSaleLabelLOC, UILabel onSaleLabel, UILabel onSaleCostBottomLabel, float saleDiscount, Offer offer, UILabel onSaleCostTopLabel, UISprite onSaleCostTopSlashSprite)
	{
	}

	[Token(Token = "0x6001D62")]
	[Address(RVA = "0x97DD10", Offset = "0x97DD10", VA = "0x97DD10")]
	public static void SetCurrencyPackSaleFormat(UILabel onSaleLabel, UILabel onSaleCostBottomLabel, float saleDiscount, Offer offer, UILabel onSaleCostTopLabel, UISprite onSaleCostTopSlashSprite)
	{
	}

	[Token(Token = "0x6001D63")]
	[Address(RVA = "0x97D920", Offset = "0x97D920", VA = "0x97D920")]
	private static void SetSaleFormat(string onSaleLabelText, UILabel onSaleLabel, UILabel onSaleCostBottomLabel, float saleDiscount, Offer offer, UILabel onSaleCostTopLabel, UISprite onSaleCostTopSlashSprite)
	{
	}
}
