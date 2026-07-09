using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000130")]
[Scope]
public class AISensorManager : GameSingleton<AISensorManager>
{
	[Token(Token = "0x2000131")]
	public class AlertLevelChangedArgs : EventArgs
	{
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x10")]
		public Memory Memory;

		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0x18")]
		public AlertLevel PreviousLevel;

		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x1C")]
		public AlertLevel NewLevel;

		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x20")]
		public bool ChangedByDeath;

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x910928", Offset = "0x910928", VA = "0x910928")]
		public AlertLevelChangedArgs()
		{
		}
	}

	[Token(Token = "0x2000132")]
	public class IsScaredChangedArgs : EventArgs
	{
		[Token(Token = "0x40006AE")]
		[FieldOffset(Offset = "0x10")]
		public bool PreviousIsScared;

		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x11")]
		public bool NewIsScared;

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x91098C", Offset = "0x91098C", VA = "0x91098C")]
		public IsScaredChangedArgs()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59258C", Offset = "0x59258C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Memory, Memory, bool> _003C_003E9__32_0;

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x910574", Offset = "0x910574", VA = "0x910574")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x91057C", Offset = "0x91057C", VA = "0x91057C")]
		internal bool _003CDelayedSetGlobalAlert_003Eb__32_0(Memory item, Memory best)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59259C", Offset = "0x59259C")]
	private sealed class _003CDelayedSetGlobalAlert_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0x20")]
		public AISensorManager _003C_003E4__this;

		[Token(Token = "0x40006B5")]
		[FieldOffset(Offset = "0x28")]
		public bool alive;

		[Token(Token = "0x17000165")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x9108D8", Offset = "0x9108D8", VA = "0x9108D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000166")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x910920", Offset = "0x910920", VA = "0x910920", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x91063C", Offset = "0x91063C", VA = "0x91063C")]
		[DebuggerHidden]
		public _003CDelayedSetGlobalAlert_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x910668", Offset = "0x910668", VA = "0x910668", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x91066C", Offset = "0x91066C", VA = "0x91066C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x9108E0", Offset = "0x9108E0", VA = "0x9108E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5925AC", Offset = "0x5925AC")]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x9105C8", Offset = "0x9105C8", VA = "0x9105C8")]
		public _003C_003Ec__DisplayClass46_0()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x9105D0", Offset = "0x9105D0", VA = "0x9105D0")]
		internal float _003CGetMultipleClosest_003Eb__0(AISensor sensor)
		{
			return default(float);
		}
	}

	[NonSerialized]
	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x48")]
	public Dictionary<string, List<AIMemento>> MementosBeingReported;

	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x50")]
	public ModelContainer Models;

	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x58")]
	public bool CommunicationsJammed;

	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B088C", Offset = "0x5B088C")]
	private AlertLevel _003CGlobalAlert_003Ek__BackingField;

	[NonSerialized]
	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x60")]
	public int BlockedNavigationLayers;

	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x64")]
	private int _maxSensorPerFrame;

	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x68")]
	private readonly LinkedList<AISensor> _sensors;

	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x70")]
	private readonly LinkedList<AIVisionEmitter> _emitters;

	[Token(Token = "0x40006A2")]
	[FieldOffset(Offset = "0x78")]
	private float _globalAlertDelay;

	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x7C")]
	private AlertLevel _pendingAlert;

	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x80")]
	private Memory _pendingAlertInstigator;

	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x88")]
	private Coroutine _globalAlertCoroutine;

	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x90")]
	private bool _ignoreGlobalAlertChange;

	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0x98")]
	private GameTimer _timer;

	[Token(Token = "0x40006A9")]
	[FieldOffset(Offset = "0xA0")]
	private LinkedListNode<AISensor> _currentSensor;

	[Token(Token = "0x17000163")]
	public float GlobalAlertDelay
	{
		[Token(Token = "0x600083E")]
		[Address(RVA = "0xA96C2C", Offset = "0xA96C2C", VA = "0xA96C2C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000164")]
	public AlertLevel GlobalAlert
	{
		[Token(Token = "0x600083F")]
		[Address(RVA = "0xA96C34", Offset = "0xA96C34", VA = "0xA96C34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6125F0", Offset = "0x6125F0")]
		get
		{
			return default(AlertLevel);
		}
		[Token(Token = "0x6000840")]
		[Address(RVA = "0xA96C3C", Offset = "0xA96C3C", VA = "0xA96C3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612600", Offset = "0x612600")]
		private set
		{
		}
	}

	[Token(Token = "0x14000012")]
	public static event EventHandler<AlertLevelChangedArgs> OnGlobalAlertChanged
	{
		[Token(Token = "0x6000841")]
		[Address(RVA = "0xA96C44", Offset = "0xA96C44", VA = "0xA96C44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612610", Offset = "0x612610")]
		add
		{
		}
		[Token(Token = "0x6000842")]
		[Address(RVA = "0xA96D00", Offset = "0xA96D00", VA = "0xA96D00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612620", Offset = "0x612620")]
		remove
		{
		}
	}

	[Token(Token = "0x6000843")]
	[Address(RVA = "0xA96DBC", Offset = "0xA96DBC", VA = "0xA96DBC", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000844")]
	[Address(RVA = "0xA96E1C", Offset = "0xA96E1C", VA = "0xA96E1C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000845")]
	[Address(RVA = "0xA96EBC", Offset = "0xA96EBC", VA = "0xA96EBC", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000846")]
	[Address(RVA = "0xA96FA0", Offset = "0xA96FA0", VA = "0xA96FA0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000847")]
	[Address(RVA = "0xA97048", Offset = "0xA97048", VA = "0xA97048")]
	private void OnGameEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000848")]
	[Address(RVA = "0xA97054", Offset = "0xA97054", VA = "0xA97054")]
	public void SetGlobalAlert(Memory memory, AlertLevel level, bool alive)
	{
	}

	[Token(Token = "0x6000849")]
	[Address(RVA = "0xA97368", Offset = "0xA97368", VA = "0xA97368")]
	public void ResetAllAlert(bool resetHighestAlert)
	{
	}

	[Token(Token = "0x600084A")]
	[Address(RVA = "0xA97180", Offset = "0xA97180", VA = "0xA97180")]
	private void DoSetGlobalAlert(Memory memory, AlertLevel newAlertLevel, bool changedByDeath)
	{
	}

	[Token(Token = "0x600084B")]
	[Address(RVA = "0xA972E8", Offset = "0xA972E8", VA = "0xA972E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x612630", Offset = "0x612630")]
	private IEnumerator DelayedSetGlobalAlert(bool alive)
	{
		return null;
	}

	[Token(Token = "0x600084C")]
	[Address(RVA = "0xA978DC", Offset = "0xA978DC", VA = "0xA978DC", Slot = "14")]
	protected override void RemoveInstance()
	{
	}

	[Token(Token = "0x600084D")]
	[Address(RVA = "0xA96974", Offset = "0xA96974", VA = "0xA96974")]
	public static void Register(AISensor sensor)
	{
	}

	[Token(Token = "0x600084E")]
	[Address(RVA = "0xA97928", Offset = "0xA97928", VA = "0xA97928")]
	public static void Register(AIVisionEmitter emitter)
	{
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0xA96AE4", Offset = "0xA96AE4", VA = "0xA96AE4")]
	public static void Unregister(AISensor sensor)
	{
	}

	[Token(Token = "0x6000850")]
	[Address(RVA = "0xA97AF4", Offset = "0xA97AF4", VA = "0xA97AF4")]
	public static void Unregister(AIVisionEmitter emitter)
	{
	}

	[Token(Token = "0x6000851")]
	[Address(RVA = "0xA97A10", Offset = "0xA97A10", VA = "0xA97A10")]
	private void Remove(AISensor sensor)
	{
	}

	[Token(Token = "0x6000852")]
	[Address(RVA = "0xA97BDC", Offset = "0xA97BDC", VA = "0xA97BDC", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6000853")]
	[Address(RVA = "0xA97BE0", Offset = "0xA97BE0", VA = "0xA97BE0")]
	private void UpdateVision()
	{
	}

	[Token(Token = "0x6000854")]
	[Address(RVA = "0xA97C94", Offset = "0xA97C94", VA = "0xA97C94")]
	private bool UpdateSensor(LinkedListNode<AISensor> sensor)
	{
		return default(bool);
	}

	[Token(Token = "0x6000855")]
	[Address(RVA = "0xA981B4", Offset = "0xA981B4", VA = "0xA981B4")]
	public void BroadcastMemento(AIMemento memento, IEnumerable<AISensor> sensors)
	{
	}

	[Token(Token = "0x6000856")]
	[Address(RVA = "0xA96040", Offset = "0xA96040", VA = "0xA96040")]
	public void BroadcastMemento(AIMemento memento)
	{
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0xA984C4", Offset = "0xA984C4", VA = "0xA984C4")]
	public List<AIMemento> GetMementosBeingReported(Faction faction)
	{
		return null;
	}

	[Token(Token = "0x6000858")]
	[Address(RVA = "0xA985CC", Offset = "0xA985CC", VA = "0xA985CC")]
	public IEnumerable<AISensor> GetMultipleClosest(Vector3 position, int maxToGet)
	{
		return null;
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0xA9871C", Offset = "0xA9871C", VA = "0xA9871C")]
	public static void MakeSound(Vector3 position, AIEmitter emitter, float detectionRadius, ThreatLevel threatLevel)
	{
	}

	[Token(Token = "0x600085A")]
	[Address(RVA = "0xA98834", Offset = "0xA98834", VA = "0xA98834")]
	public AISensorManager()
	{
	}
}
