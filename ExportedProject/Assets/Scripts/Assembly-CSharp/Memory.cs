using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200014C")]
public class Memory : GameMonoBehaviour
{
	[Token(Token = "0x200014D")]
	public class MementoAddedArgs : EventArgs
	{
		[Token(Token = "0x4000714")]
		[FieldOffset(Offset = "0x10")]
		public AIMemento Memento;

		[Token(Token = "0x4000715")]
		[FieldOffset(Offset = "0x18")]
		public Memory TargetMemory;

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x8C7084", Offset = "0x8C7084", VA = "0x8C7084")]
		public MementoAddedArgs()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200014E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59261C", Offset = "0x59261C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000716")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000717")]
		[FieldOffset(Offset = "0x8")]
		public static Func<AIMemento, int> _003C_003E9__62_0;

		[Token(Token = "0x4000718")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Memory, Memory, bool> _003C_003E9__65_0;

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x8C6EB4", Offset = "0x8C6EB4", VA = "0x8C6EB4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x8C6EBC", Offset = "0x8C6EBC", VA = "0x8C6EBC")]
		internal int _003CUpdateAlertLevel_003Eb__62_0(AIMemento memento)
		{
			return default(int);
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x8C6ED4", Offset = "0x8C6ED4", VA = "0x8C6ED4")]
		internal bool _003CUpdateGlobalAlert_003Eb__65_0(Memory a, Memory b)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59262C", Offset = "0x59262C")]
	private sealed class _003CUpdateDelayedHUDAlert_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000719")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400071A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400071B")]
		[FieldOffset(Offset = "0x20")]
		public Memory _003C_003E4__this;

		[Token(Token = "0x17000177")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x8C7034", Offset = "0x8C7034", VA = "0x8C7034", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000178")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000907")]
			[Address(RVA = "0x8C707C", Offset = "0x8C707C", VA = "0x8C707C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x8C6F10", Offset = "0x8C6F10", VA = "0x8C6F10")]
		[DebuggerHidden]
		public _003CUpdateDelayedHUDAlert_003Ed__64(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x8C6F3C", Offset = "0x8C6F3C", VA = "0x8C6F3C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x8C6F40", Offset = "0x8C6F40", VA = "0x8C6F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x8C703C", Offset = "0x8C703C", VA = "0x8C703C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float HUDAlertDelaySeconds;

	[Token(Token = "0x40006FE")]
	[FieldOffset(Offset = "0x4")]
	public static bool GLOBAL_SCARED_ACTIVE;

	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x5")]
	public static bool GLOBAL_FIREWORK_ACTIVE;

	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x48")]
	public Faction Faction;

	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0x50")]
	public bool NoAdjustForRepetition;

	[Token(Token = "0x4000702")]
	[FieldOffset(Offset = "0x51")]
	public bool ContributeToGlobalAlert;

	[NonSerialized]
	[Token(Token = "0x4000703")]
	[FieldOffset(Offset = "0x58")]
	public Blackboard Blackboard;

	[NonSerialized]
	[Token(Token = "0x4000704")]
	[FieldOffset(Offset = "0x60")]
	public List<AIMemento> Mementos;

	[NonSerialized]
	[Token(Token = "0x4000705")]
	[FieldOffset(Offset = "0x68")]
	public float LastModification;

	[NonSerialized]
	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x70")]
	public List<Record> Records;

	[NonSerialized]
	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x78")]
	public AlertLevel HighestAlert;

	[NonSerialized]
	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x7C")]
	public AlertLevel DelayedHUDAlert;

	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B091C", Offset = "0x5B091C")]
	private bool _003CAlive_003Ek__BackingField;

	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x84")]
	private AlertLevel _currentAlert;

	[Token(Token = "0x400070B")]
	[FieldOffset(Offset = "0x88")]
	private GameTimer _timer;

	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x90")]
	private int[] _eventCounts;

	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x98")]
	private Coroutine _delayedHUDAlertCoroutine;

	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B097C", Offset = "0x5B097C")]
	private AlertLevel _003CPreviousAlert_003Ek__BackingField;

	[Token(Token = "0x17000171")]
	public bool Alive
	{
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x9B8270", Offset = "0x9B8270", VA = "0x9B8270")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612988", Offset = "0x612988")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x9B8278", Offset = "0x9B8278", VA = "0x9B8278")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612998", Offset = "0x612998")]
		private set
		{
		}
	}

	[Token(Token = "0x17000172")]
	public bool IsScared
	{
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x9B8284", Offset = "0x9B8284", VA = "0x9B8284")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x9B828C", Offset = "0x9B828C", VA = "0x9B828C")]
		set
		{
		}
	}

	[Token(Token = "0x17000173")]
	public bool IsAttrackByFirework
	{
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x9B8290", Offset = "0x9B8290", VA = "0x9B8290")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000174")]
	public bool HasDelayedAlert
	{
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x9B8A94", Offset = "0x9B8A94", VA = "0x9B8A94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000175")]
	public AlertLevel PreviousAlert
	{
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x9B8AA4", Offset = "0x9B8AA4", VA = "0x9B8AA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612A48", Offset = "0x612A48")]
		get
		{
			return default(AlertLevel);
		}
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x9B8AAC", Offset = "0x9B8AAC", VA = "0x9B8AAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612A58", Offset = "0x612A58")]
		private set
		{
		}
	}

	[Token(Token = "0x17000176")]
	public AlertLevel CurrentAlert
	{
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x9B8AB4", Offset = "0x9B8AB4", VA = "0x9B8AB4")]
		get
		{
			return default(AlertLevel);
		}
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x9B8ABC", Offset = "0x9B8ABC", VA = "0x9B8ABC")]
		set
		{
		}
	}

	[Token(Token = "0x14000014")]
	public static event EventHandler<AISensorManager.AlertLevelChangedArgs> OnAlertChanged
	{
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x9B82F4", Offset = "0x9B82F4", VA = "0x9B82F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6129A8", Offset = "0x6129A8")]
		add
		{
		}
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x9B83EC", Offset = "0x9B83EC", VA = "0x9B83EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6129B8", Offset = "0x6129B8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000015")]
	public static event EventHandler<MementoAddedArgs> OnMementoAddedGlobal
	{
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x9B84E4", Offset = "0x9B84E4", VA = "0x9B84E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6129C8", Offset = "0x6129C8")]
		add
		{
		}
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x9B85DC", Offset = "0x9B85DC", VA = "0x9B85DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6129D8", Offset = "0x6129D8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000016")]
	public event EventHandler<AISensorManager.IsScaredChangedArgs> OnIsScaredChanged
	{
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x9B86D4", Offset = "0x9B86D4", VA = "0x9B86D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6129E8", Offset = "0x6129E8")]
		add
		{
		}
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x9B8774", Offset = "0x9B8774", VA = "0x9B8774")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6129F8", Offset = "0x6129F8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000017")]
	public event EventHandler<MementoAddedArgs> OnMementoAdded
	{
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x9B8814", Offset = "0x9B8814", VA = "0x9B8814")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612A08", Offset = "0x612A08")]
		add
		{
		}
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x9B88B4", Offset = "0x9B88B4", VA = "0x9B88B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612A18", Offset = "0x612A18")]
		remove
		{
		}
	}

	[Token(Token = "0x14000018")]
	public event EventHandler<EventArgs> OnMementoInvestigated
	{
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x9B8954", Offset = "0x9B8954", VA = "0x9B8954")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612A28", Offset = "0x612A28")]
		add
		{
		}
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x9B89F4", Offset = "0x9B89F4", VA = "0x9B89F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612A38", Offset = "0x612A38")]
		remove
		{
		}
	}

	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x9B8B8C", Offset = "0x9B8B8C", VA = "0x9B8B8C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x9B8C1C", Offset = "0x9B8C1C", VA = "0x9B8C1C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x9B8CE8", Offset = "0x9B8CE8", VA = "0x9B8CE8")]
	public void Die()
	{
	}

	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x9B9148", Offset = "0x9B9148", VA = "0x9B9148")]
	public Record AddRecord(AIVisionEmitter emitter)
	{
		return null;
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x9B9408", Offset = "0x9B9408", VA = "0x9B9408")]
	public Record GetRecord(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x9B9474", Offset = "0x9B9474", VA = "0x9B9474")]
	public Record GetRecord(AIEmitter emitter)
	{
		return null;
	}

	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x9B9534", Offset = "0x9B9534", VA = "0x9B9534")]
	private static int BinarySearch(List<Record> records, int start, int end, int id)
	{
		return default(int);
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x9B9510", Offset = "0x9B9510", VA = "0x9B9510")]
	public Record GetRecord(int emitterID)
	{
		return null;
	}

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x9B931C", Offset = "0x9B931C", VA = "0x9B931C")]
	private Record GetRecord(int emitterID, out int idx)
	{
		return null;
	}

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x9B96E4", Offset = "0x9B96E4", VA = "0x9B96E4")]
	public void ClearRecord(AIEmitter emitter)
	{
	}

	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x9B80C4", Offset = "0x9B80C4", VA = "0x9B80C4")]
	public void AddMemento(AIMemento original)
	{
	}

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x9B97EC", Offset = "0x9B97EC", VA = "0x9B97EC")]
	public ThreatLevel AdjustForRepetition(ThreatLevel eventLevel)
	{
		return default(ThreatLevel);
	}

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x9B9B48", Offset = "0x9B9B48", VA = "0x9B9B48")]
	public void UpdateAlertLevel()
	{
	}

	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x9B9A38", Offset = "0x9B9A38", VA = "0x9B9A38")]
	public void UpdateIsScared()
	{
	}

	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x9B8B20", Offset = "0x9B8B20", VA = "0x9B8B20")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x612A68", Offset = "0x612A68")]
	private IEnumerator UpdateDelayedHUDAlert()
	{
		return null;
	}

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x9B8E30", Offset = "0x9B8E30", VA = "0x9B8E30")]
	private void UpdateGlobalAlert()
	{
	}

	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x9B9E70", Offset = "0x9B9E70", VA = "0x9B9E70")]
	public void Forget(AIMemento memento)
	{
	}

	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x9B9EF8", Offset = "0x9B9EF8", VA = "0x9B9EF8")]
	public void OnInvestigated(AIMemento memento)
	{
	}

	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x9B9F5C", Offset = "0x9B9F5C", VA = "0x9B9F5C")]
	public void ClearMementos()
	{
	}

	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x9B97BC", Offset = "0x9B97BC", VA = "0x9B97BC")]
	private bool ShouldAdjustForRepetition(AIMemento memento)
	{
		return default(bool);
	}

	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x9BA01C", Offset = "0x9BA01C", VA = "0x9BA01C")]
	public Memory()
	{
	}
}
