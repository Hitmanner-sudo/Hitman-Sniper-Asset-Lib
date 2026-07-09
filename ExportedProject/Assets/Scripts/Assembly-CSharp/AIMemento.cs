using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200012C")]
public class AIMemento
{
	[Token(Token = "0x400067F")]
	[FieldOffset(Offset = "0x10")]
	public int Priority;

	[Token(Token = "0x4000680")]
	[FieldOffset(Offset = "0x14")]
	public ThreatLevel ThreatLevel;

	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x18")]
	public float DetectionRadius;

	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x1C")]
	public ReactionType ReactionIndex;

	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0x20")]
	public Bark ReactionBark;

	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x28")]
	public bool ShouldInvestigate;

	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x2C")]
	public float InvestigateRadius;

	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0x30")]
	public bool IsScared;

	[NonSerialized]
	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0x38")]
	public AIEmitter Emitter;

	[NonSerialized]
	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 Position;

	[NonSerialized]
	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x4C")]
	public float Timestamp;

	[NonSerialized]
	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x50")]
	public bool WasReactedTo;

	[NonSerialized]
	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0x51")]
	public bool Shared;

	[NonSerialized]
	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0x52")]
	public bool Forgotten;

	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0x53")]
	[SerializeField]
	private bool _shouldOverrideInvestigationDuration;

	[Token(Token = "0x400068E")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _overrideInvestigationDuration;

	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool _noAdjustForRepetition;

	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x59")]
	[SerializeField]
	private bool _forceCloseInvestigation;

	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B086C", Offset = "0x5B086C")]
	private int _003CReceiverCount_003Ek__BackingField;

	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B087C", Offset = "0x5B087C")]
	private long _003CID_003Ek__BackingField;

	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x0")]
	private static long _nextID;

	[Token(Token = "0x17000158")]
	public bool ShouldOverrideInvestigationDuration
	{
		[Token(Token = "0x6000818")]
		[Address(RVA = "0xA95BC4", Offset = "0xA95BC4", VA = "0xA95BC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000159")]
	public float OverrideInvestigationDuration
	{
		[Token(Token = "0x6000819")]
		[Address(RVA = "0xA95BCC", Offset = "0xA95BCC", VA = "0xA95BCC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700015A")]
	public bool NoAdjustForRepetition
	{
		[Token(Token = "0x600081A")]
		[Address(RVA = "0xA95BD4", Offset = "0xA95BD4", VA = "0xA95BD4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700015B")]
	public bool ForceCloseInvestigation
	{
		[Token(Token = "0x600081B")]
		[Address(RVA = "0xA95BDC", Offset = "0xA95BDC", VA = "0xA95BDC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700015C")]
	public int ReceiverCount
	{
		[Token(Token = "0x600081C")]
		[Address(RVA = "0xA95BE4", Offset = "0xA95BE4", VA = "0xA95BE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612590", Offset = "0x612590")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600081D")]
		[Address(RVA = "0xA95BEC", Offset = "0xA95BEC", VA = "0xA95BEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6125A0", Offset = "0x6125A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700015D")]
	public long ID
	{
		[Token(Token = "0x600081E")]
		[Address(RVA = "0xA95BF4", Offset = "0xA95BF4", VA = "0xA95BF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6125B0", Offset = "0x6125B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600081F")]
		[Address(RVA = "0xA95BFC", Offset = "0xA95BFC", VA = "0xA95BFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6125C0", Offset = "0x6125C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700015E")]
	public bool HasReaction
	{
		[Token(Token = "0x6000820")]
		[Address(RVA = "0xA95C04", Offset = "0xA95C04", VA = "0xA95C04")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700015F")]
	public virtual bool DropHandHeldItems
	{
		[Token(Token = "0x6000821")]
		[Address(RVA = "0xA95C14", Offset = "0xA95C14", VA = "0xA95C14", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000160")]
	public static long NextID
	{
		[Token(Token = "0x6000822")]
		[Address(RVA = "0xA95C24", Offset = "0xA95C24", VA = "0xA95C24")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x6000823")]
	[Address(RVA = "0xA95C90", Offset = "0xA95C90", VA = "0xA95C90")]
	public AIMemento()
	{
	}

	[Token(Token = "0x6000824")]
	[Address(RVA = "0xA95D90", Offset = "0xA95D90", VA = "0xA95D90")]
	public AIMemento(AIEmitter emitter)
	{
	}

	[Token(Token = "0x6000825")]
	[Address(RVA = "0xA95EF0", Offset = "0xA95EF0", VA = "0xA95EF0", Slot = "5")]
	public virtual void StartReaction(AIController ai)
	{
	}

	[Token(Token = "0x6000826")]
	[Address(RVA = "0xA95FA4", Offset = "0xA95FA4", VA = "0xA95FA4", Slot = "6")]
	public virtual void StopReaction(AIController ai)
	{
	}

	[Token(Token = "0x6000827")]
	[Address(RVA = "0xA95FB0", Offset = "0xA95FB0", VA = "0xA95FB0", Slot = "7")]
	public virtual bool CanBeInvestigated(Memory memory)
	{
		return default(bool);
	}

	[Token(Token = "0x6000828")]
	[Address(RVA = "0xA95FB8", Offset = "0xA95FB8", VA = "0xA95FB8", Slot = "8")]
	public virtual void Broadcast()
	{
	}

	[Token(Token = "0x6000829")]
	[Address(RVA = "0xA96048", Offset = "0xA96048", VA = "0xA96048", Slot = "9")]
	public virtual bool CanBeDetectedBy(AISensor sensor)
	{
		return default(bool);
	}

	[Token(Token = "0x600082A")]
	[Address(RVA = "0xA96224", Offset = "0xA96224", VA = "0xA96224")]
	protected bool AlreadyDetected(AISensor sensor)
	{
		return default(bool);
	}

	[Token(Token = "0x600082B")]
	[Address(RVA = "0xA96348", Offset = "0xA96348", VA = "0xA96348", Slot = "10")]
	public virtual AIMemento Push(Memory memory)
	{
		return null;
	}

	[Token(Token = "0x600082C")]
	[Address(RVA = "0xA96494", Offset = "0xA96494", VA = "0xA96494", Slot = "11")]
	public virtual void OnForget()
	{
	}

	[Token(Token = "0x600082D")]
	[Address(RVA = "0xA964A0", Offset = "0xA964A0", VA = "0xA964A0", Slot = "12")]
	public virtual void OnThreatLevelAdjusted(ThreatLevel oldLevel, ThreatLevel newLevel)
	{
	}

	[Token(Token = "0x600082F")]
	[Address(RVA = "0xA964F4", Offset = "0xA964F4", VA = "0xA964F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6125D0", Offset = "0x6125D0")]
	private bool _003CAlreadyDetected_003Eb__48_0(AIMemento previous)
	{
		return default(bool);
	}

	[Token(Token = "0x6000830")]
	[Address(RVA = "0xA96540", Offset = "0xA96540", VA = "0xA96540")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6125E0", Offset = "0x6125E0")]
	private bool _003CPush_003Eb__49_0(AIMemento previous)
	{
		return default(bool);
	}
}
