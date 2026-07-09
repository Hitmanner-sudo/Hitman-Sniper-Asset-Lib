using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200077F")]
public abstract class BaseNavigationItem : View
{
	[Token(Token = "0x4002A60")]
	[FieldOffset(Offset = "0x60")]
	public Transform NewIcon;

	[Token(Token = "0x4002A61")]
	[FieldOffset(Offset = "0x68")]
	public UISprite SelectedSprite;

	[Token(Token = "0x17000663")]
	public bool IsSelected
	{
		[Token(Token = "0x60031D6")]
		[Address(RVA = "0xC0DD58", Offset = "0xC0DD58", VA = "0xC0DD58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60031D7")]
		[Address(RVA = "0xC0DD74", Offset = "0xC0DD74", VA = "0xC0DD74")]
		set
		{
		}
	}

	[Token(Token = "0x17000664")]
	public bool HasNewItem
	{
		[Token(Token = "0x60031D8")]
		[Address(RVA = "0xC0DDCC", Offset = "0xC0DDCC", VA = "0xC0DDCC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60031D9")]
		[Address(RVA = "0xC0DDF8", Offset = "0xC0DDF8", VA = "0xC0DDF8")]
		set
		{
		}
	}

	[Token(Token = "0x60031DA")]
	[Address(RVA = "0xC0DE50", Offset = "0xC0DE50", VA = "0xC0DE50")]
	protected BaseNavigationItem()
	{
	}
}
