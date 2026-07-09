using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000348")]
public class MortarPowerUp : SpawnOnImpactPowerUp
{
	[Token(Token = "0x400120A")]
	[FieldOffset(Offset = "0xB8")]
	public float BulletSpeed;

	[Token(Token = "0x400120B")]
	[FieldOffset(Offset = "0xBC")]
	public float BulletGravity;

	[Token(Token = "0x400120C")]
	[FieldOffset(Offset = "0xC0")]
	private float _oldBulletSpeed;

	[Token(Token = "0x400120D")]
	[FieldOffset(Offset = "0xC4")]
	private float _oldBulletGravity;

	[Token(Token = "0x400120E")]
	[FieldOffset(Offset = "0xC8")]
	private bool _oldEmitsRicochetMemento;

	[Token(Token = "0x400120F")]
	[FieldOffset(Offset = "0xC9")]
	private bool _oldEmitsFlyByMemento;

	[Token(Token = "0x4001210")]
	[FieldOffset(Offset = "0xCA")]
	private bool _oldInstaBulletDisabledOverride;

	[Token(Token = "0x60013D8")]
	[Address(RVA = "0xA2C5A8", Offset = "0xA2C5A8", VA = "0xA2C5A8", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60013D9")]
	[Address(RVA = "0xA2C67C", Offset = "0xA2C67C", VA = "0xA2C67C", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x60013DA")]
	[Address(RVA = "0xA2C724", Offset = "0xA2C724", VA = "0xA2C724", Slot = "19")]
	protected override void PreEnabledFunction(GameObject spawnedGameObject, long bulletID, Bullet.Hit hit)
	{
	}

	[Token(Token = "0x60013DB")]
	[Address(RVA = "0xA2C7D0", Offset = "0xA2C7D0", VA = "0xA2C7D0")]
	public MortarPowerUp()
	{
	}
}
