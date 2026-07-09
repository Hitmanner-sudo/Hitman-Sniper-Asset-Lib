using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A4")]
public struct ForceData
{
	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 Force;

	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 Position;

	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x18")]
	public ForceMode Mode;

	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x959EA0", Offset = "0x959EA0", VA = "0x959EA0")]
	public void ApplyForceToRigidBody()
	{
	}

	[Token(Token = "0x6000B21")]
	[Address(RVA = "0x959ED0", Offset = "0x959ED0", VA = "0x959ED0")]
	public void SetForceMagnitude(float mag)
	{
	}
}
