using System;
using Il2CppDummyDll;

[Token(Token = "0x20002C7")]
public class TutorialIncreaseScoreExtraction : TutorialToLearnLogic
{
	[Token(Token = "0x4000F8F")]
	[FieldOffset(Offset = "0x28")]
	private bool _isDisplayed;

	[Token(Token = "0x600110B")]
	[Address(RVA = "0xCA49E4", Offset = "0xCA49E4", VA = "0xCA49E4")]
	public TutorialIncreaseScoreExtraction(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x600110C")]
	[Address(RVA = "0xCA4A10", Offset = "0xCA4A10", VA = "0xCA4A10", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600110D")]
	[Address(RVA = "0xCA4AE8", Offset = "0xCA4AE8", VA = "0xCA4AE8", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x600110E")]
	[Address(RVA = "0xCA4B8C", Offset = "0xCA4B8C", VA = "0xCA4B8C", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x600110F")]
	[Address(RVA = "0xCA4C70", Offset = "0xCA4C70", VA = "0xCA4C70", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x6001110")]
	[Address(RVA = "0xCA4D98", Offset = "0xCA4D98", VA = "0xCA4D98")]
	private void OnContractEnded(object sender, ContractEndedArgs e)
	{
	}

	[Token(Token = "0x6001111")]
	[Address(RVA = "0xCA4EA4", Offset = "0xCA4EA4", VA = "0xCA4EA4")]
	private void OnGamePreEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001112")]
	[Address(RVA = "0xCA4FB8", Offset = "0xCA4FB8", VA = "0xCA4FB8", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}
}
