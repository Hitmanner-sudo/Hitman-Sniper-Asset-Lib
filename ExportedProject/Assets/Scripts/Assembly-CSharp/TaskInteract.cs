using Il2CppDummyDll;

[Token(Token = "0x2000161")]
public class TaskInteract : AITask
{
	[Token(Token = "0x2000162")]
	private enum State
	{
		[Token(Token = "0x4000760")]
		Start = 0,
		[Token(Token = "0x4000761")]
		Moving = 1,
		[Token(Token = "0x4000762")]
		Turning = 2,
		[Token(Token = "0x4000763")]
		Interacting = 3
	}

	[Token(Token = "0x400075B")]
	[FieldOffset(Offset = "0x28")]
	public Interaction Interaction;

	[Token(Token = "0x400075C")]
	[FieldOffset(Offset = "0x30")]
	public float Speed;

	[Token(Token = "0x400075D")]
	[FieldOffset(Offset = "0x34")]
	private State _state;

	[Token(Token = "0x400075E")]
	[FieldOffset(Offset = "0x38")]
	private TaskMoveTo _moveToTask;

	[Token(Token = "0x6000958")]
	[Address(RVA = "0xB56E8C", Offset = "0xB56E8C", VA = "0xB56E8C")]
	public TaskInteract()
	{
	}

	[Token(Token = "0x6000959")]
	[Address(RVA = "0xB56EC8", Offset = "0xB56EC8", VA = "0xB56EC8", Slot = "7")]
	public override ExecutionStatus Execute()
	{
		return default(ExecutionStatus);
	}

	[Token(Token = "0x600095A")]
	[Address(RVA = "0xB570D8", Offset = "0xB570D8", VA = "0xB570D8")]
	private void StartMoving()
	{
	}

	[Token(Token = "0x600095B")]
	[Address(RVA = "0xB5718C", Offset = "0xB5718C", VA = "0xB5718C")]
	private void UpdateDestination()
	{
	}

	[Token(Token = "0x600095C")]
	[Address(RVA = "0xB57240", Offset = "0xB57240", VA = "0xB57240", Slot = "6")]
	public override void Stop()
	{
	}

	[Token(Token = "0x600095D")]
	[Address(RVA = "0xB57370", Offset = "0xB57370", VA = "0xB57370", Slot = "8")]
	public override void DisplaySelected()
	{
	}
}
