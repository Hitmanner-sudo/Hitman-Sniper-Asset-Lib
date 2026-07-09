using System;
using Il2CppDummyDll;

[Token(Token = "0x20002BF")]
public class TutorialEnterScope : TutorialToLearnLogic
{
	[Token(Token = "0x4000F79")]
	[FieldOffset(Offset = "0x28")]
	private float _playerSwayRatio;

	[Token(Token = "0x4000F7A")]
	[FieldOffset(Offset = "0x2C")]
	private float _timeBeforeTooltip;

	[Token(Token = "0x4000F7B")]
	[FieldOffset(Offset = "0x30")]
	private GameTimer _timebeforeTooltipTimer;

	[Token(Token = "0x60010C6")]
	[Address(RVA = "0xCA092C", Offset = "0xCA092C", VA = "0xCA092C")]
	public TutorialEnterScope(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x60010C7")]
	[Address(RVA = "0xCA0960", Offset = "0xCA0960", VA = "0xCA0960", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60010C8")]
	[Address(RVA = "0xCA0A38", Offset = "0xCA0A38", VA = "0xCA0A38", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60010C9")]
	[Address(RVA = "0xCA0ADC", Offset = "0xCA0ADC", VA = "0xCA0ADC", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x60010CA")]
	[Address(RVA = "0xCA0B4C", Offset = "0xCA0B4C", VA = "0xCA0B4C", Slot = "9")]
	protected override void DoUpdate()
	{
	}

	[Token(Token = "0x60010CB")]
	[Address(RVA = "0xCA0D64", Offset = "0xCA0D64", VA = "0xCA0D64", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x60010CC")]
	[Address(RVA = "0xCA0E90", Offset = "0xCA0E90", VA = "0xCA0E90", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x60010CD")]
	[Address(RVA = "0xCA0F44", Offset = "0xCA0F44", VA = "0xCA0F44")]
	private void OnEnterScope(object sender, EventArgs empty)
	{
	}
}
