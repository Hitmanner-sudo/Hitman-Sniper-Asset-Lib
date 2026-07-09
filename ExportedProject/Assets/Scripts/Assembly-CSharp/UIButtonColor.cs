using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001C")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590ABC", Offset = "0x590ABC")]
public class UIButtonColor : UIWidgetContainer
{
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x18")]
	public GameObject tweenTarget;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x20")]
	public Color hover;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x30")]
	public Color pressed;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x40")]
	public float duration;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x44")]
	protected Color mColor;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x54")]
	protected bool mStarted;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x55")]
	protected bool mHighlighted;

	[Token(Token = "0x17000018")]
	public Color defaultColor
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x157B1DC", Offset = "0x157B1DC", VA = "0x157B1DC")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x157B420", Offset = "0x157B420", VA = "0x157B420")]
		set
		{
		}
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x157B3EC", Offset = "0x157B3EC", VA = "0x157B3EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x157A9B0", Offset = "0x157A9B0", VA = "0x157A9B0", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x157B5C0", Offset = "0x157B5C0", VA = "0x157B5C0", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x157AFCC", Offset = "0x157AFCC", VA = "0x157AFCC")]
	protected void Init()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x157AD34", Offset = "0x157AD34", VA = "0x157AD34", Slot = "6")]
	public virtual void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x157AC64", Offset = "0x157AC64", VA = "0x157AC64", Slot = "7")]
	public virtual void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x157B29C", Offset = "0x157B29C", VA = "0x157B29C")]
	public UIButtonColor()
	{
	}
}
