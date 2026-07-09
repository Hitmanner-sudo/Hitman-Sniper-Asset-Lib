using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200008C")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591B8C", Offset = "0x591B8C")]
[ExecuteInEditMode]
public class UIFont : MonoBehaviour
{
	[Token(Token = "0x200008D")]
	public enum SymbolStyle
	{
		[Token(Token = "0x400032B")]
		None = 0,
		[Token(Token = "0x400032C")]
		Uncolored = 1,
		[Token(Token = "0x400032D")]
		Colored = 2
	}

	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private Rect mUVRect;

	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[HideInInspector]
	private BMFont mFont;

	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[SerializeField]
	private int mSpacingX;

	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	[SerializeField]
	private int mSpacingY;

	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[HideInInspector]
	private UIFont mReplacement;

	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	[SerializeField]
	private float mPixelSize;

	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[HideInInspector]
	private List<BMSymbol> mSymbols;

	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[HideInInspector]
	private List<EffectTag> mEffectTags;

	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	[SerializeField]
	private Font mDynamicFont;

	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[HideInInspector]
	private int mDynamicFontSize;

	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x74")]
	[HideInInspector]
	[SerializeField]
	private FontStyle mDynamicFontStyle;

	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x78")]
	private UISpriteData mSprite;

	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x80")]
	private int mPMA;

	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x84")]
	private bool mSpriteSet;

	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x0")]
	private static BetterList<Color> mColors;

	[Token(Token = "0x170000AF")]
	public BMFont bmFont
	{
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x179C4F8", Offset = "0x179C4F8", VA = "0x179C4F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B0")]
	public int texWidth
	{
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x179C588", Offset = "0x179C588", VA = "0x179C588")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000B1")]
	public int texHeight
	{
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x179C628", Offset = "0x179C628", VA = "0x179C628")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000B2")]
	public bool hasSymbols
	{
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x179C6C8", Offset = "0x179C6C8", VA = "0x179C6C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B3")]
	public List<BMSymbol> symbols
	{
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x179C778", Offset = "0x179C778", VA = "0x179C778")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B4")]
	public List<EffectTag> effectTags
	{
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x179C808", Offset = "0x179C808", VA = "0x179C808")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B5")]
	public UIAtlas atlas
	{
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x179C898", Offset = "0x179C898", VA = "0x179C898")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x179C928", Offset = "0x179C928", VA = "0x179C928")]
		set
		{
		}
	}

	[Token(Token = "0x170000B6")]
	public Material material
	{
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x179D0EC", Offset = "0x179D0EC", VA = "0x179D0EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x179D300", Offset = "0x179D300", VA = "0x179D300")]
		set
		{
		}
	}

	[Token(Token = "0x170000B7")]
	public float pixelSize
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x179D3E4", Offset = "0x179D3E4", VA = "0x179D3E4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x179D4C4", Offset = "0x179D4C4", VA = "0x179D4C4")]
		set
		{
		}
	}

	[Token(Token = "0x170000B8")]
	public bool premultipliedAlpha
	{
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x179D5F4", Offset = "0x179D5F4", VA = "0x179D5F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B9")]
	public Texture2D texture
	{
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x179D7AC", Offset = "0x179D7AC", VA = "0x179D7AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000BA")]
	public Rect uvRect
	{
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x179CC84", Offset = "0x179CC84", VA = "0x179CC84")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x179DAD0", Offset = "0x179DAD0", VA = "0x179DAD0")]
		set
		{
		}
	}

	[Token(Token = "0x170000BB")]
	public string spriteName
	{
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x179DBD0", Offset = "0x179DBD0", VA = "0x179DBD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x179DC68", Offset = "0x179DC68", VA = "0x179DC68")]
		set
		{
		}
	}

	[Token(Token = "0x170000BC")]
	public int horizontalSpacing
	{
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x179DD38", Offset = "0x179DD38", VA = "0x179DD38")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x179DDC8", Offset = "0x179DDC8", VA = "0x179DDC8")]
		set
		{
		}
	}

	[Token(Token = "0x170000BD")]
	public int verticalSpacing
	{
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x179DE80", Offset = "0x179DE80", VA = "0x179DE80")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x179DF10", Offset = "0x179DF10", VA = "0x179DF10")]
		set
		{
		}
	}

	[Token(Token = "0x170000BE")]
	public bool isValid
	{
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x179DFC8", Offset = "0x179DFC8", VA = "0x179DFC8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000BF")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x62DBC0", Offset = "0x62DBC0")]
	public int size
	{
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x179E05C", Offset = "0x179E05C", VA = "0x179E05C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x179E110", Offset = "0x179E110", VA = "0x179E110")]
		set
		{
		}
	}

	[Token(Token = "0x170000C0")]
	public int defaultSize
	{
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x179E060", Offset = "0x179E060", VA = "0x179E060")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x179E114", Offset = "0x179E114", VA = "0x179E114")]
		set
		{
		}
	}

	[Token(Token = "0x170000C1")]
	public UISpriteData sprite
	{
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x179CA98", Offset = "0x179CA98", VA = "0x179CA98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C2")]
	public UIFont replacement
	{
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x179E214", Offset = "0x179E214", VA = "0x179E214")]
		get
		{
			return null;
		}
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x179E21C", Offset = "0x179E21C", VA = "0x179E21C")]
		set
		{
		}
	}

	[Token(Token = "0x170000C3")]
	public bool isDynamic
	{
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x179E1A8", Offset = "0x179E1A8", VA = "0x179E1A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C4")]
	public Font dynamicFont
	{
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x179E390", Offset = "0x179E390", VA = "0x179E390")]
		get
		{
			return null;
		}
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x179E420", Offset = "0x179E420", VA = "0x179E420")]
		set
		{
		}
	}

	[Token(Token = "0x170000C5")]
	public FontStyle dynamicFontStyle
	{
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x179E538", Offset = "0x179E538", VA = "0x179E538")]
		get
		{
			return default(FontStyle);
		}
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x179E5C8", Offset = "0x179E5C8", VA = "0x179E5C8")]
		set
		{
		}
	}

	[Token(Token = "0x170000C6")]
	private Texture dynamicTexture
	{
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x179E908", Offset = "0x179E908", VA = "0x179E908")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x179D8B0", Offset = "0x179D8B0", VA = "0x179D8B0")]
	private void Trim()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x179E680", Offset = "0x179E680", VA = "0x179E680")]
	private bool References(UIFont font)
	{
		return default(bool);
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x179E774", Offset = "0x179E774", VA = "0x179E774")]
	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x179CE8C", Offset = "0x179CE8C", VA = "0x179CE8C")]
	public void MarkAsDirty()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x179EAC8", Offset = "0x179EAC8", VA = "0x179EAC8")]
	public Vector2 CalculatePrintedSize(string text, int size, bool encoding, SymbolStyle symbolStyle)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x179EF40", Offset = "0x179EF40", VA = "0x179EF40")]
	public string GetEndOfLineThatFits(string text, int size, int lineWidth, bool encoding, SymbolStyle symbolStyle)
	{
		return null;
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x179EF80", Offset = "0x179EF80", VA = "0x179EF80")]
	public int CalculateOffsetToFit(string text, int size, int lineWidth, bool encoding, SymbolStyle symbolStyle)
	{
		return default(int);
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x179F1B4", Offset = "0x179F1B4", VA = "0x179F1B4")]
	public bool WrapText(string text, int size, out string finalText, int width, int height, int maxLines, bool encoding)
	{
		return default(bool);
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x179F824", Offset = "0x179F824", VA = "0x179F824")]
	public bool WrapText(string text, int size, out string finalText, int width, int height, int maxLineCount)
	{
		return default(bool);
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x179F1DC", Offset = "0x179F1DC", VA = "0x179F1DC")]
	public bool WrapText(string text, int size, out string finalText, int width, int height, int maxLines, bool encoding, SymbolStyle symbolStyle)
	{
		return default(bool);
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x179F84C", Offset = "0x179F84C", VA = "0x179F84C")]
	public void Print(string text, int size, Color32 color, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, bool encoding, SymbolStyle symbolStyle, TextAlignment alignment, int lineWidth, bool premultiply)
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x17A0218", Offset = "0x17A0218", VA = "0x17A0218")]
	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		return null;
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x17A034C", Offset = "0x17A034C", VA = "0x17A034C")]
	private EffectTag GetEffectTag(string sequence, bool createIfMissing)
	{
		return null;
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x179EDDC", Offset = "0x179EDDC", VA = "0x179EDDC")]
	private BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x17A0480", Offset = "0x17A0480", VA = "0x17A0480")]
	public EffectTag MatchAndRemoveEffectTags(ref string text)
	{
		return null;
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x17A05F0", Offset = "0x17A05F0", VA = "0x17A05F0")]
	public void AddSymbol(string sequence, string spriteName)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x17A0628", Offset = "0x17A0628", VA = "0x17A0628")]
	public void RemoveSymbol(string sequence)
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x17A06B0", Offset = "0x17A06B0", VA = "0x17A06B0")]
	public void RenameSymbol(string before, string after)
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x17A06E4", Offset = "0x17A06E4", VA = "0x17A06E4")]
	public void AddEffectTag(string sequence, UILabel.Effect effectStyle, Vector2 effectDistance)
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x17A072C", Offset = "0x17A072C", VA = "0x17A072C")]
	public void RemoveEffectTag(string sequence)
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x17A07B4", Offset = "0x17A07B4", VA = "0x17A07B4")]
	public void RenameEffectTag(string before, string after)
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x17A07E8", Offset = "0x17A07E8", VA = "0x17A07E8")]
	public bool UsesSprite(string s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x17A08F8", Offset = "0x17A08F8", VA = "0x17A08F8")]
	public UIFont()
	{
	}
}
