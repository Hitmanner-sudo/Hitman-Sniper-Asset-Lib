using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B09")]
	internal abstract class AbstractShop
	{
		[Token(Token = "0x2000B0A")]
		protected enum RefreshOrder
		{
			[Token(Token = "0x4003862")]
			OfflineShop = 0,
			[Token(Token = "0x4003863")]
			EditorShop = 4,
			[Token(Token = "0x4003864")]
			AppleShop = 5,
			[Token(Token = "0x4003865")]
			GoogleShop = 6,
			[Token(Token = "0x4003866")]
			OnlineSuiteShop = 99
		}

		[Token(Token = "0x2000B0B")]
		protected enum Event
		{
			[Token(Token = "0x4003868")]
			OfferRefreshSuccess = 0,
			[Token(Token = "0x4003869")]
			OfferRefreshFailed = 1,
			[Token(Token = "0x400386A")]
			OffersRestoredSuccess = 2,
			[Token(Token = "0x400386B")]
			OffersRestoredFailed = 3,
			[Token(Token = "0x400386C")]
			OffersRestoredCompleted = 4,
			[Token(Token = "0x400386D")]
			OfferPurchaseSuccess = 5,
			[Token(Token = "0x400386E")]
			OfferPurchaseFailure = 6,
			[Token(Token = "0x400386F")]
			OfferPurchaseCancelled = 7,
			[Token(Token = "0x4003870")]
			OfferPurchasePending = 8
		}

		[Serializable]
		[Token(Token = "0x2000B0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597ED0", Offset = "0x597ED0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003871")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003872")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, Transaction>, bool> _003C_003E9__42_0;

			[Token(Token = "0x4003873")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<Offer> _003C_003E9__49_0;

			[Token(Token = "0x6004514")]
			[Address(RVA = "0x911CEC", Offset = "0x911CEC", VA = "0x911CEC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004515")]
			[Address(RVA = "0x911CF4", Offset = "0x911CF4", VA = "0x911CF4")]
			internal bool _003CStartRefreshOffers_003Eb__42_0(KeyValuePair<string, Transaction> kvp)
			{
				return default(bool);
			}

			[Token(Token = "0x6004516")]
			[Address(RVA = "0x911D44", Offset = "0x911D44", VA = "0x911D44")]
			internal bool _003CWaitForUI_003Eb__49_0(Offer o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000B0D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597EE0", Offset = "0x597EE0")]
		private sealed class _003C_003Ec__DisplayClass43_0
		{
			[Token(Token = "0x4003874")]
			[FieldOffset(Offset = "0x10")]
			public Action<Transaction> startAction;

			[Token(Token = "0x4003875")]
			[FieldOffset(Offset = "0x18")]
			public Transaction transaction;

			[Token(Token = "0x6004517")]
			[Address(RVA = "0x911D8C", Offset = "0x911D8C", VA = "0x911D8C")]
			public _003C_003Ec__DisplayClass43_0()
			{
			}

			[Token(Token = "0x6004518")]
			[Address(RVA = "0x911D94", Offset = "0x911D94", VA = "0x911D94")]
			internal void _003CBuy_003Eb__0(Transaction _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x2000B0E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597EF0", Offset = "0x597EF0")]
		private sealed class _003C_003Ec__DisplayClass44_0
		{
			[Token(Token = "0x4003876")]
			[FieldOffset(Offset = "0x10")]
			public AbstractShop _003C_003E4__this;

			[Token(Token = "0x4003877")]
			[FieldOffset(Offset = "0x18")]
			public Offer offer;

			[Token(Token = "0x4003878")]
			[FieldOffset(Offset = "0x20")]
			public Action<Transaction> _003C_003E9__1;

			[Token(Token = "0x6004519")]
			[Address(RVA = "0x911DEC", Offset = "0x911DEC", VA = "0x911DEC")]
			public _003C_003Ec__DisplayClass44_0()
			{
			}

			[Token(Token = "0x600451A")]
			[Address(RVA = "0x911DF4", Offset = "0x911DF4", VA = "0x911DF4")]
			internal void _003CBuy_003Eb__0(Transaction startTransaction)
			{
			}

			[Token(Token = "0x600451B")]
			[Address(RVA = "0x911EB0", Offset = "0x911EB0", VA = "0x911EB0")]
			internal void _003CBuy_003Eb__1(Transaction finishedTransaction)
			{
			}
		}

		[Token(Token = "0x2000B0F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597F00", Offset = "0x597F00")]
		private sealed class _003CWaitForUI_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003879")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400387A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400387B")]
			[FieldOffset(Offset = "0x20")]
			public AbstractShop _003C_003E4__this;

			[Token(Token = "0x400387C")]
			[FieldOffset(Offset = "0x28")]
			public Action subscriberAction;

			[Token(Token = "0x400387D")]
			[FieldOffset(Offset = "0x30")]
			private List<Offer> _003Coffers_003E5__2;

			[Token(Token = "0x400387E")]
			[FieldOffset(Offset = "0x38")]
			private float _003CstartTime_003E5__3;

			[Token(Token = "0x400387F")]
			[FieldOffset(Offset = "0x3C")]
			private bool _003CuiLoaded_003E5__4;

			[Token(Token = "0x4003880")]
			[FieldOffset(Offset = "0x40")]
			private float _003Cend_003E5__5;

			[Token(Token = "0x170008AD")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600451F")]
				[Address(RVA = "0x9122B4", Offset = "0x9122B4", VA = "0x9122B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170008AE")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004521")]
				[Address(RVA = "0x9122FC", Offset = "0x9122FC", VA = "0x9122FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600451C")]
			[Address(RVA = "0x912044", Offset = "0x912044", VA = "0x912044")]
			[DebuggerHidden]
			public _003CWaitForUI_003Ed__49(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600451D")]
			[Address(RVA = "0x912070", Offset = "0x912070", VA = "0x912070", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600451E")]
			[Address(RVA = "0x912074", Offset = "0x912074", VA = "0x912074", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004520")]
			[Address(RVA = "0x9122BC", Offset = "0x9122BC", VA = "0x9122BC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400385B")]
		[FieldOffset(Offset = "0x58")]
		protected OfferController _offerController;

		[Token(Token = "0x400385C")]
		[FieldOffset(Offset = "0x60")]
		protected Stock _stock;

		[Token(Token = "0x400385D")]
		[FieldOffset(Offset = "0x68")]
		protected Inventory _inventory;

		[Token(Token = "0x400385E")]
		[FieldOffset(Offset = "0x0")]
		protected static Dictionary<string, Transaction> _transactions;

		[Token(Token = "0x400385F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly TransactionHistory _transactionHistory;

		[Token(Token = "0x4003860")]
		[FieldOffset(Offset = "0x70")]
		protected ShopConfiguration _shopConfiguration;

		[Token(Token = "0x170008AB")]
		internal abstract string Id
		{
			[Token(Token = "0x60044FE")]
			get;
		}

		[Token(Token = "0x170008AC")]
		internal abstract int RefreshOrderIndex
		{
			[Token(Token = "0x60044FF")]
			get;
		}

		[Token(Token = "0x140000C7")]
		internal event EventHandler<ShopEvent> OnOfferRefreshSuccess
		{
			[Token(Token = "0x60044EA")]
			[Address(RVA = "0xAA366C", Offset = "0xAA366C", VA = "0xAA366C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626278", Offset = "0x626278")]
			add
			{
			}
			[Token(Token = "0x60044EB")]
			[Address(RVA = "0xAA370C", Offset = "0xAA370C", VA = "0xAA370C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626288", Offset = "0x626288")]
			remove
			{
			}
		}

		[Token(Token = "0x140000C8")]
		internal event EventHandler<ShopEvent> OnOfferRefreshFailure
		{
			[Token(Token = "0x60044EC")]
			[Address(RVA = "0xAA37AC", Offset = "0xAA37AC", VA = "0xAA37AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626298", Offset = "0x626298")]
			add
			{
			}
			[Token(Token = "0x60044ED")]
			[Address(RVA = "0xAA384C", Offset = "0xAA384C", VA = "0xAA384C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6262A8", Offset = "0x6262A8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000C9")]
		internal event EventHandler<ShopEvent> OnOffersRestoredSuccess
		{
			[Token(Token = "0x60044EE")]
			[Address(RVA = "0xAA38EC", Offset = "0xAA38EC", VA = "0xAA38EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6262B8", Offset = "0x6262B8")]
			add
			{
			}
			[Token(Token = "0x60044EF")]
			[Address(RVA = "0xAA398C", Offset = "0xAA398C", VA = "0xAA398C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6262C8", Offset = "0x6262C8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000CA")]
		internal event EventHandler<ShopEvent> OnOffersRestoredFailure
		{
			[Token(Token = "0x60044F0")]
			[Address(RVA = "0xAA3A2C", Offset = "0xAA3A2C", VA = "0xAA3A2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6262D8", Offset = "0x6262D8")]
			add
			{
			}
			[Token(Token = "0x60044F1")]
			[Address(RVA = "0xAA3ACC", Offset = "0xAA3ACC", VA = "0xAA3ACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6262E8", Offset = "0x6262E8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000CB")]
		internal event EventHandler<ShopEvent> OnOffersRestoredCompleted
		{
			[Token(Token = "0x60044F2")]
			[Address(RVA = "0xAA3B6C", Offset = "0xAA3B6C", VA = "0xAA3B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6262F8", Offset = "0x6262F8")]
			add
			{
			}
			[Token(Token = "0x60044F3")]
			[Address(RVA = "0xAA3C0C", Offset = "0xAA3C0C", VA = "0xAA3C0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626308", Offset = "0x626308")]
			remove
			{
			}
		}

		[Token(Token = "0x140000CC")]
		internal event EventHandler<ShopEvent> OnOfferPurchaseSuccess
		{
			[Token(Token = "0x60044F4")]
			[Address(RVA = "0xAA3CAC", Offset = "0xAA3CAC", VA = "0xAA3CAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626318", Offset = "0x626318")]
			add
			{
			}
			[Token(Token = "0x60044F5")]
			[Address(RVA = "0xAA3D4C", Offset = "0xAA3D4C", VA = "0xAA3D4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626328", Offset = "0x626328")]
			remove
			{
			}
		}

		[Token(Token = "0x140000CD")]
		internal event EventHandler<ShopEvent> OnOfferPurchaseFailure
		{
			[Token(Token = "0x60044F6")]
			[Address(RVA = "0xAA3DEC", Offset = "0xAA3DEC", VA = "0xAA3DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626338", Offset = "0x626338")]
			add
			{
			}
			[Token(Token = "0x60044F7")]
			[Address(RVA = "0xAA3E8C", Offset = "0xAA3E8C", VA = "0xAA3E8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626348", Offset = "0x626348")]
			remove
			{
			}
		}

		[Token(Token = "0x140000CE")]
		internal event EventHandler<ShopEvent> OnOfferPurchaseCancelled
		{
			[Token(Token = "0x60044F8")]
			[Address(RVA = "0xAA3F2C", Offset = "0xAA3F2C", VA = "0xAA3F2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626358", Offset = "0x626358")]
			add
			{
			}
			[Token(Token = "0x60044F9")]
			[Address(RVA = "0xAA3FCC", Offset = "0xAA3FCC", VA = "0xAA3FCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626368", Offset = "0x626368")]
			remove
			{
			}
		}

		[Token(Token = "0x140000CF")]
		internal event EventHandler<ShopEvent> OnOfferPurchasePending
		{
			[Token(Token = "0x60044FA")]
			[Address(RVA = "0xAA406C", Offset = "0xAA406C", VA = "0xAA406C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626378", Offset = "0x626378")]
			add
			{
			}
			[Token(Token = "0x60044FB")]
			[Address(RVA = "0xAA410C", Offset = "0xAA410C", VA = "0xAA410C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626388", Offset = "0x626388")]
			remove
			{
			}
		}

		[Token(Token = "0x60044FC")]
		protected abstract bool RefreshOffers();

		[Token(Token = "0x60044FD")]
		internal abstract void RestorePurchases();

		[Token(Token = "0x6004500")]
		[Address(RVA = "0xAA41AC", Offset = "0xAA41AC", VA = "0xAA41AC", Slot = "8")]
		public virtual bool Rollback(Offer offer)
		{
			return default(bool);
		}

		[Token(Token = "0x6004501")]
		[Address(RVA = "0xAA41D4", Offset = "0xAA41D4", VA = "0xAA41D4")]
		internal bool StartRefreshOffers()
		{
			return default(bool);
		}

		[Token(Token = "0x6004502")]
		[Address(RVA = "0xAA4614", Offset = "0xAA4614", VA = "0xAA4614")]
		protected Transaction Buy(Offer offer, Action<Transaction> startAction)
		{
			return null;
		}

		[Token(Token = "0x6004503")]
		[Address(RVA = "0xAA4A0C", Offset = "0xAA4A0C", VA = "0xAA4A0C", Slot = "9")]
		internal virtual Transaction Buy(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x6004504")]
		[Address(RVA = "0xAA4AE0", Offset = "0xAA4AE0", VA = "0xAA4AE0", Slot = "10")]
		internal virtual Transaction BuyPendingPromotedIAP(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x6004505")]
		[Address(RVA = "0xAA4B44", Offset = "0xAA4B44", VA = "0xAA4B44")]
		protected void ProcessPurchase(Transaction transaction, Action<Transaction> subcriberPurchaseAction)
		{
		}

		[Token(Token = "0x6004506")]
		[Address(RVA = "0xAA519C", Offset = "0xAA519C", VA = "0xAA519C", Slot = "11")]
		internal virtual bool Initialize(ShopConfiguration shopConfiguration, OfferController offerController, Stock stock, Inventory inventory)
		{
			return default(bool);
		}

		[Token(Token = "0x6004507")]
		[Address(RVA = "0xAA51B0", Offset = "0xAA51B0", VA = "0xAA51B0")]
		protected void RefreshOffers(Func<OfferDescription, bool> offerRegisterationQualifier, OfferState resultantState)
		{
		}

		[Token(Token = "0x6004508")]
		[Address(RVA = "0xAA5568", Offset = "0xAA5568", VA = "0xAA5568")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x626398", Offset = "0x626398")]
		protected IEnumerator WaitForUI(Action subscriberAction)
		{
			return null;
		}

		[Token(Token = "0x6004509")]
		[Address(RVA = "0xAA43B8", Offset = "0xAA43B8", VA = "0xAA43B8")]
		protected void RaiseEvent(Event eventToInvoke, ShopEvent eventHandler)
		{
		}

		[Token(Token = "0x600450A")]
		[Address(RVA = "0xAA4E58", Offset = "0xAA4E58", VA = "0xAA4E58")]
		protected void HandleError(Transaction t, Dictionary<string, bool> allocationResult, string resultKey, string errorMessageFormat)
		{
		}

		[Token(Token = "0x600450B")]
		[Address(RVA = "0xAA55E0", Offset = "0xAA55E0", VA = "0xAA55E0")]
		protected void PackagesOnShippingComplete(object sender, PackageEvent packageEvent)
		{
		}

		[Token(Token = "0x600450C")]
		[Address(RVA = "0xAA50DC", Offset = "0xAA50DC", VA = "0xAA50DC")]
		protected void EndTransaction(Transaction transaction)
		{
		}

		[Token(Token = "0x600450D")]
		[Address(RVA = "0xAA4868", Offset = "0xAA4868", VA = "0xAA4868")]
		protected Transaction LocateTransaction(string productIdentifier)
		{
			return null;
		}

		[Token(Token = "0x600450E")]
		[Address(RVA = "0xAA57E8", Offset = "0xAA57E8", VA = "0xAA57E8")]
		internal Transaction GetActiveTransaction(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x600450F")]
		[Address(RVA = "0xAA58D0", Offset = "0xAA58D0", VA = "0xAA58D0")]
		internal static void LoadTransactions(OfferController offerController)
		{
		}

		[Token(Token = "0x6004510")]
		[Address(RVA = "0xAA5974", Offset = "0xAA5974", VA = "0xAA5974")]
		public static TransactionHistory GetTransactionHistory()
		{
			return null;
		}

		[Token(Token = "0x6004511")]
		[Address(RVA = "0xAA59D8", Offset = "0xAA59D8", VA = "0xAA59D8")]
		protected AbstractShop()
		{
		}
	}
}
