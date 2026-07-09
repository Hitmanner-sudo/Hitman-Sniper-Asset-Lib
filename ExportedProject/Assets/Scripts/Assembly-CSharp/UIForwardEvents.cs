using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200002F")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590EB0", Offset = "0x590EB0")]
public class UIForwardEvents : MonoBehaviour
{
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x20")]
	public bool onHover;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x21")]
	public bool onPress;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x22")]
	public bool onClick;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x23")]
	public bool onDoubleClick;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x24")]
	public bool onSelect;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x25")]
	public bool onDrag;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x26")]
	public bool onDrop;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x27")]
	public bool onInput;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x28")]
	public bool onSubmit;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x29")]
	public bool onScroll;

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x17A0AB8", Offset = "0x17A0AB8", VA = "0x17A0AB8")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x17A0BA0", Offset = "0x17A0BA0", VA = "0x17A0BA0")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x17A0C88", Offset = "0x17A0C88", VA = "0x17A0C88")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x17A0D3C", Offset = "0x17A0D3C", VA = "0x17A0D3C")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x17A0DF0", Offset = "0x17A0DF0", VA = "0x17A0DF0")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x17A0ED8", Offset = "0x17A0ED8", VA = "0x17A0ED8")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x17A0FC8", Offset = "0x17A0FC8", VA = "0x17A0FC8")]
	private void OnDrop(GameObject go)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x17A1090", Offset = "0x17A1090", VA = "0x17A1090")]
	private void OnInput(string text)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x17A1158", Offset = "0x17A1158", VA = "0x17A1158")]
	private void OnSubmit()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x17A120C", Offset = "0x17A120C", VA = "0x17A120C")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x17A12F0", Offset = "0x17A12F0", VA = "0x17A12F0")]
	public UIForwardEvents()
	{
	}
}
