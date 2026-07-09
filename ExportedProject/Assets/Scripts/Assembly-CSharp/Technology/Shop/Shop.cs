using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Technology.Security;

namespace Technology.Shop
{
	[Token(Token = "0x2000B34")]
	public class Shop : Singleton<Shop>
	{
		[Serializable]
		[Token(Token = "0x2000B35")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598038", Offset = "0x598038")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static EventHandler<ShopEvent> _003C_003E9__56_0;

			[Token(Token = "0x4003923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Offer, string> _003C_003E9__63_0;

			[Token(Token = "0x4003924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<AbstractShop> _003C_003E9__65_0;

			[Token(Token = "0x4003925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static EventHandler<ShopEvent> _003C_003E9__103_0;

			[Token(Token = "0x4003926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static EventHandler<ShopEvent> _003C_003E9__103_1;

			[Token(Token = "0x4003927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static EventHandler<ShopEvent> _003C_003E9__103_2;

			[Token(Token = "0x4003928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static EventHandler<ShopEvent> _003C_003E9__103_3;

			[Token(Token = "0x4003929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static EventHandler<ShopEvent> _003C_003E9__103_4;

			[Token(Token = "0x400392A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static EventHandler<ShopEvent> _003C_003E9__103_5;

			[Token(Token = "0x400392B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static EventHandler<ShopEvent> _003C_003E9__103_6;

			[Token(Token = "0x400392C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static EventHandler<ShopEvent> _003C_003E9__103_7;

			[Token(Token = "0x400392D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static EventHandler<ShopEvent> _003C_003E9__103_8;

			[Token(Token = "0x60046C9")]
			[Address(RVA = "0x8BC7D0", Offset = "0x8BC7D0", VA = "0x8BC7D0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60046CA")]
			[Address(RVA = "0x8BC7D8", Offset = "0x8BC7D8", VA = "0x8BC7D8")]
			internal void _003CInitialize_003Eb__56_0(object s, ShopEvent e)
			{
			}

			[Token(Token = "0x60046CB")]
			[Address(RVA = "0x8BC854", Offset = "0x8BC854", VA = "0x8BC854")]
			internal string _003CSerializeShopState_003Eb__63_0(Offer x)
			{
				return null;
			}

			[Token(Token = "0x60046CC")]
			[Address(RVA = "0x8BC8C4", Offset = "0x8BC8C4", VA = "0x8BC8C4")]
			internal int _003CRefreshAllShops_003Eb__65_0(AbstractShop firstPair, AbstractShop nextPair)
			{
				return default(int);
			}

			[Token(Token = "0x60046CD")]
			[Address(RVA = "0x8BC924", Offset = "0x8BC924", VA = "0x8BC924")]
			internal void _003CHookEvents_003Eb__103_0(object sender, ShopEvent @event)
			{
			}

			[Token(Token = "0x60046CE")]
			[Address(RVA = "0x8BC9A0", Offset = "0x8BC9A0", VA = "0x8BC9A0")]
			internal void _003CHookEvents_003Eb__103_1(object sender, ShopEvent @event)
			{
			}

			[Token(Token = "0x60046CF")]
			[Address(RVA = "0x8BCA1C", Offset = "0x8BCA1C", VA = "0x8BCA1C")]
			internal void _003CHookEvents_003Eb__103_2(object sender, ShopEvent @event)
			{
			}

			[Token(Token = "0x60046D0")]
			[Address(RVA = "0x8BCA98", Offset = "0x8BCA98", VA = "0x8BCA98")]
			internal void _003CHookEvents_003Eb__103_3(object sender, ShopEvent @event)
			{
			}

			[Token(Token = "0x60046D1")]
			[Address(RVA = "0x8BCB14", Offset = "0x8BCB14", VA = "0x8BCB14")]
			internal void _003CHookEvents_003Eb__103_4(object sender, ShopEvent @event)
			{
			}

			[Token(Token = "0x60046D2")]
			[Address(RVA = "0x8BCB90", Offset = "0x8BCB90", VA = "0x8BCB90")]
			internal void _003CHookEvents_003Eb__103_5(object sender, ShopEvent @event)
			{
			}

			[Token(Token = "0x60046D3")]
			[Address(RVA = "0x8BCC0C", Offset = "0x8BCC0C", VA = "0x8BCC0C")]
			internal void _003CHookEvents_003Eb__103_6(object sender, ShopEvent @event)
			{
			}

			[Token(Token = "0x60046D4")]
			[Address(RVA = "0x8BCC88", Offset = "0x8BCC88", VA = "0x8BCC88")]
			internal void _003CHookEvents_003Eb__103_7(object sender, ShopEvent @event)
			{
			}

			[Token(Token = "0x60046D5")]
			[Address(RVA = "0x8BCD04", Offset = "0x8BCD04", VA = "0x8BCD04")]
			internal void _003CHookEvents_003Eb__103_8(object sender, ShopEvent @event)
			{
			}
		}

		[Token(Token = "0x2000B36")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598048", Offset = "0x598048")]
		private sealed class _003C_003Ec__DisplayClass64_0
		{
			[Token(Token = "0x400392E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string offerID;

			[Token(Token = "0x60046D6")]
			[Address(RVA = "0x8BCD80", Offset = "0x8BCD80", VA = "0x8BCD80")]
			public _003C_003Ec__DisplayClass64_0()
			{
			}

			[Token(Token = "0x60046D7")]
			[Address(RVA = "0x8BCD88", Offset = "0x8BCD88", VA = "0x8BCD88")]
			internal bool _003CGetOfferById_003Eb__0(Offer x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000B37")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598058", Offset = "0x598058")]
		private sealed class _003C_003Ec__DisplayClass65_0
		{
			[Token(Token = "0x400392F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type shopType;

			[Token(Token = "0x60046D8")]
			[Address(RVA = "0x8BCDB4", Offset = "0x8BCDB4", VA = "0x8BCDB4")]
			public _003C_003Ec__DisplayClass65_0()
			{
			}

			[Token(Token = "0x60046D9")]
			[Address(RVA = "0x8BCDBC", Offset = "0x8BCDBC", VA = "0x8BCDBC")]
			internal bool _003CRefreshAllShops_003Eb__1(AbstractShop s)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ShopConfiguration _shopConfiguration;

		[Token(Token = "0x4003919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, AbstractShop> _shops;

		[Token(Token = "0x400391A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private OfferController _offerController;

		[Token(Token = "0x400391B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Stock _stock;

		[Token(Token = "0x400391C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Inventory _inventory;

		[Token(Token = "0x400391D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<AbstractShop> _sortedShops;

		[Token(Token = "0x400391E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _refreshInProgress;

		[Token(Token = "0x400391F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private StringBuilder _refreshStatus;

		[Token(Token = "0x4003920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _firstRefreshDone;

		[Token(Token = "0x170008EB")]
		internal string SavedGUID
		{
			[Token(Token = "0x6004690")]
			[Address(RVA = "0x83F77C", Offset = "0x83F77C", VA = "0x83F77C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008EC")]
		internal string GUID
		{
			[Token(Token = "0x6004691")]
			[Address(RVA = "0x83F88C", Offset = "0x83F88C", VA = "0x83F88C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008ED")]
		internal bool IsConfigUpdated
		{
			[Token(Token = "0x6004692")]
			[Address(RVA = "0x83F8A8", Offset = "0x83F8A8", VA = "0x83F8A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170008EE")]
		internal List<OfferDescription> AllIntelUnlockWeapons
		{
			[Token(Token = "0x6004693")]
			[Address(RVA = "0x83F8C4", Offset = "0x83F8C4", VA = "0x83F8C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008EF")]
		public bool KeepOfferAssetBundleCache
		{
			[Token(Token = "0x6004694")]
			[Address(RVA = "0x83F8E0", Offset = "0x83F8E0", VA = "0x83F8E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004695")]
			[Address(RVA = "0x83F97C", Offset = "0x83F97C", VA = "0x83F97C")]
			set
			{
			}
		}

		[Token(Token = "0x170008F0")]
		public bool FirstRefreshDone
		{
			[Token(Token = "0x6004696")]
			[Address(RVA = "0x83F9E0", Offset = "0x83F9E0", VA = "0x83F9E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x140000DC")]
		internal static event EventHandler<ShopEvent> OnOfferRefreshSuccess
		{
			[Token(Token = "0x600467A")]
			[Address(RVA = "0x83E704", Offset = "0x83E704", VA = "0x83E704")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626B58", Offset = "0x626B58")]
			add
			{
			}
			[Token(Token = "0x600467B")]
			[Address(RVA = "0x83E7C0", Offset = "0x83E7C0", VA = "0x83E7C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626B68", Offset = "0x626B68")]
			remove
			{
			}
		}

		[Token(Token = "0x140000DD")]
		internal static event EventHandler<ShopEvent> OnOfferRefreshFailure
		{
			[Token(Token = "0x600467C")]
			[Address(RVA = "0x83E87C", Offset = "0x83E87C", VA = "0x83E87C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626B78", Offset = "0x626B78")]
			add
			{
			}
			[Token(Token = "0x600467D")]
			[Address(RVA = "0x83E93C", Offset = "0x83E93C", VA = "0x83E93C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626B88", Offset = "0x626B88")]
			remove
			{
			}
		}

		[Token(Token = "0x140000DE")]
		internal static event EventHandler<ShopEvent> OnOfferRefreshAllShopsComplete
		{
			[Token(Token = "0x600467E")]
			[Address(RVA = "0x83E9FC", Offset = "0x83E9FC", VA = "0x83E9FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626B98", Offset = "0x626B98")]
			add
			{
			}
			[Token(Token = "0x600467F")]
			[Address(RVA = "0x83EABC", Offset = "0x83EABC", VA = "0x83EABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626BA8", Offset = "0x626BA8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000DF")]
		internal static event EventHandler<ShopEvent> OnOffersRestoredSuccess
		{
			[Token(Token = "0x6004680")]
			[Address(RVA = "0x83EB7C", Offset = "0x83EB7C", VA = "0x83EB7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626BB8", Offset = "0x626BB8")]
			add
			{
			}
			[Token(Token = "0x6004681")]
			[Address(RVA = "0x83EC3C", Offset = "0x83EC3C", VA = "0x83EC3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626BC8", Offset = "0x626BC8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000E0")]
		internal static event EventHandler<ShopEvent> OnOffersRestoredFailure
		{
			[Token(Token = "0x6004682")]
			[Address(RVA = "0x83ECFC", Offset = "0x83ECFC", VA = "0x83ECFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626BD8", Offset = "0x626BD8")]
			add
			{
			}
			[Token(Token = "0x6004683")]
			[Address(RVA = "0x83EDBC", Offset = "0x83EDBC", VA = "0x83EDBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626BE8", Offset = "0x626BE8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000E1")]
		internal static event EventHandler<ShopEvent> OnOffersRestoredCompleted
		{
			[Token(Token = "0x6004684")]
			[Address(RVA = "0x83EE7C", Offset = "0x83EE7C", VA = "0x83EE7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626BF8", Offset = "0x626BF8")]
			add
			{
			}
			[Token(Token = "0x6004685")]
			[Address(RVA = "0x83EF3C", Offset = "0x83EF3C", VA = "0x83EF3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626C08", Offset = "0x626C08")]
			remove
			{
			}
		}

		[Token(Token = "0x140000E2")]
		internal static event EventHandler<ShopEvent> OnOfferPurchaseSuccess
		{
			[Token(Token = "0x6004686")]
			[Address(RVA = "0x83EFFC", Offset = "0x83EFFC", VA = "0x83EFFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626C18", Offset = "0x626C18")]
			add
			{
			}
			[Token(Token = "0x6004687")]
			[Address(RVA = "0x83F0BC", Offset = "0x83F0BC", VA = "0x83F0BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626C28", Offset = "0x626C28")]
			remove
			{
			}
		}

		[Token(Token = "0x140000E3")]
		internal static event EventHandler<ShopEvent> OnOfferPurchaseFailure
		{
			[Token(Token = "0x6004688")]
			[Address(RVA = "0x83F17C", Offset = "0x83F17C", VA = "0x83F17C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626C38", Offset = "0x626C38")]
			add
			{
			}
			[Token(Token = "0x6004689")]
			[Address(RVA = "0x83F23C", Offset = "0x83F23C", VA = "0x83F23C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626C48", Offset = "0x626C48")]
			remove
			{
			}
		}

		[Token(Token = "0x140000E4")]
		internal static event EventHandler<ShopEvent> OnOfferPurchaseCancelled
		{
			[Token(Token = "0x600468A")]
			[Address(RVA = "0x83F2FC", Offset = "0x83F2FC", VA = "0x83F2FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626C58", Offset = "0x626C58")]
			add
			{
			}
			[Token(Token = "0x600468B")]
			[Address(RVA = "0x83F3BC", Offset = "0x83F3BC", VA = "0x83F3BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626C68", Offset = "0x626C68")]
			remove
			{
			}
		}

		[Token(Token = "0x140000E5")]
		internal static event EventHandler<ShopEvent> OnOfferPurchasePending
		{
			[Token(Token = "0x600468C")]
			[Address(RVA = "0x83F47C", Offset = "0x83F47C", VA = "0x83F47C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626C78", Offset = "0x626C78")]
			add
			{
			}
			[Token(Token = "0x600468D")]
			[Address(RVA = "0x83F53C", Offset = "0x83F53C", VA = "0x83F53C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626C88", Offset = "0x626C88")]
			remove
			{
			}
		}

		[Token(Token = "0x140000E6")]
		internal static event EventHandler<ShopEvent> OnInventoryChanged
		{
			[Token(Token = "0x600468E")]
			[Address(RVA = "0x83F5FC", Offset = "0x83F5FC", VA = "0x83F5FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626C98", Offset = "0x626C98")]
			add
			{
			}
			[Token(Token = "0x600468F")]
			[Address(RVA = "0x83F6BC", Offset = "0x83F6BC", VA = "0x83F6BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626CA8", Offset = "0x626CA8")]
			remove
			{
			}
		}

		[Token(Token = "0x6004697")]
		[Address(RVA = "0x83F9E8", Offset = "0x83F9E8", VA = "0x83F9E8")]
		public Shop()
		{
		}

		[Token(Token = "0x6004698")]
		[Address(RVA = "0x83FCF4", Offset = "0x83FCF4", VA = "0x83FCF4")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6004699")]
		[Address(RVA = "0x8401D4", Offset = "0x8401D4", VA = "0x8401D4")]
		internal void RegisterModule(Type shopType)
		{
		}

		[Token(Token = "0x600469A")]
		[Address(RVA = "0x840908", Offset = "0x840908", VA = "0x840908")]
		public bool IsRegister(Type shopType)
		{
			return default(bool);
		}

		[Token(Token = "0x600469B")]
		[Address(RVA = "0x8409E8", Offset = "0x8409E8", VA = "0x8409E8")]
		public bool IsRefreshing()
		{
			return default(bool);
		}

		[Token(Token = "0x600469C")]
		[Address(RVA = "0x8409F0", Offset = "0x8409F0", VA = "0x8409F0")]
		public bool SetOfferIndex(string offerID, int newIndex, long endDate)
		{
			return default(bool);
		}

		[Token(Token = "0x600469D")]
		[Address(RVA = "0x840C10", Offset = "0x840C10", VA = "0x840C10")]
		public bool IsValidOfferIndex(string offerID, int newIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600469E")]
		[Address(RVA = "0x840BD4", Offset = "0x840BD4", VA = "0x840BD4")]
		private bool IsValidOfferIndex(MetaOffer offer, int newIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600469F")]
		[Address(RVA = "0x840CCC", Offset = "0x840CCC", VA = "0x840CCC")]
		public string SerializeShopState()
		{
			return null;
		}

		[Token(Token = "0x60046A0")]
		[Address(RVA = "0x840AD0", Offset = "0x840AD0", VA = "0x840AD0")]
		public Offer GetOfferById(string offerID)
		{
			return null;
		}

		[Token(Token = "0x60046A1")]
		[Address(RVA = "0x8417D0", Offset = "0x8417D0", VA = "0x8417D0")]
		internal void RefreshAllShops([Optional] Type shopType)
		{
		}

		[Token(Token = "0x60046A2")]
		[Address(RVA = "0x841C18", Offset = "0x841C18", VA = "0x841C18")]
		private void OnRefreshAllShopsCompleted(string errorMsg)
		{
		}

		[Token(Token = "0x60046A3")]
		[Address(RVA = "0x841D80", Offset = "0x841D80", VA = "0x841D80")]
		private void AbstractShopOnOnOfferRefreshComplete(object sender, ShopEvent shopEvent)
		{
		}

		[Token(Token = "0x60046A4")]
		[Address(RVA = "0x841CCC", Offset = "0x841CCC", VA = "0x841CCC")]
		private static void RegisterShopRefreshEvents(AbstractShop shop, EventHandler<ShopEvent> handler)
		{
		}

		[Token(Token = "0x60046A5")]
		[Address(RVA = "0x840198", Offset = "0x840198", VA = "0x840198")]
		private static void UnregisterShopRefreshEvents(AbstractShop shop, EventHandler<ShopEvent> handler)
		{
		}

		[Token(Token = "0x60046A6")]
		[Address(RVA = "0x842034", Offset = "0x842034", VA = "0x842034")]
		internal void Buy(Offer offer)
		{
		}

		[Token(Token = "0x60046A7")]
		[Address(RVA = "0x842368", Offset = "0x842368", VA = "0x842368")]
		internal void BuyPendingPromotedIAP(Offer offer)
		{
		}

		[Token(Token = "0x60046A8")]
		[Address(RVA = "0x842218", Offset = "0x842218", VA = "0x842218")]
		private bool CheckBuyPreconditions(Offer offer)
		{
			return default(bool);
		}

		[Token(Token = "0x60046A9")]
		[Address(RVA = "0x842584", Offset = "0x842584", VA = "0x842584")]
		internal void RestorePurchases()
		{
		}

		[Token(Token = "0x60046AA")]
		[Address(RVA = "0x84254C", Offset = "0x84254C", VA = "0x84254C")]
		internal bool IsStockAvailable(Offer offer)
		{
			return default(bool);
		}

		[Token(Token = "0x60046AB")]
		[Address(RVA = "0x8426B0", Offset = "0x8426B0", VA = "0x8426B0")]
		public bool IsStockAvailable(string itemid, int quantity)
		{
			return default(bool);
		}

		[Token(Token = "0x60046AC")]
		[Address(RVA = "0x842568", Offset = "0x842568", VA = "0x842568")]
		internal bool IsBalanceAvailable(Offer offer)
		{
			return default(bool);
		}

		[Token(Token = "0x60046AD")]
		[Address(RVA = "0x8426CC", Offset = "0x8426CC", VA = "0x8426CC")]
		internal ReadOnlyCollection<Offer> GetOffers(bool readyOnly = true)
		{
			return null;
		}

		[Token(Token = "0x60046AE")]
		[Address(RVA = "0x8426EC", Offset = "0x8426EC", VA = "0x8426EC")]
		internal SecureLocalInt GetStock(string itemid)
		{
			return null;
		}

		[Token(Token = "0x60046AF")]
		[Address(RVA = "0x842708", Offset = "0x842708", VA = "0x842708")]
		internal SecureLocalInt GetStock(Credit credit)
		{
			return null;
		}

		[Token(Token = "0x60046B0")]
		[Address(RVA = "0x842724", Offset = "0x842724", VA = "0x842724")]
		internal List<Tuple<string, SecureLocalInt>> GetStock(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x60046B1")]
		[Address(RVA = "0x842740", Offset = "0x842740", VA = "0x842740")]
		internal int GetInventoryQuantity(string itemid)
		{
			return default(int);
		}

		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x84275C", Offset = "0x84275C", VA = "0x84275C")]
		internal ReadOnlyCollection<InventoryEntry> GetInventory()
		{
			return null;
		}

		[Token(Token = "0x60046B3")]
		[Address(RVA = "0x842778", Offset = "0x842778", VA = "0x842778")]
		internal InventoryEntry GetInventoryItem(string itemid)
		{
			return null;
		}

		[Token(Token = "0x60046B4")]
		[Address(RVA = "0x842794", Offset = "0x842794", VA = "0x842794")]
		internal bool IsInInventory(string itemid)
		{
			return default(bool);
		}

		[Token(Token = "0x60046B5")]
		[Address(RVA = "0x8427B0", Offset = "0x8427B0", VA = "0x8427B0")]
		internal bool HasMembership(string membershipid = "")
		{
			return default(bool);
		}

		[Token(Token = "0x60046B6")]
		[Address(RVA = "0x8427CC", Offset = "0x8427CC", VA = "0x8427CC")]
		internal ICollection<InventoryEntry> GetMemberships(string membershipid = "")
		{
			return null;
		}

		[Token(Token = "0x60046B7")]
		[Address(RVA = "0x8427E8", Offset = "0x8427E8", VA = "0x8427E8")]
		internal bool CreditInventory(string itemid, SecureLocalInt quantity)
		{
			return default(bool);
		}

		[Token(Token = "0x60046B8")]
		[Address(RVA = "0x842860", Offset = "0x842860", VA = "0x842860")]
		internal bool CreditInventory(Credit credit)
		{
			return default(bool);
		}

		[Token(Token = "0x60046B9")]
		[Address(RVA = "0x842924", Offset = "0x842924", VA = "0x842924")]
		internal Dictionary<string, bool> CreditInventory(List<Credit> credits)
		{
			return null;
		}

		[Token(Token = "0x60046BA")]
		[Address(RVA = "0x842B44", Offset = "0x842B44", VA = "0x842B44")]
		internal bool DebitInventory(string itemid, SecureLocalInt quantity)
		{
			return default(bool);
		}

		[Token(Token = "0x60046BB")]
		[Address(RVA = "0x842BBC", Offset = "0x842BBC", VA = "0x842BBC")]
		internal bool DebitInventory(Debit debit)
		{
			return default(bool);
		}

		[Token(Token = "0x60046BC")]
		[Address(RVA = "0x842CA0", Offset = "0x842CA0", VA = "0x842CA0")]
		internal Dictionary<string, bool> DebitInventory(List<Debit> debits)
		{
			return null;
		}

		[Token(Token = "0x60046BD")]
		[Address(RVA = "0x842EAC", Offset = "0x842EAC", VA = "0x842EAC")]
		internal bool SetOfferPrice(Offer offer, float price)
		{
			return default(bool);
		}

		[Token(Token = "0x60046BE")]
		[Address(RVA = "0x842ED4", Offset = "0x842ED4", VA = "0x842ED4")]
		internal bool SetOfferPrice(string offerId, float price)
		{
			return default(bool);
		}

		[Token(Token = "0x60046BF")]
		[Address(RVA = "0x842EF0", Offset = "0x842EF0", VA = "0x842EF0")]
		internal bool SetOfferDebits(Offer offer, List<Debit> debits)
		{
			return default(bool);
		}

		[Token(Token = "0x60046C0")]
		[Address(RVA = "0x842F18", Offset = "0x842F18", VA = "0x842F18")]
		internal bool SetOfferDebits(string offerId, List<Debit> debits)
		{
			return default(bool);
		}

		[Token(Token = "0x60046C1")]
		[Address(RVA = "0x842F34", Offset = "0x842F34", VA = "0x842F34")]
		internal Transaction GetActiveTransaction(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x60046C2")]
		[Address(RVA = "0x843040", Offset = "0x843040", VA = "0x843040")]
		internal ReadonlyTransactionHistory GetReadonlyTransactionHistory()
		{
			return null;
		}

		[Token(Token = "0x60046C3")]
		[Address(RVA = "0x84310C", Offset = "0x84310C", VA = "0x84310C")]
		internal string PrintInventory()
		{
			return null;
		}

		[Token(Token = "0x60046C4")]
		[Address(RVA = "0x843128", Offset = "0x843128", VA = "0x843128")]
		internal string PrintStock()
		{
			return null;
		}

		[Token(Token = "0x60046C5")]
		[Address(RVA = "0x843144", Offset = "0x843144", VA = "0x843144")]
		internal string PrintOffers()
		{
			return null;
		}

		[Token(Token = "0x60046C6")]
		[Address(RVA = "0x843160", Offset = "0x843160", VA = "0x843160")]
		internal string PrintOffer(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x60046C7")]
		[Address(RVA = "0x8402DC", Offset = "0x8402DC", VA = "0x8402DC")]
		private void HookEvents(AbstractShop shop)
		{
		}
	}
}
