using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200037A")]
public class BulletHoleDesc
{
	[Token(Token = "0x4001367")]
	[FieldOffset(Offset = "0x10")]
	public PhysicMaterial MaterialType;

	[Token(Token = "0x4001368")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BulletHolePrefab;

	[Token(Token = "0x6001544")]
	[Address(RVA = "0xA86514", Offset = "0xA86514", VA = "0xA86514")]
	public BulletHoleDesc()
	{
	}
}
