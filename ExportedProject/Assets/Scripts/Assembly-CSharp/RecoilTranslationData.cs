using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200038E")]
public class RecoilTranslationData : RecoilData
{
	[Token(Token = "0x40013BE")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 JumpDelta;

	[Token(Token = "0x40013BF")]
	[FieldOffset(Offset = "0x40")]
	public float JumpMax;

	[Token(Token = "0x40013C0")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 MinDirection;

	[Token(Token = "0x40013C1")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 MaxDirection;

	[Token(Token = "0x600159B")]
	[Address(RVA = "0xB43190", Offset = "0xB43190", VA = "0xB43190", Slot = "4")]
	public override RecoilItem CreateRecoilItem()
	{
		return null;
	}

	[Token(Token = "0x600159C")]
	[Address(RVA = "0xB431F0", Offset = "0xB431F0", VA = "0xB431F0")]
	public RecoilTranslationData()
	{
	}
}
