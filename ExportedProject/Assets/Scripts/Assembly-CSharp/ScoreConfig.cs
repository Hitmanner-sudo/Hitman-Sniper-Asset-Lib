using Il2CppDummyDll;

[Token(Token = "0x200020D")]
public class ScoreConfig : BaseConfig<ScoreConfig>
{
	[Token(Token = "0x4000BC3")]
	[FieldOffset(Offset = "0x30")]
	public PerformanceBonusConfig AccuracyBonusConfig;

	[Token(Token = "0x4000BC4")]
	[FieldOffset(Offset = "0x38")]
	public PerformanceBonusConfig SpeedBonusConfig;

	[Token(Token = "0x4000BC5")]
	[FieldOffset(Offset = "0x40")]
	public PerformanceBonusConfig SilentBonusConfig;

	[Token(Token = "0x4000BC6")]
	[FieldOffset(Offset = "0x48")]
	public float QuickKillTimeThreshold;

	[Token(Token = "0x4000BC7")]
	[FieldOffset(Offset = "0x4C")]
	public bool GroupScoreAnimation;

	[Token(Token = "0x4000BC8")]
	[FieldOffset(Offset = "0x50")]
	public GroupScoreDescription[] GroupScoreDescriptionArray;

	[Token(Token = "0x6000C74")]
	[Address(RVA = "0xBB7000", Offset = "0xBB7000", VA = "0xBB7000")]
	public ScoreConfig()
	{
	}
}
