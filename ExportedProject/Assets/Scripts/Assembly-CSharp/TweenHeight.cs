using Il2CppDummyDll;

[Token(Token = "0x2000071")]
[Attribute(Name = "RequireComponent", RVA = "0x5917A0", Offset = "0x5917A0")]
[Attribute(Name = "AddComponentMenu", RVA = "0x5917A0", Offset = "0x5917A0")]
public class TweenHeight : UITweener
{
	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x8C")]
	public int from;

	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x90")]
	public int to;

	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x94")]
	public bool updateTable;

	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x98")]
	private UIWidget mWidget;

	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0xA0")]
	private UITable mTable;

	[Token(Token = "0x1700008E")]
	public UIWidget cachedWidget
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0xCAED04", Offset = "0xCAED04", VA = "0xCAED04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008F")]
	public int height
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0xCAEDA4", Offset = "0xCAEDA4", VA = "0xCAEDA4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000380")]
		[Address(RVA = "0xCAEDC4", Offset = "0xCAEDC4", VA = "0xCAEDC4")]
		set
		{
		}
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xCAEDF4", Offset = "0xCAEDF4", VA = "0xCAEDF4", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xCAEF7C", Offset = "0xCAEF7C", VA = "0xCAEF7C")]
	public static TweenHeight Begin(UIWidget widget, float duration, int height)
	{
		return null;
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xCAF038", Offset = "0xCAF038", VA = "0xCAF038")]
	public TweenHeight()
	{
	}
}
