using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200007D")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x591A44", Offset = "0x591A44")]
public class UIAnchor : MonoBehaviour
{
	[Token(Token = "0x200007E")]
	public enum Side
	{
		[Token(Token = "0x40002A8")]
		BottomLeft = 0,
		[Token(Token = "0x40002A9")]
		LeftMiddle = 1,
		[Token(Token = "0x40002AA")]
		TopLeft = 2,
		[Token(Token = "0x40002AB")]
		TopCenter = 3,
		[Token(Token = "0x40002AC")]
		TopRight = 4,
		[Token(Token = "0x40002AD")]
		RightMiddle = 5,
		[Token(Token = "0x40002AE")]
		BottomRight = 6,
		[Token(Token = "0x40002AF")]
		BottomCenter = 7,
		[Token(Token = "0x40002B0")]
		Center = 8,
		[Token(Token = "0x40002B1")]
		TopOnly = 9,
		[Token(Token = "0x40002B2")]
		BottomOnly = 10,
		[Token(Token = "0x40002B3")]
		RightOnly = 11,
		[Token(Token = "0x40002B4")]
		LeftOnly = 12,
		[Token(Token = "0x40002B5")]
		CenterVertically = 13,
		[Token(Token = "0x40002B6")]
		CenterHorizontally = 14
	}

	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x18")]
	private bool mNeedsHalfPixelOffset;

	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x20")]
	public Camera uiCamera;

	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x28")]
	public GameObject container;

	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x30")]
	public Side side;

	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x34")]
	public bool halfPixelOffset;

	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x35")]
	public bool runOnlyOnce;

	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x38")]
	public int runThisManyTimes;

	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 relativeOffset;

	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 pixelOffset;

	[Token(Token = "0x400029C")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private bool _useSafeArea;

	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[HideInInspector]
	private UIWidget widgetContainer;

	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x58")]
	private Transform mTrans;

	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x60")]
	private Animation mAnim;

	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x68")]
	private Rect mRect;

	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x78")]
	private UIRoot mRoot;

	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x80")]
	private UIWidget mCacheWC;

	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x88")]
	private UIPanel mCachePC;

	[Token(Token = "0x40002A4")]
	private const int m_framesToWaitToEnterSkipping = 24;

	[Token(Token = "0x40002A5")]
	private const int m_framesToSkip = 4;

	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x90")]
	private int m_frameCount;

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x1577EAC", Offset = "0x1577EAC", VA = "0x1577EAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x1577F18", Offset = "0x1577F18", VA = "0x1577F18")]
	public void UpdateContainer(GameObject newContainer)
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x157805C", Offset = "0x157805C", VA = "0x157805C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x15782C8", Offset = "0x15782C8", VA = "0x15782C8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x1578D2C", Offset = "0x1578D2C", VA = "0x1578D2C")]
	public UIAnchor()
	{
	}
}
