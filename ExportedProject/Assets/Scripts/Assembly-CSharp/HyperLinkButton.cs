using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000677")]
public class HyperLinkButton : View
{
	[Token(Token = "0x4002400")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UILabel _textUiLabel;

	[Token(Token = "0x4002401")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ButtonHandler _textButtonHandler;

	[Token(Token = "0x4002402")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private BoxCollider _textBoxCollider;

	[Token(Token = "0x4002403")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Vector2 _textBoxColliderBorderPadding;

	[Token(Token = "0x4002404")]
	[FieldOffset(Offset = "0x80")]
	private string _link;

	[Token(Token = "0x6002A33")]
	[Address(RVA = "0xA15CE8", Offset = "0xA15CE8", VA = "0xA15CE8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002A34")]
	[Address(RVA = "0xA15D98", Offset = "0xA15D98", VA = "0xA15D98", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002A35")]
	[Address(RVA = "0xA15E90", Offset = "0xA15E90", VA = "0xA15E90")]
	private void OnTextButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002A36")]
	[Address(RVA = "0xA15E9C", Offset = "0xA15E9C", VA = "0xA15E9C")]
	public void SetHyperLink(string link, string text)
	{
	}

	[Token(Token = "0x6002A37")]
	[Address(RVA = "0xA1608C", Offset = "0xA1608C", VA = "0xA1608C")]
	public HyperLinkButton()
	{
	}
}
