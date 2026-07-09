using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000277")]
public class RewardMessageReceivedAction : RewardActionBase
{
	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x68")]
	public GameEventsManager.GameEventType EventType;

	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0x96D2CC", Offset = "0x96D2CC", VA = "0x96D2CC", Slot = "4")]
	public override void OnGameStarted()
	{
	}

	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0x96D3C8", Offset = "0x96D3C8", VA = "0x96D3C8", Slot = "5")]
	public override void OnGameEnded()
	{
	}

	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0x96D4C4", Offset = "0x96D4C4", VA = "0x96D4C4")]
	private void OnGameEvent(object sender, GameEventArgs e)
	{
	}

	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0x96D4F0", Offset = "0x96D4F0", VA = "0x96D4F0")]
	public RewardMessageReceivedAction()
	{
	}
}
