using Il2CppDummyDll;

[Token(Token = "0x20000FA")]
public class HealBehaviour : AIBehaviour, TaskIdle.IListener
{
	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0x38")]
	public Record Patient;

	[Token(Token = "0x4000583")]
	[FieldOffset(Offset = "0x40")]
	private ThirdPersonCharacter _patientCharacter;

	[Token(Token = "0x4000584")]
	[FieldOffset(Offset = "0x48")]
	private AIController _patientAI;

	[Token(Token = "0x4000585")]
	private const string _taskId = "HealMoveTo";

	[Token(Token = "0x4000586")]
	private const string _patientTaskId = "GettingHealed";

	[Token(Token = "0x4000587")]
	[FieldOffset(Offset = "0x50")]
	private TaskIdle _task;

	[Token(Token = "0x4000588")]
	[FieldOffset(Offset = "0x0")]
	private static readonly float _healDistance;

	[Token(Token = "0x1700013D")]
	public new HealEvaluator Evaluator
	{
		[Token(Token = "0x600070B")]
		[Address(RVA = "0xA092B4", Offset = "0xA092B4", VA = "0xA092B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0xA09330", Offset = "0xA09330", VA = "0xA09330", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0xA096DC", Offset = "0xA096DC", VA = "0xA096DC", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0xA095F4", Offset = "0xA095F4", VA = "0xA095F4")]
	private void UpdateTask()
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0xA0983C", Offset = "0xA0983C", VA = "0xA0983C", Slot = "13")]
	private void TaskIdle_002EIListener_002EOnDestinationReached()
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0xA09BE4", Offset = "0xA09BE4", VA = "0xA09BE4", Slot = "14")]
	private void TaskIdle_002EIListener_002EOnDestinationUnreacheable()
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0xA09E1C", Offset = "0xA09E1C", VA = "0xA09E1C", Slot = "15")]
	private void TaskIdle_002EIListener_002EOnIdleComplete()
	{
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0xA09BE8", Offset = "0xA09BE8", VA = "0xA09BE8")]
	private void ReactToWound()
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0xA09FB8", Offset = "0xA09FB8", VA = "0xA09FB8", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0xA0A148", Offset = "0xA0A148", VA = "0xA0A148")]
	public HealBehaviour()
	{
	}
}
