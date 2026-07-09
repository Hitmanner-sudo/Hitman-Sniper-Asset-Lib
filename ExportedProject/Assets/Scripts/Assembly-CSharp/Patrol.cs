using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20000D2")]
public class Patrol : Attractor
{
	[Token(Token = "0x20000D3")]
	public enum StartSelection
	{
		[Token(Token = "0x40004DF")]
		First = 0,
		[Token(Token = "0x40004E0")]
		Closest = 1,
		[Token(Token = "0x40004E1")]
		Resume = 2,
		[Token(Token = "0x40004E2")]
		ClosestResume = 3,
		[Token(Token = "0x40004E3")]
		Next = 4
	}

	[Token(Token = "0x20000D4")]
	public enum PatrolMode
	{
		[Token(Token = "0x40004E5")]
		Loop = 0,
		[Token(Token = "0x40004E6")]
		Once = 1,
		[Token(Token = "0x40004E7")]
		BackAndForth = 2,
		[Token(Token = "0x40004E8")]
		Random = 3
	}

	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0xA8")]
	public List<Waypoint> Points;

	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0xB0")]
	public int MaximumNumberOfPoints;

	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0xB4")]
	public StartSelection StartAt;

	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0xB8")]
	public PatrolMode Mode;

	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0xC0")]
	private readonly SlowMorphRandom _randomizer;

	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0xC8")]
	private string _taskID;

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x8F6278", Offset = "0x8F6278", VA = "0x8F6278", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x8F64BC", Offset = "0x8F64BC", VA = "0x8F64BC", Slot = "14")]
	public override FilterType Filter(AIController ai)
	{
		return default(FilterType);
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x8F6538", Offset = "0x8F6538", VA = "0x8F6538", Slot = "20")]
	public override void StartUsing(AIController ai)
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x8F668C", Offset = "0x8F668C", VA = "0x8F668C")]
	private void ChooseClosestPoint(AIController ai, TaskPatrol task)
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x8F6D70", Offset = "0x8F6D70", VA = "0x8F6D70")]
	private void ChooseClosestResume(AIController ai, TaskPatrol task)
	{
	}

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x8F690C", Offset = "0x8F690C", VA = "0x8F690C")]
	private void ChooseResume(AIController ai, TaskPatrol task)
	{
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x8F6B00", Offset = "0x8F6B00", VA = "0x8F6B00")]
	private void ChooseNext(AIController ai, TaskPatrol task)
	{
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x8F6F90", Offset = "0x8F6F90", VA = "0x8F6F90", Slot = "21")]
	public override void StopUsing(AIController ai)
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x8F6FD0", Offset = "0x8F6FD0", VA = "0x8F6FD0", Slot = "22")]
	public override bool IsUsing(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x8F7044", Offset = "0x8F7044", VA = "0x8F7044")]
	public bool IncrementIndex(ref int index, ref int backAndForthDirection, int pointsVisited)
	{
		return default(bool);
	}

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x8F71A8", Offset = "0x8F71A8", VA = "0x8F71A8")]
	private void OnWaypointDestroyed(Waypoint waypoint)
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x8F7278", Offset = "0x8F7278", VA = "0x8F7278")]
	public Patrol()
	{
	}
}
