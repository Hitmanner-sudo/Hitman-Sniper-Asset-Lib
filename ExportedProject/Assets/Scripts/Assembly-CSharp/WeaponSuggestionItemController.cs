using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000568")]
public class WeaponSuggestionItemController : UIController
{
	[Token(Token = "0x2000569")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5952B4", Offset = "0x5952B4")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4001C9B")]
		[FieldOffset(Offset = "0x10")]
		public Action<WeaponUnlockable> onCentered;

		[Token(Token = "0x4001C9C")]
		[FieldOffset(Offset = "0x18")]
		public WeaponUnlockable weapon;

		[Token(Token = "0x6002232")]
		[Address(RVA = "0xA42D98", Offset = "0xA42D98", VA = "0xA42D98")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6002233")]
		[Address(RVA = "0xA42DA0", Offset = "0xA42DA0", VA = "0xA42DA0")]
		internal void _003CGoToArmory_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4001C97")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _buyButton;

	[Token(Token = "0x4001C98")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BlinkButtonHandler _buyButtonWithPrice;

	[Token(Token = "0x4001C99")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private BlinkButtonHandler _equipButton;

	[Token(Token = "0x4001C9A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private BlinkButtonHandler _upgradeButton;

	[Token(Token = "0x6002229")]
	[Address(RVA = "0x98D740", Offset = "0x98D740", VA = "0x98D740", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600222A")]
	[Address(RVA = "0x98D8AC", Offset = "0x98D8AC", VA = "0x98D8AC", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600222B")]
	[Address(RVA = "0x98DA18", Offset = "0x98DA18", VA = "0x98DA18")]
	private void OnBuyButtonClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs e)
	{
	}

	[Token(Token = "0x600222C")]
	[Address(RVA = "0x98DDF0", Offset = "0x98DDF0", VA = "0x98DDF0")]
	private static void OnWeaponCenteredForBuy(WeaponUnlockable weapon)
	{
	}

	[Token(Token = "0x600222D")]
	[Address(RVA = "0x98DE9C", Offset = "0x98DE9C", VA = "0x98DE9C")]
	private void OnEquipButtonClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs e)
	{
	}

	[Token(Token = "0x600222E")]
	[Address(RVA = "0x98E0F8", Offset = "0x98E0F8", VA = "0x98E0F8")]
	private void EquipWeapon()
	{
	}

	[Token(Token = "0x600222F")]
	[Address(RVA = "0x98E238", Offset = "0x98E238", VA = "0x98E238")]
	private void OnUpgradeClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6002230")]
	[Address(RVA = "0x98DC74", Offset = "0x98DC74", VA = "0x98DC74")]
	private void GoToArmory(Action<WeaponUnlockable> onCentered)
	{
	}

	[Token(Token = "0x6002231")]
	[Address(RVA = "0x98E444", Offset = "0x98E444", VA = "0x98E444")]
	public WeaponSuggestionItemController()
	{
	}
}
