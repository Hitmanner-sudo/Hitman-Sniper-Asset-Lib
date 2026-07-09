using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20001AC")]
public class DamageOverTime
{
	[Token(Token = "0x400093A")]
	[FieldOffset(Offset = "0x10")]
	public Damage.Types DamageType;

	[Token(Token = "0x400093B")]
	[FieldOffset(Offset = "0x14")]
	public bool DamageOnlyCharacter;

	[Token(Token = "0x400093C")]
	[FieldOffset(Offset = "0x18")]
	public float DamagePerSecond;

	[Token(Token = "0x400093D")]
	[FieldOffset(Offset = "0x1C")]
	public float Duration;

	[Token(Token = "0x400093E")]
	[FieldOffset(Offset = "0x20")]
	public float DurationAfterDeath;

	[Token(Token = "0x400093F")]
	[FieldOffset(Offset = "0x28")]
	public Damage.BodyPart[] SpawnEffectOnParts;

	[Token(Token = "0x4000940")]
	[FieldOffset(Offset = "0x30")]
	public int MaxEffectToSpawn;

	[Token(Token = "0x6000B43")]
	[Address(RVA = "0xAE21DC", Offset = "0xAE21DC", VA = "0xAE21DC")]
	public DamageOverTime()
	{
	}
}
