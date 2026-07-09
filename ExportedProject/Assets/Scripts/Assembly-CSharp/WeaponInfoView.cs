using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000750")]
public class WeaponInfoView : View
{
	[Token(Token = "0x4002958")]
	[FieldOffset(Offset = "0x60")]
	public UILabel Description;

	[Token(Token = "0x4002959")]
	[FieldOffset(Offset = "0x68")]
	public UISprite DescriptionBoxUnderline;

	[Token(Token = "0x400295A")]
	[FieldOffset(Offset = "0x70")]
	public UIImageWithLabel DescriptionBox;

	[Token(Token = "0x400295B")]
	[FieldOffset(Offset = "0x78")]
	public UISprite Box;

	[Token(Token = "0x400295C")]
	[FieldOffset(Offset = "0x80")]
	public List<UIWidget> BackgroundColourItems;

	[Token(Token = "0x400295D")]
	[FieldOffset(Offset = "0x88")]
	public List<UIWidget> ForegroundColourItems;

	[Token(Token = "0x400295E")]
	[FieldOffset(Offset = "0x90")]
	public WeaponInfoItemView InfoItemPrefab;

	[Token(Token = "0x400295F")]
	[FieldOffset(Offset = "0x98")]
	private List<WeaponInfoItemView> _items;

	[Token(Token = "0x60030C4")]
	[Address(RVA = "0x98AE84", Offset = "0x98AE84", VA = "0x98AE84")]
	public WeaponInfoItemView AddItem(string type, string value)
	{
		return null;
	}

	[Token(Token = "0x60030C5")]
	[Address(RVA = "0x98B1D4", Offset = "0x98B1D4", VA = "0x98B1D4", Slot = "15")]
	public virtual void SetLocked(bool locked)
	{
	}

	[Token(Token = "0x60030C6")]
	[Address(RVA = "0x98B648", Offset = "0x98B648", VA = "0x98B648")]
	public WeaponInfoView()
	{
	}
}
