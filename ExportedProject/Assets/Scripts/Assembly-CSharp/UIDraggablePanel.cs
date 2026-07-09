using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200002B")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x590E1C", Offset = "0x590E1C")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590E1C", Offset = "0x590E1C")]
public class UIDraggablePanel : MonoBehaviour
{
	[Token(Token = "0x200002C")]
	public enum DragEffect
	{
		[Token(Token = "0x40000BD")]
		None = 0,
		[Token(Token = "0x40000BE")]
		Momentum = 1,
		[Token(Token = "0x40000BF")]
		MomentumAndSpring = 2
	}

	[Token(Token = "0x200002D")]
	public enum ShowCondition
	{
		[Token(Token = "0x40000C1")]
		Always = 0,
		[Token(Token = "0x40000C2")]
		OnlyIfNeeded = 1,
		[Token(Token = "0x40000C3")]
		WhenDragging = 2
	}

	[Token(Token = "0x200002E")]
	public delegate void OnDragFinished();

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x18")]
	public DragEffect dragEffect;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x1C")]
	public bool restrictWithinPanel;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x1D")]
	public bool disableDragIfFits;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x1E")]
	public bool smoothDragStart;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x1F")]
	public bool repositionClipping;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x20")]
	public bool iOSDragEmulation;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x21")]
	public bool RecalculateBoundsOnUpdate;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x24")]
	public float scrollWheelFactor;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x28")]
	public float momentumAmount;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollBar horizontalScrollBar;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x38")]
	public UIScrollBar verticalScrollBar;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x40")]
	public ShowCondition showScrollBars;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 scale;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 relativePositionOnReset;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x58")]
	public OnDragFinished onDragFinished;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x60")]
	public bool DisableScrollWheel;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x68")]
	private Transform mTrans;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x70")]
	private UIPanel mPanel;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x78")]
	private Plane mPlane;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 mLastPos;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x94")]
	private bool mPressed;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 mMomentum;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0xA4")]
	private float mScroll;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0xA8")]
	private Bounds mBounds;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0xC0")]
	private bool mCalculatedBounds;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0xC1")]
	private bool mShouldMove;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0xC2")]
	private bool mIgnoreCallbacks;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0xC4")]
	private int mDragID;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0xC8")]
	private Vector2 mDragStartOffset;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0xD0")]
	private bool mDragStarted;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0xD1")]
	private bool _forceRecalculateBounds;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0xD2")]
	private bool _componentsCached;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0xD3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AEA4C", Offset = "0x5AEA4C")]
	private bool _003CPreventDrag_003Ek__BackingField;

	[Token(Token = "0x1700001B")]
	public Transform Trans
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x17987AC", Offset = "0x17987AC", VA = "0x17987AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public bool DragStarted
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x17987B4", Offset = "0x17987B4", VA = "0x17987B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001D")]
	public bool PreventDrag
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x17987BC", Offset = "0x17987BC", VA = "0x17987BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611910", Offset = "0x611910")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x17987C4", Offset = "0x17987C4", VA = "0x17987C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611920", Offset = "0x611920")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public UIPanel panel
	{
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x17987D0", Offset = "0x17987D0", VA = "0x17987D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001F")]
	public Bounds bounds
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x17987D8", Offset = "0x17987D8", VA = "0x17987D8")]
		get
		{
			return default(Bounds);
		}
	}

	[Token(Token = "0x17000020")]
	public bool shouldMoveHorizontally
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1798860", Offset = "0x1798860", VA = "0x1798860")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000021")]
	public bool shouldMoveVertically
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x17988CC", Offset = "0x17988CC", VA = "0x17988CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000022")]
	private bool shouldMove
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1798938", Offset = "0x1798938", VA = "0x1798938")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000023")]
	public Vector3 currentMomentum
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1798AF8", Offset = "0x1798AF8", VA = "0x1798AF8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1798B04", Offset = "0x1798B04", VA = "0x1798B04")]
		set
		{
		}
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1798B18", Offset = "0x1798B18", VA = "0x1798B18")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1798B1C", Offset = "0x1798B1C", VA = "0x1798B1C")]
	public void CacheComponents()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1798C2C", Offset = "0x1798C2C", VA = "0x1798C2C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1798D3C", Offset = "0x1798D3C", VA = "0x1798D3C")]
	private void OnPanelChange()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x17990D0", Offset = "0x17990D0", VA = "0x17990D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1799304", Offset = "0x1799304", VA = "0x1799304")]
	public bool RestrictWithinBounds(bool instant)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x17994FC", Offset = "0x17994FC", VA = "0x17994FC")]
	public void DisableSpring()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x17995B4", Offset = "0x17995B4", VA = "0x17995B4")]
	public void ForceRecalculateBounds()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1798D80", Offset = "0x1798D80", VA = "0x1798D80")]
	public void UpdateScrollbars(bool recalculateBounds)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x17995C0", Offset = "0x17995C0", VA = "0x17995C0")]
	public void SetDragAmount(float x, float y, bool updateScrollbars)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x17997C4", Offset = "0x17997C4", VA = "0x17997C4")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x17997FC", Offset = "0x17997FC", VA = "0x17997FC")]
	private void OnHorizontalBar()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x17998FC", Offset = "0x17998FC", VA = "0x17998FC")]
	private void OnVerticalBar()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x179946C", Offset = "0x179946C", VA = "0x179946C")]
	public void MoveRelative(Vector3 relative)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x17999FC", Offset = "0x17999FC", VA = "0x17999FC")]
	public void MoveAbsolute(Vector3 absolute)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x17972F0", Offset = "0x17972F0", VA = "0x17972F0")]
	public void Press(bool pressed)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x179768C", Offset = "0x179768C", VA = "0x179768C")]
	public void Drag()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1797C14", Offset = "0x1797C14", VA = "0x1797C14")]
	public void Scroll(float delta)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1799A74", Offset = "0x1799A74", VA = "0x1799A74")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1799DD0", Offset = "0x1799DD0", VA = "0x1799DD0")]
	public UIDraggablePanel()
	{
	}
}
