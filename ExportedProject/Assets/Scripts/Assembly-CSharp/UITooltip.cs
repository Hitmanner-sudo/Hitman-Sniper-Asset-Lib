using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000A9")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591FCC", Offset = "0x591FCC")]
public class UITooltip : MonoBehaviour
{
	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x0")]
	private static UITooltip mInstance;

	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x18")]
	public Camera uiCamera;

	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel text;

	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x28")]
	public UISprite background;

	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x30")]
	public float appearSpeed;

	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x34")]
	public bool scalingTransitions;

	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x38")]
	private Transform mTrans;

	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x40")]
	private float mTarget;

	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x44")]
	private float mCurrent;

	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 mPos;

	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 mSize;

	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x60")]
	private UIWidget[] mWidgets;

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x11701F8", Offset = "0x11701F8", VA = "0x11701F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x1170248", Offset = "0x1170248", VA = "0x1170248")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x1170294", Offset = "0x1170294", VA = "0x1170294")]
	private void Start()
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x117046C", Offset = "0x117046C", VA = "0x117046C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x11703C4", Offset = "0x11703C4", VA = "0x11703C4")]
	private void SetAlpha(float val)
	{
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x11705D4", Offset = "0x11705D4", VA = "0x11705D4")]
	private void SetText(string tooltipText)
	{
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x1170B14", Offset = "0x1170B14", VA = "0x1170B14")]
	public static void ShowText(string tooltipText)
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x1170BD4", Offset = "0x1170BD4", VA = "0x1170BD4")]
	public UITooltip()
	{
	}
}
