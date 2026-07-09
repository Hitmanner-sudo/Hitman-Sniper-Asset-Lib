using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000166")]
public class TaskWaypoint : AITask, TaskIdle.IListener
{
	[Token(Token = "0x2000167")]
	private enum State
	{
		[Token(Token = "0x4000788")]
		Start = 0,
		[Token(Token = "0x4000789")]
		Executing = 1
	}

	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0x28")]
	public Waypoint Waypoint;

	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0x30")]
	public int NavigationMask;

	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0x34")]
	public Vector3? StartPosition;

	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x44")]
	private State _state;

	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x48")]
	private string _taskID;

	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x50")]
	private TaskIdle _idle;

	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x58")]
	private bool _cacheIsTagged;

	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0x59")]
	private bool _cacheConsumeTag;

	[Token(Token = "0x4000786")]
	[FieldOffset(Offset = "0x5A")]
	private bool _completed;

	[Token(Token = "0x600096C")]
	[Address(RVA = "0xB58AF0", Offset = "0xB58AF0", VA = "0xB58AF0", Slot = "7")]
	public override ExecutionStatus Execute()
	{
		return default(ExecutionStatus);
	}

	[Token(Token = "0x600096D")]
	[Address(RVA = "0xB58CD0", Offset = "0xB58CD0", VA = "0xB58CD0")]
	private void StartMoving()
	{
	}

	[Token(Token = "0x600096E")]
	[Address(RVA = "0xB58E08", Offset = "0xB58E08", VA = "0xB58E08", Slot = "9")]
	private void TaskIdle_002EIListener_002EOnDestinationReached()
	{
	}

	[Token(Token = "0x600096F")]
	[Address(RVA = "0xB58F28", Offset = "0xB58F28", VA = "0xB58F28", Slot = "10")]
	private void TaskIdle_002EIListener_002EOnDestinationUnreacheable()
	{
	}

	[Token(Token = "0x6000970")]
	[Address(RVA = "0xB59058", Offset = "0xB59058", VA = "0xB59058", Slot = "11")]
	private void TaskIdle_002EIListener_002EOnIdleComplete()
	{
	}

	[Token(Token = "0x6000971")]
	[Address(RVA = "0xB59090", Offset = "0xB59090", VA = "0xB59090", Slot = "6")]
	public override void Stop()
	{
	}

	[Token(Token = "0x6000972")]
	[Address(RVA = "0xB591E8", Offset = "0xB591E8", VA = "0xB591E8")]
	public TaskWaypoint()
	{
	}
}
