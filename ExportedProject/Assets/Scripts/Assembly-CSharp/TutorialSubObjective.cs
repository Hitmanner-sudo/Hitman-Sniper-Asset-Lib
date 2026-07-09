using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200025B")]
public class TutorialSubObjective
{
	[Token(Token = "0x4000D0A")]
	[FieldOffset(Offset = "0x10")]
	public TargetGroup TargetGroup;

	[Token(Token = "0x4000D0B")]
	[FieldOffset(Offset = "0x18")]
	public TargetType[] ActivationSequence;

	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0xCAAA20", Offset = "0xCAAA20", VA = "0xCAAA20")]
	public TutorialSubObjective()
	{
	}
}
