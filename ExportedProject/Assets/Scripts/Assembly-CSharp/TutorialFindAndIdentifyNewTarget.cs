using System;
using Il2CppDummyDll;

[Token(Token = "0x20002C0")]
public class TutorialFindAndIdentifyNewTarget : TutorialToLearnLogic
{
	[Token(Token = "0x4000F7C")]
	[FieldOffset(Offset = "0x28")]
	private RogueData _newTargerData;

	[Token(Token = "0x4000F7D")]
	private const float _autoCompletionMaxTime = 10f;

	[Token(Token = "0x4000F7E")]
	private const float _autoCompletionMinTime = 2f;

	[Token(Token = "0x4000F7F")]
	[FieldOffset(Offset = "0x30")]
	private float _autoCompletionAccumulatedTime;

	[Token(Token = "0x4000F80")]
	[FieldOffset(Offset = "0x38")]
	private PlayerScopeSystem _playerScopeSystem;

	[Token(Token = "0x60010CE")]
	[Address(RVA = "0xCA12D4", Offset = "0xCA12D4", VA = "0xCA12D4")]
	public TutorialFindAndIdentifyNewTarget(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x60010CF")]
	[Address(RVA = "0xCA1300", Offset = "0xCA1300", VA = "0xCA1300", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60010D0")]
	[Address(RVA = "0xCA13D8", Offset = "0xCA13D8", VA = "0xCA13D8", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60010D1")]
	[Address(RVA = "0xCA147C", Offset = "0xCA147C", VA = "0xCA147C", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x60010D2")]
	[Address(RVA = "0xCA16CC", Offset = "0xCA16CC", VA = "0xCA16CC", Slot = "9")]
	protected override void DoUpdate()
	{
	}

	[Token(Token = "0x60010D3")]
	[Address(RVA = "0xCA17F8", Offset = "0xCA17F8", VA = "0xCA17F8", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x60010D4")]
	[Address(RVA = "0xCA19BC", Offset = "0xCA19BC", VA = "0xCA19BC", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x60010D5")]
	[Address(RVA = "0xCA1A70", Offset = "0xCA1A70", VA = "0xCA1A70")]
	private void OnEnterScope(object sender, EventArgs empty)
	{
	}

	[Token(Token = "0x60010D6")]
	[Address(RVA = "0xCA1BA8", Offset = "0xCA1BA8", VA = "0xCA1BA8")]
	private void OnExitScope(object sender, EventArgs empty)
	{
	}

	[Token(Token = "0x60010D7")]
	[Address(RVA = "0xCA1C9C", Offset = "0xCA1C9C", VA = "0xCA1C9C")]
	private void OnTagged(object targetObject, EventArgs empty)
	{
	}
}
