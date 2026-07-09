using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200008E")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x591BD8", Offset = "0x591BD8")]
public class UIInput : MonoBehaviour
{
	[Token(Token = "0x200008F")]
	public enum InputType
	{
		[Token(Token = "0x4000345")]
		Standard = 0,
		[Token(Token = "0x4000346")]
		AutoCorrect = 1,
		[Token(Token = "0x4000347")]
		Password = 2
	}

	[Token(Token = "0x2000090")]
	public enum Validation
	{
		[Token(Token = "0x4000349")]
		None = 0,
		[Token(Token = "0x400034A")]
		Integer = 1,
		[Token(Token = "0x400034B")]
		Float = 2,
		[Token(Token = "0x400034C")]
		Alphanumeric = 3,
		[Token(Token = "0x400034D")]
		Username = 4,
		[Token(Token = "0x400034E")]
		Name = 5
	}

	[Token(Token = "0x2000091")]
	public enum KeyboardType
	{
		[Token(Token = "0x4000350")]
		Default = 0,
		[Token(Token = "0x4000351")]
		ASCIICapable = 1,
		[Token(Token = "0x4000352")]
		NumbersAndPunctuation = 2,
		[Token(Token = "0x4000353")]
		URL = 3,
		[Token(Token = "0x4000354")]
		NumberPad = 4,
		[Token(Token = "0x4000355")]
		PhonePad = 5,
		[Token(Token = "0x4000356")]
		NamePhonePad = 6,
		[Token(Token = "0x4000357")]
		EmailAddress = 7
	}

	[Token(Token = "0x2000092")]
	public delegate char OnValidate(string text, int charIndex, char addedChar);

	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x0")]
	public static UIInput current;

	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x8")]
	public static UIInput selection;

	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x18")]
	public UILabel label;

	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x20")]
	public InputType inputType;

	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x24")]
	public KeyboardType keyboardType;

	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x28")]
	public Validation validation;

	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x2C")]
	public int characterLimit;

	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x30")]
	public string savedAs;

	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x38")]
	public GameObject selectOnTab;

	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x40")]
	public Color activeTextColor;

	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x50")]
	public List<EventDelegate> onSubmit;

	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0x60")]
	public OnValidate onValidate;

	[Token(Token = "0x400033B")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[HideInInspector]
	protected string mValue;

	[Token(Token = "0x400033C")]
	[FieldOffset(Offset = "0x70")]
	protected string mDefaultText;

	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x78")]
	protected Color mDefaultColor;

	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x88")]
	protected float mPosition;

	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x8C")]
	protected bool mDoInit;

	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0x90")]
	protected UIWidget.Pivot mPivot;

	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0x10")]
	protected static int mDrawStart;

	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0x14")]
	protected static int mDrawEnd;

	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0x18")]
	protected static TouchScreenKeyboard mKeyboard;

	[Token(Token = "0x170000C7")]
	public string defaultText
	{
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x17A33AC", Offset = "0x17A33AC", VA = "0x17A33AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x17A33B4", Offset = "0x17A33B4", VA = "0x17A33B4")]
		set
		{
		}
	}

	[Token(Token = "0x170000C8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x62DBF8", Offset = "0x62DBF8")]
	public string text
	{
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x17A33BC", Offset = "0x17A33BC", VA = "0x17A33BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x17A34BC", Offset = "0x17A34BC", VA = "0x17A34BC")]
		set
		{
		}
	}

	[Token(Token = "0x170000C9")]
	public string value
	{
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x17A33C0", Offset = "0x17A33C0", VA = "0x17A33C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x17A34C0", Offset = "0x17A34C0", VA = "0x17A34C0")]
		set
		{
		}
	}

	[Token(Token = "0x170000CA")]
	protected bool needsTextCursor
	{
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x17A3DB4", Offset = "0x17A3DB4", VA = "0x17A3DB4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000CB")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x62DC30", Offset = "0x62DC30")]
	public bool selected
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x17A3E38", Offset = "0x17A3E38", VA = "0x17A3E38")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x17A3E3C", Offset = "0x17A3E3C", VA = "0x17A3E3C")]
		set
		{
		}
	}

	[Token(Token = "0x170000CC")]
	public bool isSelected
	{
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x17A3738", Offset = "0x17A3738", VA = "0x17A3738")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x17A3E44", Offset = "0x17A3E44", VA = "0x17A3E44")]
		set
		{
		}
	}

	[Token(Token = "0x170000CD")]
	protected int cursorPosition
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x17A3F0C", Offset = "0x17A3F0C", VA = "0x17A3F0C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<string> OnTextUpdated
	{
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x17A326C", Offset = "0x17A326C", VA = "0x17A326C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611C30", Offset = "0x611C30")]
		add
		{
		}
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x17A330C", Offset = "0x17A330C", VA = "0x17A330C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611C40", Offset = "0x611C40")]
		remove
		{
		}
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x17A3F2C", Offset = "0x17A3F2C", VA = "0x17A3F2C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x17A3638", Offset = "0x17A3638", VA = "0x17A3638")]
	protected void Init()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x17A37DC", Offset = "0x17A37DC", VA = "0x17A37DC")]
	protected void SaveToPlayerPrefs(string val)
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x17A3FCC", Offset = "0x17A3FCC", VA = "0x17A3FCC", Slot = "4")]
	protected virtual void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x17A3FD8", Offset = "0x17A3FD8", VA = "0x17A3FD8")]
	protected void OnSelectEvent()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x17A4354", Offset = "0x17A4354", VA = "0x17A4354")]
	protected void OnDeselectEvent()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x17A4710", Offset = "0x17A4710", VA = "0x17A4710")]
	private void Update()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x17A4D04", Offset = "0x17A4D04", VA = "0x17A4D04")]
	protected void Submit()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x17A384C", Offset = "0x17A384C", VA = "0x17A384C")]
	protected void UpdateLabel()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x17A4670", Offset = "0x17A4670", VA = "0x17A4670")]
	protected void RestoreLabelPivot()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x17A4A10", Offset = "0x17A4A10", VA = "0x17A4A10")]
	protected char Validate(string text, int pos, char ch)
	{
		return default(char);
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x17A4F38", Offset = "0x17A4F38", VA = "0x17A4F38")]
	public UIInput()
	{
	}
}
