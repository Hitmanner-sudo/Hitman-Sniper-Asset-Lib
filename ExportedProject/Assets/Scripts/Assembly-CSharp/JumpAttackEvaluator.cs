using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000102")]
public class JumpAttackEvaluator : ZombieEatEvaluator
{
	[Token(Token = "0x40005AC")]
	[FieldOffset(Offset = "0x58")]
	public string SnapToBoneName;

	[Token(Token = "0x40005AD")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 OffsetPosition;

	[Token(Token = "0x40005AE")]
	[FieldOffset(Offset = "0x6C")]
	public Vector3 OffsetRotation;

	[Token(Token = "0x40005AF")]
	[FieldOffset(Offset = "0x78")]
	public float TranslationTime;

	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0x7C")]
	public float MinimumAttackDistance;

	[Token(Token = "0x40005B1")]
	[FieldOffset(Offset = "0x80")]
	public float JumpAttackDistance;

	[Token(Token = "0x40005B2")]
	[FieldOffset(Offset = "0x88")]
	private JumpAttackBehaviour _behaviour;

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x991DE4", Offset = "0x991DE4", VA = "0x991DE4", Slot = "6")]
	protected override ZombieEatBehaviour GetAIBehaviour()
	{
		return null;
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x991DEC", Offset = "0x991DEC", VA = "0x991DEC", Slot = "7")]
	protected override bool CanEat(Memory memory, Record record)
	{
		return default(bool);
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x991F94", Offset = "0x991F94", VA = "0x991F94")]
	public JumpAttackEvaluator()
	{
	}
}
