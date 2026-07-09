using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x2000902")]
public class FSM
{
	[Token(Token = "0x2000903")]
	public class StateChangedEvent : EventArgs
	{
		[Token(Token = "0x4003197")]
		[FieldOffset(Offset = "0x10")]
		public FSMState PreviousState;

		[Token(Token = "0x4003198")]
		[FieldOffset(Offset = "0x18")]
		public FSMState NewState;

		[Token(Token = "0x60039D3")]
		[Address(RVA = "0x8701A0", Offset = "0x8701A0", VA = "0x8701A0")]
		public StateChangedEvent()
		{
		}
	}

	[Token(Token = "0x2000904")]
	public delegate bool TransitionHandler(FSMState instance);

	[Token(Token = "0x2000905")]
	private struct Transition
	{
		[Token(Token = "0x4003199")]
		[FieldOffset(Offset = "0x0")]
		public readonly Type TargetState;

		[Token(Token = "0x400319A")]
		[FieldOffset(Offset = "0x8")]
		public readonly int Priority;

		[Token(Token = "0x400319B")]
		[FieldOffset(Offset = "0x10")]
		public readonly TransitionHandler Handler;

		[Token(Token = "0x60039D8")]
		[Address(RVA = "0x87027C", Offset = "0x87027C", VA = "0x87027C")]
		public Transition(Type targetState, int priority, TransitionHandler handler)
		{
		}
	}

	[Token(Token = "0x2000906")]
	private class TransitionComparer : IComparer<Transition>
	{
		[Token(Token = "0x60039D9")]
		[Address(RVA = "0x87028C", Offset = "0x87028C", VA = "0x87028C", Slot = "4")]
		private int System_002ECollections_002EGeneric_002EIComparer_003CFSM_002ETransition_003E_002ECompare(Transition x, Transition y)
		{
			return default(int);
		}

		[Token(Token = "0x60039DA")]
		[Address(RVA = "0x87029C", Offset = "0x87029C", VA = "0x87029C")]
		public TransitionComparer()
		{
		}
	}

	[Token(Token = "0x2000907")]
	private class StateData
	{
		[Token(Token = "0x400319C")]
		[FieldOffset(Offset = "0x10")]
		public List<Transition> Transitions;

		[Token(Token = "0x400319D")]
		[FieldOffset(Offset = "0x18")]
		public Stack<FSMState> FreeInstances;

		[Token(Token = "0x60039DB")]
		[Address(RVA = "0x870204", Offset = "0x870204", VA = "0x870204")]
		public StateData()
		{
		}
	}

	[Token(Token = "0x400318F")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBA84", Offset = "0x5BBA84")]
	private FSMState _003CState_003Ek__BackingField;

	[Token(Token = "0x4003190")]
	[FieldOffset(Offset = "0x18")]
	private Type _initialState;

	[Token(Token = "0x4003192")]
	[FieldOffset(Offset = "0x28")]
	private StateChangedEvent _cachedEvent;

	[Token(Token = "0x4003193")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<Type, StateData> _states;

	[Token(Token = "0x4003194")]
	[FieldOffset(Offset = "0x30")]
	private StateData _currentStateData;

	[Token(Token = "0x4003195")]
	[FieldOffset(Offset = "0x38")]
	private List<Transition> _activeTransitions;

	[Token(Token = "0x4003196")]
	[FieldOffset(Offset = "0x40")]
	public Blackboard Blackboard;

	[Token(Token = "0x17000749")]
	public FSMState State
	{
		[Token(Token = "0x60039C1")]
		[Address(RVA = "0x94CD48", Offset = "0x94CD48", VA = "0x94CD48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624780", Offset = "0x624780")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039C2")]
		[Address(RVA = "0x94CD50", Offset = "0x94CD50", VA = "0x94CD50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624790", Offset = "0x624790")]
		private set
		{
		}
	}

	[Token(Token = "0x140000B2")]
	public event EventHandler<StateChangedEvent> StateChanged
	{
		[Token(Token = "0x60039C3")]
		[Address(RVA = "0x94CD58", Offset = "0x94CD58", VA = "0x94CD58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6247A0", Offset = "0x6247A0")]
		add
		{
		}
		[Token(Token = "0x60039C4")]
		[Address(RVA = "0x94CDF8", Offset = "0x94CDF8", VA = "0x94CDF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6247B0", Offset = "0x6247B0")]
		remove
		{
		}
	}

	[Token(Token = "0x60039C5")]
	[Address(RVA = "0x94CE98", Offset = "0x94CE98", VA = "0x94CE98")]
	public FSM(Type initialState)
	{
	}

	[Token(Token = "0x60039C6")]
	[Address(RVA = "0x94CF3C", Offset = "0x94CF3C", VA = "0x94CF3C", Slot = "1")]
	~FSM()
	{
	}

	[Token(Token = "0x60039C7")]
	[Address(RVA = "0x94CFEC", Offset = "0x94CFEC", VA = "0x94CFEC")]
	public void Destroy()
	{
	}

	[Token(Token = "0x60039C8")]
	[Address(RVA = "0x94D034", Offset = "0x94D034", VA = "0x94D034", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60039C9")]
	[Address(RVA = "0x94D054", Offset = "0x94D054", VA = "0x94D054")]
	public void Run()
	{
	}

	[Token(Token = "0x60039CA")]
	[Address(RVA = "0x94D3CC", Offset = "0x94D3CC", VA = "0x94D3CC")]
	private static StateData PopulateTransitions(Type stateType)
	{
		return null;
	}

	[Token(Token = "0x60039CB")]
	[Address(RVA = "0x94D8E4", Offset = "0x94D8E4", VA = "0x94D8E4")]
	private void SetTransitions(List<Transition> transitions)
	{
	}

	[Token(Token = "0x60039CC")]
	[Address(RVA = "0x94D8EC", Offset = "0x94D8EC", VA = "0x94D8EC")]
	public bool IsInState(Type state)
	{
		return default(bool);
	}

	[Token(Token = "0x60039CD")]
	[Address(RVA = "0x94D2B0", Offset = "0x94D2B0", VA = "0x94D2B0")]
	private void TestTransitions()
	{
	}

	[Token(Token = "0x60039CE")]
	[Address(RVA = "0x94D0F4", Offset = "0x94D0F4", VA = "0x94D0F4")]
	public void SetState(Type newStateType)
	{
	}

	[Token(Token = "0x60039CF")]
	[Address(RVA = "0x94D940", Offset = "0x94D940", VA = "0x94D940")]
	public static FSMState GetStateInstance(Type stateType)
	{
		return null;
	}

	[Token(Token = "0x60039D0")]
	[Address(RVA = "0x94DA6C", Offset = "0x94DA6C", VA = "0x94DA6C", Slot = "4")]
	public virtual void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60039D1")]
	[Address(RVA = "0x94DA8C", Offset = "0x94DA8C", VA = "0x94DA8C", Slot = "5")]
	public virtual void OnDrawGizmosSelected()
	{
	}
}
