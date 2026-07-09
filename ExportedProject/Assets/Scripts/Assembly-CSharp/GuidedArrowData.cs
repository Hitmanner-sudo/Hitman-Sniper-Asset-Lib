using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200037B")]
public class GuidedArrowData
{
	[Token(Token = "0x4001369")]
	[FieldOffset(Offset = "0x10")]
	public ThirdPersonCharacter CharacterToHeadShoot;

	[Token(Token = "0x400136A")]
	[FieldOffset(Offset = "0x18")]
	public float TimeBeforeSeeking;

	[Token(Token = "0x400136B")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 ArrowPositionAdjustent;

	[Token(Token = "0x400136C")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 CurrentArrowPositionAdjustent;

	[Token(Token = "0x400136D")]
	[FieldOffset(Offset = "0x2C")]
	public float ArrowPositionAdjustmentTime;

	[Token(Token = "0x6001545")]
	[Address(RVA = "0xC90674", Offset = "0xC90674", VA = "0xC90674")]
	public GuidedArrowData()
	{
	}
}
