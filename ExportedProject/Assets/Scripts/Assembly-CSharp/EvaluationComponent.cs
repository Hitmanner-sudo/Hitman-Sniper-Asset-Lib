using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20000F2")]
public class EvaluationComponent : GameMonoBehaviour
{
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592448", Offset = "0x592448")]
	private sealed class _003CEvaluate_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x20")]
		public EvaluationComponent _003C_003E4__this;

		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x28")]
		private bool _003Csleeping_003E5__2;

		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x30")]
		private BehaviourEvaluator _003Cevaluator_003E5__3;

		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x38")]
		private AIBehaviour _003CnewBehaviour_003E5__4;

		[Token(Token = "0x1700013A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x86EE68", Offset = "0x86EE68", VA = "0x86EE68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x86EEB0", Offset = "0x86EEB0", VA = "0x86EEB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x86EABC", Offset = "0x86EABC", VA = "0x86EABC")]
		[DebuggerHidden]
		public _003CEvaluate_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x86EAE8", Offset = "0x86EAE8", VA = "0x86EAE8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x86EAEC", Offset = "0x86EAEC", VA = "0x86EAEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x86EE70", Offset = "0x86EE70", VA = "0x86EE70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000564")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0624", Offset = "0x5B0624")]
	private AIController _003CAI_003Ek__BackingField;

	[Token(Token = "0x4000565")]
	[FieldOffset(Offset = "0x50")]
	public List<BehaviourEvaluator> Evaluators;

	[Token(Token = "0x4000566")]
	[FieldOffset(Offset = "0x58")]
	private bool[] _sleepingEvaluators;

	[NonSerialized]
	[Token(Token = "0x4000567")]
	[FieldOffset(Offset = "0x60")]
	public bool TriggerEvaluation;

	[Token(Token = "0x4000568")]
	[FieldOffset(Offset = "0x64")]
	private float _nextScheduledEvaluation;

	[Token(Token = "0x4000569")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0634", Offset = "0x5B0634")]
	private float _003CLastEvaluationTime_003Ek__BackingField;

	[Token(Token = "0x400056A")]
	[FieldOffset(Offset = "0x6C")]
	private int _currentlyActiveEvaluator;

	[Token(Token = "0x400056B")]
	[FieldOffset(Offset = "0x70")]
	private int _currentlyEvaluating;

	[NonSerialized]
	[Token(Token = "0x400056C")]
	[FieldOffset(Offset = "0x74")]
	public bool KeepEvaluating;

	[Token(Token = "0x400056D")]
	[FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public float EvaluationPeriod;

	[Token(Token = "0x400056E")]
	[FieldOffset(Offset = "0x80")]
	private Coroutine _evaluateCoroutine;

	[Token(Token = "0x17000137")]
	public AIController AI
	{
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xE16470", Offset = "0xE16470", VA = "0xE16470")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612260", Offset = "0x612260")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xE16478", Offset = "0xE16478", VA = "0xE16478")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612270", Offset = "0x612270")]
		private set
		{
		}
	}

	[Token(Token = "0x17000138")]
	public BehaviourEvaluator ActiveEvaluator
	{
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xE16480", Offset = "0xE16480", VA = "0xE16480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000139")]
	public float LastEvaluationTime
	{
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xE164FC", Offset = "0xE164FC", VA = "0xE164FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612280", Offset = "0x612280")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xE16504", Offset = "0xE16504", VA = "0xE16504")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612290", Offset = "0x612290")]
		private set
		{
		}
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0xE1650C", Offset = "0xE1650C", VA = "0xE1650C")]
	public void StartEvaluation(AIController ai)
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0xE166CC", Offset = "0xE166CC", VA = "0xE166CC")]
	public void StopEvaluation()
	{
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0xE16700", Offset = "0xE16700", VA = "0xE16700", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0xE16660", Offset = "0xE16660", VA = "0xE16660")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6122A0", Offset = "0x6122A0")]
	private IEnumerator Evaluate()
	{
		return null;
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0xE167F8", Offset = "0xE167F8", VA = "0xE167F8")]
	private void ScheduleNextEvaluation()
	{
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0xE16928", Offset = "0xE16928", VA = "0xE16928")]
	public EvaluationComponent()
	{
	}
}
