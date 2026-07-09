using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Security;
using UnityEngine;

namespace Technology.Shop
{
	[Token(Token = "0x2000B26")]
	public class Offer
	{
		[Token(Token = "0x40038CD")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC818", Offset = "0x5BC818")]
		private string _003CId_003Ek__BackingField;

		[Token(Token = "0x40038CE")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC828", Offset = "0x5BC828")]
		private string _003CShopOwnerId_003Ek__BackingField;

		[Token(Token = "0x40038CF")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC838", Offset = "0x5BC838")]
		private string _003CName_003Ek__BackingField;

		[Token(Token = "0x40038D0")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC848", Offset = "0x5BC848")]
		private string _003CDescription_003Ek__BackingField;

		[Token(Token = "0x40038D1")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC858", Offset = "0x5BC858")]
		private List<Credit> _003CCredits_003Ek__BackingField;

		[Token(Token = "0x40038D2")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC868", Offset = "0x5BC868")]
		private bool _003CIsRegisteredWithFirstParty_003Ek__BackingField;

		[Token(Token = "0x40038D3")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC878", Offset = "0x5BC878")]
		private string _003CUIContentURI_003Ek__BackingField;

		[Token(Token = "0x40038D4")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC888", Offset = "0x5BC888")]
		private float _003CPrice_003Ek__BackingField;

		[Token(Token = "0x40038D5")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC898", Offset = "0x5BC898")]
		private string _003CCurrencyCode_003Ek__BackingField;

		[Token(Token = "0x40038D6")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC8A8", Offset = "0x5BC8A8")]
		private string _003CCurrencySymbol_003Ek__BackingField;

		[Token(Token = "0x40038D7")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC8B8", Offset = "0x5BC8B8")]
		private string _003CFormattedPrice_003Ek__BackingField;

		[Token(Token = "0x40038D8")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC8C8", Offset = "0x5BC8C8")]
		private string _003CSortingCategory_003Ek__BackingField;

		[Token(Token = "0x40038D9")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC8D8", Offset = "0x5BC8D8")]
		private SecureLocalFloat _003CSaleDiscount_003Ek__BackingField;

		[Token(Token = "0x40038DA")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC8E8", Offset = "0x5BC8E8")]
		private DateTime _003CSaleExpiryDate_003Ek__BackingField;

		[Token(Token = "0x40038DB")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC8F8", Offset = "0x5BC8F8")]
		private DateTime _003CSaleEffectiveDate_003Ek__BackingField;

		[Token(Token = "0x40038DC")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC908", Offset = "0x5BC908")]
		private long _003CLastUpdated_003Ek__BackingField;

		[Token(Token = "0x40038DD")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC918", Offset = "0x5BC918")]
		private OfferState _003CTransistionState_003Ek__BackingField;

		[Token(Token = "0x40038DE")]
		[FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC928", Offset = "0x5BC928")]
		private OfferState _003CStartingState_003Ek__BackingField;

		[Token(Token = "0x40038DF")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC938", Offset = "0x5BC938")]
		private UnityEngine.Object[] _003CObjects_003Ek__BackingField;

		[Token(Token = "0x40038E0")]
		[FieldOffset(Offset = "0xA0")]
		private readonly DynamicLoader _loader;

		[Token(Token = "0x40038E1")]
		[FieldOffset(Offset = "0xA8")]
		private OfferState _state;

		[Token(Token = "0x40038E2")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<Debit> _debits;

		[Token(Token = "0x40038E3")]
		[FieldOffset(Offset = "0xB8")]
		private readonly List<Debit> _originalDebits;

		[Token(Token = "0x170008BF")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x62DD88", Offset = "0x62DD88")]
		public string Id
		{
			[Token(Token = "0x60045CF")]
			[Address(RVA = "0x9EFDE4", Offset = "0x9EFDE4", VA = "0x9EFDE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6266A8", Offset = "0x6266A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045D0")]
			[Address(RVA = "0x9EFDEC", Offset = "0x9EFDEC", VA = "0x9EFDEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6266B8", Offset = "0x6266B8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008C0")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x62DDC0", Offset = "0x62DDC0")]
		public string ShopOwnerId
		{
			[Token(Token = "0x60045D1")]
			[Address(RVA = "0x9EFDF4", Offset = "0x9EFDF4", VA = "0x9EFDF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6266C8", Offset = "0x6266C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045D2")]
			[Address(RVA = "0x9EFDFC", Offset = "0x9EFDFC", VA = "0x9EFDFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6266D8", Offset = "0x6266D8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170008C1")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x62DDF8", Offset = "0x62DDF8")]
		public string Name
		{
			[Token(Token = "0x60045D3")]
			[Address(RVA = "0x9EFE04", Offset = "0x9EFE04", VA = "0x9EFE04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6266E8", Offset = "0x6266E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045D4")]
			[Address(RVA = "0x9EFE0C", Offset = "0x9EFE0C", VA = "0x9EFE0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6266F8", Offset = "0x6266F8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170008C2")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x62DE30", Offset = "0x62DE30")]
		public string Description
		{
			[Token(Token = "0x60045D5")]
			[Address(RVA = "0x9EFE14", Offset = "0x9EFE14", VA = "0x9EFE14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626708", Offset = "0x626708")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045D6")]
			[Address(RVA = "0x9EFE1C", Offset = "0x9EFE1C", VA = "0x9EFE1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626718", Offset = "0x626718")]
			internal set
			{
			}
		}

		[Token(Token = "0x170008C3")]
		public List<Debit> Debits
		{
			[Token(Token = "0x60045D7")]
			[Address(RVA = "0x9EFE24", Offset = "0x9EFE24", VA = "0x9EFE24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C4")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x62DE68", Offset = "0x62DE68")]
		public List<Credit> Credits
		{
			[Token(Token = "0x60045D8")]
			[Address(RVA = "0x9F01C0", Offset = "0x9F01C0", VA = "0x9F01C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626728", Offset = "0x626728")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045D9")]
			[Address(RVA = "0x9F01C8", Offset = "0x9F01C8", VA = "0x9F01C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626738", Offset = "0x626738")]
			internal set
			{
			}
		}

		[Token(Token = "0x170008C5")]
		public List<Debit> OriginalDebits
		{
			[Token(Token = "0x60045DA")]
			[Address(RVA = "0x9F01D0", Offset = "0x9F01D0", VA = "0x9F01D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C6")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x62DEA0", Offset = "0x62DEA0")]
		public bool IsRegisteredWithFirstParty
		{
			[Token(Token = "0x60045DB")]
			[Address(RVA = "0x9F01D8", Offset = "0x9F01D8", VA = "0x9F01D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626748", Offset = "0x626748")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60045DC")]
			[Address(RVA = "0x9F01E0", Offset = "0x9F01E0", VA = "0x9F01E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626758", Offset = "0x626758")]
			private set
			{
			}
		}

		[Token(Token = "0x170008C7")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x62DED8", Offset = "0x62DED8")]
		public string UIContentURI
		{
			[Token(Token = "0x60045DD")]
			[Address(RVA = "0x9F01EC", Offset = "0x9F01EC", VA = "0x9F01EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626768", Offset = "0x626768")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045DE")]
			[Address(RVA = "0x9F01F4", Offset = "0x9F01F4", VA = "0x9F01F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626778", Offset = "0x626778")]
			internal set
			{
			}
		}

		[Token(Token = "0x170008C8")]
		public float Price
		{
			[Token(Token = "0x60045DF")]
			[Address(RVA = "0x9F01FC", Offset = "0x9F01FC", VA = "0x9F01FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626788", Offset = "0x626788")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60045E0")]
			[Address(RVA = "0x9F0204", Offset = "0x9F0204", VA = "0x9F0204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626798", Offset = "0x626798")]
			set
			{
			}
		}

		[Token(Token = "0x170008C9")]
		public string CurrencyCode
		{
			[Token(Token = "0x60045E1")]
			[Address(RVA = "0x9F020C", Offset = "0x9F020C", VA = "0x9F020C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6267A8", Offset = "0x6267A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045E2")]
			[Address(RVA = "0x9F0214", Offset = "0x9F0214", VA = "0x9F0214")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6267B8", Offset = "0x6267B8")]
			set
			{
			}
		}

		[Token(Token = "0x170008CA")]
		public string CurrencySymbol
		{
			[Token(Token = "0x60045E3")]
			[Address(RVA = "0x9F021C", Offset = "0x9F021C", VA = "0x9F021C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6267C8", Offset = "0x6267C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045E4")]
			[Address(RVA = "0x9F0224", Offset = "0x9F0224", VA = "0x9F0224")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6267D8", Offset = "0x6267D8")]
			set
			{
			}
		}

		[Token(Token = "0x170008CB")]
		public string FormattedPrice
		{
			[Token(Token = "0x60045E5")]
			[Address(RVA = "0x9F022C", Offset = "0x9F022C", VA = "0x9F022C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6267E8", Offset = "0x6267E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045E6")]
			[Address(RVA = "0x9F0234", Offset = "0x9F0234", VA = "0x9F0234")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6267F8", Offset = "0x6267F8")]
			set
			{
			}
		}

		[Token(Token = "0x170008CC")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x62DF10", Offset = "0x62DF10")]
		public string SortingCategory
		{
			[Token(Token = "0x60045E7")]
			[Address(RVA = "0x9F023C", Offset = "0x9F023C", VA = "0x9F023C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626808", Offset = "0x626808")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045E8")]
			[Address(RVA = "0x9F0244", Offset = "0x9F0244", VA = "0x9F0244")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626818", Offset = "0x626818")]
			set
			{
			}
		}

		[Token(Token = "0x170008CD")]
		public SecureLocalFloat SaleDiscount
		{
			[Token(Token = "0x60045E9")]
			[Address(RVA = "0x9F024C", Offset = "0x9F024C", VA = "0x9F024C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626828", Offset = "0x626828")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045EA")]
			[Address(RVA = "0x9F0254", Offset = "0x9F0254", VA = "0x9F0254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626838", Offset = "0x626838")]
			set
			{
			}
		}

		[Token(Token = "0x170008CE")]
		public DateTime SaleExpiryDate
		{
			[Token(Token = "0x60045EB")]
			[Address(RVA = "0x9F025C", Offset = "0x9F025C", VA = "0x9F025C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626848", Offset = "0x626848")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60045EC")]
			[Address(RVA = "0x9F0264", Offset = "0x9F0264", VA = "0x9F0264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626858", Offset = "0x626858")]
			set
			{
			}
		}

		[Token(Token = "0x170008CF")]
		public DateTime SaleEffectiveDate
		{
			[Token(Token = "0x60045ED")]
			[Address(RVA = "0x9F026C", Offset = "0x9F026C", VA = "0x9F026C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626868", Offset = "0x626868")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60045EE")]
			[Address(RVA = "0x9F0274", Offset = "0x9F0274", VA = "0x9F0274")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626878", Offset = "0x626878")]
			set
			{
			}
		}

		[Token(Token = "0x170008D0")]
		public long LastUpdated
		{
			[Token(Token = "0x60045EF")]
			[Address(RVA = "0x9F027C", Offset = "0x9F027C", VA = "0x9F027C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626888", Offset = "0x626888")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60045F0")]
			[Address(RVA = "0x9F0284", Offset = "0x9F0284", VA = "0x9F0284")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626898", Offset = "0x626898")]
			set
			{
			}
		}

		[Token(Token = "0x170008D1")]
		public OfferState TransistionState
		{
			[Token(Token = "0x60045F1")]
			[Address(RVA = "0x9F028C", Offset = "0x9F028C", VA = "0x9F028C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6268A8", Offset = "0x6268A8")]
			get
			{
				return default(OfferState);
			}
			[Token(Token = "0x60045F2")]
			[Address(RVA = "0x9F0294", Offset = "0x9F0294", VA = "0x9F0294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6268B8", Offset = "0x6268B8")]
			set
			{
			}
		}

		[Token(Token = "0x170008D2")]
		public OfferState StartingState
		{
			[Token(Token = "0x60045F3")]
			[Address(RVA = "0x9F029C", Offset = "0x9F029C", VA = "0x9F029C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6268C8", Offset = "0x6268C8")]
			get
			{
				return default(OfferState);
			}
			[Token(Token = "0x60045F4")]
			[Address(RVA = "0x9F02A4", Offset = "0x9F02A4", VA = "0x9F02A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6268D8", Offset = "0x6268D8")]
			set
			{
			}
		}

		[Token(Token = "0x170008D3")]
		public OfferState State
		{
			[Token(Token = "0x60045F5")]
			[Address(RVA = "0x9F02AC", Offset = "0x9F02AC", VA = "0x9F02AC")]
			get
			{
				return default(OfferState);
			}
			[Token(Token = "0x60045F6")]
			[Address(RVA = "0x9F02B4", Offset = "0x9F02B4", VA = "0x9F02B4")]
			set
			{
			}
		}

		[Token(Token = "0x170008D4")]
		public bool IsSaleOn
		{
			[Token(Token = "0x60045F7")]
			[Address(RVA = "0x9F0098", Offset = "0x9F0098", VA = "0x9F0098")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170008D5")]
		public bool IsSaleFree
		{
			[Token(Token = "0x60045F8")]
			[Address(RVA = "0x9F02C8", Offset = "0x9F02C8", VA = "0x9F02C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170008D6")]
		internal UnityEngine.Object[] Objects
		{
			[Token(Token = "0x60045F9")]
			[Address(RVA = "0x9F02F8", Offset = "0x9F02F8", VA = "0x9F02F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6268E8", Offset = "0x6268E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045FA")]
			[Address(RVA = "0x9F0300", Offset = "0x9F0300", VA = "0x9F0300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6268F8", Offset = "0x6268F8")]
			private set
			{
			}
		}

		[Token(Token = "0x140000D9")]
		public static event EventHandler<OfferEvent> OnDownloadComplete
		{
			[Token(Token = "0x60045CD")]
			[Address(RVA = "0x9EFC6C", Offset = "0x9EFC6C", VA = "0x9EFC6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626688", Offset = "0x626688")]
			add
			{
			}
			[Token(Token = "0x60045CE")]
			[Address(RVA = "0x9EFD28", Offset = "0x9EFD28", VA = "0x9EFD28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626698", Offset = "0x626698")]
			remove
			{
			}
		}

		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x9F0308", Offset = "0x9F0308", VA = "0x9F0308")]
		public Offer()
		{
		}

		[Token(Token = "0x60045FC")]
		[Address(RVA = "0x9F0430", Offset = "0x9F0430", VA = "0x9F0430")]
		private Offer(List<Debit> originalDebits, List<Credit> credits)
		{
		}

		[Token(Token = "0x60045FD")]
		[Address(RVA = "0x9F04DC", Offset = "0x9F04DC", VA = "0x9F04DC")]
		public Offer GetMemberwiseClone()
		{
			return null;
		}

		[Token(Token = "0x60045FE")]
		[Address(RVA = "0x9F05C8", Offset = "0x9F05C8", VA = "0x9F05C8")]
		public Offer(string shopOwnerId, OfferState startingstate, OfferState resultantstate, string id, string name, string description, string uri, bool isregistered, string sortingcategory, List<Credit> credits, List<Debit> debits, long lastUpdate = 0L)
		{
		}

		[Token(Token = "0x60045FF")]
		[Address(RVA = "0x9F0764", Offset = "0x9F0764", VA = "0x9F0764")]
		public Offer(OfferDescription desc, string shopOwnerId, OfferState state)
		{
		}

		[Token(Token = "0x6004600")]
		[Address(RVA = "0x9F0788", Offset = "0x9F0788", VA = "0x9F0788")]
		public Offer(string offerID, OfferDescription desc, string shopOwnerId, OfferState state)
		{
		}

		[Token(Token = "0x6004601")]
		[Address(RVA = "0x9F088C", Offset = "0x9F088C", VA = "0x9F088C")]
		public void StartDownload()
		{
		}

		[Token(Token = "0x6004602")]
		[Address(RVA = "0x9F0A80", Offset = "0x9F0A80", VA = "0x9F0A80")]
		internal void LoadUI()
		{
		}

		[Token(Token = "0x6004603")]
		[Address(RVA = "0x9F0B18", Offset = "0x9F0B18", VA = "0x9F0B18")]
		internal bool SetPrice(float price)
		{
			return default(bool);
		}

		[Token(Token = "0x6004604")]
		[Address(RVA = "0x9F0E30", Offset = "0x9F0E30", VA = "0x9F0E30")]
		internal bool SetPrice(string price)
		{
			return default(bool);
		}

		[Token(Token = "0x6004605")]
		[Address(RVA = "0x9F1114", Offset = "0x9F1114", VA = "0x9F1114")]
		internal bool SetDebits(List<Debit> debits, bool overrideDebits = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6004606")]
		[Address(RVA = "0x9F13CC", Offset = "0x9F13CC", VA = "0x9F13CC")]
		internal void SetSaleInformation(float discount)
		{
		}

		[Token(Token = "0x6004607")]
		[Address(RVA = "0x9F145C", Offset = "0x9F145C", VA = "0x9F145C")]
		private void SetSaleInformation(float discount, DateTime effectiveDt, DateTime expiryDt)
		{
		}

		[Token(Token = "0x6004608")]
		[Address(RVA = "0x9F1480", Offset = "0x9F1480", VA = "0x9F1480")]
		internal bool TryParseDateTime(string dateTimeStr, out DateTime result)
		{
			return default(bool);
		}

		[Token(Token = "0x6004609")]
		[Address(RVA = "0x9F15E4", Offset = "0x9F15E4", VA = "0x9F15E4")]
		internal void SetSaleInformation(string effectiveDate, string expiryDate, float discount)
		{
		}

		[Token(Token = "0x600460A")]
		[Address(RVA = "0x9F1694", Offset = "0x9F1694", VA = "0x9F1694")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600460B")]
		[Address(RVA = "0x9F16B0", Offset = "0x9F16B0", VA = "0x9F16B0")]
		internal string Print()
		{
			return null;
		}

		[Token(Token = "0x600460C")]
		[Address(RVA = "0x9F0C80", Offset = "0x9F0C80", VA = "0x9F0C80")]
		private static string GetISOCurrencyCode()
		{
			return null;
		}

		[Token(Token = "0x600460D")]
		[Address(RVA = "0x9F0E60", Offset = "0x9F0E60", VA = "0x9F0E60")]
		private static float GetPrice(string value)
		{
			return default(float);
		}

		[Token(Token = "0x600460E")]
		[Address(RVA = "0x9F23DC", Offset = "0x9F23DC", VA = "0x9F23DC")]
		private void LoaderOnOnDownloadComplete(object sender, DynamicLoaderEvent dynamicLoaderEvent)
		{
		}

		[Token(Token = "0x600460F")]
		[Address(RVA = "0x9F0758", Offset = "0x9F0758", VA = "0x9F0758")]
		internal static string CreateURI(string offerId, string uriString, bool useDefaultPath = true)
		{
			return null;
		}

		[Token(Token = "0x6004610")]
		[Address(RVA = "0x9F2A48", Offset = "0x9F2A48", VA = "0x9F2A48")]
		internal static string CreateURI(string uriString, bool relativeOnly = false)
		{
			return null;
		}

		[Token(Token = "0x6004611")]
		[Address(RVA = "0x9F260C", Offset = "0x9F260C", VA = "0x9F260C")]
		private static string CreateURI(string offerId, string uriString, bool useDefaultPath, bool relativeOnly)
		{
			return null;
		}

		[Token(Token = "0x6004612")]
		[Address(RVA = "0x9F2AB0", Offset = "0x9F2AB0", VA = "0x9F2AB0")]
		internal void Serialize()
		{
		}

		[Token(Token = "0x6004613")]
		[Address(RVA = "0x9F34C8", Offset = "0x9F34C8", VA = "0x9F34C8")]
		internal static Offer Deserialize(string id)
		{
			return null;
		}

		[Token(Token = "0x6004614")]
		[Address(RVA = "0x9F43D8", Offset = "0x9F43D8", VA = "0x9F43D8")]
		internal void Override(Offer offer)
		{
		}
	}
}
