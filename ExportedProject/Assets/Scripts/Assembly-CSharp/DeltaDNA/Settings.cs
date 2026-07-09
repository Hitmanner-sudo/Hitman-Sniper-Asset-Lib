using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x200131D")]
	public class Settings
	{
		[Token(Token = "0x4005BA3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string SDK_VERSION;

		[Token(Token = "0x4005BA4")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly string ENGAGE_API_VERSION;

		[Token(Token = "0x4005BA5")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly string EVENT_STORAGE_PATH;

		[Token(Token = "0x4005BA6")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly string ENGAGE_STORAGE_PATH;

		[Token(Token = "0x4005BA7")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly string ACTIONS_STORAGE_PATH;

		[Token(Token = "0x4005BA8")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly string LEGACY_SETTINGS_STORAGE_PATH;

		[Token(Token = "0x4005BA9")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly string EVENT_TIMESTAMP_FORMAT;

		[Token(Token = "0x4005BAA")]
		[FieldOffset(Offset = "0x38")]
		internal static readonly string USERID_URL_PATTERN;

		[Token(Token = "0x4005BAB")]
		[FieldOffset(Offset = "0x40")]
		internal static readonly string COLLECT_URL_PATTERN;

		[Token(Token = "0x4005BAC")]
		[FieldOffset(Offset = "0x48")]
		internal static readonly string COLLECT_HASH_URL_PATTERN;

		[Token(Token = "0x4005BAD")]
		[FieldOffset(Offset = "0x50")]
		internal static readonly string ENGAGE_URL_PATTERN;

		[Token(Token = "0x4005BAE")]
		[FieldOffset(Offset = "0x58")]
		internal static readonly string ENGAGE_HASH_URL_PATTERN;

		[Token(Token = "0x4005BAF")]
		[FieldOffset(Offset = "0x10")]
		private bool _debugMode;

		[Token(Token = "0x4005BB0")]
		[FieldOffset(Offset = "0x11")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6111E0", Offset = "0x6111E0")]
		private bool _003COnFirstRunSendNewPlayerEvent_003Ek__BackingField;

		[Token(Token = "0x4005BB1")]
		[FieldOffset(Offset = "0x12")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6111F0", Offset = "0x6111F0")]
		private bool _003COnInitSendClientDeviceEvent_003Ek__BackingField;

		[Token(Token = "0x4005BB2")]
		[FieldOffset(Offset = "0x13")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611200", Offset = "0x611200")]
		private bool _003COnInitSendGameStartedEvent_003Ek__BackingField;

		[Token(Token = "0x4005BB3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611210", Offset = "0x611210")]
		private bool _003CSendGameRunningEveryMinute_003Ek__BackingField;

		[Token(Token = "0x4005BB4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611220", Offset = "0x611220")]
		private float _003CHttpRequestRetryDelaySeconds_003Ek__BackingField;

		[Token(Token = "0x4005BB5")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611230", Offset = "0x611230")]
		private int _003CHttpRequestMaxRetries_003Ek__BackingField;

		[Token(Token = "0x4005BB6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611240", Offset = "0x611240")]
		private int _003CHttpRequestCollectTimeoutSeconds_003Ek__BackingField;

		[Token(Token = "0x4005BB7")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611250", Offset = "0x611250")]
		private int _003CHttpRequestEngageTimeoutSeconds_003Ek__BackingField;

		[Token(Token = "0x4005BB8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611260", Offset = "0x611260")]
		private bool _003CBackgroundEventUpload_003Ek__BackingField;

		[Token(Token = "0x4005BB9")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611270", Offset = "0x611270")]
		private int _003CBackgroundEventUploadStartDelaySeconds_003Ek__BackingField;

		[Token(Token = "0x4005BBA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611280", Offset = "0x611280")]
		private int _003CBackgroundEventUploadRepeatRateSeconds_003Ek__BackingField;

		[Token(Token = "0x4005BBB")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611290", Offset = "0x611290")]
		private bool _003CUseEventStore_003Ek__BackingField;

		[Token(Token = "0x4005BBC")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6112A0", Offset = "0x6112A0")]
		private int _003CSessionTimeoutSeconds_003Ek__BackingField;

		[Token(Token = "0x4005BBD")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6112B0", Offset = "0x6112B0")]
		private int _003CEngageCacheExpirySeconds_003Ek__BackingField;

		[Token(Token = "0x4005BBE")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6112C0", Offset = "0x6112C0")]
		private int _003CImageCacheLimitMB_003Ek__BackingField;

		[Token(Token = "0x4005BBF")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6112D0", Offset = "0x6112D0")]
		private int _003CMaxConcurrentImageCacheFetches_003Ek__BackingField;

		[Token(Token = "0x4005BC0")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6112E0", Offset = "0x6112E0")]
		private bool _003CAdvertiserGdprUserConsent_003Ek__BackingField;

		[Token(Token = "0x4005BC1")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6112F0", Offset = "0x6112F0")]
		private bool _003CAdvertiserGdprAgeRestrictedUser_003Ek__BackingField;

		[Token(Token = "0x4005BC2")]
		[FieldOffset(Offset = "0x4A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611300", Offset = "0x611300")]
		private bool _003CMultipleActionsForEventTriggerEnabled_003Ek__BackingField;

		[Token(Token = "0x4005BC3")]
		[FieldOffset(Offset = "0x4B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611310", Offset = "0x611310")]
		private bool _003CMultipleActionsForImageMessagesEnabled_003Ek__BackingField;

		[Token(Token = "0x4005BC4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611320", Offset = "0x611320")]
		private GameParametersHandler _003CDefaultGameParameterHandler_003Ek__BackingField;

		[Token(Token = "0x4005BC5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611330", Offset = "0x611330")]
		private ImageMessageHandler _003CDefaultImageMessageHandler_003Ek__BackingField;

		[Token(Token = "0x4005BC6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611340", Offset = "0x611340")]
		private int _003CHttpRequestConfigurationTimeoutSeconds_003Ek__BackingField;

		[Token(Token = "0x4005BC7")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611350", Offset = "0x611350")]
		private int _003CHttpRequestConfigurationMaxRetries_003Ek__BackingField;

		[Token(Token = "0x4005BC8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611360", Offset = "0x611360")]
		private int _003CHttpRequestConfigurationRetryBackoffFactorSeconds_003Ek__BackingField;

		[Token(Token = "0x4005BC9")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611370", Offset = "0x611370")]
		private bool _003CAutomaticallyGenerateTransactionForAudiencePinpointer_003Ek__BackingField;

		[Token(Token = "0x17000CC7")]
		public bool OnFirstRunSendNewPlayerEvent
		{
			[Token(Token = "0x6007035")]
			[Address(RVA = "0x83D744", Offset = "0x83D744", VA = "0x83D744")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D090", Offset = "0x62D090")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007036")]
			[Address(RVA = "0x83D74C", Offset = "0x83D74C", VA = "0x83D74C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D0A0", Offset = "0x62D0A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CC8")]
		public bool OnInitSendClientDeviceEvent
		{
			[Token(Token = "0x6007037")]
			[Address(RVA = "0x83D758", Offset = "0x83D758", VA = "0x83D758")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D0B0", Offset = "0x62D0B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007038")]
			[Address(RVA = "0x83D760", Offset = "0x83D760", VA = "0x83D760")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D0C0", Offset = "0x62D0C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CC9")]
		public bool OnInitSendGameStartedEvent
		{
			[Token(Token = "0x6007039")]
			[Address(RVA = "0x83D76C", Offset = "0x83D76C", VA = "0x83D76C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D0D0", Offset = "0x62D0D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600703A")]
			[Address(RVA = "0x83D774", Offset = "0x83D774", VA = "0x83D774")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D0E0", Offset = "0x62D0E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CCA")]
		public bool SendGameRunningEveryMinute
		{
			[Token(Token = "0x600703B")]
			[Address(RVA = "0x83D780", Offset = "0x83D780", VA = "0x83D780")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D0F0", Offset = "0x62D0F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600703C")]
			[Address(RVA = "0x83D788", Offset = "0x83D788", VA = "0x83D788")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D100", Offset = "0x62D100")]
			set
			{
			}
		}

		[Token(Token = "0x17000CCB")]
		public bool DebugMode
		{
			[Token(Token = "0x600703D")]
			[Address(RVA = "0x83D794", Offset = "0x83D794", VA = "0x83D794")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600703E")]
			[Address(RVA = "0x83D67C", Offset = "0x83D67C", VA = "0x83D67C")]
			set
			{
			}
		}

		[Token(Token = "0x17000CCC")]
		public float HttpRequestRetryDelaySeconds
		{
			[Token(Token = "0x600703F")]
			[Address(RVA = "0x83D79C", Offset = "0x83D79C", VA = "0x83D79C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D110", Offset = "0x62D110")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6007040")]
			[Address(RVA = "0x83D7A4", Offset = "0x83D7A4", VA = "0x83D7A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D120", Offset = "0x62D120")]
			set
			{
			}
		}

		[Token(Token = "0x17000CCD")]
		public int HttpRequestMaxRetries
		{
			[Token(Token = "0x6007041")]
			[Address(RVA = "0x83D7AC", Offset = "0x83D7AC", VA = "0x83D7AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D130", Offset = "0x62D130")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007042")]
			[Address(RVA = "0x83D7B4", Offset = "0x83D7B4", VA = "0x83D7B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D140", Offset = "0x62D140")]
			set
			{
			}
		}

		[Token(Token = "0x17000CCE")]
		public int HttpRequestCollectTimeoutSeconds
		{
			[Token(Token = "0x6007043")]
			[Address(RVA = "0x83D7BC", Offset = "0x83D7BC", VA = "0x83D7BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D150", Offset = "0x62D150")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007044")]
			[Address(RVA = "0x83D7C4", Offset = "0x83D7C4", VA = "0x83D7C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D160", Offset = "0x62D160")]
			set
			{
			}
		}

		[Token(Token = "0x17000CCF")]
		public int HttpRequestEngageTimeoutSeconds
		{
			[Token(Token = "0x6007045")]
			[Address(RVA = "0x83D7CC", Offset = "0x83D7CC", VA = "0x83D7CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D170", Offset = "0x62D170")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007046")]
			[Address(RVA = "0x83D7D4", Offset = "0x83D7D4", VA = "0x83D7D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D180", Offset = "0x62D180")]
			set
			{
			}
		}

		[Token(Token = "0x17000CD0")]
		public bool BackgroundEventUpload
		{
			[Token(Token = "0x6007047")]
			[Address(RVA = "0x83D7DC", Offset = "0x83D7DC", VA = "0x83D7DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D190", Offset = "0x62D190")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007048")]
			[Address(RVA = "0x83D7E4", Offset = "0x83D7E4", VA = "0x83D7E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D1A0", Offset = "0x62D1A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CD1")]
		public int BackgroundEventUploadStartDelaySeconds
		{
			[Token(Token = "0x6007049")]
			[Address(RVA = "0x83D7F0", Offset = "0x83D7F0", VA = "0x83D7F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D1B0", Offset = "0x62D1B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600704A")]
			[Address(RVA = "0x83D7F8", Offset = "0x83D7F8", VA = "0x83D7F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D1C0", Offset = "0x62D1C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CD2")]
		public int BackgroundEventUploadRepeatRateSeconds
		{
			[Token(Token = "0x600704B")]
			[Address(RVA = "0x83D800", Offset = "0x83D800", VA = "0x83D800")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D1D0", Offset = "0x62D1D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600704C")]
			[Address(RVA = "0x83D808", Offset = "0x83D808", VA = "0x83D808")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D1E0", Offset = "0x62D1E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CD3")]
		public bool UseEventStore
		{
			[Token(Token = "0x600704D")]
			[Address(RVA = "0x83D810", Offset = "0x83D810", VA = "0x83D810")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D1F0", Offset = "0x62D1F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600704E")]
			[Address(RVA = "0x83D818", Offset = "0x83D818", VA = "0x83D818")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D200", Offset = "0x62D200")]
			set
			{
			}
		}

		[Token(Token = "0x17000CD4")]
		public int SessionTimeoutSeconds
		{
			[Token(Token = "0x600704F")]
			[Address(RVA = "0x83D824", Offset = "0x83D824", VA = "0x83D824")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D210", Offset = "0x62D210")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007050")]
			[Address(RVA = "0x83D82C", Offset = "0x83D82C", VA = "0x83D82C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D220", Offset = "0x62D220")]
			set
			{
			}
		}

		[Token(Token = "0x17000CD5")]
		public int EngageCacheExpirySeconds
		{
			[Token(Token = "0x6007051")]
			[Address(RVA = "0x83D834", Offset = "0x83D834", VA = "0x83D834")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D230", Offset = "0x62D230")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007052")]
			[Address(RVA = "0x83D83C", Offset = "0x83D83C", VA = "0x83D83C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D240", Offset = "0x62D240")]
			set
			{
			}
		}

		[Token(Token = "0x17000CD6")]
		public int ImageCacheLimitMB
		{
			[Token(Token = "0x6007053")]
			[Address(RVA = "0x83D844", Offset = "0x83D844", VA = "0x83D844")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D250", Offset = "0x62D250")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007054")]
			[Address(RVA = "0x83D84C", Offset = "0x83D84C", VA = "0x83D84C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D260", Offset = "0x62D260")]
			set
			{
			}
		}

		[Token(Token = "0x17000CD7")]
		public int MaxConcurrentImageCacheFetches
		{
			[Token(Token = "0x6007055")]
			[Address(RVA = "0x83D854", Offset = "0x83D854", VA = "0x83D854")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D270", Offset = "0x62D270")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007056")]
			[Address(RVA = "0x83D85C", Offset = "0x83D85C", VA = "0x83D85C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D280", Offset = "0x62D280")]
			set
			{
			}
		}

		[Token(Token = "0x17000CD8")]
		public bool AdvertiserGdprUserConsent
		{
			[Token(Token = "0x6007057")]
			[Address(RVA = "0x83D864", Offset = "0x83D864", VA = "0x83D864")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D290", Offset = "0x62D290")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007058")]
			[Address(RVA = "0x83D86C", Offset = "0x83D86C", VA = "0x83D86C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D2A0", Offset = "0x62D2A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CD9")]
		public bool AdvertiserGdprAgeRestrictedUser
		{
			[Token(Token = "0x6007059")]
			[Address(RVA = "0x83D878", Offset = "0x83D878", VA = "0x83D878")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D2B0", Offset = "0x62D2B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600705A")]
			[Address(RVA = "0x83D880", Offset = "0x83D880", VA = "0x83D880")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D2C0", Offset = "0x62D2C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CDA")]
		public bool MultipleActionsForEventTriggerEnabled
		{
			[Token(Token = "0x600705B")]
			[Address(RVA = "0x83D88C", Offset = "0x83D88C", VA = "0x83D88C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D2D0", Offset = "0x62D2D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600705C")]
			[Address(RVA = "0x83D894", Offset = "0x83D894", VA = "0x83D894")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D2E0", Offset = "0x62D2E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CDB")]
		public bool MultipleActionsForImageMessagesEnabled
		{
			[Token(Token = "0x600705D")]
			[Address(RVA = "0x83D8A0", Offset = "0x83D8A0", VA = "0x83D8A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D2F0", Offset = "0x62D2F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600705E")]
			[Address(RVA = "0x83D8A8", Offset = "0x83D8A8", VA = "0x83D8A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D300", Offset = "0x62D300")]
			set
			{
			}
		}

		[Token(Token = "0x17000CDC")]
		public GameParametersHandler DefaultGameParameterHandler
		{
			[Token(Token = "0x600705F")]
			[Address(RVA = "0x83D8B4", Offset = "0x83D8B4", VA = "0x83D8B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D310", Offset = "0x62D310")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007060")]
			[Address(RVA = "0x83D8BC", Offset = "0x83D8BC", VA = "0x83D8BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D320", Offset = "0x62D320")]
			set
			{
			}
		}

		[Token(Token = "0x17000CDD")]
		public ImageMessageHandler DefaultImageMessageHandler
		{
			[Token(Token = "0x6007061")]
			[Address(RVA = "0x83D8C4", Offset = "0x83D8C4", VA = "0x83D8C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D330", Offset = "0x62D330")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007062")]
			[Address(RVA = "0x83D8CC", Offset = "0x83D8CC", VA = "0x83D8CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D340", Offset = "0x62D340")]
			set
			{
			}
		}

		[Token(Token = "0x17000CDE")]
		public int HttpRequestConfigurationTimeoutSeconds
		{
			[Token(Token = "0x6007063")]
			[Address(RVA = "0x83D8D4", Offset = "0x83D8D4", VA = "0x83D8D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D350", Offset = "0x62D350")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007064")]
			[Address(RVA = "0x83D8DC", Offset = "0x83D8DC", VA = "0x83D8DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D360", Offset = "0x62D360")]
			set
			{
			}
		}

		[Token(Token = "0x17000CDF")]
		public int HttpRequestConfigurationMaxRetries
		{
			[Token(Token = "0x6007065")]
			[Address(RVA = "0x83D8E4", Offset = "0x83D8E4", VA = "0x83D8E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D370", Offset = "0x62D370")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007066")]
			[Address(RVA = "0x83D8EC", Offset = "0x83D8EC", VA = "0x83D8EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D380", Offset = "0x62D380")]
			set
			{
			}
		}

		[Token(Token = "0x17000CE0")]
		public int HttpRequestConfigurationRetryBackoffFactorSeconds
		{
			[Token(Token = "0x6007067")]
			[Address(RVA = "0x83D8F4", Offset = "0x83D8F4", VA = "0x83D8F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D390", Offset = "0x62D390")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007068")]
			[Address(RVA = "0x83D8FC", Offset = "0x83D8FC", VA = "0x83D8FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D3A0", Offset = "0x62D3A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CE1")]
		public bool AutomaticallyGenerateTransactionForAudiencePinpointer
		{
			[Token(Token = "0x6007069")]
			[Address(RVA = "0x83D904", Offset = "0x83D904", VA = "0x83D904")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D3B0", Offset = "0x62D3B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600706A")]
			[Address(RVA = "0x83D90C", Offset = "0x83D90C", VA = "0x83D90C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D3C0", Offset = "0x62D3C0")]
			set
			{
			}
		}

		[Token(Token = "0x6007034")]
		[Address(RVA = "0x83D5EC", Offset = "0x83D5EC", VA = "0x83D5EC")]
		internal Settings()
		{
		}
	}
}
