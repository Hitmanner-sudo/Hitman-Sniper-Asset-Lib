using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B10")]
	internal class AppleShop : AbstractShop
	{
		[Serializable]
		[Token(Token = "0x2000B11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597F10", Offset = "0x597F10")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003883")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003884")]
			[FieldOffset(Offset = "0x8")]
			public static Action<bool> _003C_003E9__6_0;

			[Token(Token = "0x4003885")]
			[FieldOffset(Offset = "0x10")]
			public static Func<OfferDescription, bool> _003C_003E9__14_0;

			[Token(Token = "0x4003886")]
			[FieldOffset(Offset = "0x18")]
			public static Func<OfferDescription, bool> _003C_003E9__14_1;

			[Token(Token = "0x4003887")]
			[FieldOffset(Offset = "0x20")]
			public static Func<Offer, string> _003C_003E9__14_3;

			[Token(Token = "0x600453C")]
			[Address(RVA = "0x9227C4", Offset = "0x9227C4", VA = "0x9227C4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600453D")]
			[Address(RVA = "0x9227CC", Offset = "0x9227CC", VA = "0x9227CC")]
			internal void _003C_002Ector_003Eb__6_0(bool isPaused)
			{
			}

			[Token(Token = "0x600453E")]
			[Address(RVA = "0x92283C", Offset = "0x92283C", VA = "0x92283C")]
			internal bool _003CRefreshOffers_003Eb__14_0(OfferDescription description)
			{
				return default(bool);
			}

			[Token(Token = "0x600453F")]
			[Address(RVA = "0x922854", Offset = "0x922854", VA = "0x922854")]
			internal bool _003CRefreshOffers_003Eb__14_1(OfferDescription description)
			{
				return default(bool);
			}

			[Token(Token = "0x6004540")]
			[Address(RVA = "0x92286C", Offset = "0x92286C", VA = "0x92286C")]
			internal string _003CRefreshOffers_003Eb__14_3(Offer offer)
			{
				return null;
			}
		}

		[Token(Token = "0x2000B12")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597F20", Offset = "0x597F20")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4003888")]
			[FieldOffset(Offset = "0x10")]
			public Offer offer;

			[Token(Token = "0x6004541")]
			[Address(RVA = "0x922884", Offset = "0x922884", VA = "0x922884")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6004542")]
			[Address(RVA = "0x92288C", Offset = "0x92288C", VA = "0x92288C")]
			internal void _003CBuy_003Eb__0(Transaction t)
			{
			}
		}

		[Token(Token = "0x2000B13")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597F30", Offset = "0x597F30")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x4003889")]
			[FieldOffset(Offset = "0x10")]
			public Offer offer;

			[Token(Token = "0x400388A")]
			[FieldOffset(Offset = "0x18")]
			public AppleShop _003C_003E4__this;

			[Token(Token = "0x6004543")]
			[Address(RVA = "0x922904", Offset = "0x922904", VA = "0x922904")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6004544")]
			[Address(RVA = "0x92290C", Offset = "0x92290C", VA = "0x92290C")]
			internal void _003CBuyPendingPromotedIAP_003Eb__0(Transaction t)
			{
			}
		}

		[Token(Token = "0x4003881")]
		internal const string SHOP_ID = "APPLESHOP";

		[Token(Token = "0x4003882")]
		[FieldOffset(Offset = "0x78")]
		private int _transactionRestoreCount;

		[Token(Token = "0x170008AF")]
		internal override string Id
		{
			[Token(Token = "0x6004522")]
			[Address(RVA = "0xD491CC", Offset = "0xD491CC", VA = "0xD491CC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B0")]
		internal override int RefreshOrderIndex
		{
			[Token(Token = "0x6004523")]
			[Address(RVA = "0xD49210", Offset = "0xD49210", VA = "0xD49210", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004524")]
		[Address(RVA = "0xD49218", Offset = "0xD49218", VA = "0xD49218")]
		public AppleShop()
		{
		}

		[Token(Token = "0x6004525")]
		[Address(RVA = "0xD4957C", Offset = "0xD4957C", VA = "0xD4957C", Slot = "9")]
		internal override Transaction Buy(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x6004526")]
		[Address(RVA = "0xD49654", Offset = "0xD49654", VA = "0xD49654", Slot = "10")]
		internal override Transaction BuyPendingPromotedIAP(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x6004527")]
		[Address(RVA = "0xD4972C", Offset = "0xD4972C", VA = "0xD4972C")]
		private void BuyFailedCallback(string error)
		{
		}

		[Token(Token = "0x6004528")]
		[Address(RVA = "0xD49730", Offset = "0xD49730", VA = "0xD49730")]
		private void BuyCancelledCallback(string error)
		{
		}

		[Token(Token = "0x6004529")]
		[Address(RVA = "0xD498D4", Offset = "0xD498D4", VA = "0xD498D4")]
		private void BuyPendingCallback(StoreKitTransaction obj)
		{
		}

		[Token(Token = "0x600452A")]
		[Address(RVA = "0xD499AC", Offset = "0xD499AC", VA = "0xD499AC")]
		private void BuySuccessCallback(StoreKitTransaction storeKitTransaction)
		{
		}

		[Token(Token = "0x600452B")]
		[Address(RVA = "0xD49990", Offset = "0xD49990", VA = "0xD49990")]
		private Transaction LocateTransaction(StoreKitTransaction storeKitTransaction)
		{
			return null;
		}

		[Token(Token = "0x600452C")]
		[Address(RVA = "0xD49C54", Offset = "0xD49C54", VA = "0xD49C54", Slot = "4")]
		protected override bool RefreshOffers()
		{
			return default(bool);
		}

		[Token(Token = "0x600452D")]
		[Address(RVA = "0xD49F08", Offset = "0xD49F08", VA = "0xD49F08")]
		private void OfferListRequestFailed(string error)
		{
		}

		[Token(Token = "0x600452E")]
		[Address(RVA = "0xD4A094", Offset = "0xD4A094", VA = "0xD4A094")]
		private void OfferListReceivedEvent(List<StoreKitProduct> offerList)
		{
		}

		[Token(Token = "0x600452F")]
		[Address(RVA = "0xD4A4A8", Offset = "0xD4A4A8", VA = "0xD4A4A8", Slot = "5")]
		internal override void RestorePurchases()
		{
		}

		[Token(Token = "0x6004530")]
		[Address(RVA = "0xD493BC", Offset = "0xD493BC", VA = "0xD493BC")]
		private void AddPurchaseListeners()
		{
		}

		[Token(Token = "0x6004531")]
		[Address(RVA = "0xD4A7B0", Offset = "0xD4A7B0", VA = "0xD4A7B0")]
		private void MonitorTransaction(StoreKitTransaction obj)
		{
		}

		[Token(Token = "0x6004532")]
		[Address(RVA = "0xD4A5F8", Offset = "0xD4A5F8", VA = "0xD4A5F8")]
		private void RemovePurchaseListeners()
		{
		}

		[Token(Token = "0x6004533")]
		[Address(RVA = "0xD4A3B4", Offset = "0xD4A3B4", VA = "0xD4A3B4")]
		private void RemoveOfferRefreshListeners()
		{
		}

		[Token(Token = "0x6004534")]
		[Address(RVA = "0xD4A510", Offset = "0xD4A510", VA = "0xD4A510")]
		private void AddRestorePurchaseListeners()
		{
		}

		[Token(Token = "0x6004535")]
		[Address(RVA = "0xD4A8E8", Offset = "0xD4A8E8", VA = "0xD4A8E8")]
		private void RemoveRestoreListeners()
		{
		}

		[Token(Token = "0x6004536")]
		[Address(RVA = "0xD4A9C8", Offset = "0xD4A9C8", VA = "0xD4A9C8")]
		private void RestoreTransactionsFailed(string errMsg)
		{
		}

		[Token(Token = "0x6004537")]
		[Address(RVA = "0xD4AA48", Offset = "0xD4AA48", VA = "0xD4AA48")]
		private void RestoreTransactionsFinished()
		{
		}

		[Token(Token = "0x6004538")]
		[Address(RVA = "0xD4AADC", Offset = "0xD4AADC", VA = "0xD4AADC", Slot = "1")]
		~AppleShop()
		{
		}

		[Token(Token = "0x6004539")]
		[Address(RVA = "0xD4AB4C", Offset = "0xD4AB4C", VA = "0xD4AB4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626448", Offset = "0x626448")]
		private void _003CBuySuccessCallback_003Eb__12_0(Transaction t)
		{
		}

		[Token(Token = "0x600453A")]
		[Address(RVA = "0xD4AFDC", Offset = "0xD4AFDC", VA = "0xD4AFDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626458", Offset = "0x626458")]
		private void _003CRefreshOffers_003Eb__14_2()
		{
		}
	}
}
