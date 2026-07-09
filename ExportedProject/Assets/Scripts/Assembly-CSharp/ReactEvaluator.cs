using Il2CppDummyDll;

[Token(Token = "0x200010B")]
public class ReactEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x20")]
	public bool EquipWeaponWhenAlerted;

	[Token(Token = "0x40005E9")]
	[FieldOffset(Offset = "0x24")]
	public ThreatLevel MinThreatLevel;

	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0x28")]
	private ReactBehaviour _behaviour;

	[Token(Token = "0x6000773")]
	[Address(RVA = "0xB41F6C", Offset = "0xB41F6C", VA = "0xB41F6C", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0xB421AC", Offset = "0xB421AC", VA = "0xB421AC", Slot = "5")]
	public override void CleanUp()
	{
	}

	[Token(Token = "0x6000775")]
	[Address(RVA = "0xB421CC", Offset = "0xB421CC", VA = "0xB421CC")]
	public ReactEvaluator()
	{
	}
}
