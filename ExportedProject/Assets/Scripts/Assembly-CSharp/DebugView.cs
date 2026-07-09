using Il2CppDummyDll;

[Token(Token = "0x2000664")]
public class DebugView : View
{
	[Token(Token = "0x400236A")]
	[FieldOffset(Offset = "0x60")]
	public UILabel FPSLabel;

	[Token(Token = "0x400236B")]
	[FieldOffset(Offset = "0x68")]
	public UILabel VersionLabel;

	[Token(Token = "0x400236C")]
	[FieldOffset(Offset = "0x70")]
	public UILabel MemLabel;

	[Token(Token = "0x400236D")]
	[FieldOffset(Offset = "0x78")]
	public float m_FPSCounterUpdateInterval;

	[Token(Token = "0x400236E")]
	[FieldOffset(Offset = "0x7C")]
	public float m_MemCounterUpdateInterval;

	[Token(Token = "0x400236F")]
	[FieldOffset(Offset = "0x80")]
	private float m_FPSCounterAccum;

	[Token(Token = "0x4002370")]
	[FieldOffset(Offset = "0x84")]
	private int m_FPSCounterFrames;

	[Token(Token = "0x4002371")]
	[FieldOffset(Offset = "0x88")]
	private float m_FPSCounterTimeleft;

	[Token(Token = "0x4002372")]
	[FieldOffset(Offset = "0x8C")]
	private float m_MemCounterAccum;

	[Token(Token = "0x4002373")]
	[FieldOffset(Offset = "0x90")]
	private int m_MemCounterFrames;

	[Token(Token = "0x4002374")]
	[FieldOffset(Offset = "0x94")]
	private float m_MemCounterTimeleft;

	[Token(Token = "0x4002375")]
	[FieldOffset(Offset = "0x98")]
	private long previousMemUsed;

	[Token(Token = "0x6002970")]
	[Address(RVA = "0xAEA85C", Offset = "0xAEA85C", VA = "0xAEA85C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002971")]
	[Address(RVA = "0xAEA8D4", Offset = "0xAEA8D4", VA = "0xAEA8D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6002972")]
	[Address(RVA = "0xAEAA54", Offset = "0xAEAA54", VA = "0xAEAA54")]
	private void UpdateFPSCounter()
	{
	}

	[Token(Token = "0x6002973")]
	[Address(RVA = "0xAEB230", Offset = "0xAEB230", VA = "0xAEB230")]
	public static long GetTotalMemory()
	{
		return default(long);
	}

	[Token(Token = "0x6002974")]
	[Address(RVA = "0xAEAD98", Offset = "0xAEAD98", VA = "0xAEAD98")]
	private void UpdateMemCounter()
	{
	}

	[Token(Token = "0x6002975")]
	[Address(RVA = "0xAEB238", Offset = "0xAEB238", VA = "0xAEB238")]
	public DebugView()
	{
	}
}
