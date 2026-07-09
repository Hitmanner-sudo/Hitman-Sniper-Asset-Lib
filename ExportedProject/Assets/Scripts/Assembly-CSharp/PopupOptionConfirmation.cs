using System;
using Il2CppDummyDll;

[Token(Token = "0x2000738")]
public class PopupOptionConfirmation : PopupOverlayView
{
	[Token(Token = "0x40028E0")]
	[FieldOffset(Offset = "0x100")]
	public BlinkButtonHandler AbortButton;

	[Token(Token = "0x6003027")]
	[Address(RVA = "0x938DE8", Offset = "0x938DE8", VA = "0x938DE8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6003028")]
	[Address(RVA = "0x938ED8", Offset = "0x938ED8", VA = "0x938ED8", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6003029")]
	[Address(RVA = "0x938FB8", Offset = "0x938FB8", VA = "0x938FB8")]
	public void SetupPopupOverlay(Action okCallback, Action cancelCallback)
	{
	}

	[Token(Token = "0x600302A")]
	[Address(RVA = "0x93906C", Offset = "0x93906C", VA = "0x93906C")]
	public PopupOptionConfirmation()
	{
	}
}
