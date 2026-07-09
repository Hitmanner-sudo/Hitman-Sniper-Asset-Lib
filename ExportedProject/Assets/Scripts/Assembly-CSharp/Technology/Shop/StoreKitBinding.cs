using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core;

namespace Technology.Shop
{
	[Token(Token = "0x2000B14")]
	public class StoreKitBinding
	{
		[Token(Token = "0x2000B15")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597F40", Offset = "0x597F40")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x400388F")]
			[FieldOffset(Offset = "0x10")]
			public Action<string> request;

			[Token(Token = "0x6004553")]
			[Address(RVA = "0xA534C4", Offset = "0xA534C4", VA = "0xA534C4")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6004554")]
			[Address(RVA = "0xA534CC", Offset = "0xA534CC", VA = "0xA534CC")]
			internal void _003CAsyncStoreRequest_003Eb__0(string guid, string rObj, string rName)
			{
			}
		}

		[Token(Token = "0x400388B")]
		private const string EVENTKEY = "iOSSK";

		[Token(Token = "0x400388C")]
		private const string ADD_STORE_PAYMENT_EVENT_KEY = "addStorePayment";

		[Token(Token = "0x400388D")]
		[FieldOffset(Offset = "0x0")]
		private static TriggerEvent<PromotedIAPChangedArgs> _pendingPromotedIAPChanged;

		[Token(Token = "0x400388E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly StoreKitEventManager _storeManager;

		[Token(Token = "0x6004545")]
		[Address(RVA = "0xD2B374", Offset = "0xD2B374", VA = "0xD2B374")]
		static StoreKitBinding()
		{
		}

		[Token(Token = "0x6004546")]
		[Address(RVA = "0xD2B584", Offset = "0xD2B584", VA = "0xD2B584")]
		private static void OnIosSkMessageReceived(JSONNode json)
		{
		}

		[Token(Token = "0x6004547")]
		[Address(RVA = "0xD2BD38", Offset = "0xD2BD38", VA = "0xD2BD38")]
		private static void OnAddStorePaymentEventReceived(JSONNode json)
		{
		}

		[Token(Token = "0x6004548")]
		[Address(RVA = "0xD2BE9C", Offset = "0xD2BE9C", VA = "0xD2BE9C")]
		private static bool IsRuntimeDevice()
		{
			return default(bool);
		}

		[Token(Token = "0x6004549")]
		[Address(RVA = "0xD2BEA4", Offset = "0xD2BEA4", VA = "0xD2BEA4")]
		private static void AsyncStoreRequest(Action<string> request, Action<JSONNode> response)
		{
		}

		[Token(Token = "0x600454A")]
		[Address(RVA = "0xD2C014", Offset = "0xD2C014", VA = "0xD2C014")]
		public static void RequestProductData(string[] productIdentifiers)
		{
		}

		[Token(Token = "0x600454B")]
		[Address(RVA = "0xD2C074", Offset = "0xD2C074", VA = "0xD2C074")]
		public static void PurchaseProduct(string productIdentifier, int quantity)
		{
		}

		[Token(Token = "0x600454C")]
		[Address(RVA = "0xD2C0D4", Offset = "0xD2C0D4", VA = "0xD2C0D4")]
		public static void RestoreCompletedTransactions()
		{
		}

		[Token(Token = "0x600454D")]
		[Address(RVA = "0xD2C134", Offset = "0xD2C134", VA = "0xD2C134")]
		public static void FinishPendingTransaction(string transactionId)
		{
		}

		[Token(Token = "0x600454E")]
		[Address(RVA = "0xD2C138", Offset = "0xD2C138", VA = "0xD2C138")]
		public static void ForceFinishPendingTransactions()
		{
		}

		[Token(Token = "0x600454F")]
		[Address(RVA = "0xD2C13C", Offset = "0xD2C13C", VA = "0xD2C13C")]
		public static bool BuyPendingPromotedIAP(string offerId)
		{
			return default(bool);
		}

		[Token(Token = "0x6004550")]
		[Address(RVA = "0xD2C144", Offset = "0xD2C144", VA = "0xD2C144")]
		public static void AddPromotedIAPChangedListener(EventHandler<PromotedIAPChangedArgs> handler)
		{
		}

		[Token(Token = "0x6004551")]
		[Address(RVA = "0xD2C1DC", Offset = "0xD2C1DC", VA = "0xD2C1DC")]
		public static void RemovePromotedIAPChangedListener(EventHandler<PromotedIAPChangedArgs> handler)
		{
		}

		[Token(Token = "0x6004552")]
		[Address(RVA = "0xD2C274", Offset = "0xD2C274", VA = "0xD2C274")]
		public StoreKitBinding()
		{
		}
	}
}
