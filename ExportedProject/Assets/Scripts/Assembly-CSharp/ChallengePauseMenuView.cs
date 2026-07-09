using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000645")]
public class ChallengePauseMenuView : PauseMenuView
{
	[Token(Token = "0x4002287")]
	[FieldOffset(Offset = "0x140")]
	public UILabel GamePausedLabel;

	[Token(Token = "0x4002288")]
	[FieldOffset(Offset = "0x148")]
	public UILabel IGCLabel;

	[Token(Token = "0x4002289")]
	[FieldOffset(Offset = "0x150")]
	public BlinkButtonHandler StartButtonHandler;

	[Token(Token = "0x400228A")]
	[FieldOffset(Offset = "0x158")]
	public GameObject PlayButton;

	[Token(Token = "0x400228B")]
	[FieldOffset(Offset = "0x160")]
	public UISprite PlayButtonSprite;

	[Token(Token = "0x400228C")]
	[FieldOffset(Offset = "0x168")]
	public GameObject UpgradePageContainer;

	[Token(Token = "0x400228D")]
	[FieldOffset(Offset = "0x170")]
	public BlinkButtonHandler ResumeBlinkButtonHandler;

	[Token(Token = "0x400228E")]
	[FieldOffset(Offset = "0x178")]
	private UpgradeView _upgradeView;

	[Token(Token = "0x600287C")]
	[Address(RVA = "0xAF5B3C", Offset = "0xAF5B3C", VA = "0xAF5B3C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600287D")]
	[Address(RVA = "0xAF5E38", Offset = "0xAF5E38", VA = "0xAF5E38", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600287E")]
	[Address(RVA = "0xAF5F8C", Offset = "0xAF5F8C", VA = "0xAF5F8C", Slot = "20")]
	protected override void PopulateRogueIconGrid()
	{
	}

	[Token(Token = "0x600287F")]
	[Address(RVA = "0xAF5F94", Offset = "0xAF5F94", VA = "0xAF5F94", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002880")]
	[Address(RVA = "0xAF5F24", Offset = "0xAF5F24", VA = "0xAF5F24")]
	private void OnChallengePauseStateChanged(ChallengePauseMenuModel.ChallengePauseMenuState state)
	{
	}

	[Token(Token = "0x6002881")]
	[Address(RVA = "0xAF61D4", Offset = "0xAF61D4", VA = "0xAF61D4", Slot = "21")]
	protected override void CheckForRogueDeath(object sender, TargetDamagedEventArgs args)
	{
	}

	[Token(Token = "0x6002882")]
	[Address(RVA = "0xAF60EC", Offset = "0xAF60EC", VA = "0xAF60EC")]
	protected void OnIGCChanged()
	{
	}

	[Token(Token = "0x6002883")]
	[Address(RVA = "0xAF61D8", Offset = "0xAF61D8", VA = "0xAF61D8", Slot = "19")]
	protected override HashSet<HUDModel.PauseMenuState> GetVisibleStates()
	{
		return null;
	}

	[Token(Token = "0x6002884")]
	[Address(RVA = "0xAF62B0", Offset = "0xAF62B0", VA = "0xAF62B0", Slot = "17")]
	protected override void SetPauseMenuActive(HUDModel.PauseMenuState newState)
	{
	}

	[Token(Token = "0x6002885")]
	[Address(RVA = "0xAF63E8", Offset = "0xAF63E8", VA = "0xAF63E8", Slot = "16")]
	protected override void SetSlidingPanelPos(HUDModel.PauseMenuState newState, ref Vector3 slidingPanelPos)
	{
	}

	[Token(Token = "0x6002886")]
	[Address(RVA = "0xAF6444", Offset = "0xAF6444", VA = "0xAF6444", Slot = "22")]
	protected override void OnPanelSlideFinished()
	{
	}

	[Token(Token = "0x6002887")]
	[Address(RVA = "0xAF6508", Offset = "0xAF6508", VA = "0xAF6508")]
	public ChallengePauseMenuView()
	{
	}
}
