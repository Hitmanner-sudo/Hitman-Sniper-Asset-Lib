using Il2CppDummyDll;

[Token(Token = "0x200031C")]
public class AttachmentsUnlockable : Unlockable
{
	[Token(Token = "0x4001160")]
	[FieldOffset(Offset = "0x58")]
	public int Version;

	[Token(Token = "0x170002CE")]
	public override bool Unlocked
	{
		[Token(Token = "0x6001316")]
		[Address(RVA = "0xC05AB8", Offset = "0xC05AB8", VA = "0xC05AB8", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001317")]
	[Address(RVA = "0xC05AC0", Offset = "0xC05AC0", VA = "0xC05AC0")]
	public AttachmentsUnlockable()
	{
	}
}
