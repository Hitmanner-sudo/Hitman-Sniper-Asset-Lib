using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000437")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593D50", Offset = "0x593D50")]
public class CheckBeatScore : FsmStateAction
{
	[Token(Token = "0x4001750")]
	[FieldOffset(Offset = "0x4C")]
	public int TargetScore;

	[Token(Token = "0x4001751")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5D60", Offset = "0x5B5D60")]
	public FsmInt TargetScoreVar;

	[Token(Token = "0x4001752")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent OnBeatScore;

	[Token(Token = "0x60019CE")]
	[Address(RVA = "0xAFD944", Offset = "0xAFD944", VA = "0xAFD944", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60019CF")]
	[Address(RVA = "0xAFD954", Offset = "0xAFD954", VA = "0xAFD954", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019D0")]
	[Address(RVA = "0xAFDA48", Offset = "0xAFDA48", VA = "0xAFDA48")]
	private void OnScoreChanged(object sender, ScoreChangedEventArgs e)
	{
	}

	[Token(Token = "0x60019D1")]
	[Address(RVA = "0xAFDAF0", Offset = "0xAFDAF0", VA = "0xAFDAF0", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x60019D2")]
	[Address(RVA = "0xAFDC5C", Offset = "0xAFDC5C", VA = "0xAFDC5C")]
	public CheckBeatScore()
	{
	}
}
