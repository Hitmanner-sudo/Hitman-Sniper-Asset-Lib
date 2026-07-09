using System;
using Il2CppDummyDll;

[Token(Token = "0x2000900")]
public abstract class FSMState
{
	[Token(Token = "0x2000901")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x596DF4", Offset = "0x596DF4")]
	public class TransitionAttribute : Attribute
	{
		[Token(Token = "0x400318D")]
		[FieldOffset(Offset = "0x10")]
		public Type TargetState;

		[Token(Token = "0x400318E")]
		[FieldOffset(Offset = "0x18")]
		public int Priority;

		[Token(Token = "0x60039C0")]
		[Address(RVA = "0x8706D8", Offset = "0x8706D8", VA = "0x8706D8")]
		public TransitionAttribute(Type targetState, int priority = 0)
		{
		}
	}

	[Token(Token = "0x400318C")]
	[FieldOffset(Offset = "0x10")]
	protected FSM _parentFSM;

	[Token(Token = "0x60039B8")]
	[Address(RVA = "0x94DB34", Offset = "0x94DB34", VA = "0x94DB34", Slot = "4")]
	public virtual void Init(FSM parentFSM)
	{
	}

	[Token(Token = "0x60039B9")]
	public abstract void Enter();

	[Token(Token = "0x60039BA")]
	public abstract void Execute();

	[Token(Token = "0x60039BB")]
	public abstract void Exit();

	[Token(Token = "0x60039BC")]
	[Address(RVA = "0x94DB3C", Offset = "0x94DB3C", VA = "0x94DB3C", Slot = "8")]
	public virtual void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60039BD")]
	[Address(RVA = "0x94DB40", Offset = "0x94DB40", VA = "0x94DB40", Slot = "9")]
	public virtual void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60039BE")]
	[Address(RVA = "0x94DB44", Offset = "0x94DB44", VA = "0x94DB44", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60039BF")]
	[Address(RVA = "0x94DB6C", Offset = "0x94DB6C", VA = "0x94DB6C")]
	protected FSMState()
	{
	}
}
