using Il2CppDummyDll;

[Token(Token = "0x2000399")]
public class LuckyLootingUpgrade : Attachment
{
	[Token(Token = "0x400142E")]
	[FieldOffset(Offset = "0x18")]
	public float RarityBonusRatio;

	[Token(Token = "0x60015FA")]
	[Address(RVA = "0x9AB448", Offset = "0x9AB448", VA = "0x9AB448", Slot = "65")]
	public override float RarityBonusRatioModifier(float rarityBonusRatio)
	{
		return default(float);
	}

	[Token(Token = "0x60015FB")]
	[Address(RVA = "0x9AB454", Offset = "0x9AB454", VA = "0x9AB454", Slot = "67")]
	protected override bool ModifiersOverlap(Attachment attach)
	{
		return default(bool);
	}

	[Token(Token = "0x60015FC")]
	[Address(RVA = "0x9AB4F4", Offset = "0x9AB4F4", VA = "0x9AB4F4")]
	public LuckyLootingUpgrade()
	{
	}
}
