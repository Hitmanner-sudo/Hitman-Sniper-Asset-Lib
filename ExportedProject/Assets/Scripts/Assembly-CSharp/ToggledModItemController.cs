using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200055E")]
public class ToggledModItemController : UIController
{
	[Token(Token = "0x4001C78")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected BlinkButtonHandler _purchaseButtonHandler;

	[Token(Token = "0x4001C79")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected ButtonHandler _backgroundButtonHandler;

	[Token(Token = "0x4001C7A")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected PointyTooltip _pointyTooltip;

	[Token(Token = "0x4001C7B")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected int _tooltipSpaceBetweenSections;

	[Token(Token = "0x60021F5")]
	[Address(RVA = "0xAD07A0", Offset = "0xAD07A0", VA = "0xAD07A0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60021F6")]
	[Address(RVA = "0xAD0968", Offset = "0xAD0968", VA = "0xAD0968", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60021F7")]
	[Address(RVA = "0xAD0B4C", Offset = "0xAD0B4C", VA = "0xAD0B4C")]
	protected void OnBackgroundButtonPressed(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x60021F8")]
	[Address(RVA = "0xAD0E40", Offset = "0xAD0E40", VA = "0xAD0E40")]
	private void PurchaseMod(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x60021F9")]
	[Address(RVA = "0xAD0CC0", Offset = "0xAD0CC0", VA = "0xAD0CC0")]
	protected void DisplayTooltip(ToggledMod mod)
	{
	}

	[Token(Token = "0x60021FA")]
	[Address(RVA = "0xAD116C", Offset = "0xAD116C", VA = "0xAD116C")]
	public ToggledModItemController()
	{
	}
}
