using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000644")]
public class ChallengePauseButtonView : PauseButtonView
{
	[Token(Token = "0x4002284")]
	[FieldOffset(Offset = "0x68")]
	public BlinkButtonHandler PulseHandler;

	[Token(Token = "0x4002285")]
	[FieldOffset(Offset = "0x70")]
	public PointyTooltip ClickShopTooltip;

	[Token(Token = "0x4002286")]
	[FieldOffset(Offset = "0x78")]
	public GameObject FadeBackground;

	[Token(Token = "0x6002875")]
	[Address(RVA = "0xAF4A84", Offset = "0xAF4A84", VA = "0xAF4A84", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002876")]
	[Address(RVA = "0xAF4B3C", Offset = "0xAF4B3C", VA = "0xAF4B3C", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002877")]
	[Address(RVA = "0xAF4B0C", Offset = "0xAF4B0C", VA = "0xAF4B0C")]
	private void OnShowShopButtonPulse(bool show)
	{
	}

	[Token(Token = "0x6002878")]
	[Address(RVA = "0xAF4D48", Offset = "0xAF4D48", VA = "0xAF4D48")]
	private void OnShowClickShopTooltip(bool show)
	{
	}

	[Token(Token = "0x6002879")]
	[Address(RVA = "0xAF4EE8", Offset = "0xAF4EE8", VA = "0xAF4EE8")]
	private void OnShowButtonGOChanged(bool show)
	{
	}

	[Token(Token = "0x600287A")]
	[Address(RVA = "0xAF4F08", Offset = "0xAF4F08", VA = "0xAF4F08", Slot = "15")]
	protected override void PauseMenuStateChanged(HUDModel.PauseMenuState newValue)
	{
	}

	[Token(Token = "0x600287B")]
	[Address(RVA = "0xAF4FCC", Offset = "0xAF4FCC", VA = "0xAF4FCC")]
	public ChallengePauseButtonView()
	{
	}
}
