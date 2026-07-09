using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000380")]
public class StickyObject : MonoBehaviour
{
	[Token(Token = "0x400137F")]
	[FieldOffset(Offset = "0x18")]
	public float DragForce;

	[Token(Token = "0x4001380")]
	[FieldOffset(Offset = "0x1C")]
	private bool _isColliding;

	[Token(Token = "0x4001381")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody _rigidBody;

	[Token(Token = "0x4001382")]
	[FieldOffset(Offset = "0x28")]
	private GameObject _lastColliderGameObject;

	[Token(Token = "0x600155A")]
	[Address(RVA = "0xD2A130", Offset = "0xD2A130", VA = "0xD2A130")]
	private void Awake()
	{
	}

	[Token(Token = "0x600155B")]
	[Address(RVA = "0xD2A184", Offset = "0xD2A184", VA = "0xD2A184")]
	private void Update()
	{
	}

	[Token(Token = "0x600155C")]
	[Address(RVA = "0xD2A458", Offset = "0xD2A458", VA = "0xD2A458")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600155D")]
	[Address(RVA = "0xD2A4AC", Offset = "0xD2A4AC", VA = "0xD2A4AC")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x600155E")]
	[Address(RVA = "0xD2A41C", Offset = "0xD2A41C", VA = "0xD2A41C")]
	private void ActivePhysic()
	{
	}

	[Token(Token = "0x600155F")]
	[Address(RVA = "0xD2A4B0", Offset = "0xD2A4B0", VA = "0xD2A4B0")]
	public StickyObject()
	{
	}
}
