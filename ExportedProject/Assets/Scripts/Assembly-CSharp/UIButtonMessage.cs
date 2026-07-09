using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001F")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590BB0", Offset = "0x590BB0")]
public class UIButtonMessage : MonoBehaviour
{
	[Token(Token = "0x2000020")]
	public enum Trigger
	{
		[Token(Token = "0x4000055")]
		OnClick = 0,
		[Token(Token = "0x4000056")]
		OnMouseOver = 1,
		[Token(Token = "0x4000057")]
		OnMouseOut = 2,
		[Token(Token = "0x4000058")]
		OnPress = 3,
		[Token(Token = "0x4000059")]
		OnRelease = 4,
		[Token(Token = "0x400005A")]
		OnDoubleClick = 5
	}

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x20")]
	public string functionName;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x28")]
	public Trigger trigger;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x2C")]
	public bool includeChildren;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x2D")]
	private bool mStarted;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x2E")]
	private bool mHighlighted;

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x157C494", Offset = "0x157C494", VA = "0x157C494")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x157C4A0", Offset = "0x157C4A0", VA = "0x157C4A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x157C53C", Offset = "0x157C53C", VA = "0x157C53C")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x157C734", Offset = "0x157C734", VA = "0x157C734")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x157C788", Offset = "0x157C788", VA = "0x157C788")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x157C7C8", Offset = "0x157C7C8", VA = "0x157C7C8")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x157C594", Offset = "0x157C594", VA = "0x157C594")]
	private void Send()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x157C80C", Offset = "0x157C80C", VA = "0x157C80C")]
	public UIButtonMessage()
	{
	}
}
