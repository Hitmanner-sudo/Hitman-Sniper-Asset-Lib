using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x2000660")]
public class CurrencyItemView : View
{
	[Token(Token = "0x400234A")]
	private const string CURRENCY_AMOUNT_STRING_FORMAT = "[{0}]{1}[-][{2}]{3:N0}[-]";

	[Token(Token = "0x400234B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UILabel _nameUILabel;

	[Token(Token = "0x400234C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _onSaleBannerGO;

	[Token(Token = "0x400234D")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _onSaleSectionGO;

	[Token(Token = "0x400234E")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject _notOnSaleSectionGO;

	[Token(Token = "0x400234F")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UILabel _buyCostLabel;

	[Token(Token = "0x4002350")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UILabel _onSaleLabel;

	[Token(Token = "0x4002351")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UILabel _onSaleCostBottomLabel;

	[Token(Token = "0x4002352")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private UILabel _onSaleCostTopLabel;

	[Token(Token = "0x4002353")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UISprite _onSaleCostTopSlashSprite;

	[Token(Token = "0x4002354")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private UITexture _backgroundUITexture;

	[Token(Token = "0x4002355")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private UITexture _itemIconUITexture;

	[Token(Token = "0x4002356")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private UILabel _amountUILabel;

	[Token(Token = "0x4002357")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private UISprite _buttonBackgroundUISPrite;

	[Token(Token = "0x4002358")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private UILabel _valueOfUILabel;

	[Token(Token = "0x600295C")]
	[Address(RVA = "0xD897BC", Offset = "0xD897BC", VA = "0xD897BC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600295D")]
	[Address(RVA = "0xD897E4", Offset = "0xD897E4", VA = "0xD897E4")]
	private void SetVisual()
	{
	}

	[Token(Token = "0x600295E")]
	[Address(RVA = "0xD89B78", Offset = "0xD89B78", VA = "0xD89B78")]
	private void AssignTexture(UITexture uiTexture, string lazyTextureID, bool useTextureSize)
	{
	}

	[Token(Token = "0x600295F")]
	[Address(RVA = "0xD89D08", Offset = "0xD89D08", VA = "0xD89D08")]
	private void SetAmount(Credit credit, Offer currentOffer)
	{
	}

	[Token(Token = "0x6002960")]
	[Address(RVA = "0xD8A180", Offset = "0xD8A180", VA = "0xD8A180")]
	public CurrencyItemView()
	{
	}
}
