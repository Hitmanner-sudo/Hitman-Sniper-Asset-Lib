using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20007A9")]
public class UITickerTapeText : GameMonoBehaviour
{
	[Token(Token = "0x20007AA")]
	public class TextBlock
	{
		[Token(Token = "0x4002B1F")]
		[FieldOffset(Offset = "0x10")]
		public string LocId;

		[Token(Token = "0x4002B20")]
		[FieldOffset(Offset = "0x18")]
		public UILabel Label;

		[Token(Token = "0x4002B21")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Separator;

		[Token(Token = "0x4002B22")]
		[FieldOffset(Offset = "0x28")]
		public object[] args;

		[Token(Token = "0x1700067A")]
		public int Width
		{
			[Token(Token = "0x600329F")]
			[Address(RVA = "0xA3E5C8", Offset = "0xA3E5C8", VA = "0xA3E5C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700067B")]
		public float Right
		{
			[Token(Token = "0x60032A0")]
			[Address(RVA = "0xA3E5F8", Offset = "0xA3E5F8", VA = "0xA3E5F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60032A1")]
		[Address(RVA = "0xA3E650", Offset = "0xA3E650", VA = "0xA3E650")]
		public void FormatString()
		{
		}

		[Token(Token = "0x60032A2")]
		[Address(RVA = "0xA3E6E4", Offset = "0xA3E6E4", VA = "0xA3E6E4")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60032A3")]
		[Address(RVA = "0xA3E818", Offset = "0xA3E818", VA = "0xA3E818")]
		public TextBlock()
		{
		}
	}

	[Token(Token = "0x4002B18")]
	[FieldOffset(Offset = "0x48")]
	public float ScrollSpeed;

	[Token(Token = "0x4002B19")]
	[FieldOffset(Offset = "0x4C")]
	public int MinNumCharsSeparating;

	[Token(Token = "0x4002B1A")]
	[FieldOffset(Offset = "0x50")]
	public UILabel LabelPrefab;

	[Token(Token = "0x4002B1B")]
	[FieldOffset(Offset = "0x58")]
	private UIWidget _parentWidget;

	[Token(Token = "0x4002B1C")]
	[FieldOffset(Offset = "0x60")]
	private bool _dirty;

	[Token(Token = "0x4002B1D")]
	[FieldOffset(Offset = "0x61")]
	private bool _forceFullPosRecalc;

	[Token(Token = "0x4002B1E")]
	[FieldOffset(Offset = "0x68")]
	private List<TextBlock> _text;

	[Token(Token = "0x6003294")]
	[Address(RVA = "0x116E2CC", Offset = "0x116E2CC", VA = "0x116E2CC")]
	public void ClearText()
	{
	}

	[Token(Token = "0x6003295")]
	[Address(RVA = "0x116E424", Offset = "0x116E424", VA = "0x116E424")]
	public TextBlock AddOrReplaceText(TextBlock oldText, string loc_id, params object[] args)
	{
		return null;
	}

	[Token(Token = "0x6003296")]
	[Address(RVA = "0x116E480", Offset = "0x116E480", VA = "0x116E480")]
	public TextBlock AddText(string loc_id, params object[] args)
	{
		return null;
	}

	[Token(Token = "0x6003297")]
	[Address(RVA = "0x116E950", Offset = "0x116E950", VA = "0x116E950")]
	public void RemoveText(TextBlock text)
	{
	}

	[Token(Token = "0x6003298")]
	[Address(RVA = "0x116E8A4", Offset = "0x116E8A4", VA = "0x116E8A4")]
	private void BuildSeparator(UILabel separator, int count)
	{
	}

	[Token(Token = "0x6003299")]
	[Address(RVA = "0x116E9D0", Offset = "0x116E9D0", VA = "0x116E9D0")]
	public void FinaliseStrings()
	{
	}

	[Token(Token = "0x600329A")]
	[Address(RVA = "0x116EE90", Offset = "0x116EE90", VA = "0x116EE90")]
	public void ReformatStrings()
	{
	}

	[Token(Token = "0x600329B")]
	[Address(RVA = "0x116EF34", Offset = "0x116EF34", VA = "0x116EF34", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600329C")]
	[Address(RVA = "0x116EFA8", Offset = "0x116EFA8", VA = "0x116EFA8")]
	public void Update()
	{
	}

	[Token(Token = "0x600329D")]
	[Address(RVA = "0x116F0C8", Offset = "0x116F0C8", VA = "0x116F0C8")]
	private void ScrollTextItem(UILabel label, UILabel prevLabel)
	{
	}

	[Token(Token = "0x600329E")]
	[Address(RVA = "0x116F2AC", Offset = "0x116F2AC", VA = "0x116F2AC")]
	public UITickerTapeText()
	{
	}
}
