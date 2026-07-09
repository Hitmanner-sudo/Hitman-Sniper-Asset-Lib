using Il2CppDummyDll;

[Token(Token = "0x20000DF")]
public class ArrestedBehaviour : AIBehaviour
{
	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x34")]
	private bool _isArrested;

	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x38")]
	private Character _lastArrester;

	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string _taskID;

	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0x40")]
	private TaskIdle _task;

	[Token(Token = "0x6000693")]
	[Address(RVA = "0xBFF8B4", Offset = "0xBFF8B4", VA = "0xBFF8B4", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0xBFF9AC", Offset = "0xBFF9AC", VA = "0xBFF9AC", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0xBFFB94", Offset = "0xBFFB94", VA = "0xBFFB94", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000696")]
	[Address(RVA = "0xBFFCCC", Offset = "0xBFFCCC", VA = "0xBFFCCC")]
	public ArrestedBehaviour()
	{
	}
}
