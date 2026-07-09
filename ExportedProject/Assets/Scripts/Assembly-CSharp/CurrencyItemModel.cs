using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000597")]
public class CurrencyItemModel : DataModel
{
	[Token(Token = "0x4001D74")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string NAME_LOC;

	[Token(Token = "0x4001D75")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string BACKGROUND_LAZY_TEXTURE;

	[Token(Token = "0x4001D76")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string ITEM_ICON_LAZY_TEXTURE;

	[Token(Token = "0x4001D77")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string OFFER;

	[Token(Token = "0x4001D78")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string BASE_OFFER;

	[Token(Token = "0x4001D79")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string ITEM_ICON_SCALE;

	[Token(Token = "0x4001D7A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string _name;

	[Token(Token = "0x4001D7B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private OfferReference _offer;

	[Token(Token = "0x4001D7C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private OfferReference _baseOffer;

	[Token(Token = "0x4001D7D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private LazyTexture _backgroundLazyTexture;

	[Token(Token = "0x4001D7E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private LazyTexture _itemIconLazyTexture;

	[Token(Token = "0x4001D7F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float _itemIconScale;

	[Token(Token = "0x60022EB")]
	[Address(RVA = "0xD890A8", Offset = "0xD890A8", VA = "0xD890A8", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60022EC")]
	[Address(RVA = "0xD89414", Offset = "0xD89414", VA = "0xD89414")]
	public CurrencyItemModel()
	{
	}

	[Token(Token = "0x60022EE")]
	[Address(RVA = "0xD895DC", Offset = "0xD895DC", VA = "0xD895DC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A1B0", Offset = "0x61A1B0")]
	private object _003CBindAllVariables_003Eb__12_0()
	{
		return null;
	}

	[Token(Token = "0x60022EF")]
	[Address(RVA = "0xD895E4", Offset = "0xD895E4", VA = "0xD895E4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A1C0", Offset = "0x61A1C0")]
	private void _003CBindAllVariables_003Eb__12_1(object a)
	{
	}

	[Token(Token = "0x60022F0")]
	[Address(RVA = "0xD89654", Offset = "0xD89654", VA = "0xD89654")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A1D0", Offset = "0x61A1D0")]
	private object _003CBindAllVariables_003Eb__12_2()
	{
		return null;
	}

	[Token(Token = "0x60022F1")]
	[Address(RVA = "0xD8965C", Offset = "0xD8965C", VA = "0xD8965C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A1E0", Offset = "0x61A1E0")]
	private void _003CBindAllVariables_003Eb__12_3(object a)
	{
	}

	[Token(Token = "0x60022F2")]
	[Address(RVA = "0xD896E8", Offset = "0xD896E8", VA = "0xD896E8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A1F0", Offset = "0x61A1F0")]
	private object _003CBindAllVariables_003Eb__12_4()
	{
		return null;
	}

	[Token(Token = "0x60022F3")]
	[Address(RVA = "0xD896F0", Offset = "0xD896F0", VA = "0xD896F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A200", Offset = "0x61A200")]
	private void _003CBindAllVariables_003Eb__12_5(object a)
	{
	}

	[Token(Token = "0x60022F4")]
	[Address(RVA = "0xD8977C", Offset = "0xD8977C", VA = "0xD8977C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A210", Offset = "0x61A210")]
	private object _003CBindAllVariables_003Eb__12_6()
	{
		return null;
	}

	[Token(Token = "0x60022F5")]
	[Address(RVA = "0xD89798", Offset = "0xD89798", VA = "0xD89798")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A220", Offset = "0x61A220")]
	private object _003CBindAllVariables_003Eb__12_7()
	{
		return null;
	}

	[Token(Token = "0x60022F6")]
	[Address(RVA = "0xD897B4", Offset = "0xD897B4", VA = "0xD897B4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A230", Offset = "0x61A230")]
	private float _003CBindAllVariables_003Eb__12_8()
	{
		return default(float);
	}
}
