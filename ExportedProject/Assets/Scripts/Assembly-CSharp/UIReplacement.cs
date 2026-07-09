using Il2CppDummyDll;

[Token(Token = "0x20008BD")]
public class UIReplacement : QualityProxy
{
	[Token(Token = "0x4003022")]
	[FieldOffset(Offset = "0x48")]
	public UIAtlas[] ReferenceAtlases;

	[Token(Token = "0x4003023")]
	[FieldOffset(Offset = "0x50")]
	public LazyUIAtlas[] SDAtlases;

	[Token(Token = "0x4003024")]
	[FieldOffset(Offset = "0x58")]
	public LazyUIAtlas[] HDAtlases;

	[Token(Token = "0x6003837")]
	[Address(RVA = "0x142CF78", Offset = "0x142CF78", VA = "0x142CF78", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6003838")]
	[Address(RVA = "0x142D01C", Offset = "0x142D01C", VA = "0x142D01C")]
	private void DoReplacement()
	{
	}

	[Token(Token = "0x6003839")]
	[Address(RVA = "0x142D05C", Offset = "0x142D05C", VA = "0x142D05C")]
	private static void RestoreAtlases(UIAtlas[] references, LazyUIAtlas[] replacements)
	{
	}

	[Token(Token = "0x600383A")]
	[Address(RVA = "0x142D1C4", Offset = "0x142D1C4", VA = "0x142D1C4")]
	public UIReplacement()
	{
	}
}
