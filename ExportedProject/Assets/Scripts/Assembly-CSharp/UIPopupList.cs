using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000037")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x59103C", Offset = "0x59103C")]
public class UIPopupList : UIWidgetContainer
{
	[Token(Token = "0x2000038")]
	public enum Position
	{
		[Token(Token = "0x4000132")]
		Auto = 0,
		[Token(Token = "0x4000133")]
		Above = 1,
		[Token(Token = "0x4000134")]
		Below = 2
	}

	[Token(Token = "0x2000039")]
	public delegate void LegacyEvent(string val);

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x0")]
	public static UIPopupList current;

	[Token(Token = "0x4000112")]
	private const float animSpeed = 0.15f;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x18")]
	public UIAtlas atlas;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x20")]
	public UIFont bitmapFont;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x28")]
	public Font trueTypeFont;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x30")]
	public int fontSize;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x34")]
	public FontStyle fontStyle;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x38")]
	public UILabel textLabel;

	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x40")]
	public string backgroundSprite;

	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x48")]
	public string highlightSprite;

	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x50")]
	public Position position;

	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x58")]
	public List<string> items;

	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 padding;

	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x68")]
	public Color textColor;

	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x78")]
	public Color backgroundColor;

	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x88")]
	public Color highlightColor;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x98")]
	public bool isAnimated;

	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x99")]
	public bool isLocalized;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0xA0")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[HideInInspector]
	private string mSelectedItem;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0xB0")]
	private UIPanel mPanel;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject mChild;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0xC0")]
	private UISprite mBackground;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0xC8")]
	private UISprite mHighlight;

	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0xD0")]
	private UILabel mHighlightedLabel;

	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0xD8")]
	private List<UILabel> mLabelList;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0xE0")]
	private float mBgBorder;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0xE8")]
	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0xF0")]
	[HideInInspector]
	[SerializeField]
	private string functionName;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0xF8")]
	[HideInInspector]
	[SerializeField]
	private float textScale;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[HideInInspector]
	private UIFont font;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x108")]
	private LegacyEvent mLegacyEvent;

	[Token(Token = "0x17000025")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x62DA70", Offset = "0x62DA70")]
	public LegacyEvent onSelectionChange
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x142A3CC", Offset = "0x142A3CC", VA = "0x142A3CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x142A3D4", Offset = "0x142A3D4", VA = "0x142A3D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public bool isOpen
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x142A3DC", Offset = "0x142A3DC", VA = "0x142A3DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000027")]
	public string value
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x142A448", Offset = "0x142A448", VA = "0x142A448")]
		get
		{
			return null;
		}
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x142A450", Offset = "0x142A450", VA = "0x142A450")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x62DAA8", Offset = "0x62DAA8")]
	public string selection
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x142A6E8", Offset = "0x142A6E8", VA = "0x142A6E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x142A6F0", Offset = "0x142A6F0", VA = "0x142A6F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	private bool handleEvents
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x142A6F4", Offset = "0x142A6F4", VA = "0x142A6F4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x142A7B0", Offset = "0x142A7B0", VA = "0x142A7B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	private bool isValid
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x142A87C", Offset = "0x142A87C", VA = "0x142A87C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002B")]
	private int activeFontSize
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x142A934", Offset = "0x142A934", VA = "0x142A934")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700002C")]
	private float activeFontScale
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x142AA04", Offset = "0x142AA04", VA = "0x142AA04")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x142AAE4", Offset = "0x142AAE4", VA = "0x142AAE4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x142ACE4", Offset = "0x142ACE4", VA = "0x142ACE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x142ADCC", Offset = "0x142ADCC", VA = "0x142ADCC")]
	private void OnLocalize(Localization loc)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x142AEB8", Offset = "0x142AEB8", VA = "0x142AEB8")]
	private void Highlight(UILabel lbl, bool instant)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x142B214", Offset = "0x142B214", VA = "0x142B214")]
	private void OnItemHover(GameObject go, bool isOver)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x142B29C", Offset = "0x142B29C", VA = "0x142B29C")]
	private void Select(UILabel lbl, bool instant)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x142B430", Offset = "0x142B430", VA = "0x142B430")]
	private void OnItemPress(GameObject go, bool isPressed)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x142B4B8", Offset = "0x142B4B8", VA = "0x142B4B8")]
	private void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x142B650", Offset = "0x142B650", VA = "0x142B650")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x142B8D4", Offset = "0x142B8D4", VA = "0x142B8D4")]
	private void AnimateColor(UIWidget widget)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x142B994", Offset = "0x142B994", VA = "0x142B994")]
	private void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x142BA54", Offset = "0x142BA54", VA = "0x142BA54")]
	private void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x142BBBC", Offset = "0x142BBBC", VA = "0x142BBBC")]
	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x142BBF8", Offset = "0x142BBF8", VA = "0x142BBF8")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x142C928", Offset = "0x142C928", VA = "0x142C928")]
	public UIPopupList()
	{
	}
}
