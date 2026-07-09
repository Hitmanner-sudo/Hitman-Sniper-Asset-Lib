using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000066")]
public class UIGeometry
{
	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x10")]
	public BetterList<Vector3> verts;

	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x18")]
	public BetterList<Vector2> uvs;

	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x20")]
	public BetterList<Color32> cols;

	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x28")]
	private BetterList<Vector3> mRtpVerts;

	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 mRtpNormal;

	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x3C")]
	private Vector4 mRtpTan;

	[Token(Token = "0x1700006A")]
	public bool hasVertices
	{
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x17A12F8", Offset = "0x17A12F8", VA = "0x17A12F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006B")]
	public bool hasTransformed
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x17A131C", Offset = "0x17A131C", VA = "0x17A131C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x17A135C", Offset = "0x17A135C", VA = "0x17A135C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x17A1408", Offset = "0x17A1408", VA = "0x17A1408")]
	public void ApplyTransform(Matrix4x4 widgetToPanel)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x17A1580", Offset = "0x17A1580", VA = "0x17A1580")]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x17A16EC", Offset = "0x17A16EC", VA = "0x17A16EC")]
	public void ReserveCapacity(ref int vertexCount, ref int uvsCount, ref int colsCount, ref int normalCount, ref int tanCount)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x17A1780", Offset = "0x17A1780", VA = "0x17A1780")]
	public UIGeometry()
	{
	}
}
