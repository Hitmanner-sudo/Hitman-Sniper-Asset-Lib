using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000531")]
public class PerksController : UIController
{
	[Token(Token = "0x4001B8E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _bannerButton;

	[Token(Token = "0x4001B8F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private LazyWeaponUnlockable _zombieWeaponIAPLazyWeaponUnlockable;

	[Token(Token = "0x6002065")]
	[Address(RVA = "0x9024E0", Offset = "0x9024E0", VA = "0x9024E0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002066")]
	[Address(RVA = "0x9025E0", Offset = "0x9025E0", VA = "0x9025E0", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002067")]
	[Address(RVA = "0x90271C", Offset = "0x90271C", VA = "0x90271C")]
	private void OnBannerButtonBlinkFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002068")]
	[Address(RVA = "0x9027DC", Offset = "0x9027DC", VA = "0x9027DC")]
	public PerksController()
	{
	}
}
