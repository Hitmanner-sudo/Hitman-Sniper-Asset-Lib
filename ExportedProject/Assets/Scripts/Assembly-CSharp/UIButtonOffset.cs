using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000021")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590BE8", Offset = "0x590BE8")]
public class UIButtonOffset : MonoBehaviour
{
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x18")]
	public Transform tweenTarget;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 hover;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 pressed;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x38")]
	public float duration;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 mPos;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x48")]
	private bool mStarted;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x49")]
	private bool mHighlighted;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x157C814", Offset = "0x157C814", VA = "0x157C814")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x157C8CC", Offset = "0x157C8CC", VA = "0x157C8CC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x157C9F4", Offset = "0x157C9F4", VA = "0x157C9F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x157CB40", Offset = "0x157CB40", VA = "0x157CB40")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x157C968", Offset = "0x157C968", VA = "0x157C968")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x157CC60", Offset = "0x157CC60", VA = "0x157CC60")]
	public UIButtonOffset()
	{
	}
}
