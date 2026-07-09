using Il2CppDummyDll;

[Token(Token = "0x2000295")]
public class SocialLoginTimer
{
	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x10")]
	private readonly Timer _timer;

	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3A64", Offset = "0x5B3A64")]
	private bool _003CStartedThroughSocialManager_003Ek__BackingField;

	[Token(Token = "0x1700026B")]
	public bool StartedThroughSocialManager
	{
		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0xA65388", Offset = "0xA65388", VA = "0xA65388")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x615654", Offset = "0x615654")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FA3")]
		[Address(RVA = "0xA65390", Offset = "0xA65390", VA = "0xA65390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x615664", Offset = "0x615664")]
		set
		{
		}
	}

	[Token(Token = "0x1700026C")]
	public bool IsRunningAndStartedThroughSocialManager
	{
		[Token(Token = "0x6000FA4")]
		[Address(RVA = "0xA6539C", Offset = "0xA6539C", VA = "0xA6539C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700026D")]
	public bool IsExpiredAndStartedThroughSocialManager
	{
		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0xA653D0", Offset = "0xA653D0", VA = "0xA653D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0xA653FC", Offset = "0xA653FC", VA = "0xA653FC")]
	public SocialLoginTimer()
	{
	}

	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0xA65464", Offset = "0xA65464", VA = "0xA65464")]
	public void Start(float duration)
	{
	}

	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0xA65480", Offset = "0xA65480", VA = "0xA65480")]
	public void Stop()
	{
	}
}
