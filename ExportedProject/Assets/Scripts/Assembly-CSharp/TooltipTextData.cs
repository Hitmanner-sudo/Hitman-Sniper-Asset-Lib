using Il2CppDummyDll;

[Token(Token = "0x2000794")]
public class TooltipTextData
{
	[Token(Token = "0x4002AB6")]
	private const int DEFAULT_SPACE_BETWEEN_TEXT_SECTIONS = 8;

	[Token(Token = "0x4002AB7")]
	[FieldOffset(Offset = "0x10")]
	public string Text;

	[Token(Token = "0x4002AB8")]
	[FieldOffset(Offset = "0x18")]
	public bool ForceOneLine;

	[Token(Token = "0x4002AB9")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget.Pivot Pivot;

	[Token(Token = "0x4002ABA")]
	[FieldOffset(Offset = "0x20")]
	public int SpaceBeforePrevious;

	[Token(Token = "0x600323C")]
	[Address(RVA = "0xAD10D4", Offset = "0xAD10D4", VA = "0xAD10D4")]
	public TooltipTextData(string text, bool forceOneLine = false, UIWidget.Pivot pivot = UIWidget.Pivot.BottomLeft, int spaceBeforePrevious = 8)
	{
	}
}
