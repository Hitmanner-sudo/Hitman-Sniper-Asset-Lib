using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000116")]
public class WanderBehaviour : AIBehaviour
{
	[Token(Token = "0x4000621")]
	[FieldOffset(Offset = "0x34")]
	public float m_WanderRadius;

	[Token(Token = "0x4000622")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_InitialPosition;

	[Token(Token = "0x4000623")]
	[FieldOffset(Offset = "0x44")]
	private float m_Cooldown;

	[Token(Token = "0x1700014B")]
	public new WanderEvaluator Evaluator
	{
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x97DEAC", Offset = "0x97DEAC", VA = "0x97DEAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x97DF28", Offset = "0x97DF28", VA = "0x97DF28", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x97E0C8", Offset = "0x97E0C8", VA = "0x97E0C8")]
	private void StartCooldown()
	{
	}

	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x97E1F8", Offset = "0x97E1F8", VA = "0x97E1F8")]
	private Vector3 GetRandomPoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x97E234", Offset = "0x97E234", VA = "0x97E234", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x97E418", Offset = "0x97E418", VA = "0x97E418", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x97E50C", Offset = "0x97E50C", VA = "0x97E50C")]
	public WanderBehaviour()
	{
	}
}
