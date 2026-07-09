using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200005C")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591534", Offset = "0x591534")]
[ExecuteInEditMode]
public class UIDrawCall : MonoBehaviour
{
	[Token(Token = "0x200005D")]
	public enum Clipping
	{
		[Token(Token = "0x40001EE")]
		None = 0,
		[Token(Token = "0x40001EF")]
		AlphaClip = 2,
		[Token(Token = "0x40001F0")]
		SoftClip = 3
	}

	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x0")]
	public static BetterList<UIDrawCall> list;

	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x18")]
	private Material mSharedMat;

	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x20")]
	private Mesh mMesh0;

	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x28")]
	private Mesh mMesh1;

	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x30")]
	private bool _forceRebuildIndices0;

	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x31")]
	private bool _forceRebuildIndices1;

	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x38")]
	private MeshFilter mFilter;

	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x40")]
	private MeshRenderer mRen;

	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x48")]
	private Clipping mClipping;

	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x4C")]
	private Vector4 mClipRange;

	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 mClipSoft;

	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x68")]
	private Material mMat;

	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x70")]
	private BetterList<int> _triangleIndices;

	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x78")]
	private bool mReset;

	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x79")]
	private bool mEven;

	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x7C")]
	private int mRenderQueue;

	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AF26C", Offset = "0x5AF26C")]
	private UIPanel _003Cpanel_003Ek__BackingField;

	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AF27C", Offset = "0x5AF27C")]
	private bool _003CisDirty_003Ek__BackingField;

	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x8")]
	public static ObjectPool<UIDrawCall> drawCallPool;

	[Token(Token = "0x1700005F")]
	public UIPanel panel
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1799E58", Offset = "0x1799E58", VA = "0x1799E58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611AC8", Offset = "0x611AC8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1799E60", Offset = "0x1799E60", VA = "0x1799E60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611AD8", Offset = "0x611AD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000060")]
	public bool isDirty
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1799E68", Offset = "0x1799E68", VA = "0x1799E68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611AE8", Offset = "0x611AE8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1799E70", Offset = "0x1799E70", VA = "0x1799E70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611AF8", Offset = "0x611AF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000061")]
	public int renderQueue
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1799E7C", Offset = "0x1799E7C", VA = "0x1799E7C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1799E84", Offset = "0x1799E84", VA = "0x1799E84")]
		set
		{
		}
	}

	[Token(Token = "0x17000062")]
	public int finalRenderQueue
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1799F7C", Offset = "0x1799F7C", VA = "0x1799F7C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000063")]
	public Material baseMaterial
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x179A068", Offset = "0x179A068", VA = "0x179A068")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000064")]
	public Texture mainTexture
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x179A070", Offset = "0x179A070", VA = "0x179A070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000065")]
	public int triangles
	{
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x179A104", Offset = "0x179A104", VA = "0x179A104")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000066")]
	public bool isClipped
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x179A1AC", Offset = "0x179A1AC", VA = "0x179A1AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000067")]
	public Clipping clipping
	{
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x179A1BC", Offset = "0x179A1BC", VA = "0x179A1BC")]
		get
		{
			return default(Clipping);
		}
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x179A1C4", Offset = "0x179A1C4", VA = "0x179A1C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000068")]
	public Vector4 clipRange
	{
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x179A1E0", Offset = "0x179A1E0", VA = "0x179A1E0")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x179A1EC", Offset = "0x179A1EC", VA = "0x179A1EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000069")]
	public Vector2 clipSoftness
	{
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x179A1F8", Offset = "0x179A1F8", VA = "0x179A1F8")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x179A200", Offset = "0x179A200", VA = "0x179A200")]
		set
		{
		}
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x179A208", Offset = "0x179A208", VA = "0x179A208")]
	private Mesh GetMesh(ref bool rebuildIndices, int vertexCount)
	{
		return null;
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x179A4D0", Offset = "0x179A4D0", VA = "0x179A4D0")]
	public void RebuildMaterial()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x179A6CC", Offset = "0x179A6CC", VA = "0x179A6CC")]
	private void UpdateMaterials()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x179A994", Offset = "0x179A994", VA = "0x179A994")]
	public void Set(BetterList<Vector3> verts, BetterList<Vector3> norms, BetterList<Vector4> tans, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x179B0E0", Offset = "0x179B0E0", VA = "0x179B0E0")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x179B228", Offset = "0x179B228", VA = "0x179B228")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x179B2A8", Offset = "0x179B2A8", VA = "0x179B2A8")]
	public static void DestroyGameObject(UIDrawCall obj)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x179B374", Offset = "0x179B374", VA = "0x179B374")]
	private static UIDrawCall CreateNewDrawCall()
	{
		return null;
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x179B480", Offset = "0x179B480", VA = "0x179B480")]
	public static void FreeDrawCall(int index)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x179B5C4", Offset = "0x179B5C4", VA = "0x179B5C4")]
	public static UIDrawCall GetDrawCall(int index, UIPanel panel, Material mat)
	{
		return null;
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x179B918", Offset = "0x179B918", VA = "0x179B918")]
	public static void FreeAll()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x179BA9C", Offset = "0x179BA9C", VA = "0x179BA9C")]
	public static void RemovePanel(UIPanel panel)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x179BBF8", Offset = "0x179BBF8", VA = "0x179BBF8")]
	public static int CountDrawCalls(UIPanel panel)
	{
		return default(int);
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x179BD3C", Offset = "0x179BD3C", VA = "0x179BD3C")]
	public static void SetDirtyAll()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x179BE1C", Offset = "0x179BE1C", VA = "0x179BE1C")]
	public static void SetDirty(UIPanel panel)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x179BF58", Offset = "0x179BF58", VA = "0x179BF58")]
	public UIDrawCall()
	{
	}
}
