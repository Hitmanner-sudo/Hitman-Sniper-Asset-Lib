using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Prime31;
using Technology.Core.Auth;

namespace Technology.Shop
{
	[Token(Token = "0x2000B1B")]
	internal class GoogleShop : AbstractShop
	{
		[Serializable]
		[Token(Token = "0x2000B1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597F50", Offset = "0x597F50")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40038B1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40038B2")]
			[FieldOffset(Offset = "0x8")]
			public static Func<OfferDescription, bool> _003C_003E9__13_0;

			[Token(Token = "0x40038B3")]
			[FieldOffset(Offset = "0x10")]
			public static Action<Offer> _003C_003E9__15_0;

			[Token(Token = "0x40038B4")]
			[FieldOffset(Offset = "0x18")]
			public static Func<Offer, string> _003C_003E9__16_0;

			[Token(Token = "0x40038B5")]
			[FieldOffset(Offset = "0x20")]
			public static Action<Offer> _003C_003E9__26_0;

			[Token(Token = "0x60045A8")]
			[Address(RVA = "0x8770F8", Offset = "0x8770F8", VA = "0x8770F8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60045A9")]
			[Address(RVA = "0x877100", Offset = "0x877100", VA = "0x877100")]
			internal bool _003CRefreshOffers_003Eb__13_0(OfferDescription description)
			{
				return default(bool);
			}

			[Token(Token = "0x60045AA")]
			[Address(RVA = "0x877118", Offset = "0x877118", VA = "0x877118")]
			internal void _003COnInitCompletedBillingNotSupported_003Eb__15_0(Offer o)
			{
			}

			[Token(Token = "0x60045AB")]
			[Address(RVA = "0x877138", Offset = "0x877138", VA = "0x877138")]
			internal string _003CQueryInventory_003Eb__16_0(Offer offer)
			{
				return null;
			}

			[Token(Token = "0x60045AC")]
			[Address(RVA = "0x877150", Offset = "0x877150", VA = "0x877150")]
			internal void _003COfferListRequestFailed_003Eb__26_0(Offer o)
			{
			}
		}

		[Token(Token = "0x2000B1D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597F60", Offset = "0x597F60")]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			[Token(Token = "0x40038B6")]
			[FieldOffset(Offset = "0x10")]
			public GoogleShop _003C_003E4__this;

			[Token(Token = "0x40038B7")]
			[FieldOffset(Offset = "0x18")]
			public GooglePurchase googlePurchase;

			[Token(Token = "0x60045AD")]
			[Address(RVA = "0x877170", Offset = "0x877170", VA = "0x877170")]
			public _003C_003Ec__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60045AE")]
			[Address(RVA = "0x877178", Offset = "0x877178", VA = "0x877178")]
			internal void _003CConfirmTransactionPurchase_003Eb__0(Transaction t)
			{
			}
		}

		[Token(Token = "0x2000B1E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597F70", Offset = "0x597F70")]
		private sealed class _003C_003Ec__DisplayClass29_0
		{
			[Token(Token = "0x40038B8")]
			[FieldOffset(Offset = "0x10")]
			public Offer offer;

			[Token(Token = "0x60045AF")]
			[Address(RVA = "0x8775E8", Offset = "0x8775E8", VA = "0x8775E8")]
			public _003C_003Ec__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60045B0")]
			[Address(RVA = "0x8775F0", Offset = "0x8775F0", VA = "0x8775F0")]
			internal void _003CBuy_003Eb__0(Transaction t)
			{
			}
		}

		[Token(Token = "0x40038AD")]
		internal const string SHOP_ID = "GOOGLESHOP";

		[Token(Token = "0x40038AE")]
		[FieldOffset(Offset = "0x0")]
		private static bool? _billingSupported;

		[Token(Token = "0x40038AF")]
		[FieldOffset(Offset = "0x78")]
		private readonly List<GooglePurchase> _purchasedGoogleOffers;

		[Token(Token = "0x40038B0")]
		[FieldOffset(Offset = "0x80")]
		private string _googleBillingKey;

		[Token(Token = "0x170008B7")]
		internal override string Id
		{
			[Token(Token = "0x6004585")]
			[Address(RVA = "0xC86AD8", Offset = "0xC86AD8", VA = "0xC86AD8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B8")]
		internal override int RefreshOrderIndex
		{
			[Token(Token = "0x6004586")]
			[Address(RVA = "0xC86B1C", Offset = "0xC86B1C", VA = "0xC86B1C", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004587")]
		[Address(RVA = "0xC86B24", Offset = "0xC86B24", VA = "0xC86B24", Slot = "11")]
		internal override bool Initialize(ShopConfiguration shopConfiguration, OfferController offerController, Stock stock, Inventory inventory)
		{
			return default(bool);
		}

		[Token(Token = "0x6004588")]
		[Address(RVA = "0xC86C0C", Offset = "0xC86C0C", VA = "0xC86C0C")]
		private void RegisterAuthenticationCallbacks()
		{
		}

		[Token(Token = "0x6004589")]
		[Address(RVA = "0xC86E2C", Offset = "0xC86E2C", VA = "0xC86E2C")]
		private void OnLogin(object sender, AuthenticationEvent e)
		{
		}

		[Token(Token = "0x600458A")]
		[Address(RVA = "0xC86EB8", Offset = "0xC86EB8", VA = "0xC86EB8")]
		private static void BillingSupportedCallback()
		{
		}

		[Token(Token = "0x600458B")]
		[Address(RVA = "0xC86F30", Offset = "0xC86F30", VA = "0xC86F30")]
		private static void BillingNotSupportedCallback(string error)
		{
		}

		[Token(Token = "0x600458C")]
		[Address(RVA = "0xC86FA8", Offset = "0xC86FA8", VA = "0xC86FA8", Slot = "4")]
		protected override bool RefreshOffers()
		{
			return default(bool);
		}

		[Token(Token = "0x600458D")]
		[Address(RVA = "0xC87208", Offset = "0xC87208", VA = "0xC87208")]
		private void OnInitCompleted()
		{
		}

		[Token(Token = "0x600458E")]
		[Address(RVA = "0xC873C4", Offset = "0xC873C4", VA = "0xC873C4")]
		private void OnInitCompletedBillingNotSupported(string s)
		{
		}

		[Token(Token = "0x600458F")]
		[Address(RVA = "0xC87670", Offset = "0xC87670", VA = "0xC87670")]
		private void QueryInventory()
		{
		}

		[Token(Token = "0x6004590")]
		[Address(RVA = "0xC87948", Offset = "0xC87948", VA = "0xC87948")]
		private void RestoreSucceededEvent(GooglePurchase googlePurchase)
		{
		}

		[Token(Token = "0x6004591")]
		[Address(RVA = "0xC879AC", Offset = "0xC879AC", VA = "0xC879AC")]
		private void SucceededEvent(GooglePurchase googlePurchase)
		{
		}

		[Token(Token = "0x6004592")]
		[Address(RVA = "0xC87E28", Offset = "0xC87E28", VA = "0xC87E28")]
		private void BuyFailedCallback(string errorMessage, int errorCode)
		{
		}

		[Token(Token = "0x6004593")]
		[Address(RVA = "0xC88058", Offset = "0xC88058", VA = "0xC88058")]
		private void BuyFailedCallback(string errorMessage)
		{
		}

		[Token(Token = "0x6004594")]
		[Address(RVA = "0xC87E5C", Offset = "0xC87E5C", VA = "0xC87E5C")]
		private static Transaction LastTransaction()
		{
			return null;
		}

		[Token(Token = "0x6004595")]
		[Address(RVA = "0xC87FB0", Offset = "0xC87FB0", VA = "0xC87FB0")]
		private void FailTransaction(Transaction transaction, string errorMessage)
		{
		}

		[Token(Token = "0x6004596")]
		[Address(RVA = "0xC87CBC", Offset = "0xC87CBC", VA = "0xC87CBC")]
		private void ConsumeProductId(string id)
		{
		}

		[Token(Token = "0x6004597")]
		[Address(RVA = "0xC87D4C", Offset = "0xC87D4C", VA = "0xC87D4C")]
		private void ConfirmTransactionPurchase(Transaction transaction, GooglePurchase googlePurchase)
		{
		}

		[Token(Token = "0x6004598")]
		[Address(RVA = "0xC881F0", Offset = "0xC881F0", VA = "0xC881F0")]
		private void RestoreTransactionsFinished()
		{
		}

		[Token(Token = "0x6004599")]
		[Address(RVA = "0xC88284", Offset = "0xC88284", VA = "0xC88284")]
		private void OfferListRequestFailed(string error)
		{
		}

		[Token(Token = "0x600459A")]
		[Address(RVA = "0xC8854C", Offset = "0xC8854C", VA = "0xC8854C")]
		private void OfferListReceivedEvent(List<GooglePurchase> purchases, List<GoogleSkuInfo> offerList)
		{
		}

		[Token(Token = "0x600459B")]
		[Address(RVA = "0xC88928", Offset = "0xC88928", VA = "0xC88928", Slot = "5")]
		internal override void RestorePurchases()
		{
		}

		[Token(Token = "0x600459C")]
		[Address(RVA = "0xC88A64", Offset = "0xC88A64", VA = "0xC88A64", Slot = "9")]
		internal override Transaction Buy(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x600459D")]
		[Address(RVA = "0xC8808C", Offset = "0xC8808C", VA = "0xC8808C")]
		private bool IsConsumable(string offerId)
		{
			return default(bool);
		}

		[Token(Token = "0x600459E")]
		[Address(RVA = "0xC86D24", Offset = "0xC86D24", VA = "0xC86D24")]
		private static void AddBillingSupportListenters()
		{
		}

		[Token(Token = "0x600459F")]
		[Address(RVA = "0xC88D04", Offset = "0xC88D04", VA = "0xC88D04")]
		private static void RemoveBillingSupportListenters()
		{
		}

		[Token(Token = "0x60045A0")]
		[Address(RVA = "0xC87828", Offset = "0xC87828", VA = "0xC87828")]
		private void AddOfferRefreshListeners()
		{
		}

		[Token(Token = "0x60045A1")]
		[Address(RVA = "0xC8842C", Offset = "0xC8842C", VA = "0xC8842C")]
		private void RemoveOfferRefreshListeners()
		{
		}

		[Token(Token = "0x60045A2")]
		[Address(RVA = "0xC88B48", Offset = "0xC88B48", VA = "0xC88B48")]
		private void AddPurchaseListeners()
		{
		}

		[Token(Token = "0x60045A3")]
		[Address(RVA = "0xC87B00", Offset = "0xC87B00", VA = "0xC87B00")]
		private void RemovePurchaseListeners()
		{
		}

		[Token(Token = "0x60045A4")]
		[Address(RVA = "0xC87990", Offset = "0xC87990", VA = "0xC87990")]
		private Transaction LocateTransaction(GooglePurchase purchase)
		{
			return null;
		}

		[Token(Token = "0x60045A5")]
		[Address(RVA = "0xC88E0C", Offset = "0xC88E0C", VA = "0xC88E0C", Slot = "1")]
		~GoogleShop()
		{
		}

		[Token(Token = "0x60045A6")]
		[Address(RVA = "0xC88E80", Offset = "0xC88E80", VA = "0xC88E80")]
		public GoogleShop()
		{
		}
	}
}
