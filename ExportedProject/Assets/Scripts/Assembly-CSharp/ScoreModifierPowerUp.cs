using Il2CppDummyDll;

[Token(Token = "0x200035C")]
public class ScoreModifierPowerUp : PowerUp
{
	[Token(Token = "0x4001263")]
	[FieldOffset(Offset = "0xA0")]
	public bool OverrideQuickMaxScore;

	[Token(Token = "0x4001264")]
	[FieldOffset(Offset = "0xA4")]
	public int QuickMaxScore;

	[Token(Token = "0x4001265")]
	[FieldOffset(Offset = "0xA8")]
	public bool OverrideQuickTimeExtend;

	[Token(Token = "0x4001266")]
	[FieldOffset(Offset = "0xAC")]
	public float QuickTimeExtend;

	[Token(Token = "0x4001267")]
	[FieldOffset(Offset = "0xB0")]
	public bool OverrideStealthMaxScore;

	[Token(Token = "0x4001268")]
	[FieldOffset(Offset = "0xB4")]
	public int StealthMaxScore;

	[Token(Token = "0x4001269")]
	[FieldOffset(Offset = "0xB8")]
	public bool OverrideHeadshotMaxScore;

	[Token(Token = "0x400126A")]
	[FieldOffset(Offset = "0xBC")]
	public int HeadshotMaxScore;

	[Token(Token = "0x400126B")]
	[FieldOffset(Offset = "0xC0")]
	public bool OverrideEnvironmentalScore;

	[Token(Token = "0x400126C")]
	[FieldOffset(Offset = "0xC4")]
	public int EnvironmentalScore;

	[Token(Token = "0x400126D")]
	[FieldOffset(Offset = "0xC8")]
	public bool OverrideAccidentalScore;

	[Token(Token = "0x400126E")]
	[FieldOffset(Offset = "0xCC")]
	public int AccidentalScore;

	[Token(Token = "0x400126F")]
	[FieldOffset(Offset = "0xD0")]
	public bool OverrideLureScore;

	[Token(Token = "0x4001270")]
	[FieldOffset(Offset = "0xD4")]
	public int LureScore;

	[Token(Token = "0x4001271")]
	[FieldOffset(Offset = "0xD8")]
	public bool OverrideXRayScore;

	[Token(Token = "0x4001272")]
	[FieldOffset(Offset = "0xDC")]
	public int XRayScore;

	[Token(Token = "0x4001273")]
	[FieldOffset(Offset = "0xE0")]
	public bool OverrideBodyDisposalScore;

	[Token(Token = "0x4001274")]
	[FieldOffset(Offset = "0xE4")]
	public int BodyDisposalScore;

	[Token(Token = "0x4001275")]
	[FieldOffset(Offset = "0xE8")]
	public bool OverrideManipulationScore;

	[Token(Token = "0x4001276")]
	[FieldOffset(Offset = "0xEC")]
	public int ManipulationScore;

	[Token(Token = "0x4001277")]
	[FieldOffset(Offset = "0xF0")]
	public bool OverrideDominoKillScore;

	[Token(Token = "0x4001278")]
	[FieldOffset(Offset = "0xF4")]
	public int DominoKillScore;

	[Token(Token = "0x4001279")]
	[FieldOffset(Offset = "0xF8")]
	public bool OverrideScoreMultiplier;

	[Token(Token = "0x400127A")]
	[FieldOffset(Offset = "0xFC")]
	public float ScoreMultiplier;

	[Token(Token = "0x400127B")]
	[FieldOffset(Offset = "0x100")]
	public bool OverrideMovingScoreMultiplier;

	[Token(Token = "0x400127C")]
	[FieldOffset(Offset = "0x104")]
	public float MovingScoreMultiplier;

	[Token(Token = "0x400127D")]
	[FieldOffset(Offset = "0x108")]
	public bool OverrideMinZoomScoreMultiplier;

	[Token(Token = "0x400127E")]
	[FieldOffset(Offset = "0x10C")]
	public float MinZoomScoreMultiplier;

	[Token(Token = "0x400127F")]
	[FieldOffset(Offset = "0x110")]
	public bool OverrideEnemyScoreMultiplier;

	[Token(Token = "0x4001280")]
	[FieldOffset(Offset = "0x114")]
	public float EnemyScoreMultiplier;

	[Token(Token = "0x4001281")]
	[FieldOffset(Offset = "0x118")]
	public bool OverrideExtractionHeadShotScoreMultiplier;

	[Token(Token = "0x4001282")]
	[FieldOffset(Offset = "0x11C")]
	public float ExtractionHeadShotScoreMultiplier;

	[Token(Token = "0x4001283")]
	[FieldOffset(Offset = "0x120")]
	public bool OverrideExtractionQuickKillScoreMultiplier;

	[Token(Token = "0x4001284")]
	[FieldOffset(Offset = "0x124")]
	public float ExtractionQuickKillScoreMultiplier;

	[Token(Token = "0x4001285")]
	[FieldOffset(Offset = "0x128")]
	public bool OverrideExtractionStealthKillScoreMultiplier;

	[Token(Token = "0x4001286")]
	[FieldOffset(Offset = "0x12C")]
	public float ExtractionStealthKillScoreMultiplier;

	[Token(Token = "0x4001287")]
	[FieldOffset(Offset = "0x130")]
	public bool OverrideExtractionTargetKillScoreMultiplier;

	[Token(Token = "0x4001288")]
	[FieldOffset(Offset = "0x134")]
	public float ExtractionTargetKillScoreMultiplier;

	[Token(Token = "0x4001289")]
	[FieldOffset(Offset = "0x138")]
	private int _oldQuickMaxScore;

	[Token(Token = "0x400128A")]
	[FieldOffset(Offset = "0x13C")]
	private float _oldQuickTimeExtend;

	[Token(Token = "0x400128B")]
	[FieldOffset(Offset = "0x140")]
	private int _oldStealthMaxScore;

	[Token(Token = "0x400128C")]
	[FieldOffset(Offset = "0x144")]
	private int _oldHeadshotMaxScore;

	[Token(Token = "0x400128D")]
	[FieldOffset(Offset = "0x148")]
	private int _oldEnvironmentalScore;

	[Token(Token = "0x400128E")]
	[FieldOffset(Offset = "0x14C")]
	private int _oldAccidentalScore;

	[Token(Token = "0x400128F")]
	[FieldOffset(Offset = "0x150")]
	private int _oldLureScore;

	[Token(Token = "0x4001290")]
	[FieldOffset(Offset = "0x154")]
	private int _oldXRayScore;

	[Token(Token = "0x4001291")]
	[FieldOffset(Offset = "0x158")]
	private int _oldBodyDisposalScore;

	[Token(Token = "0x4001292")]
	[FieldOffset(Offset = "0x15C")]
	private int _oldManipulationScore;

	[Token(Token = "0x4001293")]
	[FieldOffset(Offset = "0x160")]
	private int _oldDominoKillScore;

	[Token(Token = "0x4001294")]
	[FieldOffset(Offset = "0x164")]
	private float _oldScoreMultiplier;

	[Token(Token = "0x4001295")]
	[FieldOffset(Offset = "0x168")]
	private float _oldMovingScoreMultiplier;

	[Token(Token = "0x4001296")]
	[FieldOffset(Offset = "0x16C")]
	private float _oldMinZoomScoreMultiplier;

	[Token(Token = "0x4001297")]
	[FieldOffset(Offset = "0x170")]
	private float _oldEnemyScoreMultiplier;

	[Token(Token = "0x4001298")]
	[FieldOffset(Offset = "0x174")]
	private float _oldExtractionHeadShotScoreMultiplier;

	[Token(Token = "0x4001299")]
	[FieldOffset(Offset = "0x178")]
	private float _oldExtractionQuickKillScoreMultiplier;

	[Token(Token = "0x400129A")]
	[FieldOffset(Offset = "0x17C")]
	private float _oldExtractionStealthKillScoreMultiplier;

	[Token(Token = "0x400129B")]
	[FieldOffset(Offset = "0x180")]
	private float _oldExtractionTargetKillScoreMultiplier;

	[Token(Token = "0x6001448")]
	[Address(RVA = "0xBB8E18", Offset = "0xBB8E18", VA = "0xBB8E18", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001449")]
	[Address(RVA = "0xBB92E0", Offset = "0xBB92E0", VA = "0xBB92E0", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x600144A")]
	[Address(RVA = "0xBB9468", Offset = "0xBB9468", VA = "0xBB9468")]
	public ScoreModifierPowerUp()
	{
	}
}
