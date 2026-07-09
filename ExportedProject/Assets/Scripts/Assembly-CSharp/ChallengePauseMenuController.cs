using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200050C")]
public class ChallengePauseMenuController : PauseMenuController
{
	[Token(Token = "0x4001AC8")]
	[FieldOffset(Offset = "0xE0")]
	public BlinkButtonHandler PlayButton;

	[Token(Token = "0x4001AC9")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private BlinkButtonHandler _settingsButton;

	[Token(Token = "0x4001ACA")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private BlinkButtonHandler _shopButton;

	[Token(Token = "0x6001F05")]
	[Address(RVA = "0xAF4FD4", Offset = "0xAF4FD4", VA = "0xAF4FD4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001F06")]
	[Address(RVA = "0xAF51D4", Offset = "0xAF51D4", VA = "0xAF51D4", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001F07")]
	[Address(RVA = "0xAF52D8", Offset = "0xAF52D8", VA = "0xAF52D8")]
	private void OnSettingsClicked(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001F08")]
	[Address(RVA = "0xAF5384", Offset = "0xAF5384", VA = "0xAF5384")]
	private void OnShopClicked(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001F09")]
	[Address(RVA = "0xAF542C", Offset = "0xAF542C", VA = "0xAF542C", Slot = "20")]
	public override void OnResumeClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001F0A")]
	[Address(RVA = "0xAF54F8", Offset = "0xAF54F8", VA = "0xAF54F8", Slot = "14")]
	protected override void OnApplicationPause(bool isPaused)
	{
	}

	[Token(Token = "0x6001F0B")]
	[Address(RVA = "0xAF573C", Offset = "0xAF573C", VA = "0xAF573C", Slot = "18")]
	protected override bool StartGameResume(HUDModel.PauseMenuState newState, HUDModel.PauseMenuState oldState)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F0C")]
	[Address(RVA = "0xAF5754", Offset = "0xAF5754", VA = "0xAF5754", Slot = "19")]
	protected override bool StartGamePause(HUDModel.PauseMenuState newState, HUDModel.PauseMenuState oldState)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F0D")]
	[Address(RVA = "0xAF576C", Offset = "0xAF576C", VA = "0xAF576C", Slot = "17")]
	protected override void ShowOverlayCollider(HUDModel.PauseMenuState newState, bool paused)
	{
	}

	[Token(Token = "0x6001F0E")]
	[Address(RVA = "0xAF57AC", Offset = "0xAF57AC", VA = "0xAF57AC", Slot = "23")]
	protected override bool ShouldPause(HUDModel.PauseMenuState oldState, HUDModel.PauseMenuState newState)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F0F")]
	[Address(RVA = "0xAF57E8", Offset = "0xAF57E8", VA = "0xAF57E8", Slot = "24")]
	protected override bool ShouldResume(HUDModel.PauseMenuState oldState, HUDModel.PauseMenuState newState)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F10")]
	[Address(RVA = "0xAF5824", Offset = "0xAF5824", VA = "0xAF5824")]
	public ChallengePauseMenuController()
	{
	}
}
