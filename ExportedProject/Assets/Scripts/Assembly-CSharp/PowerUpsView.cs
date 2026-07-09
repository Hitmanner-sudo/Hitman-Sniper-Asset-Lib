using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006C2")]
public class PowerUpsView : View
{
	[Token(Token = "0x40025F7")]
	[FieldOffset(Offset = "0x60")]
	public GameObject PowerUpsGO;

	[Token(Token = "0x40025F8")]
	[FieldOffset(Offset = "0x68")]
	public PointyTooltip PowerUpTooltip;

	[Token(Token = "0x6002C77")]
	[Address(RVA = "0xB3787C", Offset = "0xB3787C", VA = "0xB3787C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002C78")]
	[Address(RVA = "0xB37C6C", Offset = "0xB37C6C", VA = "0xB37C6C", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002C79")]
	[Address(RVA = "0xB38028", Offset = "0xB38028", VA = "0xB38028")]
	private void OnShowPauseMenuChanged(HUDModel.PauseMenuState newState, HUDModel.PauseMenuState oldState)
	{
	}

	[Token(Token = "0x6002C7A")]
	[Address(RVA = "0xB37994", Offset = "0xB37994", VA = "0xB37994")]
	private void OnPowerUpsDisplayedChanged(bool displayed)
	{
	}

	[Token(Token = "0x6002C7B")]
	[Address(RVA = "0xB379B4", Offset = "0xB379B4", VA = "0xB379B4")]
	private void OnShowPowerUpTooltipChanged(bool show)
	{
	}

	[Token(Token = "0x6002C7C")]
	[Address(RVA = "0xB37AC4", Offset = "0xB37AC4", VA = "0xB37AC4")]
	private void OnSetPowerUpTooltipTextChanged(string text)
	{
	}

	[Token(Token = "0x6002C7D")]
	[Address(RVA = "0xB38348", Offset = "0xB38348", VA = "0xB38348")]
	private string GetPowerUpText(string textFormat)
	{
		return null;
	}

	[Token(Token = "0x6002C7E")]
	[Address(RVA = "0xB38138", Offset = "0xB38138", VA = "0xB38138")]
	private bool DisplayPowerUpToolTip(PointyTooltip pointyTooltip, bool mainPowerupTooltip)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C7F")]
	[Address(RVA = "0xB37B78", Offset = "0xB37B78", VA = "0xB37B78")]
	private void OnPowerUpHighlightActiveChanged(bool active)
	{
	}

	[Token(Token = "0x6002C80")]
	[Address(RVA = "0xB384B0", Offset = "0xB384B0", VA = "0xB384B0")]
	public PowerUpsView()
	{
	}
}
