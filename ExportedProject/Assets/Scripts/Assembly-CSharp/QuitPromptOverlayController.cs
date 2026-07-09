using System;
using Il2CppDummyDll;

[Token(Token = "0x200053E")]
public class QuitPromptOverlayController : UIController
{
	[Token(Token = "0x200053F")]
	public delegate void OnPressedButton();

	[Token(Token = "0x4001BC5")]
	[FieldOffset(Offset = "0x50")]
	public BlinkButtonHandler ConfirmButton;

	[Token(Token = "0x4001BC6")]
	[FieldOffset(Offset = "0x58")]
	public BlinkButtonHandler CancelButton;

	[Token(Token = "0x4001BC7")]
	[FieldOffset(Offset = "0x60")]
	public UILabel RestartText;

	[Token(Token = "0x4001BC8")]
	[FieldOffset(Offset = "0x68")]
	public UILabel QuitText;

	[NonSerialized]
	[Token(Token = "0x4001BC9")]
	[FieldOffset(Offset = "0x70")]
	public bool IsRestart;

	[Token(Token = "0x4001BCA")]
	[FieldOffset(Offset = "0x78")]
	public OnPressedButton OnConfirm;

	[Token(Token = "0x4001BCB")]
	[FieldOffset(Offset = "0x80")]
	public OnPressedButton OnCancel;

	[Token(Token = "0x60020C5")]
	[Address(RVA = "0xB3DD28", Offset = "0xB3DD28", VA = "0xB3DD28", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60020C6")]
	[Address(RVA = "0xB3DF18", Offset = "0xB3DF18", VA = "0xB3DF18", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60020C7")]
	[Address(RVA = "0xB3E060", Offset = "0xB3E060", VA = "0xB3E060")]
	private void OnConfirmClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x60020C8")]
	[Address(RVA = "0xB3E0B0", Offset = "0xB3E0B0", VA = "0xB3E0B0")]
	private void OnCancelClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x60020C9")]
	[Address(RVA = "0xB3E100", Offset = "0xB3E100", VA = "0xB3E100")]
	public QuitPromptOverlayController()
	{
	}
}
