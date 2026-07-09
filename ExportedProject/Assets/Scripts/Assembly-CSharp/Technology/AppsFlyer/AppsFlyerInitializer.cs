using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Shop;

namespace Technology.AppsFlyer
{
	[Token(Token = "0x2000E47")]
	public class AppsFlyerInitializer : Singleton<AppsFlyerInitializer>
	{
		[Token(Token = "0x2000E48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598D9C", Offset = "0x598D9C")]
		private sealed class _003CWaitForDeltaDNAInit_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40043A6")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40043A7")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40043A8")]
			[FieldOffset(Offset = "0x20")]
			public AppsFlyerInitializer _003C_003E4__this;

			[Token(Token = "0x17000BCF")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60057F0")]
				[Address(RVA = "0x923058", Offset = "0x923058", VA = "0x923058", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000BD0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60057F2")]
				[Address(RVA = "0x9230A0", Offset = "0x9230A0", VA = "0x9230A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60057ED")]
			[Address(RVA = "0x922F60", Offset = "0x922F60", VA = "0x922F60")]
			[DebuggerHidden]
			public _003CWaitForDeltaDNAInit_003Ed__25(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60057EE")]
			[Address(RVA = "0x922F8C", Offset = "0x922F8C", VA = "0x922F8C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60057EF")]
			[Address(RVA = "0x922F90", Offset = "0x922F90", VA = "0x922F90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60057F1")]
			[Address(RVA = "0x923060", Offset = "0x923060", VA = "0x923060", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000E49")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598DAC", Offset = "0x598DAC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40043A9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40043AA")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, object>, string> _003C_003E9__33_0;

			[Token(Token = "0x40043AB")]
			[FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<string, object>, string> _003C_003E9__33_1;

			[Token(Token = "0x40043AC")]
			[FieldOffset(Offset = "0x18")]
			public static Func<string, KeyValuePair<string, string>> _003C_003E9__35_0;

			[Token(Token = "0x40043AD")]
			[FieldOffset(Offset = "0x20")]
			public static Func<KeyValuePair<string, string>, string> _003C_003E9__35_1;

			[Token(Token = "0x40043AE")]
			[FieldOffset(Offset = "0x28")]
			public static Func<KeyValuePair<string, string>, string> _003C_003E9__35_2;

			[Token(Token = "0x60057F4")]
			[Address(RVA = "0x922A60", Offset = "0x922A60", VA = "0x922A60")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60057F5")]
			[Address(RVA = "0x922A68", Offset = "0x922A68", VA = "0x922A68")]
			internal string _003CHandleNoLinkNode_003Eb__33_0(KeyValuePair<string, object> kvp)
			{
				return null;
			}

			[Token(Token = "0x60057F6")]
			[Address(RVA = "0x922AA8", Offset = "0x922AA8", VA = "0x922AA8")]
			internal string _003CHandleNoLinkNode_003Eb__33_1(KeyValuePair<string, object> kvp)
			{
				return null;
			}

			[Token(Token = "0x60057F7")]
			[Address(RVA = "0x922D54", Offset = "0x922D54", VA = "0x922D54")]
			internal KeyValuePair<string, string> _003CExtractParameters_003Eb__35_0(string p)
			{
				return default(KeyValuePair<string, string>);
			}

			[Token(Token = "0x60057F8")]
			[Address(RVA = "0x922EE0", Offset = "0x922EE0", VA = "0x922EE0")]
			internal string _003CExtractParameters_003Eb__35_1(KeyValuePair<string, string> k)
			{
				return null;
			}

			[Token(Token = "0x60057F9")]
			[Address(RVA = "0x922F20", Offset = "0x922F20", VA = "0x922F20")]
			internal string _003CExtractParameters_003Eb__35_2(KeyValuePair<string, string> v)
			{
				return null;
			}
		}

		[Token(Token = "0x400439A")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, string> _conversionData;

		[Token(Token = "0x400439B")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> _appOpenAttributionData;

		[Token(Token = "0x400439C")]
		private const string PURCHASE_EVENT_NAME = "af_purchase";

		[Token(Token = "0x400439D")]
		private const string REVENUE_PARAM_NAME = "af_revenue";

		[Token(Token = "0x400439E")]
		private const string CONTENT_ID_PARAM_NAME = "af_content_id";

		[Token(Token = "0x400439F")]
		private const string CURRENCY_PARAM_NAME = "af_currency";

		[Token(Token = "0x40043A0")]
		private const string QUANTITY_PARAM_NAME = "af_quantity";

		[Token(Token = "0x40043A1")]
		private const string DEEPLINK_PARAM_NAME = "af_dp";

		[Token(Token = "0x40043A2")]
		private const string PATH_PARAM_NAME = "path";

		[Token(Token = "0x40043A3")]
		private const string HOST_PARAM_NAME = "host";

		[Token(Token = "0x40043A4")]
		private const string SCHEME_PARAM_NAME = "scheme";

		[Token(Token = "0x40043A5")]
		private const string LINK_PARAM_NAME = "link";

		[Token(Token = "0x17000BCD")]
		public Dictionary<string, string> ConversionData
		{
			[Token(Token = "0x60057DB")]
			[Address(RVA = "0xD4C120", Offset = "0xD4C120", VA = "0xD4C120")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057DC")]
			[Address(RVA = "0xD4C128", Offset = "0xD4C128", VA = "0xD4C128")]
			private set
			{
			}
		}

		[Token(Token = "0x17000BCE")]
		public Dictionary<string, string> AppOpenAttributionData
		{
			[Token(Token = "0x60057DD")]
			[Address(RVA = "0xD4C188", Offset = "0xD4C188", VA = "0xD4C188")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057DE")]
			[Address(RVA = "0xD4C190", Offset = "0xD4C190", VA = "0xD4C190")]
			set
			{
			}
		}

		[Token(Token = "0x1400017B")]
		public event Action<Dictionary<string, string>> OnConversionDataChanged
		{
			[Token(Token = "0x60057D7")]
			[Address(RVA = "0xD4BEA0", Offset = "0xD4BEA0", VA = "0xD4BEA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B8F0", Offset = "0x62B8F0")]
			add
			{
			}
			[Token(Token = "0x60057D8")]
			[Address(RVA = "0xD4BF40", Offset = "0xD4BF40", VA = "0xD4BF40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B900", Offset = "0x62B900")]
			remove
			{
			}
		}

		[Token(Token = "0x1400017C")]
		public event Action<Dictionary<string, string>> OnAppOpenAttributionDataChanged
		{
			[Token(Token = "0x60057D9")]
			[Address(RVA = "0xD4BFE0", Offset = "0xD4BFE0", VA = "0xD4BFE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B910", Offset = "0x62B910")]
			add
			{
			}
			[Token(Token = "0x60057DA")]
			[Address(RVA = "0xD4C080", Offset = "0xD4C080", VA = "0xD4C080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B920", Offset = "0x62B920")]
			remove
			{
			}
		}

		[Token(Token = "0x60057DF")]
		[Address(RVA = "0xD4C1F0", Offset = "0xD4C1F0", VA = "0xD4C1F0")]
		public AppsFlyerInitializer()
		{
		}

		[Token(Token = "0x60057E0")]
		[Address(RVA = "0xD4C344", Offset = "0xD4C344", VA = "0xD4C344")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62B930", Offset = "0x62B930")]
		private IEnumerator WaitForDeltaDNAInit()
		{
			return null;
		}

		[Token(Token = "0x60057E1")]
		[Address(RVA = "0xD4C3B0", Offset = "0xD4C3B0", VA = "0xD4C3B0")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60057E2")]
		[Address(RVA = "0xD4C770", Offset = "0xD4C770", VA = "0xD4C770")]
		private static void OnOfferPurchased(object sender, ShopEvent e)
		{
		}

		[Token(Token = "0x60057E3")]
		[Address(RVA = "0xD4C58C", Offset = "0xD4C58C", VA = "0xD4C58C")]
		private void InitAppsFlyerTrackerCallbacks()
		{
		}

		[Token(Token = "0x60057E4")]
		[Address(RVA = "0xD4C9AC", Offset = "0xD4C9AC", VA = "0xD4C9AC")]
		private void OnAppOpenAttribution(object sender, AppsFlyerTrackerCallbacks.ConversionDataEventArgs e)
		{
		}

		[Token(Token = "0x60057E5")]
		[Address(RVA = "0xD4CA8C", Offset = "0xD4CA8C", VA = "0xD4CA8C")]
		private void OnDidReceiveConversionData(object sender, AppsFlyerTrackerCallbacks.ConversionDataEventArgs e)
		{
		}

		[Token(Token = "0x60057E6")]
		[Address(RVA = "0xD4C9D8", Offset = "0xD4C9D8", VA = "0xD4C9D8")]
		private static Dictionary<string, string> ParseConversionData(AppsFlyerTrackerCallbacks.ConversionDataEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x60057E7")]
		[Address(RVA = "0xD4CD48", Offset = "0xD4CD48", VA = "0xD4CD48")]
		private static Dictionary<string, string> HandleLinkNode(JSONNode linkNode)
		{
			return null;
		}

		[Token(Token = "0x60057E8")]
		[Address(RVA = "0xD4CB54", Offset = "0xD4CB54", VA = "0xD4CB54")]
		private static Dictionary<string, string> HandleNoLinkNode(JSONNode json)
		{
			return null;
		}

		[Token(Token = "0x60057E9")]
		[Address(RVA = "0xD4D2BC", Offset = "0xD4D2BC", VA = "0xD4D2BC")]
		private static bool ExtractAppsFlyerDeeplink(IDictionary<string, string> parameters)
		{
			return default(bool);
		}

		[Token(Token = "0x60057EA")]
		[Address(RVA = "0xD4CF80", Offset = "0xD4CF80", VA = "0xD4CF80")]
		private static Dictionary<string, string> ExtractParameters(string query)
		{
			return null;
		}

		[Token(Token = "0x60057EB")]
		[Address(RVA = "0xD4CAB8", Offset = "0xD4CAB8", VA = "0xD4CAB8")]
		private static JSONNode SafeParseJson(AppsFlyerTrackerCallbacks.ConversionDataEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x60057EC")]
		[Address(RVA = "0xD4CEA8", Offset = "0xD4CEA8", VA = "0xD4CEA8")]
		private static Uri SafeMakeUri(string uriString)
		{
			return null;
		}
	}
}
