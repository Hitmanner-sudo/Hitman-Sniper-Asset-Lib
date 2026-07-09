using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000394")]
public class TaggingData : ScriptableObject
{
	[Token(Token = "0x400141A")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve TagSnapToBlend;

	[Token(Token = "0x400141B")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve TagSnapToDuration;

	[Token(Token = "0x400141C")]
	[FieldOffset(Offset = "0x28")]
	public float TagSnapToStickDuration;

	[Token(Token = "0x400141D")]
	[FieldOffset(Offset = "0x2C")]
	public float TagSnapToCancelMovement;

	[Token(Token = "0x60015E1")]
	[Address(RVA = "0xB4DE28", Offset = "0xB4DE28", VA = "0xB4DE28")]
	public TaggingData()
	{
	}
}
