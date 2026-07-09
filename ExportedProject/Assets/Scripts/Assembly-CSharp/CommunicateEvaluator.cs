using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20000EA")]
public class CommunicateEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x20000EB")]
	public class CommunicateBehaviourHistory
	{
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x10")]
		public List<Technology.Tuple<Memory, Vector3>> UnreachableTargets;

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x862984", Offset = "0x862984", VA = "0x862984")]
		public CommunicateBehaviourHistory()
		{
		}
	}

	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592428", Offset = "0x592428")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x10")]
		public AIMemento memento;

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x86287C", Offset = "0x86287C", VA = "0x86287C")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x862884", Offset = "0x862884", VA = "0x862884")]
		internal bool _003CEvaluate_003Eb__0(AIMemento x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592438", Offset = "0x592438")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x10")]
		public Memory memory;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x8628EC", Offset = "0x8628EC", VA = "0x8628EC")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x8628F4", Offset = "0x8628F4", VA = "0x8628F4")]
		internal bool _003CFindClosestTarget_003Eb__0(Technology.Tuple<Memory, Vector3> t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0x20")]
	public bool InPerson;

	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0x21")]
	public bool ToEveryone;

	[Token(Token = "0x4000541")]
	[FieldOffset(Offset = "0x22")]
	public bool ExpectFollowUp;

	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x24")]
	public ThreatLevel MinAlertLevel;

	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x28")]
	public ThreatLevel MaxAlertLevel;

	[Token(Token = "0x4000544")]
	[FieldOffset(Offset = "0x30")]
	public Faction[] FactionsToReportTo;

	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x38")]
	public float TimeBeforeSharingInfo;

	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x3C")]
	public float AnimationDuration;

	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0x40")]
	public float MaxCommunicateDistance;

	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x44")]
	public bool CommunicateAndForget;

	[NonSerialized]
	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0x48")]
	private readonly CommunicateBehaviour _behaviour;

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x8DDE34", Offset = "0x8DDE34", VA = "0x8DDE34")]
	public CommunicateEvaluator()
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x8DDEE0", Offset = "0x8DDEE0", VA = "0x8DDEE0", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x8DE924", Offset = "0x8DE924", VA = "0x8DE924")]
	private bool DoGuardsAlreadyKnow(AIMemento memento)
	{
		return default(bool);
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x8DE288", Offset = "0x8DE288", VA = "0x8DE288")]
	public static float FindClosestTarget(CommunicateBehaviour behaviour, AIMemento memento, AIController ai, out bool keepEvaluating)
	{
		return default(float);
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x8DCEC8", Offset = "0x8DCEC8", VA = "0x8DCEC8")]
	public static float FindClosestTarget(CommunicateBehaviour behaviour, AIMemento memento, AIController ai)
	{
		return default(float);
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x8DEB3C", Offset = "0x8DEB3C", VA = "0x8DEB3C", Slot = "5")]
	public override void CleanUp()
	{
	}
}
