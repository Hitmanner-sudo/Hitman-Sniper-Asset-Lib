using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20001CD")]
public class BoneInfo
{
	[Token(Token = "0x40009C9")]
	[FieldOffset(Offset = "0x10")]
	public Inventory.BoneID BoneID;

	[Token(Token = "0x40009CA")]
	[FieldOffset(Offset = "0x18")]
	public string BoneTransformName;

	[Token(Token = "0x40009CB")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 BoneOffset;

	[Token(Token = "0x40009CC")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 BoneRotation;

	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0xA7F0E8", Offset = "0xA7F0E8", VA = "0xA7F0E8")]
	public BoneInfo()
	{
	}
}
