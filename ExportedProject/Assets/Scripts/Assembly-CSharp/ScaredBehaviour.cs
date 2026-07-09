using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200010C")]
public class ScaredBehaviour : AttractorBehaviour
{
	[Token(Token = "0x200010D")]
	private enum State
	{
		[Token(Token = "0x40005F0")]
		IsReacting = 0,
		[Token(Token = "0x40005F1")]
		IsWandering = 1,
		[Token(Token = "0x40005F2")]
		IsAttracted = 2
	}

	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0x40")]
	private GameTimer _reactionTimer;

	[NonSerialized]
	[Token(Token = "0x40005EC")]
	[FieldOffset(Offset = "0x48")]
	public VistaMemento Memento;

	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 _initialPosition;

	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0x5C")]
	private State _state;

	[Token(Token = "0x17000147")]
	public new ScaredEvaluator Evaluator
	{
		[Token(Token = "0x6000776")]
		[Address(RVA = "0xBB1F00", Offset = "0xBB1F00", VA = "0xBB1F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0xBB1F7C", Offset = "0xBB1F7C", VA = "0xBB1F7C", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0xBB21E8", Offset = "0xBB21E8", VA = "0xBB21E8", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0xBB23B4", Offset = "0xBB23B4", VA = "0xBB23B4")]
	private bool IsAttracted()
	{
		return default(bool);
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0xBB22C0", Offset = "0xBB22C0", VA = "0xBB22C0")]
	private bool IsReacting()
	{
		return default(bool);
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0xBB23BC", Offset = "0xBB23BC", VA = "0xBB23BC")]
	private bool IsWandering()
	{
		return default(bool);
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0xBB2488", Offset = "0xBB2488", VA = "0xBB2488")]
	private Vector3 GetRandomPoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0xBB24E8", Offset = "0xBB24E8", VA = "0xBB24E8", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0xBB266C", Offset = "0xBB266C", VA = "0xBB266C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0xBB2724", Offset = "0xBB2724", VA = "0xBB2724", Slot = "4")]
	public override bool Equals(AIBehaviour other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0xBB272C", Offset = "0xBB272C", VA = "0xBB272C")]
	public ScaredBehaviour()
	{
	}
}
