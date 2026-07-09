using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000744")]
public class PowerUpItemSlotViewChallenge : PowerUpItemSlotView
{
	[Token(Token = "0x4002919")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private UILabel _costLabel;

	[Token(Token = "0x400291A")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private UISprite _costButtonBackground;

	[Token(Token = "0x400291B")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private BlinkButtonHandler _buyButtonHandler;

	[Token(Token = "0x400291C")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private ButtonHandler _tooltipHandler;

	[Token(Token = "0x400291D")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private UISprite _levelBarItemPrefab;

	[Token(Token = "0x400291E")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Transform _barHolder;

	[Token(Token = "0x400291F")]
	[FieldOffset(Offset = "0x108")]
	private PowerUp _powerUp;

	[Token(Token = "0x4002920")]
	[FieldOffset(Offset = "0x110")]
	private ChallengeData.WeaponPowerUp _weaponPowerUp;

	[Token(Token = "0x4002921")]
	[FieldOffset(Offset = "0x118")]
	private PlayerProfileData _playerProfile;

	[Token(Token = "0x4002922")]
	[FieldOffset(Offset = "0x120")]
	private List<UISprite> _barItemSprites;

	[Token(Token = "0x4002923")]
	private const float SPACE_PER_BAR = 7f;

	[Token(Token = "0x17000638")]
	public override int AttachmentIndex
	{
		[Token(Token = "0x600307B")]
		[Address(RVA = "0x944E48", Offset = "0x944E48", VA = "0x944E48", Slot = "22")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000639")]
	protected override ColorModel.ColorModelEnum LockedColor
	{
		[Token(Token = "0x600307C")]
		[Address(RVA = "0x944EB8", Offset = "0x944EB8", VA = "0x944EB8", Slot = "18")]
		get
		{
			return default(ColorModel.ColorModelEnum);
		}
	}

	[Token(Token = "0x600306D")]
	[Address(RVA = "0x943BB0", Offset = "0x943BB0", VA = "0x943BB0", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600306E")]
	[Address(RVA = "0x943CD8", Offset = "0x943CD8", VA = "0x943CD8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600306F")]
	[Address(RVA = "0x94453C", Offset = "0x94453C", VA = "0x94453C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6003070")]
	[Address(RVA = "0x944634", Offset = "0x944634", VA = "0x944634", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003071")]
	[Address(RVA = "0x9446CC", Offset = "0x9446CC", VA = "0x9446CC")]
	private void BuyAbility(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6003072")]
	[Address(RVA = "0x944A74", Offset = "0x944A74", VA = "0x944A74", Slot = "29")]
	public override bool WillUnlockNextLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6003073")]
	[Address(RVA = "0x944A7C", Offset = "0x944A7C", VA = "0x944A7C", Slot = "25")]
	public override void UpdateToolTip()
	{
	}

	[Token(Token = "0x6003074")]
	[Address(RVA = "0x944AAC", Offset = "0x944AAC", VA = "0x944AAC", Slot = "24")]
	public override TooltipTextData GetLockedToolTipText()
	{
		return null;
	}

	[Token(Token = "0x6003075")]
	[Address(RVA = "0x943EA4", Offset = "0x943EA4", VA = "0x943EA4")]
	protected void OnCurrentLevelChanged(int level)
	{
	}

	[Token(Token = "0x6003076")]
	[Address(RVA = "0x944AB4", Offset = "0x944AB4", VA = "0x944AB4")]
	private void SetBarLevel(int maxLevel, int level, int barsTotalWidth)
	{
	}

	[Token(Token = "0x6003077")]
	[Address(RVA = "0x944DBC", Offset = "0x944DBC", VA = "0x944DBC")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6003078")]
	[Address(RVA = "0x943E0C", Offset = "0x943E0C", VA = "0x943E0C")]
	protected void OnCurrentCostChanged(int cost)
	{
	}

	[Token(Token = "0x6003079")]
	[Address(RVA = "0x944E38", Offset = "0x944E38", VA = "0x944E38")]
	private void OnIsUnlockedChanged(bool unlocked)
	{
	}

	[Token(Token = "0x600307A")]
	[Address(RVA = "0x944E40", Offset = "0x944E40", VA = "0x944E40")]
	public void SetWeaponPowerUp(ChallengeData.WeaponPowerUp newWeaponPowerUp)
	{
	}

	[Token(Token = "0x600307D")]
	[Address(RVA = "0x944EC0", Offset = "0x944EC0", VA = "0x944EC0", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x600307E")]
	[Address(RVA = "0x9450DC", Offset = "0x9450DC", VA = "0x9450DC")]
	private void ShowTooltipButtonPressed(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600307F")]
	[Address(RVA = "0x945220", Offset = "0x945220", VA = "0x945220")]
	private void DisplayTooltip()
	{
	}

	[Token(Token = "0x6003080")]
	[Address(RVA = "0x9457F4", Offset = "0x9457F4", VA = "0x9457F4")]
	public Vector2 GetBackgroundSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6003081")]
	[Address(RVA = "0x94588C", Offset = "0x94588C", VA = "0x94588C")]
	public PowerUpItemSlotViewChallenge()
	{
	}
}
