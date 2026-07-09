using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200011C")]
public class ZombieSpawnBehaviour : AIBehaviour
{
	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x34")]
	private float _startTime;

	[Token(Token = "0x4000643")]
	private const float SKIN_MESH_RENDERERS_TIMER_DELAY = 0.2f;

	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x38")]
	private bool isRendered;

	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x40")]
	private Renderer[] _characterRenderer;

	[Token(Token = "0x1700014E")]
	public new ZombieSpawnEvaluator Evaluator
	{
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x885D48", Offset = "0x885D48", VA = "0x885D48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x885DC4", Offset = "0x885DC4", VA = "0x885DC4", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x886168", Offset = "0x886168", VA = "0x886168", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x885F40", Offset = "0x885F40", VA = "0x885F40")]
	private void SpawnEffect(GameObject SpawnEffectObject)
	{
	}

	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x886404", Offset = "0x886404", VA = "0x886404", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x886628", Offset = "0x886628", VA = "0x886628")]
	public ZombieSpawnBehaviour()
	{
	}
}
