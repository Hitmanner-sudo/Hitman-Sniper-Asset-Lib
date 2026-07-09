using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000093")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x591C10", Offset = "0x591C10")]
public class UILabel : UIWidget
{
	[Token(Token = "0x2000094")]
	public enum Effect
	{
		[Token(Token = "0x4000376")]
		None = 0,
		[Token(Token = "0x4000377")]
		Shadow = 1,
		[Token(Token = "0x4000378")]
		Outline = 2
	}

	[Token(Token = "0x2000095")]
	public enum Overflow
	{
		[Token(Token = "0x400037A")]
		ShrinkContent = 0,
		[Token(Token = "0x400037B")]
		ClampContent = 1,
		[Token(Token = "0x400037C")]
		ResizeFreely = 2,
		[Token(Token = "0x400037D")]
		ResizeHeight = 3
	}

	[Token(Token = "0x2000096")]
	public enum Crispness
	{
		[Token(Token = "0x400037F")]
		Never = 0,
		[Token(Token = "0x4000380")]
		OnDesktop = 1,
		[Token(Token = "0x4000381")]
		Always = 2
	}

	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0xF4")]
	public Crispness keepCrispWhenShrunk;

	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0xF8")]
	[HideInInspector]
	[SerializeField]
	private Font mTrueTypeFont;

	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[HideInInspector]
	private UIFont mFont;

	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[HideInInspector]
	[Attribute(Name = "MultilineAttribute", RVA = "0x5AFA5C", Offset = "0x5AFA5C")]
	private string mText;

	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[HideInInspector]
	private int mFontSize;

	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[HideInInspector]
	private FontStyle mFontStyle;

	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x118")]
	[HideInInspector]
	[SerializeField]
	private bool mEncoding;

	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x11C")]
	[HideInInspector]
	[SerializeField]
	private int mMaxLineCount;

	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x120")]
	[HideInInspector]
	[SerializeField]
	private Effect mEffectStyle;

	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x124")]
	[HideInInspector]
	[SerializeField]
	private bool mEffectInheritsColor;

	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x128")]
	[HideInInspector]
	[SerializeField]
	private Color mEffectColor;

	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x138")]
	[HideInInspector]
	[SerializeField]
	private UIFont.SymbolStyle mSymbols;

	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x13C")]
	[HideInInspector]
	[SerializeField]
	private Vector2 mEffectDistance;

	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0x144")]
	[SerializeField]
	[HideInInspector]
	private Overflow mOverflow;

	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[HideInInspector]
	private bool mShrinkToFit;

	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0x14C")]
	[HideInInspector]
	[SerializeField]
	private int mMaxLineWidth;

	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0x150")]
	[HideInInspector]
	[SerializeField]
	private int mMaxLineHeight;

	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x154")]
	[HideInInspector]
	[SerializeField]
	private float mLineWidth;

	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0x158")]
	[HideInInspector]
	[SerializeField]
	private bool mMultiline;

	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0x160")]
	private Font mActiveTTF;

	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0x168")]
	private bool mShouldBeProcessed;

	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0x170")]
	private string mProcessedText;

	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0x178")]
	private bool mPremultiply;

	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0x17C")]
	private Vector2 mCalculatedSize;

	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x184")]
	private float mScale;

	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x188")]
	private int mLastWidth;

	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x18C")]
	private int mLastHeight;

	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x190")]
	private int mPrintedSize;

	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x194")]
	private bool mUseDynamicFont;

	[Token(Token = "0x170000CE")]
	private bool hasChanged
	{
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x17A4FF8", Offset = "0x17A4FF8", VA = "0x17A4FF8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x17A5000", Offset = "0x17A5000", VA = "0x17A5000")]
		set
		{
		}
	}

	[Token(Token = "0x170000CF")]
	public override Material material
	{
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x17A501C", Offset = "0x17A501C", VA = "0x17A501C", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D0")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x62DC68", Offset = "0x62DC68")]
	public UIFont font
	{
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x17A5104", Offset = "0x17A5104", VA = "0x17A5104")]
		get
		{
			return null;
		}
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x17A510C", Offset = "0x17A510C", VA = "0x17A510C")]
		set
		{
		}
	}

	[Token(Token = "0x170000D1")]
	public UIFont bitmapFont
	{
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x17A5110", Offset = "0x17A5110", VA = "0x17A5110")]
		get
		{
			return null;
		}
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x179E9CC", Offset = "0x179E9CC", VA = "0x179E9CC")]
		set
		{
		}
	}

	[Token(Token = "0x170000D2")]
	public Font trueTypeFont
	{
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x17A5118", Offset = "0x17A5118", VA = "0x17A5118")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x17A5120", Offset = "0x17A5120", VA = "0x17A5120")]
		set
		{
		}
	}

	[Token(Token = "0x170000D3")]
	public Object ambigiousFont
	{
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x17A5544", Offset = "0x17A5544", VA = "0x17A5544")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x17A55C4", Offset = "0x17A55C4", VA = "0x17A55C4")]
		set
		{
		}
	}

	[Token(Token = "0x170000D4")]
	public string text
	{
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x17A5778", Offset = "0x17A5778", VA = "0x17A5778")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x17A4538", Offset = "0x17A4538", VA = "0x17A4538")]
		set
		{
		}
	}

	[Token(Token = "0x170000D5")]
	public int fontSize
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x17A5780", Offset = "0x17A5780", VA = "0x17A5780")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x17A5810", Offset = "0x17A5810", VA = "0x17A5810")]
		set
		{
		}
	}

	[Token(Token = "0x170000D6")]
	public FontStyle fontStyle
	{
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x17A586C", Offset = "0x17A586C", VA = "0x17A586C")]
		get
		{
			return default(FontStyle);
		}
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x17A5874", Offset = "0x17A5874", VA = "0x17A5874")]
		set
		{
		}
	}

	[Token(Token = "0x170000D7")]
	private bool usePrintedSize
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x17A5898", Offset = "0x17A5898", VA = "0x17A5898")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000D8")]
	public bool supportEncoding
	{
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x17A5A98", Offset = "0x17A5A98", VA = "0x17A5A98")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x17A3FA0", Offset = "0x17A3FA0", VA = "0x17A3FA0")]
		set
		{
		}
	}

	[Token(Token = "0x170000D9")]
	public UIFont.SymbolStyle symbolStyle
	{
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x17A5AA0", Offset = "0x17A5AA0", VA = "0x17A5AA0")]
		get
		{
			return default(UIFont.SymbolStyle);
		}
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x17A5AA8", Offset = "0x17A5AA8", VA = "0x17A5AA8")]
		set
		{
		}
	}

	[Token(Token = "0x170000DA")]
	public Overflow overflowMethod
	{
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x17A5AC8", Offset = "0x17A5AC8", VA = "0x17A5AC8")]
		get
		{
			return default(Overflow);
		}
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x17A5AD0", Offset = "0x17A5AD0", VA = "0x17A5AD0")]
		set
		{
		}
	}

	[Token(Token = "0x170000DB")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x62DCA0", Offset = "0x62DCA0")]
	public int lineWidth
	{
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x17A5AF0", Offset = "0x17A5AF0", VA = "0x17A5AF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x17A5AF8", Offset = "0x17A5AF8", VA = "0x17A5AF8")]
		set
		{
		}
	}

	[Token(Token = "0x170000DC")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x62DCD8", Offset = "0x62DCD8")]
	public int lineHeight
	{
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x17A5B00", Offset = "0x17A5B00", VA = "0x17A5B00")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x17A5B08", Offset = "0x17A5B08", VA = "0x17A5B08")]
		set
		{
		}
	}

	[Token(Token = "0x170000DD")]
	public bool multiLine
	{
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x17A5B10", Offset = "0x17A5B10", VA = "0x17A5B10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x17A5B20", Offset = "0x17A5B20", VA = "0x17A5B20")]
		set
		{
		}
	}

	[Token(Token = "0x170000DE")]
	public override Vector3[] localCorners
	{
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x17A5B50", Offset = "0x17A5B50", VA = "0x17A5B50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000DF")]
	public override Vector3[] worldCorners
	{
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x17A5B88", Offset = "0x17A5B88", VA = "0x17A5B88", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E0")]
	public int maxLineCount
	{
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x17A5BC0", Offset = "0x17A5BC0", VA = "0x17A5BC0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x17A5BC8", Offset = "0x17A5BC8", VA = "0x17A5BC8")]
		set
		{
		}
	}

	[Token(Token = "0x170000E1")]
	public Effect effectStyle
	{
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x17A5C34", Offset = "0x17A5C34", VA = "0x17A5C34")]
		get
		{
			return default(Effect);
		}
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x17A5C3C", Offset = "0x17A5C3C", VA = "0x17A5C3C")]
		set
		{
		}
	}

	[Token(Token = "0x170000E2")]
	public bool EffectInheritsColor
	{
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x17A5C5C", Offset = "0x17A5C5C", VA = "0x17A5C5C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x17A5C64", Offset = "0x17A5C64", VA = "0x17A5C64")]
		set
		{
		}
	}

	[Token(Token = "0x170000E3")]
	public Color effectColor
	{
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x17A5C70", Offset = "0x17A5C70", VA = "0x17A5C70")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x17A5CB0", Offset = "0x17A5CB0", VA = "0x17A5CB0")]
		set
		{
		}
	}

	[Token(Token = "0x170000E4")]
	public Vector2 effectDistance
	{
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x17A5D20", Offset = "0x17A5D20", VA = "0x17A5D20")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x17A5D2C", Offset = "0x17A5D2C", VA = "0x17A5D2C")]
		set
		{
		}
	}

	[Token(Token = "0x170000E5")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x62DD10", Offset = "0x62DD10")]
	public bool shrinkToFit
	{
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x17A5D70", Offset = "0x17A5D70", VA = "0x17A5D70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x17A5D80", Offset = "0x17A5D80", VA = "0x17A5D80")]
		set
		{
		}
	}

	[Token(Token = "0x170000E6")]
	public string processedText
	{
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x17A5DA0", Offset = "0x17A5DA0", VA = "0x17A5DA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E7")]
	public Vector2 printedSize
	{
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x17A5E0C", Offset = "0x17A5E0C", VA = "0x17A5E0C")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170000E8")]
	public override Vector2 localSize
	{
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x17A5E44", Offset = "0x17A5E44", VA = "0x17A5E44", Slot = "7")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170000E9")]
	private bool isValid
	{
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x17A5E7C", Offset = "0x17A5E7C", VA = "0x17A5E7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000EA")]
	private float pixelSize
	{
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x17A5F34", Offset = "0x17A5F34", VA = "0x17A5F34")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x17A56D8", Offset = "0x17A56D8", VA = "0x17A56D8")]
	public string GetTextWithoutEffectTags(string text)
	{
		return null;
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x17A542C", Offset = "0x17A542C", VA = "0x17A542C")]
	private void ProcessAndRequest()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x17A5930", Offset = "0x17A5930", VA = "0x17A5930", Slot = "13")]
	protected override void OnValidate()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x17A5FC4", Offset = "0x17A5FC4", VA = "0x17A5FC4", Slot = "16")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x179EA70", Offset = "0x179EA70", VA = "0x179EA70")]
	public void RefreshFont()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x17A60AC", Offset = "0x17A60AC", VA = "0x17A60AC", Slot = "19")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x17A5218", Offset = "0x17A5218", VA = "0x17A5218")]
	protected void SetActiveFont(Font fnt)
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x17A6138", Offset = "0x17A6138", VA = "0x17A6138", Slot = "17")]
	protected override void UpgradeFrom265()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x17A6868", Offset = "0x17A6868", VA = "0x17A6868", Slot = "24")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x17A6A40", Offset = "0x17A6A40", VA = "0x17A6A40", Slot = "14")]
	public override void MarkAsChanged()
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x17A5928", Offset = "0x17A5928", VA = "0x17A5928")]
	private void ProcessText()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x17A6368", Offset = "0x17A6368", VA = "0x17A6368")]
	private void ProcessText(bool legacyMode)
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x17A6A54", Offset = "0x17A6A54", VA = "0x17A6A54", Slot = "20")]
	public override void MakePixelPerfect()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x17A301C", Offset = "0x17A301C", VA = "0x17A301C")]
	public void AssumeNaturalSize()
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x17A6CA0", Offset = "0x17A6CA0", VA = "0x17A6CA0")]
	private void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x17A6FC8", Offset = "0x17A6FC8", VA = "0x17A6FC8", Slot = "25")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x17A4E10", Offset = "0x17A4E10", VA = "0x17A4E10")]
	public int CalculateOffsetToFit(string text)
	{
		return default(int);
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x17A7608", Offset = "0x17A7608", VA = "0x17A7608")]
	public UILabel()
	{
	}
}
