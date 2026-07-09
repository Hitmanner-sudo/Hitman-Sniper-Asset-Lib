using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000119")]
public class ZombieEatEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x4000635")]
	[FieldOffset(Offset = "0x20")]
	public float Amount;

	[Token(Token = "0x4000636")]
	[FieldOffset(Offset = "0x24")]
	public float ReachRadius;

	[Token(Token = "0x4000637")]
	[FieldOffset(Offset = "0x28")]
	public Damage.Types DamageType;

	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0x2C")]
	public bool EatEveryone;

	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0x30")]
	public Faction[] FactionsToEat;

	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0x38")]
	public AnimationConfig.MovementSpeed Speed;

	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SpawnEffectOnHit;

	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SpawnEffectOnHit2;

	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x50")]
	private ZombieEatBehaviour _behaviour;

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x8826F4", Offset = "0x8826F4", VA = "0x8826F4", Slot = "6")]
	protected virtual ZombieEatBehaviour GetAIBehaviour()
	{
		return null;
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x8826FC", Offset = "0x8826FC", VA = "0x8826FC", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x882868", Offset = "0x882868", VA = "0x882868", Slot = "7")]
	protected virtual bool CanEat(Memory memory, Record record)
	{
		return default(bool);
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x882964", Offset = "0x882964", VA = "0x882964", Slot = "5")]
	public override void CleanUp()
	{
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x882984", Offset = "0x882984", VA = "0x882984")]
	public ZombieEatEvaluator()
	{
	}
}
