using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DeltaDNA.Consent;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x20012E6")]
	public class DDNA : Singleton<DDNA>
	{
		[Token(Token = "0x20012E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE6C4", Offset = "0x5AE6C4")]
		private sealed class _003C_003Ec__DisplayClass41_0
		{
			[Token(Token = "0x4005AAE")]
			[FieldOffset(Offset = "0x10")]
			public DDNA _003C_003E4__this;

			[Token(Token = "0x4005AAF")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> callback;

			[Token(Token = "0x6006EAC")]
			[Address(RVA = "0x86568C", Offset = "0x86568C", VA = "0x86568C")]
			public _003C_003Ec__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6006EAD")]
			[Address(RVA = "0x865694", Offset = "0x865694", VA = "0x865694")]
			internal void _003CIsPiplConsentRequired_003Eb__0(bool isRequired)
			{
			}
		}

		[Token(Token = "0x20012E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE6D4", Offset = "0x5AE6D4")]
		private sealed class _003CGameHeartbeat_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005AB0")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005AB1")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005AB2")]
			[FieldOffset(Offset = "0x20")]
			public DDNA _003C_003E4__this;

			[Token(Token = "0x4005AB3")]
			[FieldOffset(Offset = "0x28")]
			public float numSeconds;

			[Token(Token = "0x17000C7B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6006EB1")]
				[Address(RVA = "0x865858", Offset = "0x865858", VA = "0x865858", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C7C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6006EB3")]
				[Address(RVA = "0x8658A0", Offset = "0x8658A0", VA = "0x8658A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006EAE")]
			[Address(RVA = "0x865730", Offset = "0x865730", VA = "0x865730")]
			[DebuggerHidden]
			public _003CGameHeartbeat_003Ed__47(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006EAF")]
			[Address(RVA = "0x86575C", Offset = "0x86575C", VA = "0x86575C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6006EB0")]
			[Address(RVA = "0x865760", Offset = "0x865760", VA = "0x865760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6006EB2")]
			[Address(RVA = "0x865860", Offset = "0x865860", VA = "0x865860", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4005A8B")]
		internal const string PF_KEY_USER_ID = "DDSDK_USER_ID";

		[Token(Token = "0x4005A8C")]
		internal const string PF_KEY_FIRST_SESSION = "DDSDK_FIRST_SESSION";

		[Token(Token = "0x4005A8D")]
		internal const string PF_KEY_LAST_SESSION = "DDSDK_LAST_SESSION";

		[Token(Token = "0x4005A8E")]
		internal const string PF_KEY_CROSS_GAME_USER_ID = "DDSDK_CROSS_GAME_USER_ID";

		[Token(Token = "0x4005A8F")]
		internal const string PF_KEY_ADVERTISING_ID = "DDSDK_ADVERTISING_ID";

		[Token(Token = "0x4005A90")]
		internal const string PF_KEY_FORGET_ME = "DDSDK_FORGET_ME";

		[Token(Token = "0x4005A91")]
		internal const string PF_KEY_STOP_TRACKING_ME = "DDSKD_STOP_TRACKING_ME";

		[Token(Token = "0x4005A92")]
		internal const string PF_KEY_FORGOTTEN = "DDSK_FORGOTTEN";

		[Token(Token = "0x4005A93")]
		internal const string PF_KEY_ACTIONS_SALT = "DDSDK_ACTIONS_SALT";

		[Token(Token = "0x4005A94")]
		internal const string PF_KEY_PREVIOUS_ENV = "DDSDK_PREVIOUS_ENV";

		[Token(Token = "0x4005A95")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string PF_KEY_DEVICE_ID;

		[Token(Token = "0x4005A96")]
		[FieldOffset(Offset = "0x18")]
		public bool isNewPlayer;

		[Token(Token = "0x4005A97")]
		internal const float gameRunningEventInterval = 60f;

		[Token(Token = "0x4005A98")]
		[FieldOffset(Offset = "0x20")]
		internal IEnumerator gameRunningEventCoroutine;

		[Token(Token = "0x4005A99")]
		[FieldOffset(Offset = "0x28")]
		private bool isGameRunningCoroutineRunning;

		[Token(Token = "0x4005A9A")]
		[FieldOffset(Offset = "0x8")]
		private static object _lock;

		[Token(Token = "0x4005A9B")]
		[FieldOffset(Offset = "0x30")]
		private ConsentTracker m_consentTracker;

		[Token(Token = "0x4005AA1")]
		[FieldOffset(Offset = "0x60")]
		private DDNABase delegated;

		[Token(Token = "0x4005AA2")]
		[FieldOffset(Offset = "0x68")]
		private string collectURL;

		[Token(Token = "0x4005AA3")]
		[FieldOffset(Offset = "0x70")]
		private string engageURL;

		[Token(Token = "0x4005AA4")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x610FD8", Offset = "0x610FD8")]
		private Settings _003CSettings_003Ek__BackingField;

		[Token(Token = "0x4005AA5")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x610FE8", Offset = "0x610FE8")]
		private AndroidNotifications _003CAndroidNotifications_003Ek__BackingField;

		[Token(Token = "0x4005AA6")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x610FF8", Offset = "0x610FF8")]
		private IosNotifications _003CIosNotifications_003Ek__BackingField;

		[Token(Token = "0x4005AA7")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611008", Offset = "0x611008")]
		private string _003CEnvironmentKey_003Ek__BackingField;

		[Token(Token = "0x4005AA8")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611018", Offset = "0x611018")]
		private string _003CSessionID_003Ek__BackingField;

		[Token(Token = "0x4005AA9")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611028", Offset = "0x611028")]
		private string _003CAppleDeveloperID_003Ek__BackingField;

		[Token(Token = "0x4005AAA")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611038", Offset = "0x611038")]
		private string _003CAppStoreID_003Ek__BackingField;

		[Token(Token = "0x4005AAB")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611048", Offset = "0x611048")]
		private string _003CHashSecret_003Ek__BackingField;

		[Token(Token = "0x4005AAC")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611058", Offset = "0x611058")]
		private string _003CClientVersion_003Ek__BackingField;

		[Token(Token = "0x4005AAD")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611068", Offset = "0x611068")]
		private string _003CPlatform_003Ek__BackingField;

		[Token(Token = "0x17000C66")]
		internal ConsentTracker consentTracker
		{
			[Token(Token = "0x6006E4B")]
			[Address(RVA = "0xBBB7BC", Offset = "0xBBB7BC", VA = "0xBBB7BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C67")]
		public Settings Settings
		{
			[Token(Token = "0x6006E77")]
			[Address(RVA = "0xBBEAD0", Offset = "0xBBEAD0", VA = "0xBBEAD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C570", Offset = "0x62C570")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E78")]
			[Address(RVA = "0xBBEAD8", Offset = "0xBBEAD8", VA = "0xBBEAD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C580", Offset = "0x62C580")]
			set
			{
			}
		}

		[Token(Token = "0x17000C68")]
		public AndroidNotifications AndroidNotifications
		{
			[Token(Token = "0x6006E79")]
			[Address(RVA = "0xBBEAE0", Offset = "0xBBEAE0", VA = "0xBBEAE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C590", Offset = "0x62C590")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E7A")]
			[Address(RVA = "0xBBEAE8", Offset = "0xBBEAE8", VA = "0xBBEAE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C5A0", Offset = "0x62C5A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C69")]
		public IosNotifications IosNotifications
		{
			[Token(Token = "0x6006E7B")]
			[Address(RVA = "0xBBEAF0", Offset = "0xBBEAF0", VA = "0xBBEAF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C5B0", Offset = "0x62C5B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E7C")]
			[Address(RVA = "0xBBEAF8", Offset = "0xBBEAF8", VA = "0xBBEAF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C5C0", Offset = "0x62C5C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C6A")]
		public EngageFactory EngageFactory
		{
			[Token(Token = "0x6006E7D")]
			[Address(RVA = "0xBBEB00", Offset = "0xBBEB00", VA = "0xBBEB00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C6B")]
		public string EnvironmentKey
		{
			[Token(Token = "0x6006E7E")]
			[Address(RVA = "0xBBEB1C", Offset = "0xBBEB1C", VA = "0xBBEB1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C5D0", Offset = "0x62C5D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E7F")]
			[Address(RVA = "0xBBEB24", Offset = "0xBBEB24", VA = "0xBBEB24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C5E0", Offset = "0x62C5E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C6C")]
		public string CollectURL
		{
			[Token(Token = "0x6006E80")]
			[Address(RVA = "0xBBEB2C", Offset = "0xBBEB2C", VA = "0xBBEB2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E81")]
			[Address(RVA = "0xBBD784", Offset = "0xBBD784", VA = "0xBBD784")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C6D")]
		public string EngageURL
		{
			[Token(Token = "0x6006E82")]
			[Address(RVA = "0xBBEB34", Offset = "0xBBEB34", VA = "0xBBEB34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E83")]
			[Address(RVA = "0xBBD7B0", Offset = "0xBBD7B0", VA = "0xBBD7B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C6E")]
		public string SessionID
		{
			[Token(Token = "0x6006E84")]
			[Address(RVA = "0xBBEB3C", Offset = "0xBBEB3C", VA = "0xBBEB3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C5F0", Offset = "0x62C5F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E85")]
			[Address(RVA = "0xBBEB44", Offset = "0xBBEB44", VA = "0xBBEB44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C600", Offset = "0x62C600")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C6F")]
		public string UserID
		{
			[Token(Token = "0x6006E86")]
			[Address(RVA = "0xBBD4D0", Offset = "0xBBD4D0", VA = "0xBBD4D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E87")]
			[Address(RVA = "0xBBD5B0", Offset = "0xBBD5B0", VA = "0xBBD5B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C70")]
		public string DeviceID
		{
			[Token(Token = "0x6006E88")]
			[Address(RVA = "0xBBD624", Offset = "0xBBD624", VA = "0xBBD624")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E89")]
			[Address(RVA = "0xBBD70C", Offset = "0xBBD70C", VA = "0xBBD70C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C71")]
		public bool HasStarted
		{
			[Token(Token = "0x6006E8A")]
			[Address(RVA = "0xBBE568", Offset = "0xBBE568", VA = "0xBBE568")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000C72")]
		public bool IsUploading
		{
			[Token(Token = "0x6006E8B")]
			[Address(RVA = "0xBBEB4C", Offset = "0xBBEB4C", VA = "0xBBEB4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000C73")]
		public string AppleDeveloperID
		{
			[Token(Token = "0x6006E8C")]
			[Address(RVA = "0xBBEB70", Offset = "0xBBEB70", VA = "0xBBEB70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C610", Offset = "0x62C610")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E8D")]
			[Address(RVA = "0xBBEB78", Offset = "0xBBEB78", VA = "0xBBEB78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C620", Offset = "0x62C620")]
			set
			{
			}
		}

		[Token(Token = "0x17000C74")]
		public string AppStoreID
		{
			[Token(Token = "0x6006E8E")]
			[Address(RVA = "0xBBEB80", Offset = "0xBBEB80", VA = "0xBBEB80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C630", Offset = "0x62C630")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E8F")]
			[Address(RVA = "0xBBEB88", Offset = "0xBBEB88", VA = "0xBBEB88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C640", Offset = "0x62C640")]
			set
			{
			}
		}

		[Token(Token = "0x17000C75")]
		public string HashSecret
		{
			[Token(Token = "0x6006E90")]
			[Address(RVA = "0xBBEB90", Offset = "0xBBEB90", VA = "0xBBEB90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C650", Offset = "0x62C650")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E91")]
			[Address(RVA = "0xBBEB98", Offset = "0xBBEB98", VA = "0xBBEB98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C660", Offset = "0x62C660")]
			set
			{
			}
		}

		[Token(Token = "0x17000C76")]
		public string ClientVersion
		{
			[Token(Token = "0x6006E92")]
			[Address(RVA = "0xBBEBA0", Offset = "0xBBEBA0", VA = "0xBBEBA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C670", Offset = "0x62C670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E93")]
			[Address(RVA = "0xBBEBA8", Offset = "0xBBEBA8", VA = "0xBBEBA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C680", Offset = "0x62C680")]
			set
			{
			}
		}

		[Token(Token = "0x17000C77")]
		public string Platform
		{
			[Token(Token = "0x6006E94")]
			[Address(RVA = "0xBBEBB0", Offset = "0xBBEBB0", VA = "0xBBEBB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C690", Offset = "0x62C690")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E95")]
			[Address(RVA = "0xBBEBB8", Offset = "0xBBEBB8", VA = "0xBBEBB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C6A0", Offset = "0x62C6A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000C78")]
		public string CrossGameUserID
		{
			[Token(Token = "0x6006E96")]
			[Address(RVA = "0xBBEBC0", Offset = "0xBBEBC0", VA = "0xBBEBC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E97")]
			[Address(RVA = "0xBBEBE4", Offset = "0xBBEBE4", VA = "0xBBEBE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000C79")]
		public string AndroidRegistrationID
		{
			[Token(Token = "0x6006E98")]
			[Address(RVA = "0xBBEC08", Offset = "0xBBEC08", VA = "0xBBEC08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E99")]
			[Address(RVA = "0xBBEC2C", Offset = "0xBBEC2C", VA = "0xBBEC2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000C7A")]
		public string PushNotificationToken
		{
			[Token(Token = "0x6006E9A")]
			[Address(RVA = "0xBBEC50", Offset = "0xBBEC50", VA = "0xBBEC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E9B")]
			[Address(RVA = "0xBBEC74", Offset = "0xBBEC74", VA = "0xBBEC74")]
			set
			{
			}
		}

		[Token(Token = "0x14000197")]
		public event Action OnNewSession
		{
			[Token(Token = "0x6006E4C")]
			[Address(RVA = "0xBBB824", Offset = "0xBBB824", VA = "0xBBB824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C400", Offset = "0x62C400")]
			add
			{
			}
			[Token(Token = "0x6006E4D")]
			[Address(RVA = "0xBBB8C4", Offset = "0xBBB8C4", VA = "0xBBB8C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C410", Offset = "0x62C410")]
			remove
			{
			}
		}

		[Token(Token = "0x14000198")]
		public event Action<bool> OnSessionConfigured
		{
			[Token(Token = "0x6006E4E")]
			[Address(RVA = "0xBBB964", Offset = "0xBBB964", VA = "0xBBB964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C420", Offset = "0x62C420")]
			add
			{
			}
			[Token(Token = "0x6006E4F")]
			[Address(RVA = "0xBBBA04", Offset = "0xBBBA04", VA = "0xBBBA04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C430", Offset = "0x62C430")]
			remove
			{
			}
		}

		[Token(Token = "0x14000199")]
		public event Action OnSessionConfigurationFailed
		{
			[Token(Token = "0x6006E50")]
			[Address(RVA = "0xBBBAA4", Offset = "0xBBBAA4", VA = "0xBBBAA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C440", Offset = "0x62C440")]
			add
			{
			}
			[Token(Token = "0x6006E51")]
			[Address(RVA = "0xBBBB44", Offset = "0xBBBB44", VA = "0xBBBB44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C450", Offset = "0x62C450")]
			remove
			{
			}
		}

		[Token(Token = "0x1400019A")]
		public event Action OnImageCachePopulated
		{
			[Token(Token = "0x6006E52")]
			[Address(RVA = "0xBBBBE4", Offset = "0xBBBBE4", VA = "0xBBBBE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C460", Offset = "0x62C460")]
			add
			{
			}
			[Token(Token = "0x6006E53")]
			[Address(RVA = "0xBBBC84", Offset = "0xBBBC84", VA = "0xBBBC84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C470", Offset = "0x62C470")]
			remove
			{
			}
		}

		[Token(Token = "0x1400019B")]
		public event Action<string> OnImageCachingFailed
		{
			[Token(Token = "0x6006E54")]
			[Address(RVA = "0xBBBD24", Offset = "0xBBBD24", VA = "0xBBBD24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C480", Offset = "0x62C480")]
			add
			{
			}
			[Token(Token = "0x6006E55")]
			[Address(RVA = "0xBBBDC4", Offset = "0xBBBDC4", VA = "0xBBBDC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C490", Offset = "0x62C490")]
			remove
			{
			}
		}

		[Token(Token = "0x6006E56")]
		[Address(RVA = "0xBBBE64", Offset = "0xBBBE64", VA = "0xBBBE64")]
		protected DDNA()
		{
		}

		[Token(Token = "0x6006E57")]
		[Address(RVA = "0xBBBF0C", Offset = "0xBBBF0C", VA = "0xBBBF0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6006E58")]
		[Address(RVA = "0xBBBF84", Offset = "0xBBBF84", VA = "0xBBBF84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6006E59")]
		[Address(RVA = "0xBBC034", Offset = "0xBBC034", VA = "0xBBC034")]
		internal void Awake()
		{
		}

		[Token(Token = "0x6006E5A")]
		[Address(RVA = "0xBBC9E4", Offset = "0xBBC9E4", VA = "0xBBC9E4")]
		public void IsPiplConsentRequired(Action<bool> callback)
		{
		}

		[Token(Token = "0x6006E5B")]
		[Address(RVA = "0xBBCADC", Offset = "0xBBCADC", VA = "0xBBCADC")]
		public void SetPiplConsent(bool dataUse, bool dataExport)
		{
		}

		[Token(Token = "0x6006E5C")]
		[Address(RVA = "0xBBCDA0", Offset = "0xBBCDA0", VA = "0xBBCDA0")]
		public void StartSDK()
		{
		}

		[Token(Token = "0x6006E5D")]
		[Address(RVA = "0xBBCDD0", Offset = "0xBBCDD0", VA = "0xBBCDD0")]
		public void StartSDK(string userID)
		{
		}

		[Token(Token = "0x6006E5E")]
		[Address(RVA = "0xBBD4C8", Offset = "0xBBD4C8", VA = "0xBBD4C8")]
		public void StartSDK(Configuration config)
		{
		}

		[Token(Token = "0x6006E5F")]
		[Address(RVA = "0xBBCE04", Offset = "0xBBCE04", VA = "0xBBCE04")]
		public void StartSDK(Configuration config, string userID)
		{
		}

		[Token(Token = "0x6006E60")]
		[Address(RVA = "0xBBDA30", Offset = "0xBBDA30", VA = "0xBBDA30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62C4A0", Offset = "0x62C4A0")]
		internal IEnumerator GameHeartbeat(float numSeconds)
		{
			return null;
		}

		[Token(Token = "0x6006E61")]
		[Address(RVA = "0xBBDAAC", Offset = "0xBBDAAC", VA = "0xBBDAAC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x62C500", Offset = "0x62C500")]
		public void StartSDK(string envKey, string collectURL, string engageURL)
		{
		}

		[Token(Token = "0x6006E62")]
		[Address(RVA = "0xBBDADC", Offset = "0xBBDADC", VA = "0xBBDADC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x62C538", Offset = "0x62C538")]
		public void StartSDK(string envKey, string collectURL, string engageURL, string userID)
		{
		}

		[Token(Token = "0x6006E63")]
		[Address(RVA = "0xBBDB10", Offset = "0xBBDB10", VA = "0xBBDB10")]
		public void StartSDK(bool isLiveVersion)
		{
		}

		[Token(Token = "0x6006E64")]
		[Address(RVA = "0xBBDB54", Offset = "0xBBDB54", VA = "0xBBDB54")]
		public void NewSession()
		{
		}

		[Token(Token = "0x6006E65")]
		[Address(RVA = "0xBBDE60", Offset = "0xBBDE60", VA = "0xBBDE60")]
		public void StopSDK()
		{
		}

		[Token(Token = "0x6006E66")]
		public EventAction RecordEvent<T>(T gameEvent) where T : GameEvent<T>
		{
			return null;
		}

		[Token(Token = "0x6006E67")]
		[Address(RVA = "0xBBDF84", Offset = "0xBBDF84", VA = "0xBBDF84")]
		public EventAction RecordEvent(string eventName)
		{
			return null;
		}

		[Token(Token = "0x6006E68")]
		[Address(RVA = "0xBBDFA4", Offset = "0xBBDFA4", VA = "0xBBDFA4")]
		public EventAction RecordEvent(string eventName, Dictionary<string, object> eventParams)
		{
			return null;
		}

		[Token(Token = "0x6006E69")]
		[Address(RVA = "0xBBDFC4", Offset = "0xBBDFC4", VA = "0xBBDFC4")]
		public void RequestEngagement(Engagement engagement, Action<Dictionary<string, object>> callback)
		{
		}

		[Token(Token = "0x6006E6A")]
		[Address(RVA = "0xBBDFE4", Offset = "0xBBDFE4", VA = "0xBBDFE4")]
		public void RequestEngagement(Engagement engagement, Action<Engagement> onCompleted, Action<Exception> onError)
		{
		}

		[Token(Token = "0x6006E6B")]
		[Address(RVA = "0xBBE008", Offset = "0xBBE008", VA = "0xBBE008")]
		public void RecordPushNotification(Dictionary<string, object> payload)
		{
		}

		[Token(Token = "0x6006E6C")]
		[Address(RVA = "0xBBCD7C", Offset = "0xBBCD7C", VA = "0xBBCD7C")]
		public void RequestSessionConfiguration()
		{
		}

		[Token(Token = "0x6006E6D")]
		[Address(RVA = "0xBBE02C", Offset = "0xBBE02C", VA = "0xBBE02C")]
		public void Upload()
		{
		}

		[Token(Token = "0x6006E6E")]
		[Address(RVA = "0xBBE050", Offset = "0xBBE050", VA = "0xBBE050")]
		public void Upload(HashSet<string> eventNameFilter)
		{
		}

		[Token(Token = "0x6006E6F")]
		[Address(RVA = "0xBBE20C", Offset = "0xBBE20C", VA = "0xBBE20C")]
		public void DownloadImageAssets()
		{
		}

		[Token(Token = "0x6006E70")]
		[Address(RVA = "0xBBE230", Offset = "0xBBE230", VA = "0xBBE230")]
		public void ClearPersistentData()
		{
		}

		[Token(Token = "0x6006E71")]
		[Address(RVA = "0xBBE58C", Offset = "0xBBE58C", VA = "0xBBE58C")]
		public void RefreshUserID()
		{
		}

		[Token(Token = "0x6006E72")]
		[Address(RVA = "0xBBCB90", Offset = "0xBBCB90", VA = "0xBBCB90")]
		public void ForgetMe()
		{
		}

		[Token(Token = "0x6006E73")]
		[Address(RVA = "0xBBE64C", Offset = "0xBBE64C", VA = "0xBBE64C")]
		public void StopTrackingMe()
		{
		}

		[Token(Token = "0x6006E74")]
		[Address(RVA = "0xBBE838", Offset = "0xBBE838", VA = "0xBBE838")]
		public void UseCollectTimestamp(bool useCollect)
		{
		}

		[Token(Token = "0x6006E75")]
		[Address(RVA = "0xBBE9A8", Offset = "0xBBE9A8", VA = "0xBBE9A8")]
		public void SetTimestampFunc(Func<DateTime?> TimestampFunc)
		{
		}

		[Token(Token = "0x6006E76")]
		[Address(RVA = "0xBBEA28", Offset = "0xBBEA28", VA = "0xBBEA28")]
		public void SetLoggingLevel(Logger.Level level)
		{
		}

		[Token(Token = "0x6006E9C")]
		[Address(RVA = "0xBBEC98", Offset = "0xBBEC98", VA = "0xBBEC98", Slot = "4")]
		public override void OnDestroy()
		{
		}

		[Token(Token = "0x6006E9D")]
		[Address(RVA = "0xBBED30", Offset = "0xBBED30", VA = "0xBBED30")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6006E9E")]
		[Address(RVA = "0xBBEDE4", Offset = "0xBBEDE4", VA = "0xBBEDE4", Slot = "5")]
		internal virtual ImageMessageStore GetImageMessageStore()
		{
			return null;
		}

		[Token(Token = "0x6006E9F")]
		[Address(RVA = "0xBBEE00", Offset = "0xBBEE00", VA = "0xBBEE00")]
		internal string ResolveEngageURL(string httpBody)
		{
			return null;
		}

		[Token(Token = "0x6006EA0")]
		[Address(RVA = "0xBBF13C", Offset = "0xBBF13C", VA = "0xBBF13C")]
		internal void NotifyOnSessionConfigured(bool cached)
		{
		}

		[Token(Token = "0x6006EA1")]
		[Address(RVA = "0xBBF1AC", Offset = "0xBBF1AC", VA = "0xBBF1AC")]
		internal void NotifyOnSessionConfigurationFailed()
		{
		}

		[Token(Token = "0x6006EA2")]
		[Address(RVA = "0xBBF1C0", Offset = "0xBBF1C0", VA = "0xBBF1C0")]
		internal void NotifyOnImageCachePopulated()
		{
		}

		[Token(Token = "0x6006EA3")]
		[Address(RVA = "0xBBF1D4", Offset = "0xBBF1D4", VA = "0xBBF1D4")]
		internal void NotifyOnImageCachingFailed(string cause)
		{
		}

		[Token(Token = "0x6006EA4")]
		[Address(RVA = "0xBBDDE4", Offset = "0xBBDDE4", VA = "0xBBDDE4")]
		private string GenerateSessionID()
		{
			return null;
		}

		[Token(Token = "0x6006EA5")]
		[Address(RVA = "0xBBD534", Offset = "0xBBD534", VA = "0xBBD534")]
		private string GenerateUserID()
		{
			return null;
		}

		[Token(Token = "0x6006EA6")]
		[Address(RVA = "0xBBD690", Offset = "0xBBD690", VA = "0xBBD690")]
		private string GenerateDeviceID()
		{
			return null;
		}

		[Token(Token = "0x6006EA7")]
		[Address(RVA = "0xBBD7DC", Offset = "0xBBD7DC", VA = "0xBBD7DC")]
		private void HandleEnvironmentChanges()
		{
		}

		[Token(Token = "0x6006EA8")]
		[Address(RVA = "0xBBEF34", Offset = "0xBBEF34", VA = "0xBBEF34")]
		internal static string GenerateHash(string data, string secret)
		{
			return null;
		}

		[Token(Token = "0x6006EA9")]
		[Address(RVA = "0xBBF074", Offset = "0xBBF074", VA = "0xBBF074")]
		internal static string FormatURI(string uriPattern, string apiHost, string envKey, string hash)
		{
			return null;
		}

		[Token(Token = "0x6006EAA")]
		[Address(RVA = "0xBBF244", Offset = "0xBBF244", VA = "0xBBF244")]
		public void TriggerDefaultEvents()
		{
		}
	}
}
