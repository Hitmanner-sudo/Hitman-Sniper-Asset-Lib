using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000A3")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x591EFC", Offset = "0x591EFC")]
public class UIStretch : MonoBehaviour
{
	[Token(Token = "0x20000A4")]
	public enum Style
	{
		[Token(Token = "0x40003FE")]
		None = 0,
		[Token(Token = "0x40003FF")]
		Horizontal = 1,
		[Token(Token = "0x4000400")]
		Vertical = 2,
		[Token(Token = "0x4000401")]
		Both = 3,
		[Token(Token = "0x4000402")]
		BasedOnHeight = 4,
		[Token(Token = "0x4000403")]
		FillKeepingRatio = 5,
		[Token(Token = "0x4000404")]
		FitInternalKeepingRatio = 6
	}

	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x18")]
	public Camera uiCamera;

	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject container;

	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x28")]
	public Style style;

	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0x2C")]
	public bool runOnlyOnce;

	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 relativeSize;

	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 initialSize;

	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 borderPadding;

	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x48")]
	public bool CanAdjustScale;

	[Token(Token = "0x40003EB")]
	[FieldOffset(Offset = "0x49")]
	public bool CheckForDeviceScalar;

	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x4A")]
	public bool AdjustCollider;

	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0x50")]
	public UIWidget AlignToFitTopWidget;

	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget AlignToFitBottomWidget;

	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x60")]
	public UIWidget AlignToFitLeftWidget;

	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x68")]
	public UIWidget AlignToFitRightWidget;

	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool _useSafeArea;

	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x78")]
	[HideInInspector]
	[SerializeField]
	private UIWidget widgetContainer;

	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x80")]
	private Transform mTrans;

	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x88")]
	private UIWidget mWidget;

	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x90")]
	private UISprite mSprite;

	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x98")]
	private UIPanel mPanel;

	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0xA0")]
	private UIRoot mRoot;

	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0xA8")]
	private Animation mAnim;

	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0xB0")]
	private Rect mRect;

	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0xC0")]
	private UIWidget mCacheWC;

	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0xC8")]
	private UIPanel mCachePC;

	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0xD0")]
	private BoxCollider _collider;

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x116A2D4", Offset = "0x116A2D4", VA = "0x116A2D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x116A3A8", Offset = "0x116A3A8", VA = "0x116A3A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x116B2DC", Offset = "0x116B2DC", VA = "0x116B2DC")]
	public void ForceUpdate()
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x116A6A4", Offset = "0x116A6A4", VA = "0x116A6A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x116B534", Offset = "0x116B534", VA = "0x116B534")]
	private float GetHeight(UIWidget topWidget, UIWidget bottomWidget)
	{
		return default(float);
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x116B57C", Offset = "0x116B57C", VA = "0x116B57C")]
	private float GetWidth(UIWidget leftWidget, UIWidget rightWidget)
	{
		return default(float);
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x116BB10", Offset = "0x116BB10", VA = "0x116BB10")]
	public UIStretch()
	{
	}
}
