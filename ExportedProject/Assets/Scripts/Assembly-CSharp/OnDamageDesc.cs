using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20001A9")]
public class OnDamageDesc
{
	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0x10")]
	public float DamageMultiplier;

	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0x18")]
	public LazyGameObject[] HitEffectPrefab;

	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x20")]
	public Damage.BodyPart Part;

	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B210C", Offset = "0x5B210C")]
	public float PenetrationRatio;

	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0x9F66C8", Offset = "0x9F66C8", VA = "0x9F66C8")]
	public OnDamageDesc()
	{
	}
}
