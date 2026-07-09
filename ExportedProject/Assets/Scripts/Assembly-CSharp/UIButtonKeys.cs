using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001E")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590B2C", Offset = "0x590B2C")]
[Attribute(Name = "RequireComponent", RVA = "0x590B2C", Offset = "0x590B2C")]
public class UIButtonKeys : MonoBehaviour
{
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x18")]
	public bool startsSelected;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x20")]
	public UIButtonKeys selectOnClick;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x28")]
	public UIButtonKeys selectOnUp;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x30")]
	public UIButtonKeys selectOnDown;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x38")]
	public UIButtonKeys selectOnLeft;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x40")]
	public UIButtonKeys selectOnRight;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x157B868", Offset = "0x157B868", VA = "0x157B868")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x157C020", Offset = "0x157C020", VA = "0x157C020")]
	private void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x157C3B0", Offset = "0x157C3B0", VA = "0x157C3B0")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x157C48C", Offset = "0x157C48C", VA = "0x157C48C")]
	public UIButtonKeys()
	{
	}
}
