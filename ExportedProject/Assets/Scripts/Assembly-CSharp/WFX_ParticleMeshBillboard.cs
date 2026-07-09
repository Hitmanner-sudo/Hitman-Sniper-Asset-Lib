using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000016")]
[Attribute(Name = "RequireComponent", RVA = "0x590968", Offset = "0x590968")]
public class WFX_ParticleMeshBillboard : MonoBehaviour
{
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x18")]
	private Mesh mesh;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x20")]
	private Vector3[] vertices;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x28")]
	private Vector3[] rvertices;

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x97BDFC", Offset = "0x97BDFC", VA = "0x97BDFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x97BEDC", Offset = "0x97BEDC", VA = "0x97BEDC")]
	private void AdjustVertices()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x97C07C", Offset = "0x97C07C", VA = "0x97C07C")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x97C334", Offset = "0x97C334", VA = "0x97C334")]
	public WFX_ParticleMeshBillboard()
	{
	}
}
