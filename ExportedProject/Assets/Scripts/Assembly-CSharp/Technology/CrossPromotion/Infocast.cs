using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C0C")]
	public class Infocast
	{
		[Token(Token = "0x2000C0D")]
		public delegate void InfocastEventHandler(Infocast infocast);

		[Token(Token = "0x2000C0E")]
		public delegate void InfocastsEventHandler(Infocast[] infocast);

		[Token(Token = "0x2000C0F")]
		private delegate void InfocastsAIsEventHandler(Infocast[] infocast, string deviceID, string languageCode);

		[Token(Token = "0x2000C10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598564", Offset = "0x598564")]
		private sealed class _003C_003Ec__DisplayClass73_0
		{
			[Token(Token = "0x4003C2A")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpQueueInfocastElement svcOp;

			[Token(Token = "0x4003C2B")]
			[FieldOffset(Offset = "0x18")]
			public Infocast _003C_003E4__this;

			[Token(Token = "0x6004C5E")]
			[Address(RVA = "0xB25DB0", Offset = "0xB25DB0", VA = "0xB25DB0")]
			public _003C_003Ec__DisplayClass73_0()
			{
			}

			[Token(Token = "0x6004C5F")]
			[Address(RVA = "0xB25DB8", Offset = "0xB25DB8", VA = "0xB25DB8")]
			internal void _003CCreate_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000C11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598574", Offset = "0x598574")]
		private sealed class _003C_003Ec__DisplayClass73_1
		{
			[Token(Token = "0x4003C2C")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpSegmentInfocastElement svcOp;

			[Token(Token = "0x4003C2D")]
			[FieldOffset(Offset = "0x18")]
			public Infocast _003C_003E4__this;

			[Token(Token = "0x6004C60")]
			[Address(RVA = "0xB25EF4", Offset = "0xB25EF4", VA = "0xB25EF4")]
			public _003C_003Ec__DisplayClass73_1()
			{
			}

			[Token(Token = "0x6004C61")]
			[Address(RVA = "0xB25EFC", Offset = "0xB25EFC", VA = "0xB25EFC")]
			internal void _003CCreate_003Eb__1(IResponseContext response)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000C12")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598584", Offset = "0x598584")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003C2E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003C2F")]
			[FieldOffset(Offset = "0x8")]
			public static Action<IResponseContext> _003C_003E9__81_0;

			[Token(Token = "0x6004C63")]
			[Address(RVA = "0xB25B44", Offset = "0xB25B44", VA = "0xB25B44")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004C64")]
			[Address(RVA = "0xB25B4C", Offset = "0xB25B4C", VA = "0xB25B4C")]
			internal void _003CGetInfocasts_003Eb__81_0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000C13")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598594", Offset = "0x598594")]
		private sealed class _003C_003Ec__DisplayClass83_0
		{
			[Token(Token = "0x4003C30")]
			[FieldOffset(Offset = "0x10")]
			public bool privateEvent;

			[Token(Token = "0x4003C31")]
			[FieldOffset(Offset = "0x18")]
			public string deviceID;

			[Token(Token = "0x4003C32")]
			[FieldOffset(Offset = "0x20")]
			public string languageCode;

			[Token(Token = "0x6004C65")]
			[Address(RVA = "0xB26038", Offset = "0xB26038", VA = "0xB26038")]
			public _003C_003Ec__DisplayClass83_0()
			{
			}

			[Token(Token = "0x6004C66")]
			[Address(RVA = "0xB26040", Offset = "0xB26040", VA = "0xB26040")]
			internal void _003CGetActiveMessagesOfTheDay_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000C14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5985A4", Offset = "0x5985A4")]
		private sealed class _003C_003Ec__DisplayClass85_0
		{
			[Token(Token = "0x4003C33")]
			[FieldOffset(Offset = "0x10")]
			public Infocast[] infocastsToAppend;

			[Token(Token = "0x4003C34")]
			[FieldOffset(Offset = "0x18")]
			public bool privateEvent;

			[Token(Token = "0x4003C35")]
			[FieldOffset(Offset = "0x20")]
			public string deviceID;

			[Token(Token = "0x6004C67")]
			[Address(RVA = "0xB262F0", Offset = "0xB262F0", VA = "0xB262F0")]
			public _003C_003Ec__DisplayClass85_0()
			{
			}

			[Token(Token = "0x6004C68")]
			[Address(RVA = "0xB262F8", Offset = "0xB262F8", VA = "0xB262F8")]
			internal void _003CGetActivePromotions_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000C15")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5985B4", Offset = "0x5985B4")]
		private sealed class _003C_003Ec__DisplayClass89_0
		{
			[Token(Token = "0x4003C36")]
			[FieldOffset(Offset = "0x10")]
			public string infocastID;

			[Token(Token = "0x6004C69")]
			[Address(RVA = "0xB265F8", Offset = "0xB265F8", VA = "0xB265F8")]
			public _003C_003Ec__DisplayClass89_0()
			{
			}

			[Token(Token = "0x6004C6A")]
			[Address(RVA = "0xB26600", Offset = "0xB26600", VA = "0xB26600")]
			internal void _003CFromServer_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x4003C0F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string MOTD_TO_STRING;

		[Token(Token = "0x4003C10")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string PROMOTION_TO_STRING;

		[Token(Token = "0x4003C1E")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDB14", Offset = "0x5BDB14")]
		private string _003CErrorMessage_003Ek__BackingField;

		[Token(Token = "0x4003C1F")]
		[FieldOffset(Offset = "0x40")]
		public ImageInfo Image;

		[Token(Token = "0x4003C20")]
		[FieldOffset(Offset = "0x58")]
		public string ID;

		[Token(Token = "0x4003C21")]
		[FieldOffset(Offset = "0x60")]
		public InfocastType Type;

		[Token(Token = "0x4003C22")]
		[FieldOffset(Offset = "0x68")]
		public string Subtype;

		[Token(Token = "0x4003C23")]
		[FieldOffset(Offset = "0x70")]
		public List<string> SegmentList;

		[Token(Token = "0x4003C24")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, string> MessageByLang;

		[Token(Token = "0x4003C25")]
		[FieldOffset(Offset = "0x80")]
		public GoogleStoreLinkInfo GoogleStoreLink;

		[Token(Token = "0x4003C26")]
		[FieldOffset(Offset = "0x88")]
		public AppleStoreLinkInfo AppleStoreLink;

		[Token(Token = "0x4003C27")]
		[FieldOffset(Offset = "0x90")]
		public DateTime Start;

		[Token(Token = "0x4003C28")]
		[FieldOffset(Offset = "0x98")]
		public DateTime End;

		[Token(Token = "0x4003C29")]
		[FieldOffset(Offset = "0xA0")]
		public DateTime LastUpdate;

		[Token(Token = "0x170009B4")]
		public string ErrorMessage
		{
			[Token(Token = "0x6004C2A")]
			[Address(RVA = "0xB0FB84", Offset = "0xB0FB84", VA = "0xB0FB84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6286A0", Offset = "0x6286A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C2B")]
			[Address(RVA = "0xB0FB8C", Offset = "0xB0FB8C", VA = "0xB0FB8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6286B0", Offset = "0x6286B0")]
			set
			{
			}
		}

		[Token(Token = "0x170009B5")]
		public string StartISO8601
		{
			[Token(Token = "0x6004C2D")]
			[Address(RVA = "0xB0FD18", Offset = "0xB0FD18", VA = "0xB0FD18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C2E")]
			[Address(RVA = "0xB0FD24", Offset = "0xB0FD24", VA = "0xB0FD24")]
			set
			{
			}
		}

		[Token(Token = "0x170009B6")]
		public string EndISO8601
		{
			[Token(Token = "0x6004C2F")]
			[Address(RVA = "0xB0FD50", Offset = "0xB0FD50", VA = "0xB0FD50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C30")]
			[Address(RVA = "0xB0FD5C", Offset = "0xB0FD5C", VA = "0xB0FD5C")]
			set
			{
			}
		}

		[Token(Token = "0x170009B7")]
		public string LastUpdatedISO8601
		{
			[Token(Token = "0x6004C31")]
			[Address(RVA = "0xB0FD88", Offset = "0xB0FD88", VA = "0xB0FD88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C32")]
			[Address(RVA = "0xB0FD94", Offset = "0xB0FD94", VA = "0xB0FD94")]
			set
			{
			}
		}

		[Token(Token = "0x14000131")]
		public event InfocastEventHandler OnCreation
		{
			[Token(Token = "0x6004C10")]
			[Address(RVA = "0xB0E5C4", Offset = "0xB0E5C4", VA = "0xB0E5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628500", Offset = "0x628500")]
			add
			{
			}
			[Token(Token = "0x6004C11")]
			[Address(RVA = "0xB0E664", Offset = "0xB0E664", VA = "0xB0E664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628510", Offset = "0x628510")]
			remove
			{
			}
		}

		[Token(Token = "0x14000132")]
		public event InfocastEventHandler OnUpdate
		{
			[Token(Token = "0x6004C12")]
			[Address(RVA = "0xB0E704", Offset = "0xB0E704", VA = "0xB0E704")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628520", Offset = "0x628520")]
			add
			{
			}
			[Token(Token = "0x6004C13")]
			[Address(RVA = "0xB0E7A4", Offset = "0xB0E7A4", VA = "0xB0E7A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628530", Offset = "0x628530")]
			remove
			{
			}
		}

		[Token(Token = "0x14000133")]
		public event InfocastEventHandler OnCoreUpdate
		{
			[Token(Token = "0x6004C14")]
			[Address(RVA = "0xB0E844", Offset = "0xB0E844", VA = "0xB0E844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628540", Offset = "0x628540")]
			add
			{
			}
			[Token(Token = "0x6004C15")]
			[Address(RVA = "0xB0E8E4", Offset = "0xB0E8E4", VA = "0xB0E8E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628550", Offset = "0x628550")]
			remove
			{
			}
		}

		[Token(Token = "0x14000134")]
		public event InfocastEventHandler OnDelete
		{
			[Token(Token = "0x6004C16")]
			[Address(RVA = "0xB0E984", Offset = "0xB0E984", VA = "0xB0E984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628560", Offset = "0x628560")]
			add
			{
			}
			[Token(Token = "0x6004C17")]
			[Address(RVA = "0xB0EA24", Offset = "0xB0EA24", VA = "0xB0EA24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628570", Offset = "0x628570")]
			remove
			{
			}
		}

		[Token(Token = "0x14000135")]
		public event InfocastEventHandler OnError
		{
			[Token(Token = "0x6004C18")]
			[Address(RVA = "0xB0EAC4", Offset = "0xB0EAC4", VA = "0xB0EAC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628580", Offset = "0x628580")]
			add
			{
			}
			[Token(Token = "0x6004C19")]
			[Address(RVA = "0xB0EB64", Offset = "0xB0EB64", VA = "0xB0EB64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628590", Offset = "0x628590")]
			remove
			{
			}
		}

		[Token(Token = "0x14000136")]
		public static event InfocastEventHandler OnInfocastFromServer
		{
			[Token(Token = "0x6004C1A")]
			[Address(RVA = "0xB0EC04", Offset = "0xB0EC04", VA = "0xB0EC04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6285A0", Offset = "0x6285A0")]
			add
			{
			}
			[Token(Token = "0x6004C1B")]
			[Address(RVA = "0xB0ECFC", Offset = "0xB0ECFC", VA = "0xB0ECFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6285B0", Offset = "0x6285B0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000137")]
		public static event InfocastEventHandler OnStaticError
		{
			[Token(Token = "0x6004C1C")]
			[Address(RVA = "0xB0EDF4", Offset = "0xB0EDF4", VA = "0xB0EDF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6285C0", Offset = "0x6285C0")]
			add
			{
			}
			[Token(Token = "0x6004C1D")]
			[Address(RVA = "0xB0EEEC", Offset = "0xB0EEEC", VA = "0xB0EEEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6285D0", Offset = "0x6285D0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000138")]
		public static event InfocastsEventHandler OnReceivedMessagesOfTheDay
		{
			[Token(Token = "0x6004C1E")]
			[Address(RVA = "0xB0EFE4", Offset = "0xB0EFE4", VA = "0xB0EFE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6285E0", Offset = "0x6285E0")]
			add
			{
			}
			[Token(Token = "0x6004C1F")]
			[Address(RVA = "0xB0F0DC", Offset = "0xB0F0DC", VA = "0xB0F0DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6285F0", Offset = "0x6285F0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000139")]
		public static event InfocastsEventHandler OnReceivedActivePromotions
		{
			[Token(Token = "0x6004C20")]
			[Address(RVA = "0xB0F1D4", Offset = "0xB0F1D4", VA = "0xB0F1D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628600", Offset = "0x628600")]
			add
			{
			}
			[Token(Token = "0x6004C21")]
			[Address(RVA = "0xB0F2CC", Offset = "0xB0F2CC", VA = "0xB0F2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628610", Offset = "0x628610")]
			remove
			{
			}
		}

		[Token(Token = "0x1400013A")]
		public static event InfocastsEventHandler OnReceivedInfocasts
		{
			[Token(Token = "0x6004C22")]
			[Address(RVA = "0xB0F3C4", Offset = "0xB0F3C4", VA = "0xB0F3C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628620", Offset = "0x628620")]
			add
			{
			}
			[Token(Token = "0x6004C23")]
			[Address(RVA = "0xB0F4BC", Offset = "0xB0F4BC", VA = "0xB0F4BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628630", Offset = "0x628630")]
			remove
			{
			}
		}

		[Token(Token = "0x1400013B")]
		public static event InfocastsEventHandler OnInfocastsFromServer
		{
			[Token(Token = "0x6004C24")]
			[Address(RVA = "0xB0F5B4", Offset = "0xB0F5B4", VA = "0xB0F5B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628640", Offset = "0x628640")]
			add
			{
			}
			[Token(Token = "0x6004C25")]
			[Address(RVA = "0xB0F6AC", Offset = "0xB0F6AC", VA = "0xB0F6AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628650", Offset = "0x628650")]
			remove
			{
			}
		}

		[Token(Token = "0x1400013C")]
		private static event InfocastsAIsEventHandler OnAIsReceivedMOTD
		{
			[Token(Token = "0x6004C26")]
			[Address(RVA = "0xB0F7A4", Offset = "0xB0F7A4", VA = "0xB0F7A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628660", Offset = "0x628660")]
			add
			{
			}
			[Token(Token = "0x6004C27")]
			[Address(RVA = "0xB0F89C", Offset = "0xB0F89C", VA = "0xB0F89C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628670", Offset = "0x628670")]
			remove
			{
			}
		}

		[Token(Token = "0x1400013D")]
		private static event InfocastsAIsEventHandler OnAIsReceivedPromotions
		{
			[Token(Token = "0x6004C28")]
			[Address(RVA = "0xB0F994", Offset = "0xB0F994", VA = "0xB0F994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628680", Offset = "0x628680")]
			add
			{
			}
			[Token(Token = "0x6004C29")]
			[Address(RVA = "0xB0FA8C", Offset = "0xB0FA8C", VA = "0xB0FA8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628690", Offset = "0x628690")]
			remove
			{
			}
		}

		[Token(Token = "0x6004C2C")]
		[Address(RVA = "0xB0FB94", Offset = "0xB0FB94", VA = "0xB0FB94")]
		public Infocast()
		{
		}

		[Token(Token = "0x6004C33")]
		[Address(RVA = "0xB0FDC0", Offset = "0xB0FDC0", VA = "0xB0FDC0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C34")]
		[Address(RVA = "0xB10148", Offset = "0xB10148", VA = "0xB10148", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6004C35")]
		[Address(RVA = "0xB0FE68", Offset = "0xB0FE68", VA = "0xB0FE68")]
		public static bool operator ==(Infocast a, Infocast b)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C36")]
		[Address(RVA = "0xB102FC", Offset = "0xB102FC", VA = "0xB102FC")]
		public static bool operator !=(Infocast a, Infocast b)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C37")]
		[Address(RVA = "0xB10378", Offset = "0xB10378", VA = "0xB10378")]
		public void Create()
		{
		}

		[Token(Token = "0x6004C38")]
		[Address(RVA = "0xB10CF0", Offset = "0xB10CF0", VA = "0xB10CF0")]
		private string ParseCreateResponse(string response, string command)
		{
			return null;
		}

		[Token(Token = "0x6004C39")]
		[Address(RVA = "0xB10EB4", Offset = "0xB10EB4", VA = "0xB10EB4")]
		public bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0xB11164", Offset = "0xB11164", VA = "0xB11164")]
		private bool UpdateSegments()
		{
			return default(bool);
		}

		[Token(Token = "0x6004C3B")]
		[Address(RVA = "0xB11404", Offset = "0xB11404", VA = "0xB11404")]
		private bool ParseUpdateResponse(string response)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C3C")]
		[Address(RVA = "0xB115DC", Offset = "0xB115DC", VA = "0xB115DC")]
		private bool ParseUpdateSegmentResponse(string response)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C3D")]
		[Address(RVA = "0xB11790", Offset = "0xB11790", VA = "0xB11790")]
		public void Delete()
		{
		}

		[Token(Token = "0x6004C3E")]
		[Address(RVA = "0xB11860", Offset = "0xB11860", VA = "0xB11860")]
		private bool ParseDeleteResponse(string response)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C3F")]
		[Address(RVA = "0xB119FC", Offset = "0xB119FC", VA = "0xB119FC")]
		public static void GetInfocasts()
		{
		}

		[Token(Token = "0x6004C40")]
		[Address(RVA = "0xB11B4C", Offset = "0xB11B4C", VA = "0xB11B4C")]
		public static void GetActiveMessagesOfTheDay(string deviceID = "", string languageCode = "")
		{
		}

		[Token(Token = "0x6004C41")]
		[Address(RVA = "0xB11BC0", Offset = "0xB11BC0", VA = "0xB11BC0")]
		private static void GetActiveMessagesOfTheDay(bool privateEvent, string deviceID = "", string languageCode = "")
		{
		}

		[Token(Token = "0x6004C42")]
		[Address(RVA = "0xB11CF0", Offset = "0xB11CF0", VA = "0xB11CF0")]
		public static void GetActivePromotions(string deviceID = "")
		{
		}

		[Token(Token = "0x6004C43")]
		[Address(RVA = "0xB11D58", Offset = "0xB11D58", VA = "0xB11D58")]
		private static void GetActivePromotions(bool privateEvent, Infocast[] infocastsToAppend, string deviceID = "")
		{
		}

		[Token(Token = "0x6004C44")]
		[Address(RVA = "0xB11E8C", Offset = "0xB11E8C", VA = "0xB11E8C")]
		public static void GetActiveInfocasts(string deviceID = "", string languageCode = "")
		{
		}

		[Token(Token = "0x6004C45")]
		[Address(RVA = "0xB12000", Offset = "0xB12000", VA = "0xB12000")]
		private static void GetAIsMOTD(Infocast[] infocasts, string deviceID, string languageCode)
		{
		}

		[Token(Token = "0x6004C46")]
		[Address(RVA = "0xB12074", Offset = "0xB12074", VA = "0xB12074")]
		private static void GetAIsPromotion(Infocast[] infocasts, string deviceID, string languageCode)
		{
		}

		[Token(Token = "0x6004C47")]
		[Address(RVA = "0xB12104", Offset = "0xB12104", VA = "0xB12104")]
		public static void FromServer(string infocastID)
		{
		}

		[Token(Token = "0x6004C48")]
		[Address(RVA = "0xB12204", Offset = "0xB12204", VA = "0xB12204")]
		public static Infocast FromJSON(JSONNode node)
		{
			return null;
		}

		[Token(Token = "0x6004C49")]
		[Address(RVA = "0xB1287C", Offset = "0xB1287C", VA = "0xB1287C")]
		private static string GetNodeValue(JSONNode node, string name)
		{
			return null;
		}

		[Token(Token = "0x6004C4A")]
		[Address(RVA = "0xB106D8", Offset = "0xB106D8", VA = "0xB106D8")]
		public string ToPostParam()
		{
			return null;
		}

		[Token(Token = "0x6004C4B")]
		[Address(RVA = "0xB1294C", Offset = "0xB1294C", VA = "0xB1294C")]
		private static Dictionary<string, string> JSONToDictionary(string messages)
		{
			return null;
		}

		[Token(Token = "0x6004C4C")]
		[Address(RVA = "0xB11148", Offset = "0xB11148", VA = "0xB11148")]
		private void TriggerEvent(InfocastEventHandler infocastEvent)
		{
		}

		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0xB12B7C", Offset = "0xB12B7C", VA = "0xB12B7C")]
		private static void TriggerEvent(InfocastEventHandler infocastEvent, Infocast infocast)
		{
		}

		[Token(Token = "0x6004C4E")]
		[Address(RVA = "0xB120F4", Offset = "0xB120F4", VA = "0xB120F4")]
		private static void TriggerEvent(InfocastsEventHandler infocastEvent, Infocast[] infocasts)
		{
		}

		[Token(Token = "0x6004C4F")]
		[Address(RVA = "0xB12B8C", Offset = "0xB12B8C", VA = "0xB12B8C")]
		private static void TriggerEvent(InfocastsAIsEventHandler infocastEvent, Infocast[] infocasts, string deviceID, string languageCode)
		{
		}

		[Token(Token = "0x6004C51")]
		[Address(RVA = "0xB12C24", Offset = "0xB12C24", VA = "0xB12C24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6286C0", Offset = "0x6286C0")]
		private void _003CDelete_003Eb__79_0(IResponseContext response)
		{
		}
	}
}
