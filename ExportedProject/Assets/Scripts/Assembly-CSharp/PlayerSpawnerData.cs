using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C3")]
public class PlayerSpawnerData : MonoBehaviour
{
	[Token(Token = "0x400099B")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 YawRotationLimits;

	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 YawRotationLimitsInScope;

	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 PitchRotationLimits;

	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0xABA1CC", Offset = "0xABA1CC", VA = "0xABA1CC")]
	public PlayerSpawnerData()
	{
	}
}
