using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000017")]
public class MeshCombineUtility
{
	[Token(Token = "0x2000018")]
	public struct MeshInstance
	{
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x0")]
		public Mesh mesh;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x8")]
		public int subMeshIndex;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0xC")]
		public Matrix4x4 transform;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x10DE000", Offset = "0x10DE000", VA = "0x10DE000")]
	public static Mesh Combine(MeshInstance[] combines, bool generateStrips)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x10EFE98", Offset = "0x10EFE98", VA = "0x10EFE98")]
	private static void Copy(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x10EFF78", Offset = "0x10EFF78", VA = "0x10EFF78")]
	private static void CopyNormal(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x10F018C", Offset = "0x10F018C", VA = "0x10F018C")]
	private static void Copy(int vertexcount, Vector2[] src, Vector2[] dst, ref int offset)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x10F0210", Offset = "0x10F0210", VA = "0x10F0210")]
	private static void CopyColors(int vertexcount, Color[] src, Color[] dst, ref int offset)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x10F007C", Offset = "0x10F007C", VA = "0x10F007C")]
	private static void CopyTangents(int vertexcount, Vector4[] src, Vector4[] dst, ref int offset, Matrix4x4 transform)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x10F0294", Offset = "0x10F0294", VA = "0x10F0294")]
	public MeshCombineUtility()
	{
	}
}
