using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000278")]
public class RewardScoreChangedAction : RewardActionBase
{
	[Token(Token = "0x2000279")]
	public enum ScoreCondition
	{
		[Token(Token = "0x4000DBE")]
		TotalScore = 0,
		[Token(Token = "0x4000DBF")]
		OneKill = 1
	}

	[Token(Token = "0x4000DBB")]
	[FieldOffset(Offset = "0x68")]
	public int TargetScore;

	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x6C")]
	public ScoreCondition ConditionType;

	[Token(Token = "0x6000EF8")]
	[Address(RVA = "0x96DA8C", Offset = "0x96DA8C", VA = "0x96DA8C", Slot = "4")]
	public override void OnGameStarted()
	{
	}

	[Token(Token = "0x6000EF9")]
	[Address(RVA = "0x96DB88", Offset = "0x96DB88", VA = "0x96DB88", Slot = "5")]
	public override void OnGameEnded()
	{
	}

	[Token(Token = "0x6000EFA")]
	[Address(RVA = "0x96DC84", Offset = "0x96DC84", VA = "0x96DC84")]
	private void OnScoreChanged(object sender, ScoreChangedEventArgs e)
	{
	}

	[Token(Token = "0x6000EFB")]
	[Address(RVA = "0x96DCB8", Offset = "0x96DCB8", VA = "0x96DCB8")]
	public RewardScoreChangedAction()
	{
	}
}
