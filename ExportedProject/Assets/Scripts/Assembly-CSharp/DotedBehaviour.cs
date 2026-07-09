using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000EF")]
public class DotedBehaviour : AttractorBehaviour
{
	[Token(Token = "0x20000F0")]
	private enum State
	{
		[Token(Token = "0x4000556")]
		IsReacting = 0,
		[Token(Token = "0x4000557")]
		IsWandering = 1,
		[Token(Token = "0x4000558")]
		IsAttracted = 2
	}

	[Token(Token = "0x400054F")]
	[FieldOffset(Offset = "0x40")]
	private GameTimer _reactionTimer;

	[NonSerialized]
	[Token(Token = "0x4000550")]
	[FieldOffset(Offset = "0x48")]
	public VistaMemento Memento;

	[Token(Token = "0x4000551")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 _initialPosition;

	[Token(Token = "0x4000552")]
	[FieldOffset(Offset = "0x5C")]
	private bool _oldHurtingState;

	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x5D")]
	private bool _oldAdjustSpeedWhenWounded;

	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x60")]
	private State _state;

	[Token(Token = "0x17000136")]
	public new DotedEvaluator Evaluator
	{
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xC189F8", Offset = "0xC189F8", VA = "0xC189F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0xC18A74", Offset = "0xC18A74", VA = "0xC18A74", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0xC18D28", Offset = "0xC18D28", VA = "0xC18D28", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0xC18EFC", Offset = "0xC18EFC", VA = "0xC18EFC")]
	private bool IsAttracted()
	{
		return default(bool);
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0xC18E08", Offset = "0xC18E08", VA = "0xC18E08")]
	private bool IsReacting()
	{
		return default(bool);
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0xC18F04", Offset = "0xC18F04", VA = "0xC18F04")]
	private bool IsWandering()
	{
		return default(bool);
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0xC18FD0", Offset = "0xC18FD0", VA = "0xC18FD0")]
	private Vector3 GetRandomPoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0xC19030", Offset = "0xC19030", VA = "0xC19030", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0xC19244", Offset = "0xC19244", VA = "0xC19244", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0xC192FC", Offset = "0xC192FC", VA = "0xC192FC", Slot = "4")]
	public override bool Equals(AIBehaviour other)
	{
		return default(bool);
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0xC19304", Offset = "0xC19304", VA = "0xC19304")]
	public DotedBehaviour()
	{
	}
}
