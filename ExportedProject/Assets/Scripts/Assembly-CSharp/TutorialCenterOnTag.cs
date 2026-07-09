using System;
using Il2CppDummyDll;

[Token(Token = "0x20002BE")]
public class TutorialCenterOnTag : TutorialToLearnLogic
{
	[Token(Token = "0x4000F76")]
	[FieldOffset(Offset = "0x28")]
	private float _tooltipDisplayMaxTime;

	[Token(Token = "0x4000F77")]
	[FieldOffset(Offset = "0x30")]
	private GameTimer _gameTimer;

	[Token(Token = "0x4000F78")]
	[FieldOffset(Offset = "0x38")]
	private bool _wasValid;

	[Token(Token = "0x60010BE")]
	[Address(RVA = "0xCA0108", Offset = "0xCA0108", VA = "0xCA0108")]
	public TutorialCenterOnTag(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x60010BF")]
	[Address(RVA = "0xCA0188", Offset = "0xCA0188", VA = "0xCA0188", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60010C0")]
	[Address(RVA = "0xCA02A8", Offset = "0xCA02A8", VA = "0xCA02A8", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60010C1")]
	[Address(RVA = "0xCA034C", Offset = "0xCA034C", VA = "0xCA034C", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x60010C2")]
	[Address(RVA = "0xCA03CC", Offset = "0xCA03CC", VA = "0xCA03CC", Slot = "9")]
	protected override void DoUpdate()
	{
	}

	[Token(Token = "0x60010C3")]
	[Address(RVA = "0xCA0734", Offset = "0xCA0734", VA = "0xCA0734", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x60010C4")]
	[Address(RVA = "0xCA0868", Offset = "0xCA0868", VA = "0xCA0868", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x60010C5")]
	[Address(RVA = "0xCA091C", Offset = "0xCA091C", VA = "0xCA091C")]
	private void OnClickbaleTagClicked(object nullObject, EventArgs empty)
	{
	}
}
