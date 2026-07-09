using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x20000FC")]
public class InvestigateBehaviour : AttractorBehaviour, TaskIdle.IListener
{
	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592458", Offset = "0x592458")]
	private sealed class _003CDelayWaitForFollower_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x20")]
		public Memory follower;

		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x28")]
		public InvestigateBehaviour _003C_003E4__this;

		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x30")]
		private float _003Cdelay_003E5__2;

		[Token(Token = "0x1700013F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0xB27F98", Offset = "0xB27F98", VA = "0xB27F98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000140")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0xB27FE0", Offset = "0xB27FE0", VA = "0xB27FE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xB27B8C", Offset = "0xB27B8C", VA = "0xB27B8C")]
		[DebuggerHidden]
		public _003CDelayWaitForFollower_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xB27BB8", Offset = "0xB27BB8", VA = "0xB27BB8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xB27BBC", Offset = "0xB27BBC", VA = "0xB27BBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xB27FA0", Offset = "0xB27FA0", VA = "0xB27FA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400058D")]
	private const string S_MOVE_TO_ID = "InvestigateMoveTo";

	[Token(Token = "0x400058E")]
	[FieldOffset(Offset = "0x40")]
	internal AIMemento Memento;

	[Token(Token = "0x400058F")]
	[FieldOffset(Offset = "0x48")]
	private TaskIdle _task;

	[Token(Token = "0x4000590")]
	[FieldOffset(Offset = "0x50")]
	private bool _skipFollowerCheck;

	[Token(Token = "0x4000591")]
	[FieldOffset(Offset = "0x58")]
	private Timer _movementTimer;

	[Token(Token = "0x1700013E")]
	private new InvestigateEvaluator Evaluator
	{
		[Token(Token = "0x600071A")]
		[Address(RVA = "0xB1BCC0", Offset = "0xB1BCC0", VA = "0xB1BCC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0xB1BD3C", Offset = "0xB1BD3C", VA = "0xB1BD3C", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0xB1C5B0", Offset = "0xB1C5B0", VA = "0xB1C5B0")]
	private void Attractor_OnUseCompleted(object sender, Attractor.UseCompleteArgs e)
	{
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0xB1C5F4", Offset = "0xB1C5F4", VA = "0xB1C5F4", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0xB1C698", Offset = "0xB1C698", VA = "0xB1C698", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0xB1C448", Offset = "0xB1C448", VA = "0xB1C448")]
	private void UpdateTask()
	{
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0xB1C940", Offset = "0xB1C940", VA = "0xB1C940", Slot = "13")]
	private void TaskIdle_002EIListener_002EOnDestinationReached()
	{
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0xB1CAF8", Offset = "0xB1CAF8", VA = "0xB1CAF8", Slot = "14")]
	private void TaskIdle_002EIListener_002EOnDestinationUnreacheable()
	{
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0xB1CB28", Offset = "0xB1CB28", VA = "0xB1CB28", Slot = "15")]
	private void TaskIdle_002EIListener_002EOnIdleComplete()
	{
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0xB1CB58", Offset = "0xB1CB58", VA = "0xB1CB58", Slot = "4")]
	public override bool Equals(AIBehaviour other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0xB1CBF0", Offset = "0xB1CBF0", VA = "0xB1CBF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0xB1CA80", Offset = "0xB1CA80", VA = "0xB1CA80")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x612350", Offset = "0x612350")]
	private IEnumerator DelayWaitForFollower(Memory follower)
	{
		return null;
	}

	[Token(Token = "0x6000726")]
	[Address(RVA = "0xB1CD98", Offset = "0xB1CD98", VA = "0xB1CD98")]
	private void OnMementoInvestigated(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0xB1C404", Offset = "0xB1C404", VA = "0xB1C404")]
	private float GetInvesetigationDuration()
	{
		return default(float);
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0xB1CDA4", Offset = "0xB1CDA4", VA = "0xB1CDA4")]
	public InvestigateBehaviour()
	{
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0xB1CE08", Offset = "0xB1CE08", VA = "0xB1CE08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6123B0", Offset = "0x6123B0")]
	private bool _003CLaunch_003Eb__7_0(InvestigationOverride x)
	{
		return default(bool);
	}
}
