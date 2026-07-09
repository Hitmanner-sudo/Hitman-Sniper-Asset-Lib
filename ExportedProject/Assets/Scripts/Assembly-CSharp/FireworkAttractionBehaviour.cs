using System;
using Il2CppDummyDll;

[Token(Token = "0x20000F4")]
public class FireworkAttractionBehaviour : AttractorBehaviour
{
	[Token(Token = "0x20000F5")]
	private enum State
	{
		[Token(Token = "0x4000579")]
		IsReacting = 0,
		[Token(Token = "0x400057A")]
		IsAttracted = 1
	}

	[Token(Token = "0x4000575")]
	[FieldOffset(Offset = "0x40")]
	private GameTimer _reactionTimer;

	[NonSerialized]
	[Token(Token = "0x4000576")]
	[FieldOffset(Offset = "0x48")]
	public VistaMemento Memento;

	[Token(Token = "0x4000577")]
	[FieldOffset(Offset = "0x50")]
	private State _state;

	[Token(Token = "0x1700013C")]
	public new FireworkAttractionEvaluator Evaluator
	{
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x9561E8", Offset = "0x9561E8", VA = "0x9561E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x956264", Offset = "0x956264", VA = "0x956264", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x9563E8", Offset = "0x9563E8", VA = "0x9563E8", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x95654C", Offset = "0x95654C", VA = "0x95654C")]
	private bool IsAttracted()
	{
		return default(bool);
	}

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x9564F0", Offset = "0x9564F0", VA = "0x9564F0")]
	private bool IsReacting()
	{
		return default(bool);
	}

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x956554", Offset = "0x956554", VA = "0x956554", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x9566D8", Offset = "0x9566D8", VA = "0x9566D8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x956790", Offset = "0x956790", VA = "0x956790", Slot = "4")]
	public override bool Equals(AIBehaviour other)
	{
		return default(bool);
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x956798", Offset = "0x956798", VA = "0x956798")]
	public FireworkAttractionBehaviour()
	{
	}
}
