using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000067")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5915B8", Offset = "0x5915B8")]
public class UIWidget : MonoBehaviour
{
	[Token(Token = "0x2000068")]
	public enum Pivot
	{
		[Token(Token = "0x400021E")]
		TopLeft = 0,
		[Token(Token = "0x400021F")]
		Top = 1,
		[Token(Token = "0x4000220")]
		TopRight = 2,
		[Token(Token = "0x4000221")]
		Left = 3,
		[Token(Token = "0x4000222")]
		Center = 4,
		[Token(Token = "0x4000223")]
		Right = 5,
		[Token(Token = "0x4000224")]
		BottomLeft = 6,
		[Token(Token = "0x4000225")]
		Bottom = 7,
		[Token(Token = "0x4000226")]
		BottomRight = 8
	}

	[Token(Token = "0x2000069")]
	public class SizeChangedEventArgs : EventArgs
	{
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x10")]
		public int PreviousHeight;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x14")]
		public int PreviousWidth;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x18")]
		public int CurrentHeight;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x1C")]
		public int CurrentWidth;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xA3EA2C", Offset = "0xA3EA2C", VA = "0xA3EA2C")]
		public SizeChangedEventArgs()
		{
		}
	}

	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x0")]
	public static BetterList<UIWidget> list;

	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x8")]
	public static List<UIWidget> OrphanWidgets;

	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	protected Color mColor;

	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[HideInInspector]
	protected Pivot mPivot;

	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[HideInInspector]
	protected int mWidth;

	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	protected int mHeight;

	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[HideInInspector]
	protected int mDepth;

	[NonSerialized]
	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x38")]
	public Color OriginalColor;

	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0x48")]
	public ColorModel.ColorModelEnum SpecificColor;

	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x4C")]
	public bool autoResizeBoxCollider;

	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x50")]
	protected GameObject mGo;

	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x58")]
	protected Transform mTrans;

	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x60")]
	protected UIPanel mPanel;

	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x68")]
	protected bool mChanged;

	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x69")]
	protected bool mPlayMode;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x6A")]
	private bool mStarted;

	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x6C")]
	private Matrix4x4 mLocalToPanel;

	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0xAC")]
	private bool mVisibleByPanel;

	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0xB0")]
	private float mLastAlpha;

	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AF3A4", Offset = "0x5AF3A4")]
	private UIDrawCall _003CdrawCall_003Ek__BackingField;

	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0xC0")]
	private UIGeometry mGeom;

	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3[] mCorners;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0xD8")]
	private bool mForceVisible;

	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0xDC")]
	private Vector3 mOldV0;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0xE8")]
	private Vector3 mOldV1;

	[Token(Token = "0x1700006C")]
	public UIDrawCall drawCall
	{
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1173F0C", Offset = "0x1173F0C", VA = "0x1173F0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611B08", Offset = "0x611B08")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1173F14", Offset = "0x1173F14", VA = "0x1173F14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611B18", Offset = "0x611B18")]
		set
		{
		}
	}

	[Token(Token = "0x1700006D")]
	public bool isVisible
	{
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1173F1C", Offset = "0x1173F1C", VA = "0x1173F1C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006E")]
	public int width
	{
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1174160", Offset = "0x1174160", VA = "0x1174160")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x116B5C4", Offset = "0x116B5C4", VA = "0x116B5C4")]
		set
		{
		}
	}

	[Token(Token = "0x1700006F")]
	public int height
	{
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x11742B0", Offset = "0x11742B0", VA = "0x11742B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x116B6D4", Offset = "0x116B6D4", VA = "0x116B6D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000070")]
	public virtual Color color
	{
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x11742B8", Offset = "0x11742B8", VA = "0x11742B8", Slot = "4")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x11742C4", Offset = "0x11742C4", VA = "0x11742C4", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000071")]
	public float alpha
	{
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1174320", Offset = "0x1174320", VA = "0x1174320")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x116F9E0", Offset = "0x116F9E0", VA = "0x116F9E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000072")]
	public float finalAlpha
	{
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1173F50", Offset = "0x1173F50", VA = "0x1173F50")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000073")]
	public Pivot pivot
	{
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1174588", Offset = "0x1174588", VA = "0x1174588")]
		get
		{
			return default(Pivot);
		}
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1174590", Offset = "0x1174590", VA = "0x1174590")]
		set
		{
		}
	}

	[Token(Token = "0x17000074")]
	public int depth
	{
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1174864", Offset = "0x1174864", VA = "0x1174864")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x117486C", Offset = "0x117486C", VA = "0x117486C")]
		set
		{
		}
	}

	[Token(Token = "0x17000075")]
	public int raycastDepth
	{
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x11748F8", Offset = "0x11748F8", VA = "0x11748F8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000076")]
	public float top
	{
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x116B8B4", Offset = "0x116B8B4", VA = "0x116B8B4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000077")]
	public float bottom
	{
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x116B7F0", Offset = "0x116B7F0", VA = "0x116B7F0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000078")]
	public float left
	{
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x116BA4C", Offset = "0x116BA4C", VA = "0x116BA4C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000079")]
	public float right
	{
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x116B980", Offset = "0x116B980", VA = "0x116B980")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700007A")]
	public virtual Vector3[] localCorners
	{
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x117498C", Offset = "0x117498C", VA = "0x117498C", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007B")]
	public virtual Vector2 localSize
	{
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1174A58", Offset = "0x1174A58", VA = "0x1174A58", Slot = "7")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700007C")]
	public virtual Vector3[] worldCorners
	{
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1174AA4", Offset = "0x1174AA4", VA = "0x1174AA4", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007D")]
	public Vector3[] innerWorldCorners
	{
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1174C04", Offset = "0x1174C04", VA = "0x1174C04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007E")]
	public bool hasVertices
	{
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1174D9C", Offset = "0x1174D9C", VA = "0x1174D9C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700007F")]
	public Vector2 pivotOffset
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x116B7E4", Offset = "0x116B7E4", VA = "0x116B7E4")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000080")]
	public GameObject cachedGameObject
	{
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1174DB0", Offset = "0x1174DB0", VA = "0x1174DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000081")]
	public Transform cachedTransform
	{
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x11747D8", Offset = "0x11747D8", VA = "0x11747D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000082")]
	public virtual Material material
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1174E3C", Offset = "0x1174E3C", VA = "0x1174E3C", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1174E44", Offset = "0x1174E44", VA = "0x1174E44", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17000083")]
	public virtual Texture mainTexture
	{
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1174EC8", Offset = "0x1174EC8", VA = "0x1174EC8", Slot = "11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1174F70", Offset = "0x1174F70", VA = "0x1174F70", Slot = "12")]
		set
		{
		}
	}

	[Token(Token = "0x17000084")]
	public UIPanel panel
	{
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1174FF4", Offset = "0x1174FF4", VA = "0x1174FF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1175078", Offset = "0x1175078", VA = "0x1175078")]
		set
		{
		}
	}

	[Token(Token = "0x17000085")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x62DB88", Offset = "0x62DB88")]
	public Vector2 relativeSize
	{
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1175198", Offset = "0x1175198", VA = "0x1175198")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000086")]
	public bool hasBoxCollider
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x11751A0", Offset = "0x11751A0", VA = "0x11751A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000087")]
	public virtual int minWidth
	{
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1176750", Offset = "0x1176750", VA = "0x1176750", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000088")]
	public virtual int minHeight
	{
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1176758", Offset = "0x1176758", VA = "0x1176758", Slot = "22")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000089")]
	public virtual Vector4 border
	{
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1176760", Offset = "0x1176760", VA = "0x1176760", Slot = "23")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x14000003")]
	public event EventHandler<SizeChangedEventArgs> OnSizeChanged
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1174020", Offset = "0x1174020", VA = "0x1174020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611B28", Offset = "0x611B28")]
		add
		{
		}
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x11740C0", Offset = "0x11740C0", VA = "0x11740C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611B38", Offset = "0x611B38")]
		remove
		{
		}
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x1174168", Offset = "0x1174168", VA = "0x1174168")]
	private void ResizeCollider()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x117527C", Offset = "0x117527C", VA = "0x117527C")]
	public static int CompareFunc(UIWidget left, UIWidget right)
	{
		return default(int);
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x117542C", Offset = "0x117542C", VA = "0x117542C")]
	public Bounds CalculateBounds()
	{
		return default(Bounds);
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x116B2E0", Offset = "0x116B2E0", VA = "0x116B2E0")]
	public Bounds CalculateBounds(Transform relativeParent)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x117546C", Offset = "0x117546C", VA = "0x117546C")]
	private void SetDirty()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x1175568", Offset = "0x1175568", VA = "0x1175568")]
	protected void RemoveFromPanel(bool setOrphan = true)
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x1175670", Offset = "0x1175670", VA = "0x1175670", Slot = "13")]
	protected virtual void OnValidate()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x116D9B0", Offset = "0x116D9B0", VA = "0x116D9B0")]
	public void MarkAsChangedLite()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x1175718", Offset = "0x1175718", VA = "0x1175718", Slot = "14")]
	public virtual void MarkAsChanged()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x1174328", Offset = "0x1174328", VA = "0x1174328")]
	public void CreatePanel(bool unsetOrphan = true)
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x1175818", Offset = "0x1175818", VA = "0x1175818")]
	public void CheckLayer()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x117596C", Offset = "0x117596C", VA = "0x117596C")]
	public void ParentHasChanged()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x1175A8C", Offset = "0x1175A8C", VA = "0x1175A8C", Slot = "15")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x1175AC8", Offset = "0x1175AC8", VA = "0x1175AC8")]
	private void SetSpecificColor()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x1175B84", Offset = "0x1175B84", VA = "0x1175B84", Slot = "16")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x1175D0C", Offset = "0x1175D0C", VA = "0x1175D0C", Slot = "17")]
	protected virtual void UpgradeFrom265()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x1175E50", Offset = "0x1175E50", VA = "0x1175E50")]
	private void Start()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x1175E8C", Offset = "0x1175E8C", VA = "0x1175E8C", Slot = "18")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x1175F14", Offset = "0x1175F14", VA = "0x1175F14", Slot = "19")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x117608C", Offset = "0x117608C", VA = "0x117608C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x117610C", Offset = "0x117610C", VA = "0x117610C")]
	private bool HasTransformChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x1176160", Offset = "0x1176160", VA = "0x1176160")]
	public bool UpdateGeometry(bool forceVisible)
	{
		return default(bool);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x1176718", Offset = "0x1176718", VA = "0x1176718")]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x1176734", Offset = "0x1176734", VA = "0x1176734")]
	public void ReserveCapacity(ref int vertexCount, ref int uvsCount, ref int colsCount, ref int normalCount, ref int tanCount)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x116DC74", Offset = "0x116DC74", VA = "0x116DC74", Slot = "20")]
	public virtual void MakePixelPerfect()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x1176768", Offset = "0x1176768", VA = "0x1176768", Slot = "24")]
	protected virtual void OnStart()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x117676C", Offset = "0x117676C", VA = "0x117676C", Slot = "25")]
	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x116E200", Offset = "0x116E200", VA = "0x116E200")]
	public UIWidget()
	{
	}
}
