using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000344")]
public class LandMinePowerUp : SpawnOnImpactPowerUp
{
	[Token(Token = "0x40011FE")]
	[FieldOffset(Offset = "0xB8")]
	private bool _spawnBulletHole;

	[Token(Token = "0x40011FF")]
	[FieldOffset(Offset = "0xB9")]
	private bool _emitsRicochetMemento;

	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x994644", Offset = "0x994644", VA = "0x994644", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60013CB")]
	[Address(RVA = "0x9946A4", Offset = "0x9946A4", VA = "0x9946A4", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x994700", Offset = "0x994700", VA = "0x994700", Slot = "20")]
	protected override void PostEnabledFunction(GameObject spawnedGameObject, long bulletID, Bullet.Hit hit)
	{
	}

	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x99492C", Offset = "0x99492C", VA = "0x99492C")]
	public LandMinePowerUp()
	{
	}
}
