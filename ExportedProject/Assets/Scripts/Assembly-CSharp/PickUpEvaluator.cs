using Il2CppDummyDll;

[Token(Token = "0x2000107")]
public class PickUpEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x2000108")]
	public enum Condition
	{
		[Token(Token = "0x40005E2")]
		PickUpAll = 0,
		[Token(Token = "0x40005E3")]
		PickUpOneOfEach = 1,
		[Token(Token = "0x40005E4")]
		PickUpOne = 2
	}

	[Token(Token = "0x2000109")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x592478", Offset = "0x592478")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x10")]
		public InventoryItem candidate;

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x8D08EC", Offset = "0x8D08EC", VA = "0x8D08EC")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x8D08F4", Offset = "0x8D08F4", VA = "0x8D08F4")]
		internal bool _003CEvaluate_003Eb__0(AIMemento memento)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0x20")]
	public float MaxDistance;

	[Token(Token = "0x40005DA")]
	[FieldOffset(Offset = "0x28")]
	public InventoryItem[] Items;

	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0x30")]
	public Condition AlreadyOwnedCondition;

	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x5B0734", Offset = "0x5B0734")]
	public AlertLevel MinAlertLevel;

	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x5B076C", Offset = "0x5B076C")]
	public AlertLevel MaxAlertLevel;

	[Token(Token = "0x40005DE")]
	[FieldOffset(Offset = "0x3C")]
	public AnimationConfig.MovementSpeed MovementSpeed;

	[Token(Token = "0x40005DF")]
	[FieldOffset(Offset = "0x40")]
	private PickUpBehaviour _behaviour;

	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x48")]
	public AnimationConfig.IdleType TellAnimation;

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x90A724", Offset = "0x90A724", VA = "0x90A724", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x6000769")]
	[Address(RVA = "0x90AC20", Offset = "0x90AC20", VA = "0x90AC20", Slot = "5")]
	public override void CleanUp()
	{
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x90AC40", Offset = "0x90AC40", VA = "0x90AC40")]
	public PickUpEvaluator()
	{
	}
}
