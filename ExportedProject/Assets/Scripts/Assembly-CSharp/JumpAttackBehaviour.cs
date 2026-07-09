using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000101")]
public class JumpAttackBehaviour : ZombieEatBehaviour
{
	[Token(Token = "0x40005A6")]
	[FieldOffset(Offset = "0x0")]
	public static string IS_JUMP_ATTACKED;

	[Token(Token = "0x40005A7")]
	[FieldOffset(Offset = "0x68")]
	private Transform _cachedAttachedBone;

	[Token(Token = "0x40005A8")]
	[FieldOffset(Offset = "0x70")]
	private Transform _cachedAttachedToBone;

	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0x78")]
	private float _startAttachTime;

	[Token(Token = "0x40005AA")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 _startAttachedBonePosition;

	[Token(Token = "0x40005AB")]
	[FieldOffset(Offset = "0x88")]
	private Quaternion _startCharacterRotation;

	[Token(Token = "0x17000142")]
	public new JumpAttackEvaluator Evaluator
	{
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x990DB0", Offset = "0x990DB0", VA = "0x990DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x990E34", Offset = "0x990E34", VA = "0x990E34", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x990F34", Offset = "0x990F34", VA = "0x990F34", Slot = "16")]
	protected override void ArriveAtDestination()
	{
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0x9910F0", Offset = "0x9910F0", VA = "0x9910F0", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x600073F")]
	[Address(RVA = "0x9913A4", Offset = "0x9913A4", VA = "0x9913A4")]
	private void AdjustPositionOnBone()
	{
	}

	[Token(Token = "0x6000740")]
	[Address(RVA = "0x9916A8", Offset = "0x9916A8", VA = "0x9916A8")]
	private bool CacheGameObject()
	{
		return default(bool);
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0x99194C", Offset = "0x99194C", VA = "0x99194C", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x991D1C", Offset = "0x991D1C", VA = "0x991D1C")]
	public JumpAttackBehaviour()
	{
	}
}
