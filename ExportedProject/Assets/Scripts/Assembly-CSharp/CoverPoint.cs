using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000C9")]
public class CoverPoint : Waypoint
{
	[Token(Token = "0x20000CA")]
	public enum CoverType
	{
		[Token(Token = "0x40004C4")]
		[HideInInspector]
		None = 0,
		[Token(Token = "0x40004C5")]
		CrouchLeft = 1,
		[Token(Token = "0x40004C6")]
		CrouchRight = 2,
		[Token(Token = "0x40004C7")]
		StandLeft = 3,
		[Token(Token = "0x40004C8")]
		StandRight = 4
	}

	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0xE8")]
	public CoverType Type;

	[Token(Token = "0x6000616")]
	[Address(RVA = "0xD80918", Offset = "0xD80918", VA = "0xD80918", Slot = "16")]
	protected override void Register()
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0xD80990", Offset = "0xD80990", VA = "0xD80990", Slot = "17")]
	protected override void UnRegister()
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0xD80A08", Offset = "0xD80A08", VA = "0xD80A08", Slot = "20")]
	public override void StartUsing(AIController ai)
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0xD80A90", Offset = "0xD80A90", VA = "0xD80A90", Slot = "27")]
	public override void OnReached(AIController ai)
	{
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0xD80C68", Offset = "0xD80C68", VA = "0xD80C68", Slot = "24")]
	public override float GetDistanceSqr(AIController ai)
	{
		return default(float);
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0xD80D00", Offset = "0xD80D00", VA = "0xD80D00", Slot = "25")]
	protected override void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600061C")]
	[Address(RVA = "0xD80D08", Offset = "0xD80D08", VA = "0xD80D08")]
	public CoverPoint()
	{
	}
}
