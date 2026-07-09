using Il2CppDummyDll;

[Token(Token = "0x2000594")]
public class ContractDataModel : DataModel
{
	[Token(Token = "0x2000595")]
	public enum DifficultyType
	{
		[Token(Token = "0x4001D6E")]
		NONE = -1,
		[Token(Token = "0x4001D6F")]
		NORMAL = 0,
		[Token(Token = "0x4001D70")]
		HARD = 1,
		[Token(Token = "0x4001D71")]
		EXPERT = 2
	}

	[Token(Token = "0x4001D63")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string CONTRACT_DATA;

	[Token(Token = "0x4001D64")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string SCENE_PROPERTIES;

	[Token(Token = "0x4001D65")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string LEADERBOARD_ID;

	[Token(Token = "0x4001D66")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string GAME_CENTER_LEADERBOARD_ID;

	[Token(Token = "0x4001D67")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string DIFFICULTY;

	[Token(Token = "0x4001D68")]
	[FieldOffset(Offset = "0x48")]
	public ContractData ContractData;

	[Token(Token = "0x4001D69")]
	[FieldOffset(Offset = "0x50")]
	public LevelProperties[] SceneProperties;

	[Token(Token = "0x4001D6A")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "ClampAttribute", RVA = "0x5B7F1C", Offset = "0x5B7F1C")]
	public int LeaderboardID;

	[Token(Token = "0x4001D6B")]
	[FieldOffset(Offset = "0x60")]
	public string GameCenterLeaderboardID;

	[Token(Token = "0x4001D6C")]
	[FieldOffset(Offset = "0x68")]
	private DifficultyType _difficulty;

	[Token(Token = "0x60022DE")]
	[Address(RVA = "0x8E6AFC", Offset = "0x8E6AFC", VA = "0x8E6AFC", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60022DF")]
	[Address(RVA = "0x8E6DA0", Offset = "0x8E6DA0", VA = "0x8E6DA0")]
	private LevelProperties GetSceneProperties()
	{
		return null;
	}

	[Token(Token = "0x60022E0")]
	[Address(RVA = "0x8E6E08", Offset = "0x8E6E08", VA = "0x8E6E08")]
	public ContractDataModel()
	{
	}

	[Token(Token = "0x60022E2")]
	[Address(RVA = "0x8E6EF8", Offset = "0x8E6EF8", VA = "0x8E6EF8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A150", Offset = "0x61A150")]
	private object _003CBindAllVariables_003Eb__11_0()
	{
		return null;
	}

	[Token(Token = "0x60022E3")]
	[Address(RVA = "0x8E6F00", Offset = "0x8E6F00", VA = "0x8E6F00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A160", Offset = "0x61A160")]
	private int _003CBindAllVariables_003Eb__11_1()
	{
		return default(int);
	}

	[Token(Token = "0x60022E4")]
	[Address(RVA = "0x8E6F08", Offset = "0x8E6F08", VA = "0x8E6F08")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A170", Offset = "0x61A170")]
	private object _003CBindAllVariables_003Eb__11_2()
	{
		return null;
	}

	[Token(Token = "0x60022E5")]
	[Address(RVA = "0x8E6F10", Offset = "0x8E6F10", VA = "0x8E6F10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A180", Offset = "0x61A180")]
	private object _003CBindAllVariables_003Eb__11_3()
	{
		return null;
	}

	[Token(Token = "0x60022E6")]
	[Address(RVA = "0x8E6F70", Offset = "0x8E6F70", VA = "0x8E6F70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A190", Offset = "0x61A190")]
	private void _003CBindAllVariables_003Eb__11_4(object a)
	{
	}
}
