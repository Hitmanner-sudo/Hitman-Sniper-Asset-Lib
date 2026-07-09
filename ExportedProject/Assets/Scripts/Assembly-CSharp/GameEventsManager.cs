using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology;
using Technology.Distribution;
using UnityEngine;

[Token(Token = "0x2000238")]
[Scope]
public class GameEventsManager : GameSingleton<GameEventsManager>
{
	[Token(Token = "0x2000239")]
	public enum GameEndResult
	{
		[Token(Token = "0x4000C83")]
		None = 0,
		[Token(Token = "0x4000C84")]
		Success = 1,
		[Token(Token = "0x4000C85")]
		Failure = 2,
		[Token(Token = "0x4000C86")]
		RestartFromPause = 3,
		[Token(Token = "0x4000C87")]
		RestartFromTally = 4,
		[Token(Token = "0x4000C88")]
		Quit = 5
	}

	[Token(Token = "0x200023A")]
	public enum GameEventType
	{
		[Token(Token = "0x4000C8A")]
		StealthKill = 0
	}

	[Token(Token = "0x200023B")]
	public enum State
	{
		[Token(Token = "0x4000C8C")]
		GameNotStarted = 0,
		[Token(Token = "0x4000C8D")]
		GameInProgress = 1,
		[Token(Token = "0x4000C8E")]
		GameEnded = 2,
		[Token(Token = "0x4000C8F")]
		GameResults = 3,
		[Token(Token = "0x4000C90")]
		GameInTallyScreen = 4,
		[Token(Token = "0x4000C91")]
		GameNotCreated = 5
	}

	[Token(Token = "0x200023C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592C5C", Offset = "0x592C5C")]
	private sealed class _003CAlarmRaisedCoroutine_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000C93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameEventsManager _003C_003E4__this;

		[Token(Token = "0x4000C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003Cdelay_003E5__2;

		[Token(Token = "0x17000215")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D65")]
			[Address(RVA = "0x87269C", Offset = "0x87269C", VA = "0x87269C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000216")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D67")]
			[Address(RVA = "0x8726E4", Offset = "0x8726E4", VA = "0x8726E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x8723B4", Offset = "0x8723B4", VA = "0x8723B4")]
		[DebuggerHidden]
		public _003CAlarmRaisedCoroutine_003Ed__84(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x8723E0", Offset = "0x8723E0", VA = "0x8723E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x8723E4", Offset = "0x8723E4", VA = "0x8723E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x8726A4", Offset = "0x8726A4", VA = "0x8726A4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200023D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592C6C", Offset = "0x592C6C")]
	private sealed class _003CRaiseGameEndedCoroutine_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x4000C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameEventsManager _003C_003E4__this;

		[Token(Token = "0x4000C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _003Cdelay_003E5__2;

		[Token(Token = "0x17000217")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D6B")]
			[Address(RVA = "0x872D78", Offset = "0x872D78", VA = "0x872D78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000218")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D6D")]
			[Address(RVA = "0x872DC0", Offset = "0x872DC0", VA = "0x872DC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D68")]
		[Address(RVA = "0x872BBC", Offset = "0x872BBC", VA = "0x872BBC")]
		[DebuggerHidden]
		public _003CRaiseGameEndedCoroutine_003Ed__85(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x872BE8", Offset = "0x872BE8", VA = "0x872BE8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x872BEC", Offset = "0x872BEC", VA = "0x872BEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0x872D80", Offset = "0x872D80", VA = "0x872D80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200023E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592C7C", Offset = "0x592C7C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<BundleAdditive, GameObject> _003C_003E9__89_0;

		[Token(Token = "0x4000C9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<AIController, GameObject> _003C_003E9__89_1;

		[Token(Token = "0x6000D6F")]
		[Address(RVA = "0x871FAC", Offset = "0x871FAC", VA = "0x871FAC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x871FB4", Offset = "0x871FB4", VA = "0x871FB4")]
		internal GameObject _003CAdditiveScenesAndAICleanup_003Eb__89_0(BundleAdditive b)
		{
			return null;
		}

		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x871FD0", Offset = "0x871FD0", VA = "0x871FD0")]
		internal GameObject _003CAdditiveScenesAndAICleanup_003Eb__89_1(AIController tpc)
		{
			return null;
		}
	}

	[Token(Token = "0x200023F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592C8C", Offset = "0x592C8C")]
	private sealed class _003C_003Ec__DisplayClass90_0
	{
		[Token(Token = "0x4000C9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isLowEnd;

		[Token(Token = "0x4000C9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIController uiController;

		[Token(Token = "0x4000CA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action actionToRun;

		[Token(Token = "0x4000CA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string menu;

		[Token(Token = "0x6000D72")]
		[Address(RVA = "0x872000", Offset = "0x872000", VA = "0x872000")]
		public _003C_003Ec__DisplayClass90_0()
		{
		}

		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x872008", Offset = "0x872008", VA = "0x872008")]
		internal void _003CLoadMenuCoroutine_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000240")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592C9C", Offset = "0x592C9C")]
	private sealed class _003CLoadMenuCoroutine_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000CA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIController uiController;

		[Token(Token = "0x4000CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action actionToRun;

		[Token(Token = "0x4000CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string menu;

		[Token(Token = "0x4000CA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameEventsManager _003C_003E4__this;

		[Token(Token = "0x4000CA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass90_0 _003C_003E8__1;

		[Token(Token = "0x4000CA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AsyncOperation _003CasyncOp_003E5__2;

		[Token(Token = "0x17000219")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x872944", Offset = "0x872944", VA = "0x872944", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D79")]
			[Address(RVA = "0x87298C", Offset = "0x87298C", VA = "0x87298C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D74")]
		[Address(RVA = "0x8726EC", Offset = "0x8726EC", VA = "0x8726EC")]
		[DebuggerHidden]
		public _003CLoadMenuCoroutine_003Ed__90(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x872718", Offset = "0x872718", VA = "0x872718", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x87271C", Offset = "0x87271C", VA = "0x87271C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x87294C", Offset = "0x87294C", VA = "0x87294C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000241")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592CAC", Offset = "0x592CAC")]
	private sealed class _003COnApplicationLowMemoryCoroutine_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000CAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000CAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000CAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _003CisLowEnd_003E5__2;

		[Token(Token = "0x4000CAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation _003CasyncOp_003E5__3;

		[Token(Token = "0x1700021B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x872B6C", Offset = "0x872B6C", VA = "0x872B6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x872BB4", Offset = "0x872BB4", VA = "0x872BB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x872994", Offset = "0x872994", VA = "0x872994")]
		[DebuggerHidden]
		public _003COnApplicationLowMemoryCoroutine_003Ed__92(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x8729C0", Offset = "0x8729C0", VA = "0x8729C0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x8729C4", Offset = "0x8729C4", VA = "0x8729C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x872B74", Offset = "0x872B74", VA = "0x872B74", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000C69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3498", Offset = "0x5B3498")]
	private bool _003CBulletInAir_003Ek__BackingField;

	[Token(Token = "0x4000C6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Faction> FactionsThatBreakKillStreaks;

	[Token(Token = "0x4000C6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Faction VictimFaction;

	[Token(Token = "0x4000C6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string[] MissionExpiredLocalizationKeys;

	[Token(Token = "0x4000C6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B34A8", Offset = "0x5B34A8")]
	private bool _003CIsLastPingOnline_003Ek__BackingField;

	[Token(Token = "0x4000C6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool _isCurrentlyPinging;

	[Token(Token = "0x4000C6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Coroutine _raiseGameEndedCoroutine;

	[Token(Token = "0x4000C70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Coroutine _alarmRaisedCoroutine;

	[Token(Token = "0x4000C71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Action _actionForLoading;

	[Token(Token = "0x4000C77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static EventHandler OnSceneLoading;

	[Token(Token = "0x4000C78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static EventHandler OnSceneUnloading;

	[NonSerialized]
	[Token(Token = "0x4000C7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float StartGameTime;

	[Token(Token = "0x4000C7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3548", Offset = "0x5B3548")]
	private float _003CAlarmRaisedCoroutineTimeLeft_003Ek__BackingField;

	[Token(Token = "0x4000C7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3558", Offset = "0x5B3558")]
	private State _003CGameState_003Ek__BackingField;

	[Token(Token = "0x4000C80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3568", Offset = "0x5B3568")]
	private GameStats _003CStats_003Ek__BackingField;

	[Token(Token = "0x4000C81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3578", Offset = "0x5B3578")]
	private bool _003CIsGameRunningAndLoaded_003Ek__BackingField;

	[Token(Token = "0x1700020C")]
	public bool BulletInAir
	{
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0xD95860", Offset = "0xD95860", VA = "0xD95860")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614784", Offset = "0x614784")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0xD95868", Offset = "0xD95868", VA = "0xD95868")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614794", Offset = "0x614794")]
		set
		{
		}
	}

	[Token(Token = "0x1700020D")]
	public bool IsLastPingOnline
	{
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0xD95874", Offset = "0xD95874", VA = "0xD95874")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6147A4", Offset = "0x6147A4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0xD9587C", Offset = "0xD9587C", VA = "0xD9587C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6147B4", Offset = "0x6147B4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700020E")]
	public float AlarmRaisedCoroutineTimeLeft
	{
		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0xD96540", Offset = "0xD96540", VA = "0xD96540")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6148E4", Offset = "0x6148E4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0xD96548", Offset = "0xD96548", VA = "0xD96548")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6148F4", Offset = "0x6148F4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700020F")]
	public State GameState
	{
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0xD96550", Offset = "0xD96550", VA = "0xD96550")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614904", Offset = "0x614904")]
		get
		{
			return default(State);
		}
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0xD96558", Offset = "0xD96558", VA = "0xD96558")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614914", Offset = "0x614914")]
		private set
		{
		}
	}

	[Token(Token = "0x17000210")]
	public GameStats Stats
	{
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0xD96560", Offset = "0xD96560", VA = "0xD96560")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614924", Offset = "0x614924")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0xD96568", Offset = "0xD96568", VA = "0xD96568")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614934", Offset = "0x614934")]
		private set
		{
		}
	}

	[Token(Token = "0x17000211")]
	public bool IsGameRunningAndLoaded
	{
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0xD96570", Offset = "0xD96570", VA = "0xD96570")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614944", Offset = "0x614944")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0xD96578", Offset = "0xD96578", VA = "0xD96578")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614954", Offset = "0x614954")]
		private set
		{
		}
	}

	[Token(Token = "0x17000212")]
	public bool IsGameRunning
	{
		[Token(Token = "0x6000D42")]
		[Address(RVA = "0xD96584", Offset = "0xD96584", VA = "0xD96584")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000213")]
	public bool IsGameEnded
	{
		[Token(Token = "0x6000D43")]
		[Address(RVA = "0xD96594", Offset = "0xD96594", VA = "0xD96594")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000214")]
	public bool IsInGameResults
	{
		[Token(Token = "0x6000D44")]
		[Address(RVA = "0xD965A8", Offset = "0xD965A8", VA = "0xD965A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400002A")]
	public static event EventHandler OnGameStarted
	{
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0xD95888", Offset = "0xD95888", VA = "0xD95888")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6147C4", Offset = "0x6147C4")]
		add
		{
		}
		[Token(Token = "0x6000D29")]
		[Address(RVA = "0xD95944", Offset = "0xD95944", VA = "0xD95944")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6147D4", Offset = "0x6147D4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002B")]
	public static event EventHandler OnGamePreEnded
	{
		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0xD95A00", Offset = "0xD95A00", VA = "0xD95A00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6147E4", Offset = "0x6147E4")]
		add
		{
		}
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0xD95AC0", Offset = "0xD95AC0", VA = "0xD95AC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6147F4", Offset = "0x6147F4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002C")]
	public static event EventHandler OnGameEnded
	{
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0xD95B80", Offset = "0xD95B80", VA = "0xD95B80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614804", Offset = "0x614804")]
		add
		{
		}
		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0xD95C40", Offset = "0xD95C40", VA = "0xD95C40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614814", Offset = "0x614814")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002D")]
	public static event EventHandler OnLevelCleanup
	{
		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0xD95D00", Offset = "0xD95D00", VA = "0xD95D00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614824", Offset = "0x614824")]
		add
		{
		}
		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0xD95DC0", Offset = "0xD95DC0", VA = "0xD95DC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614834", Offset = "0x614834")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002E")]
	public static event EventHandler<ContractEndedArgs> OnContractEnded
	{
		[Token(Token = "0x6000D30")]
		[Address(RVA = "0xD95E80", Offset = "0xD95E80", VA = "0xD95E80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614844", Offset = "0x614844")]
		add
		{
		}
		[Token(Token = "0x6000D31")]
		[Address(RVA = "0xD95F40", Offset = "0xD95F40", VA = "0xD95F40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614854", Offset = "0x614854")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002F")]
	public static event EventHandler<CheckIsOnlineArgs> OnCheckOnlineDone
	{
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0xD96000", Offset = "0xD96000", VA = "0xD96000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614864", Offset = "0x614864")]
		add
		{
		}
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0xD960C0", Offset = "0xD960C0", VA = "0xD960C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614874", Offset = "0x614874")]
		remove
		{
		}
	}

	[Token(Token = "0x14000030")]
	public event EventHandler ShotMissed
	{
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0xD96180", Offset = "0xD96180", VA = "0xD96180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614884", Offset = "0x614884")]
		add
		{
		}
		[Token(Token = "0x6000D35")]
		[Address(RVA = "0xD96220", Offset = "0xD96220", VA = "0xD96220")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614894", Offset = "0x614894")]
		remove
		{
		}
	}

	[Token(Token = "0x14000031")]
	public event EventHandler<GameEventArgs> GameEventRaised
	{
		[Token(Token = "0x6000D36")]
		[Address(RVA = "0xD962C0", Offset = "0xD962C0", VA = "0xD962C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6148A4", Offset = "0x6148A4")]
		add
		{
		}
		[Token(Token = "0x6000D37")]
		[Address(RVA = "0xD96360", Offset = "0xD96360", VA = "0xD96360")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6148B4", Offset = "0x6148B4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000032")]
	public event EventHandler OnKillStreakWithoutNoticeBroken
	{
		[Token(Token = "0x6000D38")]
		[Address(RVA = "0xD96400", Offset = "0xD96400", VA = "0xD96400")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6148C4", Offset = "0x6148C4")]
		add
		{
		}
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0xD964A0", Offset = "0xD964A0", VA = "0xD964A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6148D4", Offset = "0x6148D4")]
		remove
		{
		}
	}

	[Token(Token = "0x6000D45")]
	[Address(RVA = "0xD965B8", Offset = "0xD965B8", VA = "0xD965B8", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000D46")]
	[Address(RVA = "0xD9671C", Offset = "0xD9671C", VA = "0xD9671C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000D47")]
	[Address(RVA = "0xD96900", Offset = "0xD96900", VA = "0xD96900")]
	private void OnLoadingViewDisable(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000D48")]
	[Address(RVA = "0xD96B8C", Offset = "0xD96B8C", VA = "0xD96B8C")]
	protected void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x6000D49")]
	[Address(RVA = "0xD96C2C", Offset = "0xD96C2C", VA = "0xD96C2C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000D4A")]
	[Address(RVA = "0xD96E34", Offset = "0xD96E34", VA = "0xD96E34")]
	public void StartGame()
	{
	}

	[Token(Token = "0x6000D4B")]
	[Address(RVA = "0xD96E98", Offset = "0xD96E98", VA = "0xD96E98")]
	public void ResetTimer()
	{
	}

	[Token(Token = "0x6000D4C")]
	[Address(RVA = "0xD96F50", Offset = "0xD96F50", VA = "0xD96F50")]
	private void StopGameEndedCoroutine()
	{
	}

	[Token(Token = "0x6000D4D")]
	[Address(RVA = "0xD96F80", Offset = "0xD96F80", VA = "0xD96F80")]
	public void OnBulletShot(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0xD97104", Offset = "0xD97104", VA = "0xD97104")]
	public void OnBulletDied(object sender, Bullet.BulletDiedArgs e)
	{
	}

	[Token(Token = "0x6000D4F")]
	[Address(RVA = "0xD97218", Offset = "0xD97218", VA = "0xD97218")]
	public void OnMurderedVictimFound(object sender, CharacterEmitter.MurderedVictimFoundArgs args)
	{
	}

	[Token(Token = "0x6000D50")]
	[Address(RVA = "0xD973CC", Offset = "0xD973CC", VA = "0xD973CC")]
	public void RaiseEvent(object sender, GameEventType eventType)
	{
	}

	[Token(Token = "0x6000D51")]
	[Address(RVA = "0xD97464", Offset = "0xD97464", VA = "0xD97464")]
	public void StartAlarmRaisedExtraction()
	{
	}

	[Token(Token = "0x6000D52")]
	[Address(RVA = "0xD97510", Offset = "0xD97510", VA = "0xD97510")]
	public void EndGame(GameEndResult gameEndResult)
	{
	}

	[Token(Token = "0x6000D53")]
	[Address(RVA = "0xD974A4", Offset = "0xD974A4", VA = "0xD974A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x614964", Offset = "0x614964")]
	private IEnumerator AlarmRaisedCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000D54")]
	[Address(RVA = "0xD9792C", Offset = "0xD9792C", VA = "0xD9792C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6149C4", Offset = "0x6149C4")]
	private IEnumerator RaiseGameEndedCoroutine(float time)
	{
		return null;
	}

	[Token(Token = "0x6000D55")]
	[Address(RVA = "0xD979A8", Offset = "0xD979A8", VA = "0xD979A8")]
	private void RaiseGameEnded()
	{
	}

	[Token(Token = "0x6000D56")]
	[Address(RVA = "0xD97A34", Offset = "0xD97A34", VA = "0xD97A34")]
	public void GoToTallyScreen()
	{
	}

	[Token(Token = "0x6000D57")]
	[Address(RVA = "0xD97A4C", Offset = "0xD97A4C", VA = "0xD97A4C")]
	public void AdditiveScenesAndAICleanupAndResourceRelease(string menu, [Optional] UIController uiController, [Optional] Action actionToRun)
	{
	}

	[Token(Token = "0x6000D58")]
	[Address(RVA = "0xD97B68", Offset = "0xD97B68", VA = "0xD97B68")]
	private void AdditiveScenesAndAICleanup()
	{
	}

	[Token(Token = "0x6000D59")]
	[Address(RVA = "0xD9810C", Offset = "0xD9810C", VA = "0xD9810C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x614A24", Offset = "0x614A24")]
	private IEnumerator LoadMenuCoroutine(string menu, UIController uiController, [Optional] Action actionToRun)
	{
		return null;
	}

	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0xD98198", Offset = "0xD98198", VA = "0xD98198")]
	private void OnApplicationLowMemory()
	{
	}

	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0xD981C4", Offset = "0xD981C4", VA = "0xD981C4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x614A84", Offset = "0x614A84")]
	private IEnumerator OnApplicationLowMemoryCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0xD98220", Offset = "0xD98220", VA = "0xD98220")]
	public void SetGameNotStarted()
	{
	}

	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0xD98228", Offset = "0xD98228", VA = "0xD98228")]
	public void CheckOnlineStatus()
	{
	}

	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0xD98320", Offset = "0xD98320", VA = "0xD98320")]
	private void HandleResult(bool isOnline)
	{
	}

	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0xD9781C", Offset = "0xD9781C", VA = "0xD9781C")]
	private float GetDelayedExtractionTime()
	{
		return default(float);
	}

	[Token(Token = "0x6000D60")]
	[Address(RVA = "0xD983E0", Offset = "0xD983E0", VA = "0xD983E0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000D61")]
	[Address(RVA = "0xD98484", Offset = "0xD98484", VA = "0xD98484")]
	public GameEventsManager()
	{
	}
}
