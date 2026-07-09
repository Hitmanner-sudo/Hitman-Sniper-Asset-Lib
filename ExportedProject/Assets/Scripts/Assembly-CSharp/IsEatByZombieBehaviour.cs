using Il2CppDummyDll;

[Token(Token = "0x20000FF")]
public class IsEatByZombieBehaviour : AIBehaviour
{
	[Token(Token = "0x40005A2")]
	[FieldOffset(Offset = "0x38")]
	private TaskIdle _task;

	[Token(Token = "0x40005A3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string _taskID;

	[Token(Token = "0x17000141")]
	public new IsEatByZombieEvaluator Evaluator
	{
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x10BE2B0", Offset = "0x10BE2B0", VA = "0x10BE2B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x10BE32C", Offset = "0x10BE32C", VA = "0x10BE32C", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0x10BE4C0", Offset = "0x10BE4C0", VA = "0x10BE4C0", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0x10BE588", Offset = "0x10BE588", VA = "0x10BE588", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0x10BE7FC", Offset = "0x10BE7FC", VA = "0x10BE7FC")]
	public IsEatByZombieBehaviour()
	{
	}
}
