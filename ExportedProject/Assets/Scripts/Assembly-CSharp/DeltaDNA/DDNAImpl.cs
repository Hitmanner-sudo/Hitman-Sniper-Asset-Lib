using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x20012EB")]
	internal class DDNAImpl : DDNABase
	{
		[Token(Token = "0x20012EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE6F4", Offset = "0x5AE6F4")]
		private sealed class _003C_003Ec__DisplayClass29_0
		{
			[Token(Token = "0x4005ACF")]
			[FieldOffset(Offset = "0x10")]
			public Engagement engagement;

			[Token(Token = "0x4005AD0")]
			[FieldOffset(Offset = "0x18")]
			public Action<Dictionary<string, object>> callback;

			[Token(Token = "0x6006F11")]
			[Address(RVA = "0x867A40", Offset = "0x867A40", VA = "0x867A40")]
			public _003C_003Ec__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6006F12")]
			[Address(RVA = "0x867A48", Offset = "0x867A48", VA = "0x867A48")]
			internal void _003CRequestEngagement_003Eb__0(string response, int statusCode, string error)
			{
			}
		}

		[Token(Token = "0x20012ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE704", Offset = "0x5AE704")]
		private sealed class _003C_003Ec__DisplayClass30_0
		{
			[Token(Token = "0x4005AD1")]
			[FieldOffset(Offset = "0x10")]
			public Engagement engagement;

			[Token(Token = "0x4005AD2")]
			[FieldOffset(Offset = "0x18")]
			public Action<Engagement> onCompleted;

			[Token(Token = "0x6006F13")]
			[Address(RVA = "0x867C58", Offset = "0x867C58", VA = "0x867C58")]
			public _003C_003Ec__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6006F14")]
			[Address(RVA = "0x867C60", Offset = "0x867C60", VA = "0x867C60")]
			internal void _003CRequestEngagement_003Eb__0(string response, int statusCode, string error)
			{
			}
		}

		[Token(Token = "0x20012EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE714", Offset = "0x5AE714")]
		private sealed class _003CUploadCoroutine_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005AD3")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005AD4")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005AD5")]
			[FieldOffset(Offset = "0x20")]
			public DDNAImpl _003C_003E4__this;

			[Token(Token = "0x4005AD6")]
			[FieldOffset(Offset = "0x28")]
			public HashSet<string> eventNameFilter;

			[Token(Token = "0x17000C92")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6006F19")]
				[Address(RVA = "0x868A90", Offset = "0x868A90", VA = "0x868A90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C93")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6006F1B")]
				[Address(RVA = "0x868AD8", Offset = "0x868AD8", VA = "0x868AD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006F15")]
			[Address(RVA = "0x868550", Offset = "0x868550", VA = "0x868550")]
			[DebuggerHidden]
			public _003CUploadCoroutine_003Ed__53(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006F16")]
			[Address(RVA = "0x86857C", Offset = "0x86857C", VA = "0x86857C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6006F17")]
			[Address(RVA = "0x8685D8", Offset = "0x8685D8", VA = "0x8685D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6006F18")]
			[Address(RVA = "0x8685B4", Offset = "0x8685B4", VA = "0x8685B4")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6006F1A")]
			[Address(RVA = "0x868A98", Offset = "0x868A98", VA = "0x868A98", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x20012EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE724", Offset = "0x5AE724")]
		private sealed class _003C_003Ec__DisplayClass54_0
		{
			[Token(Token = "0x4005AD7")]
			[FieldOffset(Offset = "0x10")]
			public bool succeeded;

			[Token(Token = "0x4005AD8")]
			[FieldOffset(Offset = "0x14")]
			public int status;

			[Token(Token = "0x6006F1C")]
			[Address(RVA = "0x867D2C", Offset = "0x867D2C", VA = "0x867D2C")]
			public _003C_003Ec__DisplayClass54_0()
			{
			}

			[Token(Token = "0x6006F1D")]
			[Address(RVA = "0x867D34", Offset = "0x867D34", VA = "0x867D34")]
			internal void _003CPostEvents_003Eb__0(int statusCode, string data, string error)
			{
			}
		}

		[Token(Token = "0x20012F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE734", Offset = "0x5AE734")]
		private sealed class _003CPostEvents_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005AD9")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005ADA")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005ADB")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool, int> resultCallback;

			[Token(Token = "0x4005ADC")]
			[FieldOffset(Offset = "0x28")]
			public string[] events;

			[Token(Token = "0x4005ADD")]
			[FieldOffset(Offset = "0x30")]
			public DDNAImpl _003C_003E4__this;

			[Token(Token = "0x4005ADE")]
			[FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass54_0 _003C_003E8__1;

			[Token(Token = "0x4005ADF")]
			[FieldOffset(Offset = "0x40")]
			private int _003Cattempts_003E5__2;

			[Token(Token = "0x4005AE0")]
			[FieldOffset(Offset = "0x48")]
			private Action<int, string, string> _003CcompletionHandler_003E5__3;

			[Token(Token = "0x4005AE1")]
			[FieldOffset(Offset = "0x50")]
			private HttpRequest _003Crequest_003E5__4;

			[Token(Token = "0x17000C94")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6006F21")]
				[Address(RVA = "0x868500", Offset = "0x868500", VA = "0x868500", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C95")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6006F23")]
				[Address(RVA = "0x868548", Offset = "0x868548", VA = "0x868548", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006F1E")]
			[Address(RVA = "0x867F54", Offset = "0x867F54", VA = "0x867F54")]
			[DebuggerHidden]
			public _003CPostEvents_003Ed__54(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006F1F")]
			[Address(RVA = "0x867F80", Offset = "0x867F80", VA = "0x867F80", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6006F20")]
			[Address(RVA = "0x867F84", Offset = "0x867F84", VA = "0x867F84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6006F22")]
			[Address(RVA = "0x868508", Offset = "0x868508", VA = "0x868508", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20012F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE744", Offset = "0x5AE744")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005AE2")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005AE3")]
			[FieldOffset(Offset = "0x8")]
			public static Func<object, string> _003C_003E9__58_0;

			[Token(Token = "0x4005AE4")]
			[FieldOffset(Offset = "0x10")]
			public static Func<object, string> _003C_003E9__58_1;

			[Token(Token = "0x4005AE5")]
			[FieldOffset(Offset = "0x18")]
			public static Func<EventTrigger, string> _003C_003E9__58_3;

			[Token(Token = "0x4005AE6")]
			[FieldOffset(Offset = "0x20")]
			public static Func<IGrouping<string, EventTrigger>, string> _003C_003E9__58_4;

			[Token(Token = "0x4005AE7")]
			[FieldOffset(Offset = "0x28")]
			public static Func<IGrouping<string, EventTrigger>, ReadOnlyCollection<EventTrigger>> _003C_003E9__58_5;

			[Token(Token = "0x4005AE8")]
			[FieldOffset(Offset = "0x30")]
			public static Func<object, string> _003C_003E9__58_6;

			[Token(Token = "0x6006F25")]
			[Address(RVA = "0x86779C", Offset = "0x86779C", VA = "0x86779C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6006F26")]
			[Address(RVA = "0x8677A4", Offset = "0x8677A4", VA = "0x8677A4")]
			internal string _003CHandleSessionConfigurationCallback_003Eb__58_0(object e)
			{
				return null;
			}

			[Token(Token = "0x6006F27")]
			[Address(RVA = "0x867804", Offset = "0x867804", VA = "0x867804")]
			internal string _003CHandleSessionConfigurationCallback_003Eb__58_1(object e)
			{
				return null;
			}

			[Token(Token = "0x6006F28")]
			[Address(RVA = "0x867864", Offset = "0x867864", VA = "0x867864")]
			internal string _003CHandleSessionConfigurationCallback_003Eb__58_3(EventTrigger e)
			{
				return null;
			}

			[Token(Token = "0x6006F29")]
			[Address(RVA = "0x86787C", Offset = "0x86787C", VA = "0x86787C")]
			internal string _003CHandleSessionConfigurationCallback_003Eb__58_4(IGrouping<string, EventTrigger> e)
			{
				return null;
			}

			[Token(Token = "0x6006F2A")]
			[Address(RVA = "0x867924", Offset = "0x867924", VA = "0x867924")]
			internal ReadOnlyCollection<EventTrigger> _003CHandleSessionConfigurationCallback_003Eb__58_5(IGrouping<string, EventTrigger> e)
			{
				return null;
			}

			[Token(Token = "0x6006F2B")]
			[Address(RVA = "0x8679E0", Offset = "0x8679E0", VA = "0x8679E0")]
			internal string _003CHandleSessionConfigurationCallback_003Eb__58_6(object e)
			{
				return null;
			}
		}

		[Token(Token = "0x20012F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE754", Offset = "0x5AE754")]
		private sealed class _003CDoSessionConfigurationRetry_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005AE9")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005AEA")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005AEB")]
			[FieldOffset(Offset = "0x20")]
			public int delay;

			[Token(Token = "0x4005AEC")]
			[FieldOffset(Offset = "0x28")]
			public DDNAImpl _003C_003E4__this;

			[Token(Token = "0x17000C96")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6006F2F")]
				[Address(RVA = "0x867F04", Offset = "0x867F04", VA = "0x867F04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C97")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6006F31")]
				[Address(RVA = "0x867F4C", Offset = "0x867F4C", VA = "0x867F4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006F2C")]
			[Address(RVA = "0x867E1C", Offset = "0x867E1C", VA = "0x867E1C")]
			[DebuggerHidden]
			public _003CDoSessionConfigurationRetry_003Ed__60(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006F2D")]
			[Address(RVA = "0x867E48", Offset = "0x867E48", VA = "0x867E48", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6006F2E")]
			[Address(RVA = "0x867E4C", Offset = "0x867E4C", VA = "0x867E4C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6006F30")]
			[Address(RVA = "0x867F0C", Offset = "0x867F0C", VA = "0x867F0C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4005ABB")]
		[FieldOffset(Offset = "0x30")]
		private readonly EventStore eventStore;

		[Token(Token = "0x4005ABC")]
		[FieldOffset(Offset = "0x38")]
		private readonly EngageCache engageCache;

		[Token(Token = "0x4005ABD")]
		[FieldOffset(Offset = "0x40")]
		private readonly ActionStore actionStore;

		[Token(Token = "0x4005ABE")]
		[FieldOffset(Offset = "0x48")]
		private readonly ExecutionCountManager executionCountManager;

		[Token(Token = "0x4005ABF")]
		[FieldOffset(Offset = "0x50")]
		private bool started;

		[Token(Token = "0x4005AC0")]
		[FieldOffset(Offset = "0x51")]
		private bool uploading;

		[Token(Token = "0x4005AC1")]
		[FieldOffset(Offset = "0x58")]
		private DateTime lastActive;

		[Token(Token = "0x4005AC2")]
		[FieldOffset(Offset = "0x60")]
		private bool isFetchingConfig;

		[Token(Token = "0x4005AC3")]
		[FieldOffset(Offset = "0x68")]
		private GameEvent launchNotificationEvent;

		[Token(Token = "0x4005AC4")]
		[FieldOffset(Offset = "0x70")]
		private string pushNotificationToken;

		[Token(Token = "0x4005AC5")]
		[FieldOffset(Offset = "0x78")]
		private string androidRegistrationId;

		[Token(Token = "0x4005AC6")]
		[FieldOffset(Offset = "0x80")]
		private ReadOnlyCollection<string> whitelistDps;

		[Token(Token = "0x4005AC7")]
		[FieldOffset(Offset = "0x88")]
		private ReadOnlyCollection<string> whitelistEvents;

		[Token(Token = "0x4005AC8")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<string, ReadOnlyCollection<EventTrigger>> eventTriggers;

		[Token(Token = "0x4005AC9")]
		[FieldOffset(Offset = "0x98")]
		private ReadOnlyCollection<string> cacheImages;

		[Token(Token = "0x4005ACA")]
		[FieldOffset(Offset = "0xA0")]
		private bool hasSentDefaultEvents;

		[Token(Token = "0x4005ACB")]
		[FieldOffset(Offset = "0xA1")]
		private bool newPlayer;

		[Token(Token = "0x4005ACC")]
		[FieldOffset(Offset = "0xA4")]
		private int retryAttempts;

		[Token(Token = "0x4005ACD")]
		[FieldOffset(Offset = "0xA8")]
		private int readyToTriggerEventsCounter;

		[Token(Token = "0x4005ACE")]
		private const int expectedCountToTriggerEvents = 2;

		[Token(Token = "0x17000C8D")]
		internal override bool HasStarted
		{
			[Token(Token = "0x6006EFD")]
			[Address(RVA = "0xBD1180", Offset = "0xBD1180", VA = "0xBD1180", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000C8E")]
		internal override bool IsUploading
		{
			[Token(Token = "0x6006EFE")]
			[Address(RVA = "0xBD1188", Offset = "0xBD1188", VA = "0xBD1188", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000C8F")]
		internal override string CrossGameUserID
		{
			[Token(Token = "0x6006EFF")]
			[Address(RVA = "0xBD1190", Offset = "0xBD1190", VA = "0xBD1190", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F00")]
			[Address(RVA = "0xBD11DC", Offset = "0xBD11DC", VA = "0xBD11DC", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000C90")]
		internal override string AndroidRegistrationID
		{
			[Token(Token = "0x6006F01")]
			[Address(RVA = "0xBD1384", Offset = "0xBD1384", VA = "0xBD1384", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F02")]
			[Address(RVA = "0xBD138C", Offset = "0xBD138C", VA = "0xBD138C", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000C91")]
		internal override string PushNotificationToken
		{
			[Token(Token = "0x6006F03")]
			[Address(RVA = "0xBD14C0", Offset = "0xBD14C0", VA = "0xBD14C0", Slot = "27")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F04")]
			[Address(RVA = "0xBD14C8", Offset = "0xBD14C8", VA = "0xBD14C8", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x6006EE9")]
		[Address(RVA = "0xBBC488", Offset = "0xBBC488", VA = "0xBBC488")]
		internal DDNAImpl(DDNA ddna)
		{
		}

		[Token(Token = "0x6006EEA")]
		[Address(RVA = "0xBCE6B8", Offset = "0xBCE6B8", VA = "0xBCE6B8", Slot = "4")]
		internal override void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6006EEB")]
		[Address(RVA = "0xBCE810", Offset = "0xBCE810", VA = "0xBCE810", Slot = "5")]
		internal override void OnDestroy()
		{
		}

		[Token(Token = "0x6006EEC")]
		[Address(RVA = "0xBCE858", Offset = "0xBCE858", VA = "0xBCE858", Slot = "6")]
		internal override void ClearAllEvents()
		{
		}

		[Token(Token = "0x6006EED")]
		[Address(RVA = "0xBCE874", Offset = "0xBCE874", VA = "0xBCE874", Slot = "7")]
		internal override void StartSDK(bool newPlayer)
		{
		}

		[Token(Token = "0x6006EEE")]
		[Address(RVA = "0xBCE954", Offset = "0xBCE954", VA = "0xBCE954", Slot = "8")]
		internal override void StopSDK()
		{
		}

		[Token(Token = "0x6006EEF")]
		internal override EventAction RecordEvent<T>(T gameEvent)
		{
			return null;
		}

		[Token(Token = "0x6006EF0")]
		[Address(RVA = "0xBCEA78", Offset = "0xBCEA78", VA = "0xBCEA78", Slot = "10")]
		internal override EventAction RecordEvent(string eventName)
		{
			return null;
		}

		[Token(Token = "0x6006EF1")]
		[Address(RVA = "0xBCEB1C", Offset = "0xBCEB1C", VA = "0xBCEB1C", Slot = "11")]
		internal override EventAction RecordEvent(string eventName, Dictionary<string, object> eventParams)
		{
			return null;
		}

		[Token(Token = "0x6006EF2")]
		[Address(RVA = "0xBCED28", Offset = "0xBCED28", VA = "0xBCED28", Slot = "12")]
		internal override void RequestEngagement(Engagement engagement, Action<Dictionary<string, object>> callback)
		{
		}

		[Token(Token = "0x6006EF3")]
		[Address(RVA = "0xBCF40C", Offset = "0xBCF40C", VA = "0xBCF40C", Slot = "13")]
		internal override void RequestEngagement(Engagement engagement, Action<Engagement> onCompleted, Action<Exception> onError)
		{
		}

		[Token(Token = "0x6006EF4")]
		[Address(RVA = "0xBCFADC", Offset = "0xBCFADC", VA = "0xBCFADC", Slot = "14")]
		internal override void RecordPushNotification(Dictionary<string, object> payload)
		{
		}

		[Token(Token = "0x6006EF5")]
		[Address(RVA = "0xBD0404", Offset = "0xBD0404", VA = "0xBD0404")]
		private DateTime? RetrieveSessionDate(string playerPrefsKey)
		{
			return null;
		}

		[Token(Token = "0x6006EF6")]
		[Address(RVA = "0xBD076C", Offset = "0xBD076C", VA = "0xBD076C", Slot = "15")]
		internal override void RequestSessionConfiguration()
		{
		}

		[Token(Token = "0x6006EF7")]
		[Address(RVA = "0xBD0E58", Offset = "0xBD0E58", VA = "0xBD0E58", Slot = "16")]
		internal override void Upload()
		{
		}

		[Token(Token = "0x6006EF8")]
		[Address(RVA = "0xBBE0E8", Offset = "0xBBE0E8", VA = "0xBBE0E8")]
		internal void Upload(HashSet<string> eventNameFilter)
		{
		}

		[Token(Token = "0x6006EF9")]
		[Address(RVA = "0xBD0ED8", Offset = "0xBD0ED8", VA = "0xBD0ED8", Slot = "17")]
		internal override void DownloadImageAssets()
		{
		}

		[Token(Token = "0x6006EFA")]
		[Address(RVA = "0xBD1050", Offset = "0xBD1050", VA = "0xBD1050", Slot = "18")]
		internal override void ClearPersistentData()
		{
		}

		[Token(Token = "0x6006EFB")]
		[Address(RVA = "0xBD10F0", Offset = "0xBD10F0", VA = "0xBD10F0", Slot = "19")]
		internal override void ForgetMe()
		{
		}

		[Token(Token = "0x6006EFC")]
		[Address(RVA = "0xBD1138", Offset = "0xBD1138", VA = "0xBD1138", Slot = "20")]
		internal override void StopTrackingMe()
		{
		}

		[Token(Token = "0x6006F05")]
		[Address(RVA = "0xBD0E60", Offset = "0xBD0E60", VA = "0xBD0E60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62C740", Offset = "0x62C740")]
		private IEnumerator UploadCoroutine(HashSet<string> eventNameFilter)
		{
			return null;
		}

		[Token(Token = "0x6006F06")]
		[Address(RVA = "0xBD15FC", Offset = "0xBD15FC", VA = "0xBD15FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62C7A0", Offset = "0x62C7A0")]
		private IEnumerator PostEvents(string[] events, Action<bool, int> resultCallback)
		{
			return null;
		}

		[Token(Token = "0x6006F07")]
		[Address(RVA = "0xBBF2DC", Offset = "0xBBF2DC", VA = "0xBBF2DC")]
		public void CanTriggerDefaultEvents()
		{
		}

		[Token(Token = "0x6006F08")]
		[Address(RVA = "0xBD167C", Offset = "0xBD167C", VA = "0xBD167C")]
		private void TriggerDefaultEvents()
		{
		}

		[Token(Token = "0x6006F09")]
		[Address(RVA = "0xBD1ECC", Offset = "0xBD1ECC", VA = "0xBD1ECC")]
		private string GetClientS_UID()
		{
			return null;
		}

		[Token(Token = "0x6006F0A")]
		[Address(RVA = "0xBD1FCC", Offset = "0xBD1FCC", VA = "0xBD1FCC")]
		private void HandleSessionConfigurationCallback(Dictionary<string, object> response)
		{
		}

		[Token(Token = "0x6006F0B")]
		[Address(RVA = "0xBD2CF4", Offset = "0xBD2CF4", VA = "0xBD2CF4")]
		private void HandleSessionConfigurationRetry()
		{
		}

		[Token(Token = "0x6006F0C")]
		[Address(RVA = "0xBD3054", Offset = "0xBD3054", VA = "0xBD3054")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62C800", Offset = "0x62C800")]
		private IEnumerator DoSessionConfigurationRetry(int delay)
		{
			return null;
		}

		[Token(Token = "0x6006F0D")]
		[Address(RVA = "0xBD30D0", Offset = "0xBD30D0", VA = "0xBD30D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C860", Offset = "0x62C860")]
		private void _003CDownloadImageAssets_003Eb__36_0()
		{
		}

		[Token(Token = "0x6006F0E")]
		[Address(RVA = "0xBD3170", Offset = "0xBD3170", VA = "0xBD3170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C870", Offset = "0x62C870")]
		private void _003CDownloadImageAssets_003Eb__36_1(string e)
		{
		}

		[Token(Token = "0x6006F0F")]
		[Address(RVA = "0xBD3220", Offset = "0xBD3220", VA = "0xBD3220")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C880", Offset = "0x62C880")]
		private void _003CUploadCoroutine_003Eb__53_0(bool succeeded, int statusCode)
		{
		}

		[Token(Token = "0x6006F10")]
		[Address(RVA = "0xBD3334", Offset = "0xBD3334", VA = "0xBD3334")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C890", Offset = "0x62C890")]
		private EventTrigger _003CHandleSessionConfigurationCallback_003Eb__58_2(object e, int i)
		{
			return null;
		}
	}
}
