using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200009E")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x591E1C", Offset = "0x591E1C")]
public class UISprite : UIWidget
{
	[Token(Token = "0x200009F")]
	public enum Type
	{
		[Token(Token = "0x40003C4")]
		Simple = 0,
		[Token(Token = "0x40003C5")]
		Sliced = 1,
		[Token(Token = "0x40003C6")]
		Tiled = 2,
		[Token(Token = "0x40003C7")]
		Filled = 3
	}

	[Token(Token = "0x20000A0")]
	public enum FillDirection
	{
		[Token(Token = "0x40003C9")]
		Horizontal = 0,
		[Token(Token = "0x40003CA")]
		Vertical = 1,
		[Token(Token = "0x40003CB")]
		Radial90 = 2,
		[Token(Token = "0x40003CC")]
		Radial180 = 3,
		[Token(Token = "0x40003CD")]
		Radial360 = 4
	}

	[Token(Token = "0x40003B8")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[Token(Token = "0x40003B9")]
	[FieldOffset(Offset = "0x100")]
	[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	[Token(Token = "0x40003BA")]
	[FieldOffset(Offset = "0x108")]
	[HideInInspector]
	[SerializeField]
	private bool mFillCenter;

	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0x10C")]
	[HideInInspector]
	[SerializeField]
	private Type mType;

	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[HideInInspector]
	private FillDirection mFillDirection;

	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[HideInInspector]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B0040", Offset = "0x5B0040")]
	private float mFillAmount;

	[Token(Token = "0x40003BE")]
	[FieldOffset(Offset = "0x118")]
	[HideInInspector]
	[SerializeField]
	private bool mInvert;

	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0x120")]
	protected UISpriteData mSprite;

	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x128")]
	protected Rect mInnerUV;

	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x138")]
	protected Rect mOuterUV;

	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x148")]
	private bool mSpriteSet;

	[Token(Token = "0x170000F8")]
	public virtual Type type
	{
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1432904", Offset = "0x1432904", VA = "0x1432904", Slot = "26")]
		get
		{
			return default(Type);
		}
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x143290C", Offset = "0x143290C", VA = "0x143290C", Slot = "27")]
		set
		{
		}
	}

	[Token(Token = "0x170000F9")]
	public override Material material
	{
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1432930", Offset = "0x1432930", VA = "0x1432930", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000FA")]
	public UIAtlas atlas
	{
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x14329C4", Offset = "0x14329C4", VA = "0x14329C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x14329CC", Offset = "0x14329CC", VA = "0x14329CC")]
		set
		{
		}
	}

	[Token(Token = "0x170000FB")]
	public string spriteName
	{
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1432BFC", Offset = "0x1432BFC", VA = "0x1432BFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1423E88", Offset = "0x1423E88", VA = "0x1423E88")]
		set
		{
		}
	}

	[Token(Token = "0x170000FC")]
	public bool isValid
	{
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1432C04", Offset = "0x1432C04", VA = "0x1432C04")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000FD")]
	public bool fillCenter
	{
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1432C20", Offset = "0x1432C20", VA = "0x1432C20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1432C28", Offset = "0x1432C28", VA = "0x1432C28")]
		set
		{
		}
	}

	[Token(Token = "0x170000FE")]
	public FillDirection fillDirection
	{
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1432C58", Offset = "0x1432C58", VA = "0x1432C58")]
		get
		{
			return default(FillDirection);
		}
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1432C60", Offset = "0x1432C60", VA = "0x1432C60")]
		set
		{
		}
	}

	[Token(Token = "0x170000FF")]
	public float fillAmount
	{
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1432C7C", Offset = "0x1432C7C", VA = "0x1432C7C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x142CDA4", Offset = "0x142CDA4", VA = "0x142CDA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000100")]
	public bool invert
	{
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1432C84", Offset = "0x1432C84", VA = "0x1432C84")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1432C8C", Offset = "0x1432C8C", VA = "0x1432C8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000101")]
	public override Vector4 border
	{
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1432CB4", Offset = "0x1432CB4", VA = "0x1432CB4", Slot = "23")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x17000102")]
	public override int minWidth
	{
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1432D54", Offset = "0x1432D54", VA = "0x1432D54", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000103")]
	public override int minHeight
	{
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1432EAC", Offset = "0x1432EAC", VA = "0x1432EAC", Slot = "22")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000104")]
	private Vector4 drawingDimensions
	{
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1434D7C", Offset = "0x1434D7C", VA = "0x1434D7C")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x1433004", Offset = "0x1433004", VA = "0x1433004", Slot = "13")]
	protected override void OnValidate()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x142B0B4", Offset = "0x142B0B4", VA = "0x142B0B4")]
	public UISpriteData GetAtlasSprite()
	{
		return null;
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x1432B74", Offset = "0x1432B74", VA = "0x1432B74")]
	protected void SetAtlasSprite(UISpriteData sp)
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x1433038", Offset = "0x1433038", VA = "0x1433038", Slot = "20")]
	public override void MakePixelPerfect()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x14331B4", Offset = "0x14331B4", VA = "0x14331B4", Slot = "18")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x14331F8", Offset = "0x14331F8", VA = "0x14331F8", Slot = "25")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x14334FC", Offset = "0x14334FC", VA = "0x14334FC")]
	protected void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x14337A4", Offset = "0x14337A4", VA = "0x14337A4")]
	protected void SlicedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x14348B0", Offset = "0x14348B0", VA = "0x14348B0")]
	protected void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x1433E3C", Offset = "0x1433E3C", VA = "0x1433E3C")]
	protected void FilledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x1434EC4", Offset = "0x1434EC4", VA = "0x1434EC4")]
	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
	{
		return default(bool);
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x1434FA4", Offset = "0x1434FA4", VA = "0x1434FA4")]
	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x143537C", Offset = "0x143537C", VA = "0x143537C")]
	public UISprite()
	{
	}
}
