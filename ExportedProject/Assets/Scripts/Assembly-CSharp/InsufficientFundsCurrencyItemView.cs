using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x200067E")]
public class InsufficientFundsCurrencyItemView : View
{
	[Token(Token = "0x4002440")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UILabel _nameUILabel;

	[Token(Token = "0x4002441")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UILabel _costDescriptionLabel;

	[Token(Token = "0x4002442")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UITexture _itemIconUITexture;

	[Token(Token = "0x4002443")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UILabel _amountUILabel;

	[Token(Token = "0x4002444")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UISprite _buttonBackgroundUISPrite;

	[Token(Token = "0x4002445")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private string _descriptionLocKey;

	[Token(Token = "0x4002446")]
	[FieldOffset(Offset = "0x90")]
	private int _maxHeight;

	[Token(Token = "0x6002A6F")]
	[Address(RVA = "0xB14600", Offset = "0xB14600", VA = "0xB14600", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002A70")]
	[Address(RVA = "0xB14628", Offset = "0xB14628", VA = "0xB14628")]
	private void SetVisual()
	{
	}

	[Token(Token = "0x6002A71")]
	[Address(RVA = "0xB149B0", Offset = "0xB149B0", VA = "0xB149B0")]
	private void AssignTexture(UITexture uiTexture, string lazyTextureID)
	{
	}

	[Token(Token = "0x6002A72")]
	[Address(RVA = "0xB14AF4", Offset = "0xB14AF4", VA = "0xB14AF4")]
	private void SetAmount(Credit credit, Offer currentOffer)
	{
	}

	[Token(Token = "0x6002A73")]
	[Address(RVA = "0xB14C30", Offset = "0xB14C30", VA = "0xB14C30")]
	public InsufficientFundsCurrencyItemView()
	{
	}
}
