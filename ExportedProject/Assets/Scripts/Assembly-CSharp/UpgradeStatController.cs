using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000567")]
public class UpgradeStatController : UIController
{
	[Token(Token = "0x4001C90")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _plusBlinkButtonHandler;

	[Token(Token = "0x4001C91")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ButtonHandler _showTooltipButtonHandler;

	[Token(Token = "0x4001C92")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PointyTooltip _pointyTooltip;

	[Token(Token = "0x4001C93")]
	[FieldOffset(Offset = "0x68")]
	private Action<WeaponData, GameplayConfig, int> _gradeSetter;

	[Token(Token = "0x4001C94")]
	[FieldOffset(Offset = "0x70")]
	private Func<int, float> _upgradePercentageFunc;

	[Token(Token = "0x4001C95")]
	[FieldOffset(Offset = "0x78")]
	private GameplayConfig _config;

	[Token(Token = "0x4001C96")]
	[FieldOffset(Offset = "0x80")]
	private Weapon _weapon;

	[Token(Token = "0x6002220")]
	[Address(RVA = "0xB9DE90", Offset = "0xB9DE90", VA = "0xB9DE90", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002221")]
	[Address(RVA = "0xB9DF7C", Offset = "0xB9DF7C", VA = "0xB9DF7C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002222")]
	[Address(RVA = "0xB9E1B0", Offset = "0xB9E1B0", VA = "0xB9E1B0", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002223")]
	[Address(RVA = "0xB9E31C", Offset = "0xB9E31C", VA = "0xB9E31C")]
	public void SetStatsController(UpgradeStatModel statModel, Action<WeaponData, GameplayConfig, int> setter, Func<int, float> upgradePercentageFunc)
	{
	}

	[Token(Token = "0x6002224")]
	[Address(RVA = "0xB9E3A0", Offset = "0xB9E3A0", VA = "0xB9E3A0")]
	private void PlusButtonBlinkFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002225")]
	[Address(RVA = "0xB9E0A4", Offset = "0xB9E0A4", VA = "0xB9E0A4")]
	public void SetWeaponData()
	{
	}

	[Token(Token = "0x6002226")]
	[Address(RVA = "0xB9E5FC", Offset = "0xB9E5FC", VA = "0xB9E5FC")]
	private void ShowTooltipButtonPressed(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002227")]
	[Address(RVA = "0xB9E754", Offset = "0xB9E754", VA = "0xB9E754")]
	private void DisplayTooltip()
	{
	}

	[Token(Token = "0x6002228")]
	[Address(RVA = "0xB9EB20", Offset = "0xB9EB20", VA = "0xB9EB20")]
	public UpgradeStatController()
	{
	}
}
