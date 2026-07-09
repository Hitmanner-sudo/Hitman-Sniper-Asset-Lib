using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000AA")]
[Attribute(Name = "RequireComponent", RVA = "0x592004", Offset = "0x592004")]
[Attribute(Name = "AddComponentMenu", RVA = "0x592004", Offset = "0x592004")]
[ExecuteInEditMode]
public class UIViewport : MonoBehaviour
{
	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x18")]
	public Camera sourceCamera;

	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x20")]
	public Transform topLeft;

	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x28")]
	public Transform bottomRight;

	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x30")]
	public float fullSize;

	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x38")]
	private Camera mCam;

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x1173C2C", Offset = "0x1173C2C", VA = "0x1173C2C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x1173CD0", Offset = "0x1173CD0", VA = "0x1173CD0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x1173EFC", Offset = "0x1173EFC", VA = "0x1173EFC")]
	public UIViewport()
	{
	}
}
