using System;
using Il2CppDummyDll;

[Token(Token = "0x200078D")]
public class MultiProgressBar : UIWidgetContainer
{
	[Token(Token = "0x4002A87")]
	[FieldOffset(Offset = "0x18")]
	public UISlider[] Foregrounds;

	[Token(Token = "0x4002A88")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Background;

	[NonSerialized]
	[Token(Token = "0x4002A89")]
	[FieldOffset(Offset = "0x28")]
	public UISprite[] ForegroundsSprites;

	[NonSerialized]
	[Token(Token = "0x4002A8A")]
	[FieldOffset(Offset = "0x30")]
	public UISprite[] ForegroundsThumbs;

	[Token(Token = "0x4002A8B")]
	[FieldOffset(Offset = "0x38")]
	private bool _cached;

	[Token(Token = "0x6003207")]
	[Address(RVA = "0xA30ED0", Offset = "0xA30ED0", VA = "0xA30ED0")]
	public void CacheSprites(bool force = false)
	{
	}

	[Token(Token = "0x6003208")]
	[Address(RVA = "0xA31104", Offset = "0xA31104", VA = "0xA31104")]
	public MultiProgressBar()
	{
	}
}
