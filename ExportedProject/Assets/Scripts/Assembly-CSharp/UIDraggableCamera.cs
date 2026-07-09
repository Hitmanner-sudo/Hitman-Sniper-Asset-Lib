using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200002A")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590D98", Offset = "0x590D98")]
[Attribute(Name = "RequireComponent", RVA = "0x590D98", Offset = "0x590D98")]
public class UIDraggableCamera : MonoBehaviour
{
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x18")]
	public Transform rootForBounds;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 scale;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x28")]
	public float scrollWheelFactor;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x2C")]
	public UIDragObject.DragEffect dragEffect;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x30")]
	public bool smoothDragStart;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x34")]
	public float momentumAmount;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x38")]
	private Camera mCam;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x40")]
	private Transform mTrans;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x48")]
	private bool mPressed;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 mMomentum;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x54")]
	private Bounds mBounds;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x6C")]
	private float mScroll;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x70")]
	private UIRoot mRoot;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x78")]
	private bool mDragStarted;

	[Token(Token = "0x1700001A")]
	public Vector2 currentMomentum
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1798130", Offset = "0x1798130", VA = "0x1798130")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1798138", Offset = "0x1798138", VA = "0x1798138")]
		set
		{
		}
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1798140", Offset = "0x1798140", VA = "0x1798140")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x17981E0", Offset = "0x17981E0", VA = "0x17981E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1798274", Offset = "0x1798274", VA = "0x1798274")]
	private Vector3 CalculateConstrainOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x17984F4", Offset = "0x17984F4", VA = "0x17984F4")]
	public bool ConstrainToBounds(bool immediate)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1795D00", Offset = "0x1795D00", VA = "0x1795D00")]
	public void Press(bool isPressed)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1795F78", Offset = "0x1795F78", VA = "0x1795F78")]
	public void Drag(Vector2 delta)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x179623C", Offset = "0x179623C", VA = "0x179623C")]
	public void Scroll(float delta)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1798678", Offset = "0x1798678", VA = "0x1798678")]
	private void Update()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1798758", Offset = "0x1798758", VA = "0x1798758")]
	public UIDraggableCamera()
	{
	}
}
