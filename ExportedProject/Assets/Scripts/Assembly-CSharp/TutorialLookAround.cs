using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002C9")]
public class TutorialLookAround : TutorialToLearnLogic
{
	[Token(Token = "0x4000F91")]
	[FieldOffset(Offset = "0x28")]
	private float _dragAmountToComplete;

	[Token(Token = "0x4000F92")]
	[FieldOffset(Offset = "0x2C")]
	private float _dragAmountAccumulated;

	[Token(Token = "0x600111B")]
	[Address(RVA = "0xCA56F4", Offset = "0xCA56F4", VA = "0xCA56F4")]
	public TutorialLookAround(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x600111C")]
	[Address(RVA = "0xCA5728", Offset = "0xCA5728", VA = "0xCA5728", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600111D")]
	[Address(RVA = "0xCA5800", Offset = "0xCA5800", VA = "0xCA5800", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x600111E")]
	[Address(RVA = "0xCA58A4", Offset = "0xCA58A4", VA = "0xCA58A4", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x600111F")]
	[Address(RVA = "0xCA5A20", Offset = "0xCA5A20", VA = "0xCA5A20", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x6001120")]
	[Address(RVA = "0xCA5C10", Offset = "0xCA5C10", VA = "0xCA5C10", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x6001121")]
	[Address(RVA = "0xCA5CC4", Offset = "0xCA5CC4", VA = "0xCA5CC4")]
	private void UpdateAiming(FingerInput.FingerID finger, Vector2 drag)
	{
	}
}
