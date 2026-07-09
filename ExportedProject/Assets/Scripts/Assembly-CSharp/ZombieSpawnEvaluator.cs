using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200011D")]
public class ZombieSpawnEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SpawnEffectOnHit;

	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0x28")]
	private ZombieSpawnBehaviour _behaviour;

	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x0")]
	public static string IS_SPAWNNED;

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x886630", Offset = "0x886630", VA = "0x886630", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x8866FC", Offset = "0x8866FC", VA = "0x8866FC")]
	public ZombieSpawnEvaluator()
	{
	}
}
