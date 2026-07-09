using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000026")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590CC8", Offset = "0x590CC8")]
[ExecuteInEditMode]
public class UIDragCamera : MonoBehaviour
{
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x18")]
	public UIDraggableCamera draggableCamera;

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1795B28", Offset = "0x1795B28", VA = "0x1795B28")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1795C00", Offset = "0x1795C00", VA = "0x1795C00")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1795E70", Offset = "0x1795E70", VA = "0x1795E70")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x179613C", Offset = "0x179613C", VA = "0x179613C")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x179631C", Offset = "0x179631C", VA = "0x179631C")]
	public UIDragCamera()
	{
	}
}
