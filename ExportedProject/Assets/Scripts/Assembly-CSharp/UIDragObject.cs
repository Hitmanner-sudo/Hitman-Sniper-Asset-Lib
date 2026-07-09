using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000027")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590D14", Offset = "0x590D14")]
public class UIDragObject : MonoBehaviour
{
	[Token(Token = "0x2000028")]
	public enum DragEffect
	{
		[Token(Token = "0x4000089")]
		None = 0,
		[Token(Token = "0x400008A")]
		Momentum = 1,
		[Token(Token = "0x400008B")]
		MomentumAndSpring = 2
	}

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 scale;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x2C")]
	public float scrollWheelFactor;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x30")]
	public bool restrictWithinPanel;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x34")]
	public DragEffect dragEffect;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x38")]
	public float momentumAmount;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x3C")]
	private Plane mPlane;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 mLastPos;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x58")]
	private UIPanel mPanel;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x60")]
	private bool mPressed;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 mMomentum;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x70")]
	private float mScroll;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x74")]
	private Bounds mBounds;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x8C")]
	private int mTouchID;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x90")]
	private bool mStarted;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1796324", Offset = "0x1796324", VA = "0x1796324")]
	private void FindPanel()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1796434", Offset = "0x1796434", VA = "0x1796434")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x179685C", Offset = "0x179685C", VA = "0x179685C")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1796C9C", Offset = "0x1796C9C", VA = "0x1796C9C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1796FE8", Offset = "0x1796FE8", VA = "0x1796FE8")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x17970C8", Offset = "0x17970C8", VA = "0x17970C8")]
	public UIDragObject()
	{
	}
}
