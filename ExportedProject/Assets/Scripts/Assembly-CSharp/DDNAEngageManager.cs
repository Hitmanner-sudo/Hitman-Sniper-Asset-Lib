using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using DeltaDNA;
using Il2CppDummyDll;
using Technology;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x20007E7")]
[Scope]
public class DDNAEngageManager : GameSingleton<DDNAEngageManager>
{
	[Token(Token = "0x20007E8")]
	private struct MainMenuEngagmentCallback
	{
		[Token(Token = "0x4002C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Engagement Engagement;

		[Token(Token = "0x4002C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Action<Engagement> Callback;
	}

	[Token(Token = "0x20007E9")]
	public enum DecisionPoint
	{
		[Token(Token = "0x4002C64")]
		EnterSplashScreen = 0,
		[Token(Token = "0x4002C65")]
		ExitSplashScreen = 1,
		[Token(Token = "0x4002C66")]
		EnterMainMenu = 2,
		[Token(Token = "0x4002C67")]
		EnterMainMenu_2 = 3,
		[Token(Token = "0x4002C68")]
		EnterMainMenu_3 = 4,
		[Token(Token = "0x4002C69")]
		EnterMenuTab = 5,
		[Token(Token = "0x4002C6A")]
		TallyScreen = 6,
		[Token(Token = "0x4002C6B")]
		Purchase = 7
	}

	[Token(Token = "0x20007EA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59650C", Offset = "0x59650C")]
	private sealed class _003C_003Ec__DisplayClass64_0
	{
		[Token(Token = "0x4002C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<DecisionPoint, MainMenuEngagmentCallback> responses;

		[Token(Token = "0x60033E7")]
		[Address(RVA = "0x866298", Offset = "0x866298", VA = "0x866298")]
		public _003C_003Ec__DisplayClass64_0()
		{
		}
	}

	[Token(Token = "0x20007EB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59651C", Offset = "0x59651C")]
	private sealed class _003C_003Ec__DisplayClass64_1
	{
		[Token(Token = "0x4002C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DecisionPoint decisionPoint;

		[Token(Token = "0x4002C6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass64_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x60033E8")]
		[Address(RVA = "0x8662A0", Offset = "0x8662A0", VA = "0x8662A0")]
		public _003C_003Ec__DisplayClass64_1()
		{
		}

		[Token(Token = "0x60033E9")]
		[Address(RVA = "0x8662A8", Offset = "0x8662A8", VA = "0x8662A8")]
		internal void _003CRequestEnterMainMenuEngagement_003Eb__0(Engagement engagement, Action<Engagement> callback)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20007EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59652C", Offset = "0x59652C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002C6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002C70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<KeyValuePair<string, object>, bool> _003C_003E9__66_0;

		[Token(Token = "0x4002C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<KeyValuePair<string, object>, string> _003C_003E9__66_1;

		[Token(Token = "0x4002C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<KeyValuePair<string, object>, object> _003C_003E9__66_2;

		[Token(Token = "0x4002C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<KeyValuePair<string, object>, string> _003C_003E9__67_1;

		[Token(Token = "0x4002C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<KeyValuePair<string, object>, object> _003C_003E9__67_2;

		[Token(Token = "0x4002C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action<Exception> _003C_003E9__68_2;

		[Token(Token = "0x4002C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Func<string, string[]> _003C_003E9__69_0;

		[Token(Token = "0x4002C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Func<string[], string> _003C_003E9__69_1;

		[Token(Token = "0x4002C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Func<string[], int> _003C_003E9__69_2;

		[Token(Token = "0x4002C79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Func<string, string[]> _003C_003E9__80_0;

		[Token(Token = "0x4002C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Func<string[], string> _003C_003E9__80_1;

		[Token(Token = "0x4002C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Func<string[], int> _003C_003E9__80_2;

		[Token(Token = "0x4002C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Func<string, string[]> _003C_003E9__85_0;

		[Token(Token = "0x4002C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Func<string[], string> _003C_003E9__85_1;

		[Token(Token = "0x4002C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static Func<string[], int> _003C_003E9__85_2;

		[Token(Token = "0x4002C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Func<KeyValuePair<string, int>, Credit> _003C_003E9__85_3;

		[Token(Token = "0x4002C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Func<string, int, _003C_003Ef__AnonymousType2<string, int>> _003C_003E9__100_0;

		[Token(Token = "0x4002C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static Func<_003C_003Ef__AnonymousType2<string, int>, string> _003C_003E9__100_1;

		[Token(Token = "0x4002C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static Func<_003C_003Ef__AnonymousType2<string, int>, int> _003C_003E9__100_2;

		[Token(Token = "0x60033EB")]
		[Address(RVA = "0x865C68", Offset = "0x865C68", VA = "0x865C68")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60033EC")]
		[Address(RVA = "0x865C70", Offset = "0x865C70", VA = "0x865C70")]
		internal bool _003CRequestTallyScreenEngagement_003Eb__66_0(KeyValuePair<string, object> p)
		{
			return default(bool);
		}

		[Token(Token = "0x60033ED")]
		[Address(RVA = "0x865D08", Offset = "0x865D08", VA = "0x865D08")]
		internal string _003CRequestTallyScreenEngagement_003Eb__66_1(KeyValuePair<string, object> p)
		{
			return null;
		}

		[Token(Token = "0x60033EE")]
		[Address(RVA = "0x865D48", Offset = "0x865D48", VA = "0x865D48")]
		internal object _003CRequestTallyScreenEngagement_003Eb__66_2(KeyValuePair<string, object> p)
		{
			return null;
		}

		[Token(Token = "0x60033EF")]
		[Address(RVA = "0x865D88", Offset = "0x865D88", VA = "0x865D88")]
		internal string _003CRequestPurchaseEngagement_003Eb__67_1(KeyValuePair<string, object> p)
		{
			return null;
		}

		[Token(Token = "0x60033F0")]
		[Address(RVA = "0x865DC8", Offset = "0x865DC8", VA = "0x865DC8")]
		internal object _003CRequestPurchaseEngagement_003Eb__67_2(KeyValuePair<string, object> p)
		{
			return null;
		}

		[Token(Token = "0x60033F1")]
		[Address(RVA = "0x865E08", Offset = "0x865E08", VA = "0x865E08")]
		internal void _003CRequestEngagement_003Eb__68_2(Exception ex)
		{
		}

		[Token(Token = "0x60033F2")]
		[Address(RVA = "0x865E0C", Offset = "0x865E0C", VA = "0x865E0C")]
		internal string[] _003CResponseValid_003Eb__69_0(string part)
		{
			return null;
		}

		[Token(Token = "0x60033F3")]
		[Address(RVA = "0x865E90", Offset = "0x865E90", VA = "0x865E90")]
		internal string _003CResponseValid_003Eb__69_1(string[] split)
		{
			return null;
		}

		[Token(Token = "0x60033F4")]
		[Address(RVA = "0x865EC0", Offset = "0x865EC0", VA = "0x865EC0")]
		internal int _003CResponseValid_003Eb__69_2(string[] split)
		{
			return default(int);
		}

		[Token(Token = "0x60033F5")]
		[Address(RVA = "0x865EF8", Offset = "0x865EF8", VA = "0x865EF8")]
		internal string[] _003CHandleGiftEngageParameters_003Eb__80_0(string part)
		{
			return null;
		}

		[Token(Token = "0x60033F6")]
		[Address(RVA = "0x865F7C", Offset = "0x865F7C", VA = "0x865F7C")]
		internal string _003CHandleGiftEngageParameters_003Eb__80_1(string[] split)
		{
			return null;
		}

		[Token(Token = "0x60033F7")]
		[Address(RVA = "0x865FAC", Offset = "0x865FAC", VA = "0x865FAC")]
		internal int _003CHandleGiftEngageParameters_003Eb__80_2(string[] split)
		{
			return default(int);
		}

		[Token(Token = "0x60033F8")]
		[Address(RVA = "0x865FE4", Offset = "0x865FE4", VA = "0x865FE4")]
		internal string[] _003CHandleStarterPackParameters_003Eb__85_0(string part)
		{
			return null;
		}

		[Token(Token = "0x60033F9")]
		[Address(RVA = "0x866068", Offset = "0x866068", VA = "0x866068")]
		internal string _003CHandleStarterPackParameters_003Eb__85_1(string[] split)
		{
			return null;
		}

		[Token(Token = "0x60033FA")]
		[Address(RVA = "0x866098", Offset = "0x866098", VA = "0x866098")]
		internal int _003CHandleStarterPackParameters_003Eb__85_2(string[] split)
		{
			return default(int);
		}

		[Token(Token = "0x60033FB")]
		[Address(RVA = "0x8660D0", Offset = "0x8660D0", VA = "0x8660D0")]
		internal Credit _003CHandleStarterPackParameters_003Eb__85_3(KeyValuePair<string, int> creditInfo)
		{
			return null;
		}

		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x866184", Offset = "0x866184", VA = "0x866184")]
		internal _003C_003Ef__AnonymousType2<string, int> _003CGetLocLanguageIndices_003Eb__100_0(string languageCode, int index)
		{
			return null;
		}

		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x866208", Offset = "0x866208", VA = "0x866208")]
		internal string _003CGetLocLanguageIndices_003Eb__100_1(_003C_003Ef__AnonymousType2<string, int> entry)
		{
			return null;
		}

		[Token(Token = "0x60033FE")]
		[Address(RVA = "0x866250", Offset = "0x866250", VA = "0x866250")]
		internal int _003CGetLocLanguageIndices_003Eb__100_2(_003C_003Ef__AnonymousType2<string, int> entry)
		{
			return default(int);
		}
	}

	[Token(Token = "0x20007ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59653C", Offset = "0x59653C")]
	private sealed class _003C_003Ec__DisplayClass67_0
	{
		[Token(Token = "0x4002C83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public HashSet<string> keysToBeKept;

		[Token(Token = "0x60033FF")]
		[Address(RVA = "0x8664C8", Offset = "0x8664C8", VA = "0x8664C8")]
		public _003C_003Ec__DisplayClass67_0()
		{
		}

		[Token(Token = "0x6003400")]
		[Address(RVA = "0x8664D0", Offset = "0x8664D0", VA = "0x8664D0")]
		internal bool _003CRequestPurchaseEngagement_003Eb__0(KeyValuePair<string, object> p)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20007EE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59654C", Offset = "0x59654C")]
	private sealed class _003C_003Ec__DisplayClass68_0
	{
		[Token(Token = "0x4002C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DDNAEngageManager _003C_003E4__this;

		[Token(Token = "0x4002C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DecisionPoint decisionPoint;

		[Token(Token = "0x4002C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Engagement, Action<Engagement>> handleResponse;

		[Token(Token = "0x4002C87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<Engagement> onCompleted;

		[Token(Token = "0x6003401")]
		[Address(RVA = "0x866540", Offset = "0x866540", VA = "0x866540")]
		public _003C_003Ec__DisplayClass68_0()
		{
		}

		[Token(Token = "0x6003402")]
		[Address(RVA = "0x866548", Offset = "0x866548", VA = "0x866548")]
		internal void _003CRequestEngagement_003Eb__0(Engagement response)
		{
		}

		[Token(Token = "0x6003403")]
		[Address(RVA = "0x866708", Offset = "0x866708", VA = "0x866708")]
		internal void _003CRequestEngagement_003Eb__1(Engagement e)
		{
		}
	}

	[Token(Token = "0x20007EF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59655C", Offset = "0x59655C")]
	private sealed class _003C_003Ec__DisplayClass70_0
	{
		[Token(Token = "0x4002C88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DDNAEngageManager _003C_003E4__this;

		[Token(Token = "0x4002C89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, object> parameters;

		[Token(Token = "0x4002C8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public long transactionID;

		[Token(Token = "0x4002C8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string heading;

		[Token(Token = "0x4002C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string message;

		[Token(Token = "0x6003404")]
		[Address(RVA = "0x866770", Offset = "0x866770", VA = "0x866770")]
		public _003C_003Ec__DisplayClass70_0()
		{
		}

		[Token(Token = "0x6003405")]
		[Address(RVA = "0x866778", Offset = "0x866778", VA = "0x866778")]
		internal void _003CHandleResponse_003Eb__0()
		{
		}

		[Token(Token = "0x6003406")]
		[Address(RVA = "0x8668C8", Offset = "0x8668C8", VA = "0x8668C8")]
		internal void _003CHandleResponse_003Eb__1()
		{
		}
	}

	[Token(Token = "0x20007F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59656C", Offset = "0x59656C")]
	private sealed class _003C_003Ec__DisplayClass70_1
	{
		[Token(Token = "0x4002C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PopupDDNAMessage prefab;

		[Token(Token = "0x4002C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action actionLambda;

		[Token(Token = "0x4002C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupDDNAMessage.OkButtonText actionText;

		[Token(Token = "0x4002C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action dismissLambda;

		[Token(Token = "0x4002C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool showDismiss;

		[Token(Token = "0x4002C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public _003C_003Ec__DisplayClass70_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6003407")]
		[Address(RVA = "0x866A0C", Offset = "0x866A0C", VA = "0x866A0C")]
		public _003C_003Ec__DisplayClass70_1()
		{
		}

		[Token(Token = "0x6003408")]
		[Address(RVA = "0x866A14", Offset = "0x866A14", VA = "0x866A14")]
		internal void _003CHandleResponse_003Eb__2()
		{
		}
	}

	[Token(Token = "0x20007F1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59657C", Offset = "0x59657C")]
	private sealed class _003C_003Ec__DisplayClass70_2
	{
		[Token(Token = "0x4002C93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int width;

		[Token(Token = "0x4002C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int height;

		[Token(Token = "0x4002C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D texture;

		[Token(Token = "0x4002C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass70_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x4002C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action _003C_003E9__4;

		[Token(Token = "0x6003409")]
		[Address(RVA = "0x866B18", Offset = "0x866B18", VA = "0x866B18")]
		public _003C_003Ec__DisplayClass70_2()
		{
		}

		[Token(Token = "0x600340A")]
		[Address(RVA = "0x866B20", Offset = "0x866B20", VA = "0x866B20")]
		internal void _003CHandleResponse_003Eb__3(string error)
		{
		}

		[Token(Token = "0x600340B")]
		[Address(RVA = "0x866C9C", Offset = "0x866C9C", VA = "0x866C9C")]
		internal void _003CHandleResponse_003Eb__4()
		{
		}
	}

	[Token(Token = "0x20007F2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59658C", Offset = "0x59658C")]
	private sealed class _003CDelayedPopupCheck_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DDNAEngageManager _003C_003E4__this;

		[Token(Token = "0x170006A8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600340F")]
			[Address(RVA = "0x8671D8", Offset = "0x8671D8", VA = "0x8671D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003411")]
			[Address(RVA = "0x867220", Offset = "0x867220", VA = "0x867220", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600340C")]
		[Address(RVA = "0x867060", Offset = "0x867060", VA = "0x867060")]
		[DebuggerHidden]
		public _003CDelayedPopupCheck_003Ed__74(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600340D")]
		[Address(RVA = "0x86708C", Offset = "0x86708C", VA = "0x86708C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600340E")]
		[Address(RVA = "0x867090", Offset = "0x867090", VA = "0x867090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003410")]
		[Address(RVA = "0x8671E0", Offset = "0x8671E0", VA = "0x8671E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20007F3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59659C", Offset = "0x59659C")]
	private sealed class _003CShowPopups_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002C9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DDNAEngageManager _003C_003E4__this;

		[Token(Token = "0x4002C9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action _003Cpopup_003E5__2;

		[Token(Token = "0x170006AA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003415")]
			[Address(RVA = "0x8676EC", Offset = "0x8676EC", VA = "0x8676EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006AB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003417")]
			[Address(RVA = "0x867734", Offset = "0x867734", VA = "0x867734", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003412")]
		[Address(RVA = "0x867540", Offset = "0x867540", VA = "0x867540")]
		[DebuggerHidden]
		public _003CShowPopups_003Ed__75(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003413")]
		[Address(RVA = "0x86756C", Offset = "0x86756C", VA = "0x86756C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003414")]
		[Address(RVA = "0x867570", Offset = "0x867570", VA = "0x867570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003416")]
		[Address(RVA = "0x8676F4", Offset = "0x8676F4", VA = "0x8676F4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20007F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5965AC", Offset = "0x5965AC")]
	private sealed class _003CDelayedGoToPage_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002C9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002CA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002CA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string pageId;

		[Token(Token = "0x170006AC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600341B")]
			[Address(RVA = "0x867010", Offset = "0x867010", VA = "0x867010", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006AD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600341D")]
			[Address(RVA = "0x867058", Offset = "0x867058", VA = "0x867058", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003418")]
		[Address(RVA = "0x866E10", Offset = "0x866E10", VA = "0x866E10")]
		[DebuggerHidden]
		public _003CDelayedGoToPage_003Ed__88(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003419")]
		[Address(RVA = "0x866E3C", Offset = "0x866E3C", VA = "0x866E3C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600341A")]
		[Address(RVA = "0x866E40", Offset = "0x866E40", VA = "0x866E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600341C")]
		[Address(RVA = "0x867018", Offset = "0x867018", VA = "0x867018", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20007F5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5965BC", Offset = "0x5965BC")]
	private sealed class _003CDelayedShowStarterPackPopup_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002CA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DDNAEngageManager _003C_003E4__this;

		[Token(Token = "0x170006AE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003421")]
			[Address(RVA = "0x8674F0", Offset = "0x8674F0", VA = "0x8674F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006AF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003423")]
			[Address(RVA = "0x867538", Offset = "0x867538", VA = "0x867538", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600341E")]
		[Address(RVA = "0x867228", Offset = "0x867228", VA = "0x867228")]
		[DebuggerHidden]
		public _003CDelayedShowStarterPackPopup_003Ed__89(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600341F")]
		[Address(RVA = "0x867254", Offset = "0x867254", VA = "0x867254", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003420")]
		[Address(RVA = "0x867258", Offset = "0x867258", VA = "0x867258", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003422")]
		[Address(RVA = "0x8674F8", Offset = "0x8674F8", VA = "0x8674F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20007F6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5965CC", Offset = "0x5965CC")]
	private sealed class _003C_003Ec__DisplayClass98_0
	{
		[Token(Token = "0x4002CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string weaponPath;

		[Token(Token = "0x6003424")]
		[Address(RVA = "0x866DC8", Offset = "0x866DC8", VA = "0x866DC8")]
		public _003C_003Ec__DisplayClass98_0()
		{
		}

		[Token(Token = "0x6003425")]
		[Address(RVA = "0x866DD0", Offset = "0x866DD0", VA = "0x866DD0")]
		internal bool _003CIsHidden_003Eb__0(LazyWeaponUnlockable w)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4002C26")]
	private const string RESPONSE_HEADING_KEY = "heading";

	[Token(Token = "0x4002C27")]
	private const string RESPONSE_HEIGHT_KEY = "height";

	[Token(Token = "0x4002C28")]
	private const string RESPONSE_IMAGE_KEY = "image";

	[Token(Token = "0x4002C29")]
	private const string RESPONSE_MESSAGE_KEY = "message";

	[Token(Token = "0x4002C2A")]
	private const string RESPONSE_MESSAGE_PARAMETERIZATION_KEY = "messageParametrization";

	[Token(Token = "0x4002C2B")]
	private const string RESPONSE_PARAMETERS_KEY = "parameters";

	[Token(Token = "0x4002C2C")]
	private const string RESPONSE_SHOW_DISMISS_KEY = "showDismiss";

	[Token(Token = "0x4002C2D")]
	private const string RESPONSE_TRANSACTION_ID_KEY = "transactionID";

	[Token(Token = "0x4002C2E")]
	private const string RESPONSE_URL_KEY = "url";

	[Token(Token = "0x4002C2F")]
	private const string RESPONSE_WIDTH_KEY = "width";

	[Token(Token = "0x4002C30")]
	private const string PARAM_ACTION_TEXT_KEY = "actionText";

	[Token(Token = "0x4002C31")]
	private const string PARAM_ACTION_PARAMETERIZATION_KEY = "actionParameterization";

	[Token(Token = "0x4002C32")]
	private const string PARAM_DISMISS_TEXT_KEY = "dismissText";

	[Token(Token = "0x4002C33")]
	private const string PARAM_EQUIP_WEAPON_KEY = "equipWeapon";

	[Token(Token = "0x4002C34")]
	private const string PARAM_GIFTS_KEY = "gifts";

	[Token(Token = "0x4002C35")]
	private const string PARAM_GUN_EQUIPPED = "gunEquipped";

	[Token(Token = "0x4002C36")]
	private const string PARAM_HEADING_KEY = "heading";

	[Token(Token = "0x4002C37")]
	private const string PARAM_HYPERLINK_KEY = "hyperlink";

	[Token(Token = "0x4002C38")]
	private const string PARAM_IMAGE_KEY = "image";

	[Token(Token = "0x4002C39")]
	private const string PARAM_LOADING_HINT_INDEX_KEY = "loadingHintIndex";

	[Token(Token = "0x4002C3A")]
	private const string PARAM_LOC_LANGUAGES_ORDER = "locLanguagesOrder";

	[Token(Token = "0x4002C3B")]
	private const string PARAM_MESSAGE_KEY = "message";

	[Token(Token = "0x4002C3C")]
	private const string PARAM_OFFER_DISCOUNT_KEY = "offerDiscount";

	[Token(Token = "0x4002C3D")]
	private const string PARAM_OFFER_PRICE_KEY = "offerPrice";

	[Token(Token = "0x4002C3E")]
	private const string PARAM_PAGE_GO_TO_KEY = "pageGoTo";

	[Token(Token = "0x4002C3F")]
	private const string PARAM_POPUP_GO_TO_KEY = "popupGoTo";

	[Token(Token = "0x4002C40")]
	private const string PARAM_SUBPAGE_GO_TO_KEY = "subPageGoTo";

	[Token(Token = "0x4002C41")]
	private const string PARAM_STARTER_PACK_CREDITS_KEY = "starterPackCredits";

	[Token(Token = "0x4002C42")]
	private const string PARAM_STARTER_PACK_DATE_TIME_LIMIT_KEY = "starterPackDateTimeLimit";

	[Token(Token = "0x4002C43")]
	private const string PARAM_STARTER_PACK_DURATION_KEY = "starterPackDuration";

	[Token(Token = "0x4002C44")]
	private const string PARAM_STARTER_PACK_SHOW_POPUP_KEY = "starterPackShowOnCampaignStart";

	[Token(Token = "0x4002C45")]
	private const string PARAM_WEAPON_TO_SHOW_KEY = "weaponToShow";

	[Token(Token = "0x4002C46")]
	private const string PARAM_SHOOT_BUTTON_DEFAULT_VALUE_KEY = "shootButtonDefault";

	[Token(Token = "0x4002C47")]
	private const string PARAM_JUSTCAUSE_REFERRAL_COUNT_KEY = "justcauseReferralCountRequired";

	[Token(Token = "0x4002C48")]
	private const string POPUP_CURRENCY_STORE_ID = "Currency";

	[Token(Token = "0x4002C49")]
	private const string POPUP_STARTER_PACK_ID = "StarterPack";

	[Token(Token = "0x4002C4A")]
	private const string PAGE_ARMORY = "Armory";

	[Token(Token = "0x4002C4B")]
	private const string PAGE_DEATH_VALLEY = "Death Valley";

	[Token(Token = "0x4002C4C")]
	private const string PAGE_MONTENEGRO = "Montenegro";

	[Token(Token = "0x4002C4D")]
	private const string PAGE_UPGRADES = "Upgrades";

	[Token(Token = "0x4002C4E")]
	private const string PAGE_TARGETS = "Targets";

	[Token(Token = "0x4002C4F")]
	private const string LOC_VALUES_PARAM_FORMAT = "loc_{0}";

	[Token(Token = "0x4002C50")]
	private const char LOC_VALUES_SEPERATOR = ',';

	[Token(Token = "0x4002C51")]
	private const int INVALID_LANGUAGE_INDEX = -1;

	[Token(Token = "0x4002C52")]
	private const bool IsDisabled = true;

	[Token(Token = "0x4002C53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int _hintIndex;

	[Token(Token = "0x4002C54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool _shouldShowHint;

	[Token(Token = "0x4002C55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool PopupsLocked;

	[Token(Token = "0x4002C56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Queue<Action> _popupsInWaiting;

	[Token(Token = "0x4002C57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly DecisionPoint[] ENTER_MAIN_MENU_DECISION_POINTS;

	[Token(Token = "0x4002C58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Dictionary<string, ModesModel.MenuPages> MenuPageMapping;

	[Token(Token = "0x4002C59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PopupDDNAMessage _textOnlyPrefab;

	[Token(Token = "0x4002C5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private PopupDDNAMessage _imageOnlyPopupPrefab;

	[Token(Token = "0x4002C5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private PopupDDNAMessage _textAndImagePopupPrefab;

	[Token(Token = "0x4002C5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly HashSet<string> _keysToBeKept;

	[Token(Token = "0x4002C5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool _splashScreenEngagementRequested;

	[Token(Token = "0x4002C5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool _goreOffEngagementRequested;

	[Token(Token = "0x4002C5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Coroutine _showPopupCoroutine;

	[Token(Token = "0x4002C60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly Dictionary<DecisionPoint, Engagement> _lastEngagements;

	[Token(Token = "0x60033B9")]
	[Address(RVA = "0xBC37A0", Offset = "0xBC37A0", VA = "0xBC37A0")]
	public bool TryGetLastReceivedEngagement(DecisionPoint point, out Engagement engagement)
	{
		return default(bool);
	}

	[Token(Token = "0x60033BA")]
	[Address(RVA = "0xBC380C", Offset = "0xBC380C", VA = "0xBC380C")]
	public int GetHintIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60033BB")]
	[Address(RVA = "0xBC382C", Offset = "0xBC382C", VA = "0xBC382C")]
	public void RequestSplashScreenEngagement()
	{
	}

	[Token(Token = "0x60033BC")]
	[Address(RVA = "0xBC3AA0", Offset = "0xBC3AA0", VA = "0xBC3AA0")]
	public void RequestEnterMainMenuEngagement(string source, int previousProgression, int previousTimesFailed)
	{
	}

	[Token(Token = "0x60033BD")]
	[Address(RVA = "0xBC3F88", Offset = "0xBC3F88", VA = "0xBC3F88")]
	public void RequestEnterMenuTabEngagement(string tab)
	{
	}

	[Token(Token = "0x60033BE")]
	[Address(RVA = "0xBC40E4", Offset = "0xBC40E4", VA = "0xBC40E4")]
	public void RequestTallyScreenEngagement()
	{
	}

	[Token(Token = "0x60033BF")]
	[Address(RVA = "0xBC0224", Offset = "0xBC0224", VA = "0xBC0224")]
	public void RequestPurchaseEngagement(Dictionary<string, object> parameters)
	{
	}

	[Token(Token = "0x60033C0")]
	[Address(RVA = "0xBC3A24", Offset = "0xBC3A24", VA = "0xBC3A24")]
	public void RequestEngagement(DecisionPoint decisionPoint, [Optional] Dictionary<string, object> aParameters, [Optional] Action<Engagement, Action<Engagement>> handleResponse)
	{
	}

	[Token(Token = "0x60033C1")]
	[Address(RVA = "0xBC4508", Offset = "0xBC4508", VA = "0xBC4508")]
	public bool ResponseValid(Engagement response)
	{
		return default(bool);
	}

	[Token(Token = "0x60033C2")]
	[Address(RVA = "0xBC5DF8", Offset = "0xBC5DF8", VA = "0xBC5DF8")]
	public void HandleResponse(Engagement response)
	{
	}

	[Token(Token = "0x60033C3")]
	[Address(RVA = "0xBC6804", Offset = "0xBC6804", VA = "0xBC6804")]
	private static string GetNode(string nodeName, Dictionary<string, object> response)
	{
		return null;
	}

	[Token(Token = "0x60033C4")]
	[Address(RVA = "0xBC6870", Offset = "0xBC6870", VA = "0xBC6870")]
	private static Dictionary<string, object> TryGetImageProperties(Dictionary<string, object> response)
	{
		return null;
	}

	[Token(Token = "0x60033C5")]
	[Address(RVA = "0xBC7B00", Offset = "0xBC7B00", VA = "0xBC7B00")]
	private void QueuePopup(Action popup)
	{
	}

	[Token(Token = "0x60033C6")]
	[Address(RVA = "0xBC7D00", Offset = "0xBC7D00", VA = "0xBC7D00")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622D20", Offset = "0x622D20")]
	private IEnumerator DelayedPopupCheck()
	{
		return null;
	}

	[Token(Token = "0x60033C7")]
	[Address(RVA = "0xBC7D6C", Offset = "0xBC7D6C", VA = "0xBC7D6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622D80", Offset = "0x622D80")]
	public IEnumerator ShowPopups()
	{
		return null;
	}

	[Token(Token = "0x60033C8")]
	[Address(RVA = "0xBC7DD8", Offset = "0xBC7DD8", VA = "0xBC7DD8")]
	public bool ApplyDDNACancelHandlers(Dictionary<string, object> parameters)
	{
		return default(bool);
	}

	[Token(Token = "0x60033C9")]
	[Address(RVA = "0xBC6CB4", Offset = "0xBC6CB4", VA = "0xBC6CB4")]
	public bool ApplyDDNAHandlers(Dictionary<string, object> parameters, long transactionID)
	{
		return default(bool);
	}

	[Token(Token = "0x60033CA")]
	[Address(RVA = "0xBC7B8C", Offset = "0xBC7B8C", VA = "0xBC7B8C")]
	public void HandleEngageParameters(Dictionary<string, object> parameters, long transactionID, bool isPopupMessage)
	{
	}

	[Token(Token = "0x60033CB")]
	[Address(RVA = "0xBC9908", Offset = "0xBC9908", VA = "0xBC9908")]
	private void HandleGoreCampaign(Dictionary<string, object> parameters)
	{
	}

	[Token(Token = "0x60033CC")]
	[Address(RVA = "0xBC9BBC", Offset = "0xBC9BBC", VA = "0xBC9BBC")]
	private void HandleGiftEngageParameters(Dictionary<string, object> parameters)
	{
	}

	[Token(Token = "0x60033CD")]
	[Address(RVA = "0xBCA520", Offset = "0xBCA520", VA = "0xBCA520")]
	private void HandleNavigationEngageParameters(Dictionary<string, object> parameters)
	{
	}

	[Token(Token = "0x60033CE")]
	[Address(RVA = "0xBCAB98", Offset = "0xBCAB98", VA = "0xBCAB98")]
	private void HandlePopupNavigationEngageParameters(Dictionary<string, object> parameters)
	{
	}

	[Token(Token = "0x60033CF")]
	[Address(RVA = "0xBCAC60", Offset = "0xBCAC60", VA = "0xBCAC60")]
	private static void HandleHyperlinkEngageParameters(Dictionary<string, object> parameters)
	{
	}

	[Token(Token = "0x60033D0")]
	[Address(RVA = "0xBCACE8", Offset = "0xBCACE8", VA = "0xBCACE8")]
	private void HandleLoadingScreenHintEngageParameters(Dictionary<string, object> parameters)
	{
	}

	[Token(Token = "0x60033D1")]
	[Address(RVA = "0xBCAD80", Offset = "0xBCAD80", VA = "0xBCAD80")]
	private void HandleStarterPackParameters(Dictionary<string, object> parameters, long transactionID)
	{
	}

	[Token(Token = "0x60033D2")]
	[Address(RVA = "0xBCB8B8", Offset = "0xBCB8B8", VA = "0xBCB8B8")]
	private static void HandleShootButtonEngageParameters(Dictionary<string, object> parameters)
	{
	}

	[Token(Token = "0x60033D3")]
	[Address(RVA = "0xBCBAA8", Offset = "0xBCBAA8", VA = "0xBCBAA8")]
	private static void HandleJustCauseFriendsReferralParameters(Dictionary<string, object> parameters)
	{
	}

	[Token(Token = "0x60033D4")]
	[Address(RVA = "0xBCBF90", Offset = "0xBCBF90", VA = "0xBCBF90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622DE0", Offset = "0x622DE0")]
	private static IEnumerator DelayedGoToPage(string pageId)
	{
		return null;
	}

	[Token(Token = "0x60033D5")]
	[Address(RVA = "0xBCBFFC", Offset = "0xBCBFFC", VA = "0xBCBFFC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622E40", Offset = "0x622E40")]
	private IEnumerator DelayedShowStarterPackPopup()
	{
		return null;
	}

	[Token(Token = "0x60033D6")]
	[Address(RVA = "0xBCC068", Offset = "0xBCC068", VA = "0xBCC068")]
	public Dictionary<string, object> GetDecisionPointParameters([Optional] Dictionary<string, object> specificParameters)
	{
		return null;
	}

	[Token(Token = "0x60033D7")]
	[Address(RVA = "0xBC5C84", Offset = "0xBC5C84", VA = "0xBC5C84")]
	private bool IsUnlocked(string gun)
	{
		return default(bool);
	}

	[Token(Token = "0x60033D8")]
	[Address(RVA = "0xBCD884", Offset = "0xBCD884", VA = "0xBCD884")]
	private static string GetZombieModeUnlocked()
	{
		return null;
	}

	[Token(Token = "0x60033D9")]
	[Address(RVA = "0xBCD9EC", Offset = "0xBCD9EC", VA = "0xBCD9EC")]
	private static int GetUnclaimedPerks()
	{
		return default(int);
	}

	[Token(Token = "0x60033DA")]
	[Address(RVA = "0xBCD69C", Offset = "0xBCD69C", VA = "0xBCD69C")]
	private static float GetPercentageOfUpgradeCost(WeaponUnlockable weapon)
	{
		return default(float);
	}

	[Token(Token = "0x60033DB")]
	[Address(RVA = "0xBC736C", Offset = "0xBC736C", VA = "0xBC736C")]
	private static string TryFormatText(string text, string parameters, long transactionID)
	{
		return null;
	}

	[Token(Token = "0x60033DC")]
	[Address(RVA = "0xBC6DE8", Offset = "0xBC6DE8", VA = "0xBC6DE8")]
	private bool GetActionText(Dictionary<string, object> parameters, int locLanguageIdx, long transactionId, out PopupDDNAMessage.OkButtonText actionText)
	{
		return default(bool);
	}

	[Token(Token = "0x60033DD")]
	[Address(RVA = "0xBCDA80", Offset = "0xBCDA80", VA = "0xBCDA80")]
	private static string GetLocalizedEquippedWeaponName()
	{
		return null;
	}

	[Token(Token = "0x60033DE")]
	[Address(RVA = "0xBC5914", Offset = "0xBC5914", VA = "0xBC5914")]
	private bool IsHidden(string weaponName)
	{
		return default(bool);
	}

	[Token(Token = "0x60033DF")]
	[Address(RVA = "0xBC7338", Offset = "0xBC7338", VA = "0xBC7338")]
	private PopupDDNAMessage GetPopupPrefab(bool hasHeader, bool hasBody, bool hasImage)
	{
		return null;
	}

	[Token(Token = "0x60033E0")]
	[Address(RVA = "0xBCDB70", Offset = "0xBCDB70", VA = "0xBCDB70")]
	private Dictionary<string, int> GetLocLanguageIndices(long transactionID, Dictionary<string, object> parameters)
	{
		return null;
	}

	[Token(Token = "0x60033E1")]
	[Address(RVA = "0xBC6770", Offset = "0xBC6770", VA = "0xBC6770")]
	private int GetLocLanguageIndex(long transactionID, Dictionary<string, object> parameters, string languageCode)
	{
		return default(int);
	}

	[Token(Token = "0x60033E2")]
	[Address(RVA = "0xBC68EC", Offset = "0xBC68EC", VA = "0xBC68EC")]
	private string LocalizeParameter(long transactionID, Dictionary<string, object> parameters, string paramName, int languageIndex, [Optional] string alternateValue)
	{
		return null;
	}

	[Token(Token = "0x60033E3")]
	[Address(RVA = "0xBCE008", Offset = "0xBCE008", VA = "0xBCE008")]
	private static BetterList<string> ReadLocLine(string line)
	{
		return null;
	}

	[Token(Token = "0x60033E4")]
	[Address(RVA = "0xBC5788", Offset = "0xBC5788", VA = "0xBC5788")]
	private static bool HasActionText(Dictionary<string, object> parameters)
	{
		return default(bool);
	}

	[Token(Token = "0x60033E5")]
	[Address(RVA = "0xBCE1C4", Offset = "0xBCE1C4", VA = "0xBCE1C4")]
	public DDNAEngageManager()
	{
	}
}
