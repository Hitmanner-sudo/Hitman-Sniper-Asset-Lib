using Il2CppDummyDll;

[Token(Token = "0x20000DD")]
public class ArrestBehaviour : AIBehaviour
{
	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x38")]
	public Record Victim;

	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x40")]
	public float TimeBeforeSuspicious;

	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x44")]
	public float TimeBeforeAware;

	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x48")]
	public float TimeBeforeAlarmRaised;

	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x4C")]
	public float TimeBeforeExecution;

	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0x50")]
	public float MinDistanceFromVictim;

	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0x54")]
	public float MaxDistanceFromVictim;

	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x58")]
	private bool _victimUnderArrest;

	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x60")]
	private GameTimer _raiseAlarmTimer;

	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x68")]
	private Weapon _weapon;

	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string _arrestIdleID;

	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x70")]
	private TaskIdle _taskIdle;

	[Token(Token = "0x6000688")]
	[Address(RVA = "0xBFE4A0", Offset = "0xBFE4A0", VA = "0xBFE4A0", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0xBFE5C0", Offset = "0xBFE5C0", VA = "0xBFE5C0", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0xBFE880", Offset = "0xBFE880", VA = "0xBFE880")]
	private void StartRaiseAlertTimer()
	{
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0xBFE9F0", Offset = "0xBFE9F0", VA = "0xBFE9F0")]
	private void Shoot()
	{
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0xBFEC40", Offset = "0xBFEC40", VA = "0xBFEC40", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0xBFEEF4", Offset = "0xBFEEF4", VA = "0xBFEEF4")]
	public ArrestBehaviour()
	{
	}
}
