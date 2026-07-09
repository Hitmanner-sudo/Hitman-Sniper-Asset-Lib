using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200035D")]
public class SpawnOnImpactPowerUp : PowerUp
{
	[Token(Token = "0x400129C")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private LazyGameObject _projectileEffectToAdd;

	[Token(Token = "0x400129D")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	protected LazyGameObject _gameObjectToSpawnOnImpact;

	[Token(Token = "0x400129E")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private bool _alignOnCollision;

	[Token(Token = "0x400129F")]
	[FieldOffset(Offset = "0xB1")]
	[SerializeField]
	private bool _bulletNoDamage;

	[Token(Token = "0x40012A0")]
	[FieldOffset(Offset = "0xB4")]
	private int _previousDamage;

	[Token(Token = "0x600144B")]
	[Address(RVA = "0xA72594", Offset = "0xA72594", VA = "0xA72594", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x600144C")]
	[Address(RVA = "0xA72844", Offset = "0xA72844", VA = "0xA72844", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x600144D")]
	[Address(RVA = "0xA728C0", Offset = "0xA728C0", VA = "0xA728C0", Slot = "18")]
	protected virtual void ResetBullet(Bullet bullet, BulletData bulletData)
	{
	}

	[Token(Token = "0x600144E")]
	[Address(RVA = "0xA72ADC", Offset = "0xA72ADC", VA = "0xA72ADC", Slot = "19")]
	protected virtual void PreEnabledFunction(GameObject spawnedGameObject, long bulletID, Bullet.Hit hit)
	{
	}

	[Token(Token = "0x600144F")]
	[Address(RVA = "0xA72AE0", Offset = "0xA72AE0", VA = "0xA72AE0", Slot = "20")]
	protected virtual void PostEnabledFunction(GameObject spawnedGameObject, long bulletID, Bullet.Hit hit)
	{
	}

	[Token(Token = "0x6001450")]
	[Address(RVA = "0xA72AE4", Offset = "0xA72AE4", VA = "0xA72AE4")]
	public SpawnOnImpactPowerUp()
	{
	}

	[Token(Token = "0x6001451")]
	[Address(RVA = "0xA72AEC", Offset = "0xA72AEC", VA = "0xA72AEC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6171A4", Offset = "0x6171A4")]
	private bool _003CResetBullet_003Eb__7_0(BulletData.SpawnOnImpactObject x)
	{
		return default(bool);
	}
}
