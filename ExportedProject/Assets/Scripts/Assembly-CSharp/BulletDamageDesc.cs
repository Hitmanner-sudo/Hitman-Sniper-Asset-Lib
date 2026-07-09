using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000379")]
public class BulletDamageDesc
{
	[Token(Token = "0x4001365")]
	[FieldOffset(Offset = "0x10")]
	public float DamageMultiplier;

	[Token(Token = "0x4001366")]
	[FieldOffset(Offset = "0x14")]
	public Damage.BodyPart Part;

	[Token(Token = "0x6001543")]
	[Address(RVA = "0xA85C80", Offset = "0xA85C80", VA = "0xA85C80")]
	public BulletDamageDesc()
	{
	}
}
