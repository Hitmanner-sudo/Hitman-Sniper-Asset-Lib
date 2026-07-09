using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200015D")]
public class TaskIdle : AITask
{
	[Token(Token = "0x200015E")]
	private enum State
	{
		[Token(Token = "0x4000755")]
		Start = 0,
		[Token(Token = "0x4000756")]
		Moving = 1,
		[Token(Token = "0x4000757")]
		Turning = 2,
		[Token(Token = "0x4000758")]
		Waiting = 3
	}

	[Token(Token = "0x200015F")]
	public interface IListener
	{
		[Token(Token = "0x6000954")]
		void OnDestinationReached();

		[Token(Token = "0x6000955")]
		void OnDestinationUnreacheable();

		[Token(Token = "0x6000956")]
		void OnIdleComplete();
	}

	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x28")]
	public IListener Listener;

	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 Destination;

	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3? Orientation;

	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x4C")]
	public float ReachRadius;

	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x50")]
	public int NavigationMask;

	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x54")]
	public float Speed;

	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x58")]
	public AnimationConfig.IdleType IdleType;

	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x5C")]
	public bool StopAtRadius;

	[Token(Token = "0x400074C")]
	[FieldOffset(Offset = "0x60")]
	private float _idleDuration;

	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0x64")]
	public bool PrecisePositioning;

	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x68")]
	private State _state;

	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x70")]
	private GameTimer _idleTimer;

	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 _lastDestination;

	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 _adjustedDestination;

	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float PrecisePositioningRadius;

	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0x90")]
	private TaskMoveTo _moveTo;

	[Token(Token = "0x1700017E")]
	public float IdleDuration
	{
		[Token(Token = "0x6000947")]
		[Address(RVA = "0xB55F5C", Offset = "0xB55F5C", VA = "0xB55F5C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000948")]
		[Address(RVA = "0xB55F64", Offset = "0xB55F64", VA = "0xB55F64")]
		set
		{
		}
	}

	[Token(Token = "0x1700017F")]
	public float RemainingDuration
	{
		[Token(Token = "0x6000949")]
		[Address(RVA = "0xB55FFC", Offset = "0xB55FFC", VA = "0xB55FFC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600094A")]
	[Address(RVA = "0xB56018", Offset = "0xB56018", VA = "0xB56018")]
	public TaskIdle()
	{
	}

	[Token(Token = "0x600094B")]
	[Address(RVA = "0xB560D0", Offset = "0xB560D0", VA = "0xB560D0", Slot = "4")]
	public override void Paused(bool paused)
	{
	}

	[Token(Token = "0x600094C")]
	[Address(RVA = "0xB56148", Offset = "0xB56148", VA = "0xB56148", Slot = "7")]
	public override ExecutionStatus Execute()
	{
		return default(ExecutionStatus);
	}

	[Token(Token = "0x600094D")]
	[Address(RVA = "0xB56550", Offset = "0xB56550", VA = "0xB56550")]
	private void StartMoving()
	{
	}

	[Token(Token = "0x600094E")]
	[Address(RVA = "0xB566B4", Offset = "0xB566B4", VA = "0xB566B4")]
	private void OnDestinationReached()
	{
	}

	[Token(Token = "0x600094F")]
	[Address(RVA = "0xB56818", Offset = "0xB56818", VA = "0xB56818")]
	private void OnDestinationUnreacheable()
	{
	}

	[Token(Token = "0x6000950")]
	[Address(RVA = "0xB568DC", Offset = "0xB568DC", VA = "0xB568DC", Slot = "6")]
	public override void Stop()
	{
	}

	[Token(Token = "0x6000951")]
	[Address(RVA = "0xB569E8", Offset = "0xB569E8", VA = "0xB569E8", Slot = "8")]
	public override void DisplaySelected()
	{
	}

	[Token(Token = "0x6000952")]
	[Address(RVA = "0xB56B68", Offset = "0xB56B68", VA = "0xB56B68", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
