using Il2CppDummyDll;

[Token(Token = "0x200078E")]
public class NavigationItem : BaseNavigationItem
{
	[Token(Token = "0x4002A8C")]
	[FieldOffset(Offset = "0x70")]
	public UILabel Label;

	[Token(Token = "0x4002A8D")]
	[FieldOffset(Offset = "0x78")]
	public UISprite Background;

	[Token(Token = "0x17000665")]
	public string Text
	{
		[Token(Token = "0x6003209")]
		[Address(RVA = "0xC58C64", Offset = "0xC58C64", VA = "0xC58C64")]
		get
		{
			return null;
		}
		[Token(Token = "0x600320A")]
		[Address(RVA = "0xC58C80", Offset = "0xC58C80", VA = "0xC58C80")]
		set
		{
		}
	}

	[Token(Token = "0x600320B")]
	[Address(RVA = "0xC58CD8", Offset = "0xC58CD8", VA = "0xC58CD8")]
	public NavigationItem()
	{
	}
}
