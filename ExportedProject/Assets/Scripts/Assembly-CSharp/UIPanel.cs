using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000099")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x591D84", Offset = "0x591D84")]
public class UIPanel : MonoBehaviour
{
	[Token(Token = "0x200009A")]
	public enum DebugInfo
	{
		[Token(Token = "0x40003A9")]
		None = 0,
		[Token(Token = "0x40003AA")]
		Gizmos = 1,
		[Token(Token = "0x40003AB")]
		Geometry = 2
	}

	[Token(Token = "0x200009B")]
	public delegate void OnChangeDelegate();

	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0x0")]
	public static BetterList<UIPanel> list;

	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0x18")]
	public OnChangeDelegate onChange;

	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x20")]
	public bool showInPanelTool;

	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x21")]
	public bool generateNormals;

	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0x22")]
	public bool widgetsAreStatic;

	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0x23")]
	public bool cullWhileDragging;

	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public Matrix4x4 worldToLocal;

	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[HideInInspector]
	private float mAlpha;

	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[HideInInspector]
	private UIDrawCall.Clipping mClipping;

	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[HideInInspector]
	private Vector4 mClipRange;

	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[HideInInspector]
	private Vector2 mClipSoftness;

	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x84")]
	[HideInInspector]
	[SerializeField]
	private int mDepth;

	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x8")]
	private static bool mFullRebuild;

	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x10")]
	private static BetterList<Vector3> mVerts;

	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x18")]
	private static BetterList<Vector3> mNorms;

	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0x20")]
	private static BetterList<Vector4> mTans;

	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0x28")]
	private static BetterList<Vector2> mUvs;

	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x30")]
	private static BetterList<Color32> mCols;

	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x88")]
	private GameObject mGo;

	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0x90")]
	private Transform mTrans;

	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0x98")]
	private Camera mCam;

	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0xA0")]
	private int mLayer;

	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0xA4")]
	private float mCullTime;

	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0xA8")]
	private float mUpdateTime;

	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0xAC")]
	private float mMatrixTime;

	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0x38")]
	private static float[] mTemp;

	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0xB0")]
	private Vector2 mMin;

	[Token(Token = "0x40003A4")]
	[FieldOffset(Offset = "0xB8")]
	private Vector2 mMax;

	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0xC0")]
	private UIPanel[] mChildPanels;

	[NonSerialized]
	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0xC8")]
	public List<UIWidget> Widgets;

	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0x40")]
	private static BetterList<UIWidget> _widgetsToSubmit;

	[Token(Token = "0x170000ED")]
	public GameObject cachedGameObject
	{
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1425088", Offset = "0x1425088", VA = "0x1425088")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000EE")]
	public Transform cachedTransform
	{
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1425114", Offset = "0x1425114", VA = "0x1425114")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000EF")]
	public float alpha
	{
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x14251A0", Offset = "0x14251A0", VA = "0x14251A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x14251A8", Offset = "0x14251A8", VA = "0x14251A8")]
		set
		{
		}
	}

	[Token(Token = "0x170000F0")]
	public int depth
	{
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1425354", Offset = "0x1425354", VA = "0x1425354")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x142535C", Offset = "0x142535C", VA = "0x142535C")]
		set
		{
		}
	}

	[Token(Token = "0x170000F1")]
	public UIDrawCall.Clipping clipping
	{
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1425728", Offset = "0x1425728", VA = "0x1425728")]
		get
		{
			return default(UIDrawCall.Clipping);
		}
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1425730", Offset = "0x1425730", VA = "0x1425730")]
		set
		{
		}
	}

	[Token(Token = "0x170000F2")]
	public Vector4 clipRange
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x14259CC", Offset = "0x14259CC", VA = "0x14259CC")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x14259D8", Offset = "0x14259D8", VA = "0x14259D8")]
		set
		{
		}
	}

	[Token(Token = "0x170000F3")]
	public Vector2 clipSoftness
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1425AAC", Offset = "0x1425AAC", VA = "0x1425AAC")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1425AB4", Offset = "0x1425AB4", VA = "0x1425AB4")]
		set
		{
		}
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x1425574", Offset = "0x1425574", VA = "0x1425574")]
	public static int CompareFunc(UIPanel a, UIPanel b)
	{
		return default(int);
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x1425650", Offset = "0x1425650", VA = "0x1425650")]
	public void SetAlphaRecursive(float val, bool rebuildList)
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x1425AE8", Offset = "0x1425AE8", VA = "0x1425AE8")]
	private bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		return default(bool);
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x1425F78", Offset = "0x1425F78", VA = "0x1425F78")]
	public bool IsVisible(Vector3 worldPos)
	{
		return default(bool);
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x142602C", Offset = "0x142602C", VA = "0x142602C")]
	public bool IsVisible(UIWidget w)
	{
		return default(bool);
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x1426198", Offset = "0x1426198", VA = "0x1426198")]
	public static void SetDirty()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x1426200", Offset = "0x1426200", VA = "0x1426200")]
	private UIDrawCall GetDrawCall(int index, Material mat)
	{
		return null;
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x142627C", Offset = "0x142627C", VA = "0x142627C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x14262B4", Offset = "0x14262B4", VA = "0x14262B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x14263D8", Offset = "0x14263D8", VA = "0x14263D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x14264FC", Offset = "0x14264FC", VA = "0x14264FC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x1426608", Offset = "0x1426608", VA = "0x1426608")]
	public static void TrimBuffers()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x1426728", Offset = "0x1426728", VA = "0x1426728")]
	public static void ProcessOrphanWidgets()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x1425DCC", Offset = "0x1425DCC", VA = "0x1425DCC")]
	private void UpdateTransformMatrix()
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x142574C", Offset = "0x142574C", VA = "0x142574C")]
	private void UpdateDrawcalls()
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x1426864", Offset = "0x1426864", VA = "0x1426864")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x1426CD0", Offset = "0x1426CD0", VA = "0x1426CD0")]
	private void UpdateLayers()
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x1426FA0", Offset = "0x1426FA0", VA = "0x1426FA0")]
	private void UpdateWidgets()
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x1427F78", Offset = "0x1427F78", VA = "0x1427F78")]
	public void Refresh()
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x1427FE0", Offset = "0x1427FE0", VA = "0x1427FE0")]
	public Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x1428054", Offset = "0x1428054", VA = "0x1428054")]
	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
		return default(bool);
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x1428238", Offset = "0x1428238", VA = "0x1428238")]
	public bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
		return default(bool);
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x1427DC8", Offset = "0x1427DC8", VA = "0x1427DC8")]
	private static void SetChildLayer(Transform t, int layer)
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x14282B0", Offset = "0x14282B0", VA = "0x14282B0")]
	public static UIPanel Find(Transform trans, bool createIfMissing)
	{
		return null;
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x142851C", Offset = "0x142851C", VA = "0x142851C")]
	public static UIPanel Find(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x14271DC", Offset = "0x14271DC", VA = "0x14271DC")]
	private static void Fill()
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x1428580", Offset = "0x1428580", VA = "0x1428580")]
	private static void SubmitDrawCall(UIPanel pan, UIDrawCall dc, ref int vertexCount, ref int uvsCount, ref int colsCount, ref int normalsCount, ref int tansCount)
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x14288C0", Offset = "0x14288C0", VA = "0x14288C0")]
	private void SubmitDrawCall(UIDrawCall dc)
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x1427740", Offset = "0x1427740", VA = "0x1427740")]
	private static bool Fill(UIDrawCall dc)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x1428AA8", Offset = "0x1428AA8", VA = "0x1428AA8")]
	public UIPanel()
	{
	}
}
