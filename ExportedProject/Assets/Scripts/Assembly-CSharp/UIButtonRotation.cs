using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000022")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590C20", Offset = "0x590C20")]
public class UIButtonRotation : MonoBehaviour
{
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x18")]
	public Transform tweenTarget;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 hover;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 pressed;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x38")]
	public float duration;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x3C")]
	private Quaternion mRot;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x4C")]
	private bool mStarted;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x4D")]
	private bool mHighlighted;

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x157CCA0", Offset = "0x157CCA0", VA = "0x157CCA0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x157CD58", Offset = "0x157CD58", VA = "0x157CD58")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x157CEF0", Offset = "0x157CEF0", VA = "0x157CEF0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x157D03C", Offset = "0x157D03C", VA = "0x157D03C")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x157CDF4", Offset = "0x157CDF4", VA = "0x157CDF4")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x157D1A8", Offset = "0x157D1A8", VA = "0x157D1A8")]
	public UIButtonRotation()
	{
	}
}
