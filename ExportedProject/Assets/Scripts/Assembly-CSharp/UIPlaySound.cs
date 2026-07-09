using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000034")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590FB8", Offset = "0x590FB8")]
public class UIPlaySound : MonoBehaviour
{
	[Token(Token = "0x2000035")]
	public enum Trigger
	{
		[Token(Token = "0x40000FC")]
		OnClick = 0,
		[Token(Token = "0x40000FD")]
		OnMouseOver = 1,
		[Token(Token = "0x40000FE")]
		OnMouseOut = 2,
		[Token(Token = "0x40000FF")]
		OnPress = 3,
		[Token(Token = "0x4000100")]
		OnRelease = 4
	}

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip audioClip;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x20")]
	public Trigger trigger;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5AEACC", Offset = "0x5AEACC")]
	public float volume;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5AEAE4", Offset = "0x5AEAE4")]
	public float pitch;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1429688", Offset = "0x1429688", VA = "0x1429688")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x142974C", Offset = "0x142974C", VA = "0x142974C")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1429810", Offset = "0x1429810", VA = "0x1429810")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x14298B4", Offset = "0x14298B4", VA = "0x14298B4")]
	public UIPlaySound()
	{
	}
}
