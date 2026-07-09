using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x200073F")]
public class PopupStarterPackView : PopupOverlayView
{
	[Serializable]
	[Token(Token = "0x2000740")]
	private struct WeaponImageMapping
	{
		[Token(Token = "0x4002914")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private LazyWeaponUnlockable _weapon;

		[Token(Token = "0x4002915")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private LazyTexture _texture;

		[Token(Token = "0x17000633")]
		public WeaponUnlockable Weapon
		{
			[Token(Token = "0x6003061")]
			[Address(RVA = "0x8AF798", Offset = "0x8AF798", VA = "0x8AF798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000634")]
		public Texture Texture
		{
			[Token(Token = "0x6003062")]
			[Address(RVA = "0x8AF82C", Offset = "0x8AF82C", VA = "0x8AF82C")]
			get
			{
				return null;
			}
		}
	}

	[Token(Token = "0x4002906")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private UILabel _weaponMultiplierUILabel;

	[Token(Token = "0x4002907")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private UILabel _goldUILabel;

	[Token(Token = "0x4002908")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private UILabel _challengeTokenUILabel;

	[Token(Token = "0x4002909")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private UILabel _rebatePercentageUILabel;

	[Token(Token = "0x400290A")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private GameObject _rebatePercentageGO;

	[Token(Token = "0x400290B")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private UILabel _onSaleLabel;

	[Token(Token = "0x400290C")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private UILabel _onSaleCostBottomLabel;

	[Token(Token = "0x400290D")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private UILabel _onSaleCostTopLabel;

	[Token(Token = "0x400290E")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private UISprite _onSaleCostTopSlashSprite;

	[Token(Token = "0x400290F")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private GameObject _onSaleBannerGO;

	[Token(Token = "0x4002910")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private GameObject _onlineBuyButtonGO;

	[Token(Token = "0x4002911")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private GameObject _offlineBuyButtonGO;

	[Token(Token = "0x4002912")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	private UILabel _weaponNameLabel;

	[Token(Token = "0x4002913")]
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	private List<WeaponImageMapping> _weaponImageMappings;

	[Token(Token = "0x600305B")]
	[Address(RVA = "0x93C4F8", Offset = "0x93C4F8", VA = "0x93C4F8")]
	public void SetupPopupOverlay(Offer starterPackOffer, Action cancelCallback, Action exitCallback)
	{
	}

	[Token(Token = "0x600305C")]
	[Address(RVA = "0x93CA68", Offset = "0x93CA68", VA = "0x93CA68")]
	private void SetupWeaponInformation(Credit credit)
	{
	}

	[Token(Token = "0x600305D")]
	[Address(RVA = "0x93CC90", Offset = "0x93CC90", VA = "0x93CC90")]
	private WeaponUnlockable FindWeaponByItemId(string itemId)
	{
		return null;
	}

	[Token(Token = "0x600305E")]
	[Address(RVA = "0x93CF60", Offset = "0x93CF60", VA = "0x93CF60")]
	private Texture GetWeaponTexture(WeaponUnlockable weapon)
	{
		return null;
	}

	[Token(Token = "0x600305F")]
	[Address(RVA = "0x93C93C", Offset = "0x93C93C", VA = "0x93C93C")]
	private static void SetCurrencyRewardDisplay(UILabel currencyUILabel, Credit credit)
	{
	}

	[Token(Token = "0x6003060")]
	[Address(RVA = "0x93D084", Offset = "0x93D084", VA = "0x93D084")]
	public PopupStarterPackView()
	{
	}
}
