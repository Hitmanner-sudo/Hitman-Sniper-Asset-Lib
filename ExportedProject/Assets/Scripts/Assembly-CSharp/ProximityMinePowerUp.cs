using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000359")]
public class ProximityMinePowerUp : SpawnOnImpactPowerUp
{
	[Token(Token = "0x400125D")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private ProximityIndicatorController _indicatorPrefab;

	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private float _previewHeight;

	[Token(Token = "0x400125F")]
	[FieldOffset(Offset = "0xC4")]
	private bool _spawnBulletHole;

	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0xC5")]
	private bool _emitsRicochetMemento;

	[Token(Token = "0x6001440")]
	[Address(RVA = "0xB3B654", Offset = "0xB3B654", VA = "0xB3B654", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001441")]
	[Address(RVA = "0xB3B6B4", Offset = "0xB3B6B4", VA = "0xB3B6B4", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001442")]
	[Address(RVA = "0xB3B710", Offset = "0xB3B710", VA = "0xB3B710", Slot = "20")]
	protected override void PostEnabledFunction(GameObject spawnedGameObject, long bulletID, Bullet.Hit hit)
	{
	}

	[Token(Token = "0x6001443")]
	[Address(RVA = "0xB3B8E4", Offset = "0xB3B8E4", VA = "0xB3B8E4")]
	public ProximityMinePowerUp()
	{
	}
}
