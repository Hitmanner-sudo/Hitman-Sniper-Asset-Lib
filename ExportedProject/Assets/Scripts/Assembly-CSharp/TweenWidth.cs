using Il2CppDummyDll;

[Token(Token = "0x2000078")]
[Attribute(Name = "RequireComponent", RVA = "0x5919C0", Offset = "0x5919C0")]
[Attribute(Name = "AddComponentMenu", RVA = "0x5919C0", Offset = "0x5919C0")]
public class TweenWidth : UITweener
{
	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0x8C")]
	public int from;

	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x90")]
	public int to;

	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0x94")]
	public bool updateTable;

	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0x98")]
	private UIWidget mWidget;

	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0xA0")]
	private UITable mTable;

	[Token(Token = "0x1700009A")]
	public UIWidget cachedWidget
	{
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1574F48", Offset = "0x1574F48", VA = "0x1574F48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009B")]
	public int width
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1574FE8", Offset = "0x1574FE8", VA = "0x1574FE8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1575008", Offset = "0x1575008", VA = "0x1575008")]
		set
		{
		}
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x1575038", Offset = "0x1575038", VA = "0x1575038", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x15751C0", Offset = "0x15751C0", VA = "0x15751C0")]
	public static TweenWidth Begin(UIWidget widget, float duration, int width)
	{
		return null;
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x157527C", Offset = "0x157527C", VA = "0x157527C")]
	public TweenWidth()
	{
	}
}
