using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000023")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590C58", Offset = "0x590C58")]
public class UIButtonScale : MonoBehaviour
{
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x18")]
	public Transform tweenTarget;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 hover;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 pressed;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x38")]
	public float duration;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 mScale;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x48")]
	private bool mStarted;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x49")]
	private bool mHighlighted;

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x157D1F8", Offset = "0x157D1F8", VA = "0x157D1F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x157D2B0", Offset = "0x157D2B0", VA = "0x157D2B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x157D3D8", Offset = "0x157D3D8", VA = "0x157D3D8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x157D524", Offset = "0x157D524", VA = "0x157D524")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x157D34C", Offset = "0x157D34C", VA = "0x157D34C")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x157D644", Offset = "0x157D644", VA = "0x157D644")]
	public UIButtonScale()
	{
	}
}
