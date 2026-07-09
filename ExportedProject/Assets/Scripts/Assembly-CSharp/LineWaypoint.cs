using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000D0")]
public class LineWaypoint : Waypoint
{
	[Token(Token = "0x20000D1")]
	public enum LineType
	{
		[Token(Token = "0x40004D5")]
		ClosestPoint = 0,
		[Token(Token = "0x40004D6")]
		Spread = 1,
		[Token(Token = "0x40004D7")]
		Queue = 2
	}

	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0xE8")]
	public Vector3 RelativeStart;

	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0xF4")]
	public Vector3 RelativeEnd;

	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x100")]
	public LineType Type;

	[Token(Token = "0x1700012E")]
	public Vector3 StartPos
	{
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x9C91D0", Offset = "0x9C91D0", VA = "0x9C91D0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x9C9214", Offset = "0x9C9214", VA = "0x9C9214")]
		set
		{
		}
	}

	[Token(Token = "0x1700012F")]
	public Vector3 EndPos
	{
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x9C929C", Offset = "0x9C929C", VA = "0x9C929C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x9C92E0", Offset = "0x9C92E0", VA = "0x9C92E0")]
		set
		{
		}
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0x9C9368", Offset = "0x9C9368", VA = "0x9C9368", Slot = "18")]
	public override Vector3 GetDestination(AIController ai)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0x9C9514", Offset = "0x9C9514", VA = "0x9C9514", Slot = "19")]
	public override Vector3 GetDirection(AIController ai)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0x9C9580", Offset = "0x9C9580", VA = "0x9C9580")]
	private void SortUsers()
	{
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x9C9630", Offset = "0x9C9630", VA = "0x9C9630")]
	private void CleanUsers()
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x9C97EC", Offset = "0x9C97EC", VA = "0x9C97EC", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x9C9820", Offset = "0x9C9820", VA = "0x9C9820")]
	public LineWaypoint()
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x9C9840", Offset = "0x9C9840", VA = "0x9C9840")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x612120", Offset = "0x612120")]
	private int _003CSortUsers_003Eb__12_0(AIController a, AIController b)
	{
		return default(int);
	}
}
