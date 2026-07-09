using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000777")]
public class WeaponSuggestionItemView : View
{
	[Serializable]
	[Token(Token = "0x2000778")]
	private struct BuyButtonInfo
	{
		[Token(Token = "0x4002A4A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GameObject _button;

		[Token(Token = "0x4002A4B")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private UILabel _buttonLabel;

		[Token(Token = "0x4002A4C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UILabel _currentPriceLabel;

		[Token(Token = "0x4002A4D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UILabel _originalCostLabel;

		[Token(Token = "0x4002A4E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UISprite _strikethroughSprite;

		[Token(Token = "0x17000659")]
		public GameObject Button
		{
			[Token(Token = "0x60031B8")]
			[Address(RVA = "0xA42DF8", Offset = "0xA42DF8", VA = "0xA42DF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065A")]
		public UILabel ButtonLabel
		{
			[Token(Token = "0x60031B9")]
			[Address(RVA = "0xA42E00", Offset = "0xA42E00", VA = "0xA42E00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065B")]
		public UILabel CurrentPriceLabel
		{
			[Token(Token = "0x60031BA")]
			[Address(RVA = "0xA42E08", Offset = "0xA42E08", VA = "0xA42E08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065C")]
		public UILabel OriginalCostLabel
		{
			[Token(Token = "0x60031BB")]
			[Address(RVA = "0xA42E10", Offset = "0xA42E10", VA = "0xA42E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065D")]
		public UISprite StrikethroughSprite
		{
			[Token(Token = "0x60031BC")]
			[Address(RVA = "0xA42E18", Offset = "0xA42E18", VA = "0xA42E18")]
			get
			{
				return null;
			}
		}
	}

	[Token(Token = "0x4002A40")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform _imageHolder;

	[Token(Token = "0x4002A41")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _buyButton;

	[Token(Token = "0x4002A42")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _upgradeButton;

	[Token(Token = "0x4002A43")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject _equipButton;

	[Token(Token = "0x4002A44")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject _saleBanner;

	[Token(Token = "0x4002A45")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UILabel _saleDiscountLabel;

	[Token(Token = "0x4002A46")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private BuyButtonInfo _noSaleBuyButton;

	[Token(Token = "0x4002A47")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private BuyButtonInfo _saleBuyButton;

	[Token(Token = "0x4002A48")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private GameObject _disabledBuyButton;

	[Token(Token = "0x4002A49")]
	[FieldOffset(Offset = "0xE8")]
	private string _buyLocalizationKey;

	[Token(Token = "0x60031B4")]
	[Address(RVA = "0x98E6EC", Offset = "0x98E6EC", VA = "0x98E6EC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60031B5")]
	[Address(RVA = "0x98ED04", Offset = "0x98ED04", VA = "0x98ED04", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60031B6")]
	[Address(RVA = "0x98E784", Offset = "0x98E784", VA = "0x98E784")]
	private void OnWeaponChanged(WeaponUnlockable weapon)
	{
	}

	[Token(Token = "0x60031B7")]
	[Address(RVA = "0x98EE0C", Offset = "0x98EE0C", VA = "0x98EE0C")]
	public WeaponSuggestionItemView()
	{
	}
}
