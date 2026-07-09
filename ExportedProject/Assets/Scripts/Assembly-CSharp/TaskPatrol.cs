using Il2CppDummyDll;

[Token(Token = "0x2000165")]
public class TaskPatrol : AITask
{
	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0x28")]
	public Patrol Patrol;

	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x30")]
	public int Index;

	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x34")]
	private bool _lastPoint;

	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0x38")]
	private Waypoint _currentWaypoint;

	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x40")]
	private Waypoint _nextWaypoint;

	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0x48")]
	private int _pointsVisited;

	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x4C")]
	private bool _completed;

	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x50")]
	private int _backAndForthDirection;

	[Token(Token = "0x6000969")]
	[Address(RVA = "0xB585FC", Offset = "0xB585FC", VA = "0xB585FC", Slot = "7")]
	public override ExecutionStatus Execute()
	{
		return default(ExecutionStatus);
	}

	[Token(Token = "0x600096A")]
	[Address(RVA = "0xB58994", Offset = "0xB58994", VA = "0xB58994", Slot = "6")]
	public override void Stop()
	{
	}

	[Token(Token = "0x600096B")]
	[Address(RVA = "0xB58AE0", Offset = "0xB58AE0", VA = "0xB58AE0")]
	public TaskPatrol()
	{
	}
}
