using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006C0")]
public class PowerUpView : View
{
	[Token(Token = "0x40025DA")]
	[FieldOffset(Offset = "0x60")]
	public UICircleProgressBar ProgressIndicator;

	[Token(Token = "0x40025DB")]
	[FieldOffset(Offset = "0x68")]
	public UITexture Icon;

	[Token(Token = "0x40025DC")]
	[FieldOffset(Offset = "0x70")]
	public UITexture IconFlash;

	[Token(Token = "0x40025DD")]
	[FieldOffset(Offset = "0x78")]
	public UISprite Background;

	[Token(Token = "0x40025DE")]
	[FieldOffset(Offset = "0x80")]
	public UISprite Foreground;

	[Token(Token = "0x40025DF")]
	[FieldOffset(Offset = "0x88")]
	public UISprite Arrow;

	[Token(Token = "0x40025E0")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject _pointyToolTipPrefab;

	[Token(Token = "0x40025E1")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private ColorModel.ColorModelEnum _disabledIconColor;

	[Token(Token = "0x40025E2")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private ColorModel.ColorModelEnum _disabledForegroundColor;

	[Token(Token = "0x40025E3")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private ColorModel.ColorModelEnum _disabledBackgroundColor;

	[Token(Token = "0x40025E4")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private ColorModel.ColorModelEnum _enabledIconColor;

	[Token(Token = "0x40025E5")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private ColorModel.ColorModelEnum _enabledForegroundColor;

	[Token(Token = "0x40025E6")]
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	private ColorModel.ColorModelEnum _enabledBackgroundColor;

	[Token(Token = "0x40025E7")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private ColorModel.ColorModelEnum _activatedIconColor;

	[Token(Token = "0x40025E8")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private ColorModel.ColorModelEnum _activatedForegroundColor;

	[Token(Token = "0x40025E9")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private ColorModel.ColorModelEnum _activatedOneUseOnlyIconColor;

	[Token(Token = "0x40025EA")]
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	private ColorModel.ColorModelEnum _activatedOneUseOnlyForegroundColor;

	[Token(Token = "0x40025EB")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private ColorModel.ColorModelEnum _activatedBackgroundColor;

	[Token(Token = "0x40025EC")]
	[FieldOffset(Offset = "0xC4")]
	[SerializeField]
	private ColorModel.ColorModelEnum _cooldownIconColor;

	[Token(Token = "0x40025ED")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private ColorModel.ColorModelEnum _cooldownForegroundColor;

	[Token(Token = "0x40025EE")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	private ColorModel.ColorModelEnum _cooldownBackgroundColor;

	[Token(Token = "0x40025EF")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GameObject _foregroundFlashGO;

	[Token(Token = "0x40025F0")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private GameObject _iconFlashGO;

	[Token(Token = "0x40025F1")]
	[FieldOffset(Offset = "0xE0")]
	private PointyTooltip _pointyTooltip;

	[Token(Token = "0x40025F2")]
	[FieldOffset(Offset = "0xE8")]
	private GameTimer _activeTimer;

	[Token(Token = "0x40025F3")]
	[FieldOffset(Offset = "0xF0")]
	private GameTimer _cooldownTimer;

	[Token(Token = "0x6002C67")]
	[Address(RVA = "0x945F0C", Offset = "0x945F0C", VA = "0x945F0C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002C68")]
	[Address(RVA = "0x946074", Offset = "0x946074", VA = "0x946074", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002C69")]
	[Address(RVA = "0x9462D0", Offset = "0x9462D0", VA = "0x9462D0")]
	private void OnShowTooltipChanged(bool isVisible)
	{
	}

	[Token(Token = "0x6002C6A")]
	[Address(RVA = "0x945FE8", Offset = "0x945FE8", VA = "0x945FE8")]
	private void UpdateColors()
	{
	}

	[Token(Token = "0x6002C6B")]
	[Address(RVA = "0x946B78", Offset = "0x946B78", VA = "0x946B78")]
	private void UpdateLockedColor()
	{
	}

	[Token(Token = "0x6002C6C")]
	[Address(RVA = "0x946A04", Offset = "0x946A04", VA = "0x946A04")]
	private void UpdateUnlockedColor()
	{
	}

	[Token(Token = "0x6002C6D")]
	[Address(RVA = "0x946CE0", Offset = "0x946CE0", VA = "0x946CE0")]
	private void SetColors(ColorModel.ColorModelEnum iconColor, ColorModel.ColorModelEnum foregroundColor, ColorModel.ColorModelEnum backgroundColor)
	{
	}

	[Token(Token = "0x6002C6E")]
	[Address(RVA = "0x946870", Offset = "0x946870", VA = "0x946870")]
	private void OnIsCooldownChanged(bool isOnCooldown)
	{
	}

	[Token(Token = "0x6002C6F")]
	[Address(RVA = "0x946DE8", Offset = "0x946DE8", VA = "0x946DE8", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6002C70")]
	[Address(RVA = "0x946F04", Offset = "0x946F04", VA = "0x946F04")]
	public PowerUpView()
	{
	}
}
