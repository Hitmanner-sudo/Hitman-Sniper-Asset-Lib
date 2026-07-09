using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Token(Token = "0x2000813")]
[Scope]
public class ShopCampaignManager : GameSingleton<ShopCampaignManager>, ISaveable
{
	[Serializable]
	[Token(Token = "0x2000814")]
	private struct InactivityPopupInfo
	{
		[Token(Token = "0x4002CF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private LazyTexture _image;

		[Token(Token = "0x4002CF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Vector2 _imageSize;

		[Token(Token = "0x4002CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _titleLocKey;

		[Token(Token = "0x4002CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _descriptionLocKey;

		[Token(Token = "0x170006BE")]
		public Texture Image
		{
			[Token(Token = "0x60034A5")]
			[Address(RVA = "0x8BCF18", Offset = "0x8BCF18", VA = "0x8BCF18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006BF")]
		public Vector2 ImageSize
		{
			[Token(Token = "0x60034A6")]
			[Address(RVA = "0x8BD0AC", Offset = "0x8BD0AC", VA = "0x8BD0AC")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x170006C0")]
		public string Title
		{
			[Token(Token = "0x60034A7")]
			[Address(RVA = "0x8BD0B4", Offset = "0x8BD0B4", VA = "0x8BD0B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C1")]
		public string Description
		{
			[Token(Token = "0x60034A8")]
			[Address(RVA = "0x8BD11C", Offset = "0x8BD11C", VA = "0x8BD11C")]
			get
			{
				return null;
			}
		}
	}

	[Token(Token = "0x2000815")]
	public struct InactivityPromotion : ISaveable
	{
		[Serializable]
		[Token(Token = "0x2000816")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5966D0", Offset = "0x5966D0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002D03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x60034AF")]
			[Address(RVA = "0xA46C58", Offset = "0xA46C58", VA = "0xA46C58")]
			public _003C_003Ec()
			{
			}
		}

		[Token(Token = "0x4002CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string BEGIN_DATE_FIELD_NAME;

		[Token(Token = "0x4002CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string END_DATE_FIELD_NAME;

		[Token(Token = "0x4002CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string OFFER_ID_FIELD_NAME;

		[Token(Token = "0x4002CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string PROMOTION_IDX_FIELD_NAME;

		[Token(Token = "0x4002CFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB460", Offset = "0x5BB460")]
		private long _beginDate;

		[Token(Token = "0x4002D00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB470", Offset = "0x5BB470")]
		private long _endDate;

		[Token(Token = "0x4002D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB480", Offset = "0x5BB480")]
		private string _offerId;

		[Token(Token = "0x4002D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB490", Offset = "0x5BB490")]
		private int _promotionIdx;

		[Token(Token = "0x60034A9")]
		[Address(RVA = "0x8BD184", Offset = "0x8BD184", VA = "0x8BD184")]
		public InactivityPromotion(DateTime beginDate, DateTime endDate, MetaOfferReference offer)
		{
		}

		[Token(Token = "0x60034AA")]
		[Address(RVA = "0x8BD1E8", Offset = "0x8BD1E8", VA = "0x8BD1E8")]
		public bool TryApplyPromotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60034AB")]
		[Address(RVA = "0x8BD3FC", Offset = "0x8BD3FC", VA = "0x8BD3FC", Slot = "4")]
		public void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x60034AC")]
		[Address(RVA = "0x8BD658", Offset = "0x8BD658", VA = "0x8BD658", Slot = "5")]
		public JSONNode OnSaveableSerialization()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000817")]
	public struct InactivityPromotionOverride : ISaveable, IEquatable<InactivityPromotionOverride>, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x2000818")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5966E0", Offset = "0x5966E0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002D0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x60034BE")]
			[Address(RVA = "0xA46CC0", Offset = "0xA46CC0", VA = "0xA46CC0")]
			public _003C_003Ec()
			{
			}
		}

		[Token(Token = "0x4002D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string ID_FIELD_NAME;

		[Token(Token = "0x4002D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string DURATION_FIELD_NAME;

		[Token(Token = "0x4002D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly string PROMOS_FIELD_NAME;

		[Token(Token = "0x4002D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly string OFFER_DURATION_FIELD_NAME;

		[Token(Token = "0x4002D08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB4A0", Offset = "0x5BB4A0")]
		[SerializeField]
		private int _id;

		[Token(Token = "0x4002D09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB4D8", Offset = "0x5BB4D8")]
		private long _duration;

		[Token(Token = "0x4002D0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SerializableTimeSpan _offerDuration;

		[Token(Token = "0x4002D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB4F8", Offset = "0x5BB4F8")]
		private MetaOfferReference[] _promos;

		[Token(Token = "0x170006C2")]
		public int Id
		{
			[Token(Token = "0x60034B0")]
			[Address(RVA = "0x8BDB54", Offset = "0x8BDB54", VA = "0x8BDB54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006C3")]
		public TimeSpan Duration
		{
			[Token(Token = "0x60034B1")]
			[Address(RVA = "0x8BDB5C", Offset = "0x8BDB5C", VA = "0x8BDB5C")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x170006C4")]
		public MetaOfferReference[] Promos
		{
			[Token(Token = "0x60034B2")]
			[Address(RVA = "0x8BDB64", Offset = "0x8BDB64", VA = "0x8BDB64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60034B3")]
		[Address(RVA = "0x8BDB6C", Offset = "0x8BDB6C", VA = "0x8BDB6C", Slot = "4")]
		public void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x60034B4")]
		[Address(RVA = "0x8BDE38", Offset = "0x8BDE38", VA = "0x8BDE38", Slot = "5")]
		public JSONNode OnSaveableSerialization()
		{
			return null;
		}

		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x8BDEDC", Offset = "0x8BDEDC", VA = "0x8BDEDC", Slot = "6")]
		public bool Equals(InactivityPromotionOverride other)
		{
			return default(bool);
		}

		[Token(Token = "0x60034B6")]
		[Address(RVA = "0x8BDF14", Offset = "0x8BDF14", VA = "0x8BDF14", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x8BDFC0", Offset = "0x8BDFC0", VA = "0x8BDFC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60034B8")]
		[Address(RVA = "0x8BE014", Offset = "0x8BE014", VA = "0x8BE014")]
		public static bool operator ==(InactivityPromotionOverride a, InactivityPromotionOverride b)
		{
			return default(bool);
		}

		[Token(Token = "0x60034B9")]
		[Address(RVA = "0x8BE0BC", Offset = "0x8BE0BC", VA = "0x8BE0BC")]
		public static bool operator !=(InactivityPromotionOverride a, InactivityPromotionOverride b)
		{
			return default(bool);
		}

		[Token(Token = "0x60034BA")]
		[Address(RVA = "0x8BE17C", Offset = "0x8BE17C", VA = "0x8BE17C", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60034BB")]
		[Address(RVA = "0x8BE180", Offset = "0x8BE180", VA = "0x8BE180", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}

	[Token(Token = "0x2000819")]
	public class Promotion : ISaveable
	{
		[Token(Token = "0x4002D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB530", Offset = "0x5BB530")]
		public long endTime;

		[Token(Token = "0x4002D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB540", Offset = "0x5BB540")]
		public int offerIndex;

		[Token(Token = "0x170006C5")]
		public static Promotion NoPromotion
		{
			[Token(Token = "0x60034BF")]
			[Address(RVA = "0x8BE634", Offset = "0x8BE634", VA = "0x8BE634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60034C0")]
		[Address(RVA = "0x8BE6E4", Offset = "0x8BE6E4", VA = "0x8BE6E4")]
		public Promotion()
		{
		}

		[Token(Token = "0x60034C1")]
		[Address(RVA = "0x8BD3B4", Offset = "0x8BD3B4", VA = "0x8BD3B4")]
		public Promotion(DateTime pEndTime, int pOfferIndex)
		{
		}

		[Token(Token = "0x60034C2")]
		[Address(RVA = "0x8BE6EC", Offset = "0x8BE6EC", VA = "0x8BE6EC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x8BE804", Offset = "0x8BE804", VA = "0x8BE804", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60034C4")]
		[Address(RVA = "0x8BE814", Offset = "0x8BE814", VA = "0x8BE814", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x8BE8D8", Offset = "0x8BE8D8", VA = "0x8BE8D8", Slot = "4")]
		public void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x60034C6")]
		[Address(RVA = "0x8BE960", Offset = "0x8BE960", VA = "0x8BE960", Slot = "5")]
		public JSONNode OnSaveableSerialization()
		{
			return null;
		}
	}

	[Token(Token = "0x200081A")]
	public class PromotionController : ISaveable
	{
		[Serializable]
		[Token(Token = "0x200081B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5966F0", Offset = "0x5966F0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002D12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4002D13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Promotion> _003C_003E9__4_0;

			[Token(Token = "0x60034D0")]
			[Address(RVA = "0xA46D28", Offset = "0xA46D28", VA = "0xA46D28")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60034D1")]
			[Address(RVA = "0xA46D30", Offset = "0xA46D30", VA = "0xA46D30")]
			internal bool _003CRefresh_003Eb__4_0(Promotion p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4002D0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB550", Offset = "0x5BB550")]
		public Promotion _currentPromotion;

		[Token(Token = "0x4002D10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HashSet<Promotion> _availablePromotions;

		[Token(Token = "0x4002D11")]
		private const string AVAILABLE_PROMOTIONS_NAME = "_availablePromotions";

		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x8BE9D8", Offset = "0x8BE9D8", VA = "0x8BE9D8")]
		public PromotionController()
		{
		}

		[Token(Token = "0x60034C8")]
		[Address(RVA = "0x8BEA5C", Offset = "0x8BEA5C", VA = "0x8BEA5C")]
		public bool Refresh()
		{
			return default(bool);
		}

		[Token(Token = "0x60034C9")]
		[Address(RVA = "0x8BECA0", Offset = "0x8BECA0", VA = "0x8BECA0")]
		public int GetCurrentPromotionIdx()
		{
			return default(int);
		}

		[Token(Token = "0x60034CA")]
		[Address(RVA = "0x8BECBC", Offset = "0x8BECBC", VA = "0x8BECBC")]
		public long GetCurrentPromotionEndDate()
		{
			return default(long);
		}

		[Token(Token = "0x60034CB")]
		[Address(RVA = "0x8BECD8", Offset = "0x8BECD8", VA = "0x8BECD8")]
		public void Add(Promotion p)
		{
		}

		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x8BED3C", Offset = "0x8BED3C", VA = "0x8BED3C")]
		public bool Remove(Promotion p)
		{
			return default(bool);
		}

		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x8BEDA0", Offset = "0x8BEDA0", VA = "0x8BEDA0", Slot = "4")]
		public void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x8BF19C", Offset = "0x8BF19C", VA = "0x8BF19C", Slot = "5")]
		public JSONNode OnSaveableSerialization()
		{
			return null;
		}
	}

	[Token(Token = "0x200081C")]
	public class PromotionDictionary : ISaveable
	{
		[Token(Token = "0x200081D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596700", Offset = "0x596700")]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x4002D16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string offer;

			[Token(Token = "0x60034DA")]
			[Address(RVA = "0xA46DEC", Offset = "0xA46DEC", VA = "0xA46DEC")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60034DB")]
			[Address(RVA = "0xA46DF4", Offset = "0xA46DF4", VA = "0xA46DF4")]
			internal bool _003CContainsKey_003Eb__0(string s)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200081E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596710", Offset = "0x596710")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x4002D17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string offer;

			[Token(Token = "0x60034DC")]
			[Address(RVA = "0xA46E18", Offset = "0xA46E18", VA = "0xA46E18")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60034DD")]
			[Address(RVA = "0xA46E20", Offset = "0xA46E20", VA = "0xA46E20")]
			internal bool _003CGetPromotionController_003Eb__0(string s)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4002D14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB560", Offset = "0x5BB560")]
		public List<string> offers;

		[Token(Token = "0x4002D15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB570", Offset = "0x5BB570")]
		public List<PromotionController> promotionControllers;

		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x8BF3BC", Offset = "0x8BF3BC", VA = "0x8BF3BC")]
		public PromotionDictionary()
		{
		}

		[Token(Token = "0x60034D3")]
		[Address(RVA = "0x8BF478", Offset = "0x8BF478", VA = "0x8BF478")]
		public bool ContainsKey(string offer)
		{
			return default(bool);
		}

		[Token(Token = "0x60034D4")]
		[Address(RVA = "0x8BF568", Offset = "0x8BF568", VA = "0x8BF568")]
		public PromotionController GetPromotionController(string offer)
		{
			return null;
		}

		[Token(Token = "0x60034D5")]
		[Address(RVA = "0x8BF6A0", Offset = "0x8BF6A0", VA = "0x8BF6A0")]
		public void Add(string offer, PromotionController promotionController)
		{
		}

		[Token(Token = "0x60034D6")]
		[Address(RVA = "0x8BF730", Offset = "0x8BF730", VA = "0x8BF730")]
		public KeyValuePair<string, PromotionController> GetAt(int i)
		{
			return default(KeyValuePair<string, PromotionController>);
		}

		[Token(Token = "0x60034D7")]
		[Address(RVA = "0x8BF844", Offset = "0x8BF844", VA = "0x8BF844")]
		public int Length()
		{
			return default(int);
		}

		[Token(Token = "0x60034D8")]
		[Address(RVA = "0x8BF890", Offset = "0x8BF890", VA = "0x8BF890", Slot = "4")]
		public void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x60034D9")]
		[Address(RVA = "0x8BF918", Offset = "0x8BF918", VA = "0x8BF918", Slot = "5")]
		public JSONNode OnSaveableSerialization()
		{
			return null;
		}
	}

	[Token(Token = "0x200081F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596720", Offset = "0x596720")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x4002D18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InactivityNotificationData data;

		[Token(Token = "0x60034DE")]
		[Address(RVA = "0x8BCE50", Offset = "0x8BCE50", VA = "0x8BCE50")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60034DF")]
		[Address(RVA = "0x8BCE58", Offset = "0x8BCE58", VA = "0x8BCE58")]
		internal bool _003CRefreshInactivityPromotions_003Eb__0(InactivityPromotionOverride o)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000820")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596730", Offset = "0x596730")]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		[Token(Token = "0x4002D19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action onDismiss;

		[Token(Token = "0x60034E0")]
		[Address(RVA = "0x8BCE80", Offset = "0x8BCE80", VA = "0x8BCE80")]
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60034E1")]
		[Address(RVA = "0x8BCE88", Offset = "0x8BCE88", VA = "0x8BCE88")]
		internal void _003CTryShowInactivityPromoPopup_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4002CF0")]
	public const string SAVE_NAME = "SNIPER_SHOP_CAMPAIGNS_SAVE";

	[Token(Token = "0x4002CF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB3D0", Offset = "0x5BB3D0")]
	private bool _003CShowInactivityPromotionsPopup_003Ek__BackingField;

	[Token(Token = "0x4002CF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private InactivityPopupInfo _inactivityPopupInfo;

	[Token(Token = "0x4002CF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB3F0", Offset = "0x5BB3F0")]
	public PromotionDictionary offerToPromotionController;

	[Token(Token = "0x4002CF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB400", Offset = "0x5BB400")]
	private List<InactivityPromotion> _inactivityPromotions;

	[Token(Token = "0x4002CF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB410", Offset = "0x5BB410")]
	private InactivityPromotionOverride[] _inactivityOverrides;

	[Token(Token = "0x170006BC")]
	public bool ShowInactivityPromotionsPopup
	{
		[Token(Token = "0x6003492")]
		[Address(RVA = "0x8432BC", Offset = "0x8432BC", VA = "0x8432BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623050", Offset = "0x623050")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003493")]
		[Address(RVA = "0x8432C4", Offset = "0x8432C4", VA = "0x8432C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623060", Offset = "0x623060")]
		private set
		{
		}
	}

	[Token(Token = "0x170006BD")]
	public InactivityPromotionOverride[] InactivityPromotionsOverride
	{
		[Token(Token = "0x600349E")]
		[Address(RVA = "0x8441DC", Offset = "0x8441DC", VA = "0x8441DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600349F")]
		[Address(RVA = "0x8441E4", Offset = "0x8441E4", VA = "0x8441E4")]
		set
		{
		}
	}

	[Token(Token = "0x140000AD")]
	public event Action OnPromotionRefreshed
	{
		[Token(Token = "0x6003490")]
		[Address(RVA = "0x84317C", Offset = "0x84317C", VA = "0x84317C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623030", Offset = "0x623030")]
		add
		{
		}
		[Token(Token = "0x6003491")]
		[Address(RVA = "0x84321C", Offset = "0x84321C", VA = "0x84321C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623040", Offset = "0x623040")]
		remove
		{
		}
	}

	[Token(Token = "0x6003494")]
	[Address(RVA = "0x8432D0", Offset = "0x8432D0", VA = "0x8432D0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6003495")]
	[Address(RVA = "0x843428", Offset = "0x843428", VA = "0x843428")]
	private void OnOfferRefresh(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6003496")]
	[Address(RVA = "0x84356C", Offset = "0x84356C", VA = "0x84356C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003497")]
	[Address(RVA = "0x84342C", Offset = "0x84342C", VA = "0x84342C")]
	public void RefreshPromotions()
	{
	}

	[Token(Token = "0x6003498")]
	[Address(RVA = "0x8436F0", Offset = "0x8436F0", VA = "0x8436F0")]
	public bool AddPromotion(string offer, Promotion promotion)
	{
		return default(bool);
	}

	[Token(Token = "0x6003499")]
	[Address(RVA = "0x84385C", Offset = "0x84385C", VA = "0x84385C")]
	public void RemovePromotion(string offer, Promotion promotion)
	{
	}

	[Token(Token = "0x600349A")]
	[Address(RVA = "0x843968", Offset = "0x843968", VA = "0x843968")]
	public bool IsValidPromotion(string offer, Promotion promotion)
	{
		return default(bool);
	}

	[Token(Token = "0x600349B")]
	[Address(RVA = "0x843AA0", Offset = "0x843AA0", VA = "0x843AA0")]
	public void RefreshInactivityPromotions(List<InactivityNotificationData> notificationsData)
	{
	}

	[Token(Token = "0x600349C")]
	[Address(RVA = "0x843EA0", Offset = "0x843EA0", VA = "0x843EA0")]
	private void RegisterInactivityPromotions(MetaOfferReference[] promotions, DateTime beginDate, DateTime endDate)
	{
	}

	[Token(Token = "0x600349D")]
	[Address(RVA = "0x843F94", Offset = "0x843F94", VA = "0x843F94")]
	public bool TryShowInactivityPromoPopup([Optional] Action onDismiss)
	{
		return default(bool);
	}

	[Token(Token = "0x60034A0")]
	[Address(RVA = "0x843620", Offset = "0x843620", VA = "0x843620")]
	public void Save()
	{
	}

	[Token(Token = "0x60034A1")]
	[Address(RVA = "0x843370", Offset = "0x843370", VA = "0x843370")]
	public void Load()
	{
	}

	[Token(Token = "0x60034A2")]
	[Address(RVA = "0x844264", Offset = "0x844264", VA = "0x844264", Slot = "16")]
	public void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x60034A3")]
	[Address(RVA = "0x8441EC", Offset = "0x8441EC", VA = "0x8441EC", Slot = "17")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x60034A4")]
	[Address(RVA = "0x8442EC", Offset = "0x8442EC", VA = "0x8442EC")]
	public ShopCampaignManager()
	{
	}
}
