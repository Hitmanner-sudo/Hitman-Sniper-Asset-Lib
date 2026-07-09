using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000105")]
public class MoveAndAttackEvaluator : AttractorEvaluator
{
	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x34")]
	public float AttackRange;

	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0x38")]
	public float AttackForce;

	[Token(Token = "0x40005C9")]
	[FieldOffset(Offset = "0x3C")]
	public float AttackVictimRange;

	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x40")]
	public float Damage;

	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x44")]
	public float HurtReactionDuration;

	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x48")]
	public float HurtReactionSlowValue;

	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x50")]
	public Faction TargetFaction;

	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x58")]
	public GameObject SpawnEffectOnHit;

	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x60")]
	public GameObject SpawnEffectOnHit2;

	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x68")]
	public float NormalHitDuration;

	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x6C")]
	public float FinalHitDuration;

	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0x70")]
	public SoundContainer HitSFX;

	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x78")]
	public SoundContainer BigHitSFX;

	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x80")]
	private MoveAndAttackBehaviour _behaviour;

	[Token(Token = "0x600075F")]
	[Address(RVA = "0xA2FCB0", Offset = "0xA2FCB0", VA = "0xA2FCB0", Slot = "7")]
	protected override AttractorBehaviour GetAIBehaviour(Attractor attractor)
	{
		return null;
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0xA2FCB8", Offset = "0xA2FCB8", VA = "0xA2FCB8")]
	public MoveAndAttackEvaluator()
	{
	}
}
