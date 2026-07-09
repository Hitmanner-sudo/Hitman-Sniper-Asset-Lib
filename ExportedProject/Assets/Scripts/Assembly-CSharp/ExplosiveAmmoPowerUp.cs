using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000333")]
public class ExplosiveAmmoPowerUp : PowerUp
{
	[Token(Token = "0x40011AF")]
	[FieldOffset(Offset = "0xA0")]
	public float ExplosionDamage;

	[Token(Token = "0x40011B0")]
	[FieldOffset(Offset = "0xA4")]
	public float ExplosionRadius;

	[Token(Token = "0x40011B1")]
	[FieldOffset(Offset = "0xA8")]
	public float ExplosionImpulse;

	[Token(Token = "0x40011B2")]
	[FieldOffset(Offset = "0xAC")]
	public float ExplosionCuriousDistance;

	[Token(Token = "0x40011B3")]
	[FieldOffset(Offset = "0xB0")]
	public float ExplosionSuspiciousDistance;

	[Token(Token = "0x40011B4")]
	[FieldOffset(Offset = "0xB4")]
	public bool ExplosionUniformDamage;

	[Token(Token = "0x40011B5")]
	[FieldOffset(Offset = "0xB8")]
	public DamageOverTime DotToApply;

	[Token(Token = "0x40011B6")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject ExplosionEffect;

	[Token(Token = "0x40011B7")]
	[FieldOffset(Offset = "0xC8")]
	private float _damageDelta;

	[Token(Token = "0x40011B8")]
	[FieldOffset(Offset = "0xCC")]
	private float _radiusDelta;

	[Token(Token = "0x40011B9")]
	[FieldOffset(Offset = "0xD0")]
	private float _impulseDelta;

	[Token(Token = "0x40011BA")]
	[FieldOffset(Offset = "0xD4")]
	private float _curiousDistanceDelta;

	[Token(Token = "0x40011BB")]
	[FieldOffset(Offset = "0xD8")]
	private float _suspiciousDistanceDelta;

	[Token(Token = "0x40011BC")]
	[FieldOffset(Offset = "0xDC")]
	private bool _explosionUniformDamage;

	[Token(Token = "0x6001372")]
	[Address(RVA = "0xE2024C", Offset = "0xE2024C", VA = "0xE2024C", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001373")]
	[Address(RVA = "0xE20388", Offset = "0xE20388", VA = "0xE20388", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001374")]
	[Address(RVA = "0xE2047C", Offset = "0xE2047C", VA = "0xE2047C")]
	public ExplosiveAmmoPowerUp()
	{
	}
}
