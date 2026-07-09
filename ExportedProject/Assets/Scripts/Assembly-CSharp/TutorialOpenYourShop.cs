using Il2CppDummyDll;

[Token(Token = "0x20002CD")]
public class TutorialOpenYourShop : TutorialToLearnLogic
{
	[Token(Token = "0x6001133")]
	[Address(RVA = "0xCA7FCC", Offset = "0xCA7FCC", VA = "0xCA7FCC")]
	public TutorialOpenYourShop(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x6001134")]
	[Address(RVA = "0xCA7FF8", Offset = "0xCA7FF8", VA = "0xCA7FF8", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6001135")]
	[Address(RVA = "0xCA80D0", Offset = "0xCA80D0", VA = "0xCA80D0", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x6001136")]
	[Address(RVA = "0xCA8174", Offset = "0xCA8174", VA = "0xCA8174", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x6001137")]
	[Address(RVA = "0xCA839C", Offset = "0xCA839C", VA = "0xCA839C", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x6001138")]
	[Address(RVA = "0xCA859C", Offset = "0xCA859C", VA = "0xCA859C")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001139")]
	[Address(RVA = "0xCA86D0", Offset = "0xCA86D0", VA = "0xCA86D0", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}
}
