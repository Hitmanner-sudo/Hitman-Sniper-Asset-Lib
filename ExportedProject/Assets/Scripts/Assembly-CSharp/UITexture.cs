using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000A8")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x591F80", Offset = "0x591F80")]
public class UITexture : UIWidget
{
	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0xF4")]
	[HideInInspector]
	[SerializeField]
	private Rect mRect;

	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[HideInInspector]
	private Shader mShader;

	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[HideInInspector]
	private Texture mTexture;

	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x118")]
	[HideInInspector]
	[SerializeField]
	private Material mMat;

	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x120")]
	private bool mCreatingMat;

	[Token(Token = "0x4000419")]
	[FieldOffset(Offset = "0x128")]
	private Material mDynamicMat;

	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x130")]
	private int mPMA;

	[Token(Token = "0x1700010C")]
	public Rect uvRect
	{
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x116D050", Offset = "0x116D050", VA = "0x116D050")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x116D05C", Offset = "0x116D05C", VA = "0x116D05C")]
		set
		{
		}
	}

	[Token(Token = "0x1700010D")]
	public Shader shader
	{
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x116D0EC", Offset = "0x116D0EC", VA = "0x116D0EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x116D224", Offset = "0x116D224", VA = "0x116D224")]
		set
		{
		}
	}

	[Token(Token = "0x1700010E")]
	public bool hasDynamicMaterial
	{
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x116D30C", Offset = "0x116D30C", VA = "0x116D30C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700010F")]
	public override Material material
	{
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x116D378", Offset = "0x116D378", VA = "0x116D378", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x116D5E8", Offset = "0x116D5E8", VA = "0x116D5E8", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17000110")]
	public bool premultipliedAlpha
	{
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x116D69C", Offset = "0x116D69C", VA = "0x116D69C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000111")]
	public override Texture mainTexture
	{
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x116D7D4", Offset = "0x116D7D4", VA = "0x116D7D4", Slot = "11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x116D8AC", Offset = "0x116D8AC", VA = "0x116D8AC", Slot = "12")]
		set
		{
		}
	}

	[Token(Token = "0x17000112")]
	private Vector4 drawingDimensions
	{
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x116D9BC", Offset = "0x116D9BC", VA = "0x116D9BC")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x116DB8C", Offset = "0x116DB8C", VA = "0x116DB8C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x116D534", Offset = "0x116D534", VA = "0x116D534")]
	private void Cleanup()
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x116DB90", Offset = "0x116DB90", VA = "0x116DB90", Slot = "20")]
	public override void MakePixelPerfect()
	{
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x116DEA0", Offset = "0x116DEA0", VA = "0x116DEA0", Slot = "25")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x116E164", Offset = "0x116E164", VA = "0x116E164")]
	public UITexture()
	{
	}
}
