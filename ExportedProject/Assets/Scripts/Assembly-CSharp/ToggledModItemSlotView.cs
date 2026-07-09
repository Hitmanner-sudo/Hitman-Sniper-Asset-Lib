using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000767")]
public class ToggledModItemSlotView : View
{
	[Token(Token = "0x40029E8")]
	[FieldOffset(Offset = "0x60")]
	public UITexture ModImage;

	[Token(Token = "0x40029E9")]
	[FieldOffset(Offset = "0x68")]
	public UISprite Background;

	[Token(Token = "0x40029EA")]
	[FieldOffset(Offset = "0x70")]
	public BlinkButtonHandler Button;

	[Token(Token = "0x40029EB")]
	[FieldOffset(Offset = "0x78")]
	public UISprite BuyButtonBackground;

	[Token(Token = "0x40029EC")]
	[FieldOffset(Offset = "0x80")]
	public UILabel CostLabel;

	[Token(Token = "0x1700064C")]
	protected ColorModel.ColorModelEnum _lockedBackgroundColor
	{
		[Token(Token = "0x600313D")]
		[Address(RVA = "0xAD15C8", Offset = "0xAD15C8", VA = "0xAD15C8")]
		get
		{
			return default(ColorModel.ColorModelEnum);
		}
	}

	[Token(Token = "0x1700064D")]
	protected ColorModel.ColorModelEnum UnlockedBackgroundColor
	{
		[Token(Token = "0x600313E")]
		[Address(RVA = "0xAD15D0", Offset = "0xAD15D0", VA = "0xAD15D0")]
		get
		{
			return default(ColorModel.ColorModelEnum);
		}
	}

	[Token(Token = "0x600313F")]
	[Address(RVA = "0xAD15D8", Offset = "0xAD15D8", VA = "0xAD15D8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6003140")]
	[Address(RVA = "0xAD1C38", Offset = "0xAD1C38", VA = "0xAD1C38", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6003141")]
	[Address(RVA = "0xAD1788", Offset = "0xAD1788", VA = "0xAD1788")]
	private void OnModUnlockedChanged(bool unlocked)
	{
	}

	[Token(Token = "0x6003142")]
	[Address(RVA = "0xAD16A0", Offset = "0xAD16A0", VA = "0xAD16A0")]
	private void OnModChanged(ToggledMod toggledMod)
	{
	}

	[Token(Token = "0x6003143")]
	[Address(RVA = "0xAD1920", Offset = "0xAD1920", VA = "0xAD1920")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6003144")]
	[Address(RVA = "0xAD1DD8", Offset = "0xAD1DD8", VA = "0xAD1DD8")]
	public Vector2 GetBackgroundSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6003145")]
	[Address(RVA = "0xAD1E70", Offset = "0xAD1E70", VA = "0xAD1E70")]
	public ToggledModItemSlotView()
	{
	}
}
