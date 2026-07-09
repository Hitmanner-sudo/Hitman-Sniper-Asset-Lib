using Il2CppDummyDll;

[Token(Token = "0x200031F")]
public class IntelUnlockable : Unlockable
{
	[Token(Token = "0x4001163")]
	[FieldOffset(Offset = "0x58")]
	public int Score;

	[Token(Token = "0x4001164")]
	[FieldOffset(Offset = "0x5C")]
	public int Version;

	[Token(Token = "0x4001165")]
	[FieldOffset(Offset = "0x60")]
	public RogueData RogueData;

	[Token(Token = "0x170002CF")]
	public override bool Unlocked
	{
		[Token(Token = "0x600131A")]
		[Address(RVA = "0xB16CAC", Offset = "0xB16CAC", VA = "0xB16CAC", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600131B")]
	[Address(RVA = "0xB16D14", Offset = "0xB16D14", VA = "0xB16D14", Slot = "7")]
	public override void Unlock(bool showNewFeedback = true)
	{
	}

	[Token(Token = "0x600131C")]
	[Address(RVA = "0xB16F0C", Offset = "0xB16F0C", VA = "0xB16F0C")]
	public IntelUnlockable()
	{
	}
}
