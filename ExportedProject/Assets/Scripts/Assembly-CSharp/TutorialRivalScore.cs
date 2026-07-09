using System;
using Il2CppDummyDll;

[Token(Token = "0x20002D6")]
public class TutorialRivalScore : TutorialToLearnLogic
{
	[Token(Token = "0x4000FAD")]
	[FieldOffset(Offset = "0x28")]
	private float _rivalScoreTooltipTimer;

	[Token(Token = "0x4000FAE")]
	[FieldOffset(Offset = "0x2C")]
	private float _rivalScoreAccumulateTime;

	[Token(Token = "0x6001177")]
	[Address(RVA = "0xCAA48C", Offset = "0xCAA48C", VA = "0xCAA48C")]
	public TutorialRivalScore(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x6001178")]
	[Address(RVA = "0xCAA4C0", Offset = "0xCAA4C0", VA = "0xCAA4C0", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6001179")]
	[Address(RVA = "0xCAA5D4", Offset = "0xCAA5D4", VA = "0xCAA5D4", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x600117A")]
	[Address(RVA = "0xCAA678", Offset = "0xCAA678", VA = "0xCAA678", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x600117B")]
	[Address(RVA = "0xCAA7A0", Offset = "0xCAA7A0", VA = "0xCAA7A0", Slot = "9")]
	protected override void DoUpdate()
	{
	}

	[Token(Token = "0x600117C")]
	[Address(RVA = "0xCAA89C", Offset = "0xCAA89C", VA = "0xCAA89C", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x600117D")]
	[Address(RVA = "0xCAA95C", Offset = "0xCAA95C", VA = "0xCAA95C", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x600117E")]
	[Address(RVA = "0xCAAA10", Offset = "0xCAAA10", VA = "0xCAAA10")]
	private void OnScorePanelClicked(object sender, EventArgs args)
	{
	}
}
