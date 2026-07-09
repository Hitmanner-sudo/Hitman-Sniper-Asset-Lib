using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000032")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590F34", Offset = "0x590F34")]
public class UIImageButton : MonoBehaviour
{
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x18")]
	public UISprite target;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x20")]
	public string normalSprite;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x28")]
	public string hoverSprite;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x30")]
	public string pressedSprite;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x38")]
	public string disabledSprite;

	[Token(Token = "0x17000024")]
	public bool isEnabled
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x17A21AC", Offset = "0x17A21AC", VA = "0x17A21AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x17A2260", Offset = "0x17A2260", VA = "0x17A2260")]
		set
		{
		}
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x17A2470", Offset = "0x17A2470", VA = "0x17A2470")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x17A2340", Offset = "0x17A2340", VA = "0x17A2340")]
	private void UpdateImage()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x17A250C", Offset = "0x17A250C", VA = "0x17A250C")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x17A25E4", Offset = "0x17A25E4", VA = "0x17A25E4")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x17A2640", Offset = "0x17A2640", VA = "0x17A2640")]
	public UIImageButton()
	{
	}
}
