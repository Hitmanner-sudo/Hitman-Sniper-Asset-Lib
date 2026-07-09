using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000250")]
[Scope]
public class MissionConfig : GameSingleton<MissionConfig>
{
	[Token(Token = "0x4000CD5")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 YawRotationLimits;

	[Token(Token = "0x4000CD6")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 PitchRotationLimits;

	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x9C39D0", Offset = "0x9C39D0", VA = "0x9C39D0")]
	public MissionConfig()
	{
	}
}
