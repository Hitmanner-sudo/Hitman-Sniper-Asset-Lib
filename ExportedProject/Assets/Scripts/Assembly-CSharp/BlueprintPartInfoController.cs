using Il2CppDummyDll;

[Token(Token = "0x2000551")]
[Attribute(Name = "RequireComponent", RVA = "0x5951D4", Offset = "0x5951D4")]
public class BlueprintPartInfoController : UIController
{
	[Token(Token = "0x4001C3A")]
	[FieldOffset(Offset = "0x50")]
	public BlinkButtonHandler BackButton;

	[Token(Token = "0x4001C3B")]
	[FieldOffset(Offset = "0x58")]
	public BlinkButtonHandler PurchaseButton;

	[Token(Token = "0x4001C3C")]
	[FieldOffset(Offset = "0x60")]
	private BlueprintPartInfoView _selfView;

	[Token(Token = "0x600217F")]
	[Address(RVA = "0xA76EEC", Offset = "0xA76EEC", VA = "0xA76EEC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002180")]
	[Address(RVA = "0xA77008", Offset = "0xA77008", VA = "0xA77008", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002181")]
	[Address(RVA = "0xA77150", Offset = "0xA77150", VA = "0xA77150")]
	private void OnPurchaseClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002182")]
	[Address(RVA = "0xA77178", Offset = "0xA77178", VA = "0xA77178")]
	private void OnBackClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002183")]
	[Address(RVA = "0xA771A0", Offset = "0xA771A0", VA = "0xA771A0")]
	public BlueprintPartInfoController()
	{
	}
}
