using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BE7")]
	public class GameConfiguration
	{
		[Token(Token = "0x2000BE8")]
		private class Schema
		{
			[Token(Token = "0x4003B9A")]
			public const string VERSION = "vrs";

			[Token(Token = "0x6004B7F")]
			[Address(RVA = "0x871F44", Offset = "0x871F44", VA = "0x871F44")]
			public Schema()
			{
			}
		}

		[Token(Token = "0x2000BE9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5984D4", Offset = "0x5984D4")]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			[Token(Token = "0x4003B9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string platform;

			[Token(Token = "0x4003B9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameConfiguration _003C_003E4__this;

			[Token(Token = "0x4003B9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool async;

			[Token(Token = "0x6004B80")]
			[Address(RVA = "0x871C48", Offset = "0x871C48", VA = "0x871C48")]
			public _003C_003Ec__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6004B81")]
			[Address(RVA = "0x871C50", Offset = "0x871C50", VA = "0x871C50")]
			internal void _003CInitialize_003Eb__0(bool online)
			{
			}
		}

		[Token(Token = "0x4003B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DLCConfiguration _dlcConfig;

		[Token(Token = "0x4003B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ServerContext _srvCxtConfig;

		[Token(Token = "0x4003B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ABConfiguration _abConfig;

		[Token(Token = "0x4003B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SettingsConfiguration _settingsConfig;

		[Token(Token = "0x4003B96")]
		private const string INITIAL_JSON = "{}";

		[Token(Token = "0x4003B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Download _download;

		[Token(Token = "0x4003B98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly LoadMeta _loadMeta;

		[Token(Token = "0x4003B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD914", Offset = "0x5BD914")]
		private int _003CVersion_003Ek__BackingField;

		[Token(Token = "0x17000990")]
		public DLCConfiguration DLCConfiguration
		{
			[Token(Token = "0x6004B68")]
			[Address(RVA = "0xD94168", Offset = "0xD94168", VA = "0xD94168")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000991")]
		public ServerContext ServerContextConfiguration
		{
			[Token(Token = "0x6004B69")]
			[Address(RVA = "0xD94170", Offset = "0xD94170", VA = "0xD94170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000992")]
		public ABConfiguration ABConfiguration
		{
			[Token(Token = "0x6004B6A")]
			[Address(RVA = "0xD94178", Offset = "0xD94178", VA = "0xD94178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000993")]
		public SettingsConfiguration SettingsConfiguration
		{
			[Token(Token = "0x6004B6B")]
			[Address(RVA = "0xD94180", Offset = "0xD94180", VA = "0xD94180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000994")]
		public int Version
		{
			[Token(Token = "0x6004B6C")]
			[Address(RVA = "0xD94188", Offset = "0xD94188", VA = "0xD94188")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x628270", Offset = "0x628270")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B6D")]
			[Address(RVA = "0xD94190", Offset = "0xD94190", VA = "0xD94190")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x628280", Offset = "0x628280")]
			set
			{
			}
		}

		[Token(Token = "0x17000995")]
		public static bool IsEventOnErrorDefined
		{
			[Token(Token = "0x6004B6E")]
			[Address(RVA = "0xD94198", Offset = "0xD94198", VA = "0xD94198")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000996")]
		public static bool IsEventOnInitializedDefined
		{
			[Token(Token = "0x6004B6F")]
			[Address(RVA = "0xD941EC", Offset = "0xD941EC", VA = "0xD941EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000997")]
		public LoadMeta LoadMeta
		{
			[Token(Token = "0x6004B70")]
			[Address(RVA = "0xD94240", Offset = "0xD94240", VA = "0xD94240")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400012C")]
		public static event GameConfigurationEventHandler OnInitialized
		{
			[Token(Token = "0x6004B64")]
			[Address(RVA = "0xD93E70", Offset = "0xD93E70", VA = "0xD93E70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x628230", Offset = "0x628230")]
			add
			{
			}
			[Token(Token = "0x6004B65")]
			[Address(RVA = "0xD93F2C", Offset = "0xD93F2C", VA = "0xD93F2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x628240", Offset = "0x628240")]
			remove
			{
			}
		}

		[Token(Token = "0x1400012D")]
		public static event GameConfigurationEventHandler OnError
		{
			[Token(Token = "0x6004B66")]
			[Address(RVA = "0xD93FE8", Offset = "0xD93FE8", VA = "0xD93FE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x628250", Offset = "0x628250")]
			add
			{
			}
			[Token(Token = "0x6004B67")]
			[Address(RVA = "0xD940A8", Offset = "0xD940A8", VA = "0xD940A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x628260", Offset = "0x628260")]
			remove
			{
			}
		}

		[Token(Token = "0x6004B71")]
		[Address(RVA = "0xD94248", Offset = "0xD94248", VA = "0xD94248")]
		public GameConfiguration()
		{
		}

		[Token(Token = "0x6004B72")]
		[Address(RVA = "0xD942FC", Offset = "0xD942FC", VA = "0xD942FC")]
		public GameConfiguration(Download download, LoadMeta loadMeta)
		{
		}

		[Token(Token = "0x6004B73")]
		[Address(RVA = "0xD94334", Offset = "0xD94334", VA = "0xD94334")]
		public void Initialize([Optional][DefaultParameterValue(true)] bool async, [Optional] string platform, [Optional] Download download)
		{
		}

		[Token(Token = "0x6004B74")]
		[Address(RVA = "0xD945A4", Offset = "0xD945A4", VA = "0xD945A4")]
		public static string GetURI([Optional] string platform, bool official = false)
		{
			return null;
		}

		[Token(Token = "0x6004B75")]
		[Address(RVA = "0xD94658", Offset = "0xD94658", VA = "0xD94658")]
		public static string GetRelativeURI([Optional] string platform, bool official = false, string bundleID = "")
		{
			return null;
		}

		[Token(Token = "0x6004B76")]
		[Address(RVA = "0xD94940", Offset = "0xD94940", VA = "0xD94940")]
		public static string GetConfigurationFile([Optional] string platform, bool official = false, string bundleID = "")
		{
			return null;
		}

		[Token(Token = "0x6004B77")]
		[Address(RVA = "0xD949EC", Offset = "0xD949EC", VA = "0xD949EC")]
		public JSONNode ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6004B78")]
		[Address(RVA = "0xD94C1C", Offset = "0xD94C1C", VA = "0xD94C1C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004B79")]
		[Address(RVA = "0xD94C40", Offset = "0xD94C40", VA = "0xD94C40")]
		public void Parse(string l_json)
		{
		}

		[Token(Token = "0x6004B7A")]
		[Address(RVA = "0xD94EE4", Offset = "0xD94EE4", VA = "0xD94EE4")]
		private void HandleRequestSuccess(Bundle l_bundle)
		{
		}

		[Token(Token = "0x6004B7B")]
		[Address(RVA = "0xD952C8", Offset = "0xD952C8", VA = "0xD952C8")]
		private void HandleRequestError(Bundle l_bundle)
		{
		}

		[Token(Token = "0x6004B7C")]
		[Address(RVA = "0xD95358", Offset = "0xD95358", VA = "0xD95358")]
		private void HandleRequestTimeout(Bundle l_bundle)
		{
		}

		[Token(Token = "0x6004B7D")]
		[Address(RVA = "0xD94490", Offset = "0xD94490", VA = "0xD94490")]
		private void AddEventHandlers(Download l_gcd)
		{
		}

		[Token(Token = "0x6004B7E")]
		[Address(RVA = "0xD94FA8", Offset = "0xD94FA8", VA = "0xD94FA8")]
		private void RemoveEventHandlers(Download l_gcd)
		{
		}
	}
}
