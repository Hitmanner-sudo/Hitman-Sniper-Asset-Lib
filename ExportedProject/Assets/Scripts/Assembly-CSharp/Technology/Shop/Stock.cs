using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Security;

namespace Technology.Shop
{
	[Token(Token = "0x2000B39")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x598068", Offset = "0x598068")]
	internal class Stock
	{
		[Token(Token = "0x400393C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Item> _stock;

		[Token(Token = "0x170008F4")]
		internal Item Item
		{
			[Token(Token = "0x60046E7")]
			[Address(RVA = "0xD2A968", Offset = "0xD2A968", VA = "0xD2A968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046E2")]
		[Address(RVA = "0xD2A4C4", Offset = "0xD2A4C4", VA = "0xD2A4C4")]
		internal Stock(ShopConfiguration shopConfiguration)
		{
		}

		[Token(Token = "0x60046E3")]
		[Address(RVA = "0xD2A648", Offset = "0xD2A648", VA = "0xD2A648")]
		internal Dictionary<string, Item> GetSkus()
		{
			return null;
		}

		[Token(Token = "0x60046E4")]
		[Address(RVA = "0xD2A650", Offset = "0xD2A650", VA = "0xD2A650")]
		internal List<Tuple<string, SecureLocalInt>> GetStock(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x60046E5")]
		[Address(RVA = "0xD2A88C", Offset = "0xD2A88C", VA = "0xD2A88C")]
		internal SecureLocalInt GetStock(Credit credit)
		{
			return null;
		}

		[Token(Token = "0x60046E6")]
		[Address(RVA = "0xD2A8A0", Offset = "0xD2A8A0", VA = "0xD2A8A0")]
		internal SecureLocalInt GetStock(string itemId)
		{
			return null;
		}

		[Token(Token = "0x60046E8")]
		[Address(RVA = "0xD2AA1C", Offset = "0xD2AA1C", VA = "0xD2AA1C")]
		internal void SetRemoteGameplayURI(string itemid, string uri)
		{
		}

		[Token(Token = "0x60046E9")]
		[Address(RVA = "0xD2AABC", Offset = "0xD2AABC", VA = "0xD2AABC")]
		internal bool IsStockAvailable(Offer offer)
		{
			return default(bool);
		}

		[Token(Token = "0x60046EA")]
		[Address(RVA = "0xD2AAD0", Offset = "0xD2AAD0", VA = "0xD2AAD0")]
		internal bool IsStockAvailable(List<Credit> credits)
		{
			return default(bool);
		}

		[Token(Token = "0x60046EB")]
		[Address(RVA = "0xD2AB7C", Offset = "0xD2AB7C", VA = "0xD2AB7C")]
		private bool IsStockAvailable(Credit credit)
		{
			return default(bool);
		}

		[Token(Token = "0x60046EC")]
		[Address(RVA = "0xD2AD14", Offset = "0xD2AD14", VA = "0xD2AD14")]
		internal bool IsStockAvailable(ILedgerEntry credit)
		{
			return default(bool);
		}

		[Token(Token = "0x60046ED")]
		[Address(RVA = "0xD2ABDC", Offset = "0xD2ABDC", VA = "0xD2ABDC")]
		internal bool IsStockAvailable(string itemId, int itemQuantity)
		{
			return default(bool);
		}

		[Token(Token = "0x60046EE")]
		[Address(RVA = "0xD2AE50", Offset = "0xD2AE50", VA = "0xD2AE50")]
		internal string Print()
		{
			return null;
		}
	}
}
