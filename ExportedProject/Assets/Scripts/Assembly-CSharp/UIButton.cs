using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001A")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590A4C", Offset = "0x590A4C")]
public class UIButton : UIButtonColor
{
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x0")]
	public static UIButton current;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x58")]
	public Color disabledColor;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x68")]
	public List<EventDelegate> onClick;

	[Token(Token = "0x17000017")]
	public bool isEnabled
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x157A8EC", Offset = "0x157A8EC", VA = "0x157A8EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x157AF04", Offset = "0x157AF04", VA = "0x157AF04")]
		set
		{
		}
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x157A880", Offset = "0x157A880", VA = "0x157A880", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x157AB9C", Offset = "0x157AB9C", VA = "0x157AB9C", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x157AC28", Offset = "0x157AC28", VA = "0x157AC28", Slot = "7")]
	public override void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x157ACF8", Offset = "0x157ACF8", VA = "0x157ACF8", Slot = "6")]
	public override void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x157AE60", Offset = "0x157AE60", VA = "0x157AE60")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x157AA54", Offset = "0x157AA54", VA = "0x157AA54")]
	public void UpdateColor(bool shouldBeEnabled, bool immediate)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x157B218", Offset = "0x157B218", VA = "0x157B218")]
	public UIButton()
	{
	}
}
