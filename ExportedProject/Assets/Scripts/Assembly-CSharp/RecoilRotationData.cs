using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200038C")]
public class RecoilRotationData : RecoilData
{
	[Token(Token = "0x40013BB")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 MinAngle;

	[Token(Token = "0x40013BC")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 MaxAngle;

	[Token(Token = "0x6001593")]
	[Address(RVA = "0xB428B4", Offset = "0xB428B4", VA = "0xB428B4", Slot = "4")]
	public override RecoilItem CreateRecoilItem()
	{
		return null;
	}

	[Token(Token = "0x6001594")]
	[Address(RVA = "0xB42914", Offset = "0xB42914", VA = "0xB42914")]
	public RecoilRotationData()
	{
	}
}
