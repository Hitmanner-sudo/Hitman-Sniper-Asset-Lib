using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20008EA")]
[Scope]
public class GameTimeManager : GameSingleton<GameTimeManager>
{
	[Token(Token = "0x4003134")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB89C", Offset = "0x5BB89C")]
	private static TimeReferential _003CGameTime_003Ek__BackingField;

	[Token(Token = "0x4003135")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB8AC", Offset = "0x5BB8AC")]
	private static TimeReferential _003CPlayerTime_003Ek__BackingField;

	[Token(Token = "0x4003136")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB8BC", Offset = "0x5BB8BC")]
	private static TimeReferential _003CInputTime_003Ek__BackingField;

	[Token(Token = "0x4003137")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB8CC", Offset = "0x5BB8CC")]
	private static TimeReferential _003CGameRealTime_003Ek__BackingField;

	[Token(Token = "0x4003138")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB8DC", Offset = "0x5BB8DC")]
	private static TimeReferential[] _003CGameTimes_003Ek__BackingField;

	[Token(Token = "0x4003139")]
	[FieldOffset(Offset = "0x48")]
	protected float _lastRealTimestamp;

	[Token(Token = "0x400313A")]
	[FieldOffset(Offset = "0x4C")]
	protected float _lastDeltaTime;

	[Token(Token = "0x400313B")]
	[FieldOffset(Offset = "0x50")]
	private float _storedFixedDeltaTime;

	[Token(Token = "0x400313C")]
	[FieldOffset(Offset = "0x54")]
	private float _storedMaximumTimeStep;

	[Token(Token = "0x1700072F")]
	public static TimeReferential GameTime
	{
		[Token(Token = "0x600392D")]
		[Address(RVA = "0xD9C1D4", Offset = "0xD9C1D4", VA = "0xD9C1D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6244B0", Offset = "0x6244B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600392E")]
		[Address(RVA = "0xD9C238", Offset = "0xD9C238", VA = "0xD9C238")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6244C0", Offset = "0x6244C0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000730")]
	public static TimeReferential PlayerTime
	{
		[Token(Token = "0x600392F")]
		[Address(RVA = "0xD9C2A0", Offset = "0xD9C2A0", VA = "0xD9C2A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6244D0", Offset = "0x6244D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003930")]
		[Address(RVA = "0xD9C304", Offset = "0xD9C304", VA = "0xD9C304")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6244E0", Offset = "0x6244E0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000731")]
	public static TimeReferential InputTime
	{
		[Token(Token = "0x6003931")]
		[Address(RVA = "0xD9C36C", Offset = "0xD9C36C", VA = "0xD9C36C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6244F0", Offset = "0x6244F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003932")]
		[Address(RVA = "0xD9C3D0", Offset = "0xD9C3D0", VA = "0xD9C3D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x624500", Offset = "0x624500")]
		private set
		{
		}
	}

	[Token(Token = "0x17000732")]
	public static TimeReferential GameRealTime
	{
		[Token(Token = "0x6003933")]
		[Address(RVA = "0xD9C438", Offset = "0xD9C438", VA = "0xD9C438")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x624510", Offset = "0x624510")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003934")]
		[Address(RVA = "0xD9C49C", Offset = "0xD9C49C", VA = "0xD9C49C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x624520", Offset = "0x624520")]
		private set
		{
		}
	}

	[Token(Token = "0x17000733")]
	public static TimeReferential[] GameTimes
	{
		[Token(Token = "0x6003935")]
		[Address(RVA = "0xD9C504", Offset = "0xD9C504", VA = "0xD9C504")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x624530", Offset = "0x624530")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003936")]
		[Address(RVA = "0xD9C568", Offset = "0xD9C568", VA = "0xD9C568")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x624540", Offset = "0x624540")]
		private set
		{
		}
	}

	[Token(Token = "0x6003929")]
	[Address(RVA = "0xD9B840", Offset = "0xD9B840", VA = "0xD9B840")]
	public void Pause(object pauser)
	{
	}

	[Token(Token = "0x600392A")]
	[Address(RVA = "0xD9BC34", Offset = "0xD9BC34", VA = "0xD9BC34")]
	public void Resume(object pauser)
	{
	}

	[Token(Token = "0x600392B")]
	[Address(RVA = "0xD9BA4C", Offset = "0xD9BA4C", VA = "0xD9BA4C")]
	private void EnableIgnoredAudioListenerOnly(bool enable)
	{
	}

	[Token(Token = "0x600392C")]
	[Address(RVA = "0xD9BDF0", Offset = "0xD9BDF0", VA = "0xD9BDF0")]
	static GameTimeManager()
	{
	}

	[Token(Token = "0x6003937")]
	[Address(RVA = "0xD9C5D0", Offset = "0xD9C5D0", VA = "0xD9C5D0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6003938")]
	[Address(RVA = "0xD9C620", Offset = "0xD9C620", VA = "0xD9C620")]
	private void Update()
	{
	}

	[Token(Token = "0x6003939")]
	[Address(RVA = "0xD9C85C", Offset = "0xD9C85C", VA = "0xD9C85C")]
	public GameTimeManager()
	{
	}
}
