using Il2CppDummyDll;

[Token(Token = "0x2000106")]
public class PickUpBehaviour : AIBehaviour
{
	[Token(Token = "0x40005D5")]
	private const string s_PickupTaskID = "PickUp MoveTo";

	[Token(Token = "0x40005D6")]
	private const string s_TellTaskID = "PickUp Tell Task";

	[Token(Token = "0x40005D7")]
	[FieldOffset(Offset = "0x38")]
	private TaskInteract _task;

	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0x40")]
	public InventoryItem Item;

	[Token(Token = "0x17000146")]
	private new PickUpEvaluator Evaluator
	{
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x90A208", Offset = "0x90A208", VA = "0x90A208")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x90A284", Offset = "0x90A284", VA = "0x90A284", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x90A474", Offset = "0x90A474", VA = "0x90A474", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x90A498", Offset = "0x90A498", VA = "0x90A498", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x90A5BC", Offset = "0x90A5BC", VA = "0x90A5BC", Slot = "4")]
	public override bool Equals(AIBehaviour other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x90A6B0", Offset = "0x90A6B0", VA = "0x90A6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x90A71C", Offset = "0x90A71C", VA = "0x90A71C")]
	public PickUpBehaviour()
	{
	}
}
