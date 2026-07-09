using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000AF8")]
	public static class Constants
	{
		[Token(Token = "0x40037F1")]
		internal const char PERSISTENCE_KEY_ARRAY_ELEMENT_SEPARATOR_C = ',';

		[Token(Token = "0x40037F2")]
		internal const string PERSISTENCE_KEY_ARRAY_ELEMENT_SEPARATOR_S = ",";

		[Token(Token = "0x40037F3")]
		internal const string PERSISTENCE_KEY_ITEM_QTY_SUFFIX = "availQty";

		[Token(Token = "0x40037F4")]
		internal const string PERSISTENCE_KEY_ITEM_URI_SUFFIX = "uri";

		[Token(Token = "0x40037F5")]
		internal const string PERSISTENCE_KEY_ITEM_DISCOUNT_SUFFIX = "discount";

		[Token(Token = "0x40037F6")]
		internal const string PERSISTENCE_KEY_ITEM_DISCOUNTAPPLIED_SUFFIX = "isapplied";

		[Token(Token = "0x40037F7")]
		internal const string PERSISTENCE_KEY_ITEM_OSMAP = "oskeymap";

		[Token(Token = "0x40037F8")]
		internal const string PERSISTENCE_KEY_TRANSACTION_IDS = "ids";

		[Token(Token = "0x40037F9")]
		internal const string PERSISTENCE_KEY_TRANSACTION_TIMESTAMP = "tmstmp";

		[Token(Token = "0x40037FA")]
		internal const string PERSISTENCE_KEY_TRANSACTION_FP_TRANSACTION_ID = "fptid";

		[Token(Token = "0x40037FB")]
		internal const string PERSISTENCE_KEY_TRANSACTION_FP_TRANSACTION_DATA = "fprdata";

		[Token(Token = "0x40037FC")]
		internal const string PERSISTENCE_KEY_TRANSACTION_STATE = "tstate";

		[Token(Token = "0x40037FD")]
		internal const string PERSISTENCE_KEY_STOCK_IDS = "ids";

		[Token(Token = "0x40037FE")]
		internal const string PERSISTENCE_KEY_SHOP_CONFIG_GUID = "cguid";

		[Token(Token = "0x40037FF")]
		internal const string PERSISTENCE_KEY_INVENTORY_IDS = "ids";

		[Token(Token = "0x4003800")]
		internal const string PERSISTENCE_KEY_INVENTORY_PACKAGE_SUFFIX = "packageuri";

		[Token(Token = "0x4003801")]
		internal const string PERSISTENCE_KEY_OFFERS = "offers";

		[Token(Token = "0x4003802")]
		internal const string PERSISTENCE_KEY_OFFER_IDS = "oids";

		[Token(Token = "0x4003803")]
		internal const string PERSISTENCE_KEY_OFFER_ID = "ofid";

		[Token(Token = "0x4003804")]
		internal const string PERSISTENCE_KEY_OFFER_OWNER = "owid";

		[Token(Token = "0x4003805")]
		internal const string PERSISTENCE_KEY_OFFER_NAME = "nm";

		[Token(Token = "0x4003806")]
		internal const string PERSISTENCE_KEY_OFFER_DESCRIPTION = "desc";

		[Token(Token = "0x4003807")]
		internal const string PERSISTENCE_KEY_OFFER_ISREGISTERED = "isreg";

		[Token(Token = "0x4003808")]
		internal const string PERSISTENCE_KEY_OFFER_TMSTMP = "tmstmp";

		[Token(Token = "0x4003809")]
		internal const string PERSISTENCE_KEY_OFFER_STATE = "state";

		[Token(Token = "0x400380A")]
		internal const string PERSISTENCE_KEY_OFFER_TSTATE = "tstate";

		[Token(Token = "0x400380B")]
		internal const string PERSISTENCE_KEY_OFFER_OSTATE = "ostate";

		[Token(Token = "0x400380C")]
		internal const string PERSISTENCE_KEY_OFFER_SORTINGCATEGORY = "sortc";

		[Token(Token = "0x400380D")]
		internal const string PERSISTENCE_KEY_OFFER_UIURI = "uiuri";

		[Token(Token = "0x400380E")]
		internal const string PERSISTENCE_KEY_OFFER_PRICE = "price";

		[Token(Token = "0x400380F")]
		internal const string PERSISTENCE_KEY_OFFER_CURRENCYCODE = "ccode";

		[Token(Token = "0x4003810")]
		internal const string PERSISTENCE_KEY_OFFER_FORMATTEDPRICE = "fprice";

		[Token(Token = "0x4003811")]
		internal const string PERSISTENCE_KEY_OFFER_CURRENCYSYMBOL = "csymbol";

		[Token(Token = "0x4003812")]
		internal const string PERSISTENCE_KEY_OFFER_SALE = "f_salediscount";

		[Token(Token = "0x4003813")]
		internal const string PERSISTENCE_KEY_OFFER_SALE_EFFECTIVE_DT = "s_saleeffective";

		[Token(Token = "0x4003814")]
		internal const string PERSISTENCE_KEY_OFFER_SALE_EXPIRY_DT = "s_saleexpiry";

		[Token(Token = "0x4003815")]
		internal const string PERSISTENCE_KEY_OFFER_LASTUPDATE = "d_last_update";

		[Token(Token = "0x4003816")]
		internal const string PERSISTENCE_KEY_OFFER_CREDIT_IDS = "cids";

		[Token(Token = "0x4003817")]
		internal const string PERSISTENCE_KEY_OFFER_CREDIT_QTY = "cqty";

		[Token(Token = "0x4003818")]
		internal const string PERSISTENCE_KEY_OFFER_DEBIT_IDS = "dids";

		[Token(Token = "0x4003819")]
		internal const string PERSISTENCE_KEY_OFFER_DEBIT_QTY = "dqty";

		[Token(Token = "0x400381A")]
		internal const string PERSISTENCE_KEY_PREFIX = "technology.shop";

		[Token(Token = "0x400381B")]
		internal const string PERSISTENCE_KEY_INVENTORY_PREFIX = "technology.shop.inventory";

		[Token(Token = "0x400381C")]
		internal const string PERSISTENCE_KEY_TRANSACTION_PREFIX = "technology.shop.transaction";

		[Token(Token = "0x400381D")]
		internal const string PERSISTENCE_KEY_TRANSACTION_ACTIVE_PREFIX = "technology.shop.atransaction";

		[Token(Token = "0x400381E")]
		internal const string PERSISTENCE_KEY_OFFER_PREFIX = "technology.shop.offer";

		[Token(Token = "0x400381F")]
		internal const int INFINITE_SUPPLY = -1;

		[Token(Token = "0x4003820")]
		internal const string STOCK_AVAILABLE_SUCCESS = "sdsuccess";

		[Token(Token = "0x4003821")]
		internal const string INVENTORY_DEBIT_SUCCESS = "idsuccess";

		[Token(Token = "0x4003822")]
		internal const string INVENTORY_CREDIT_SUCCESS = "icsuccess";

		[Token(Token = "0x4003823")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly List<Offer> EMPTY_LIST;

		[Token(Token = "0x4003824")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly string CLASS_CONSUMABLE;

		[Token(Token = "0x4003825")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly string CLASS_NONCONSUMABLE;

		[Token(Token = "0x4003826")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly string CLASS_MEMBERSHIP;
	}
}
