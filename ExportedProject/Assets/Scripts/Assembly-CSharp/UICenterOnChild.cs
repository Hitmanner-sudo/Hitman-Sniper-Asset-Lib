using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000024")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590C90", Offset = "0x590C90")]
public class UICenterOnChild : MonoBehaviour
{
	[Token(Token = "0x2000025")]
	public delegate void OnCenterChanged(Vector3 offset);

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float springStrength;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float MomentumBias;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool UseFlickMomentumMethod;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SpringPanel.OnFinished onFinished;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OnCenterChanged onCenterChanged;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private UIDraggablePanel mDrag;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject mCenteredObject;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject mLastCentered;

	[Token(Token = "0x17000019")]
	public GameObject centeredObject
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1581CD8", Offset = "0x1581CD8", VA = "0x1581CD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1581CE0", Offset = "0x1581CE0", VA = "0x1581CE0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1582220", Offset = "0x1582220", VA = "0x1582220")]
	private void OnDragFinished()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1581CE8", Offset = "0x1581CE8", VA = "0x1581CE8")]
	public void Recenter([Optional] GameObject child)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x158225C", Offset = "0x158225C", VA = "0x158225C")]
	public Transform GetClosestChild()
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1582480", Offset = "0x1582480", VA = "0x1582480")]
	public void ResetCenteredObject()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1582488", Offset = "0x1582488", VA = "0x1582488")]
	public UICenterOnChild()
	{
	}
}
