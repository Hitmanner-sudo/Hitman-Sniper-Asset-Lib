using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000098")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x591CF0", Offset = "0x591CF0")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591CF0", Offset = "0x591CF0")]
public class UIOrthoCamera : MonoBehaviour
{
	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x18")]
	private Camera mCam;

	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x20")]
	private Transform mTrans;

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x1424EF4", Offset = "0x1424EF4", VA = "0x1424EF4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x1424F70", Offset = "0x1424F70", VA = "0x1424F70")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x1425080", Offset = "0x1425080", VA = "0x1425080")]
	public UIOrthoCamera()
	{
	}
}
