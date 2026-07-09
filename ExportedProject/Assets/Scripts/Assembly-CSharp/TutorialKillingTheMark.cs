using System;
using Il2CppDummyDll;

[Token(Token = "0x20002C8")]
public class TutorialKillingTheMark : TutorialToLearnLogic
{
	[Token(Token = "0x4000F90")]
	[FieldOffset(Offset = "0x28")]
	private bool _isDisplayed;

	[Token(Token = "0x6001113")]
	[Address(RVA = "0xCA506C", Offset = "0xCA506C", VA = "0xCA506C")]
	public TutorialKillingTheMark(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x6001114")]
	[Address(RVA = "0xCA5098", Offset = "0xCA5098", VA = "0xCA5098", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6001115")]
	[Address(RVA = "0xCA5170", Offset = "0xCA5170", VA = "0xCA5170", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x6001116")]
	[Address(RVA = "0xCA5214", Offset = "0xCA5214", VA = "0xCA5214", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x6001117")]
	[Address(RVA = "0xCA52F8", Offset = "0xCA52F8", VA = "0xCA52F8", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x6001118")]
	[Address(RVA = "0xCA5420", Offset = "0xCA5420", VA = "0xCA5420")]
	private void OnContractEnded(object sender, ContractEndedArgs e)
	{
	}

	[Token(Token = "0x6001119")]
	[Address(RVA = "0xCA552C", Offset = "0xCA552C", VA = "0xCA552C")]
	private void OnGamePreEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x600111A")]
	[Address(RVA = "0xCA5640", Offset = "0xCA5640", VA = "0xCA5640", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}
}
