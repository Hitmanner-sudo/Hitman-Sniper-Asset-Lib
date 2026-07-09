using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000163")]
public class TaskMoveTo : AITask
{
	[Token(Token = "0x2000164")]
	private enum MoveToState
	{
		[Token(Token = "0x4000774")]
		Moving = 0,
		[Token(Token = "0x4000775")]
		Turning = 1
	}

	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 Destination;

	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 AdjustedDestination;

	[Token(Token = "0x4000766")]
	[FieldOffset(Offset = "0x40")]
	public Vector3? DestinationOrientation;

	[Token(Token = "0x4000767")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 _lastDestination;

	[Token(Token = "0x4000768")]
	[FieldOffset(Offset = "0x60")]
	private readonly NavMeshPath _path;

	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x68")]
	private bool _reversed;

	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x6C")]
	private int _currentCornerIndex;

	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0x70")]
	public float Speed;

	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x74")]
	private float _reachRadiusSqr;

	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x78")]
	public int NavigationMask;

	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x7C")]
	public bool StopAtDestination;

	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x80")]
	public Vector3? StartPosition;

	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x90")]
	private bool _failed;

	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0x91")]
	private bool _moveCompleted;

	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x94")]
	private MoveToState _state;

	[Token(Token = "0x17000180")]
	public float ReachRadius
	{
		[Token(Token = "0x600095E")]
		[Address(RVA = "0xB568D0", Offset = "0xB568D0", VA = "0xB568D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000181")]
	private int CurrentCornerIndex
	{
		[Token(Token = "0x600095F")]
		[Address(RVA = "0xB574EC", Offset = "0xB574EC", VA = "0xB574EC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000960")]
	[Address(RVA = "0xB57540", Offset = "0xB57540", VA = "0xB57540")]
	public TaskMoveTo()
	{
	}

	[Token(Token = "0x6000961")]
	[Address(RVA = "0xB575D4", Offset = "0xB575D4", VA = "0xB575D4", Slot = "5")]
	public override void Start(AIController newAI)
	{
	}

	[Token(Token = "0x6000962")]
	[Address(RVA = "0xB57600", Offset = "0xB57600", VA = "0xB57600", Slot = "7")]
	public override ExecutionStatus Execute()
	{
		return default(ExecutionStatus);
	}

	[Token(Token = "0x6000963")]
	[Address(RVA = "0xB577A4", Offset = "0xB577A4", VA = "0xB577A4")]
	private ExecutionStatus Move()
	{
		return default(ExecutionStatus);
	}

	[Token(Token = "0x6000964")]
	[Address(RVA = "0xB57FA4", Offset = "0xB57FA4", VA = "0xB57FA4")]
	private bool HasReached(bool lastNode)
	{
		return default(bool);
	}

	[Token(Token = "0x6000965")]
	[Address(RVA = "0xB56650", Offset = "0xB56650", VA = "0xB56650")]
	public static bool HasReached(AIController controller, Vector3 position, float reachRadiusSqr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000966")]
	[Address(RVA = "0xB58314", Offset = "0xB58314", VA = "0xB58314", Slot = "6")]
	public override void Stop()
	{
	}

	[Token(Token = "0x6000967")]
	[Address(RVA = "0xB58390", Offset = "0xB58390", VA = "0xB58390", Slot = "8")]
	public override void DisplaySelected()
	{
	}

	[Token(Token = "0x6000968")]
	[Address(RVA = "0xB582D8", Offset = "0xB582D8", VA = "0xB582D8")]
	private float IntermediateReachRadiusSqr(float speed)
	{
		return default(float);
	}
}
