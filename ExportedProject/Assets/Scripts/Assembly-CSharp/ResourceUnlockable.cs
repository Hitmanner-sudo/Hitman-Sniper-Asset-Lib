using Il2CppDummyDll;

[Token(Token = "0x2000366")]
public class ResourceUnlockable : Unlockable
{
	[Token(Token = "0x40012D1")]
	[FieldOffset(Offset = "0x58")]
	public Wallet.CurrencyAmount CurrencyAmount;

	[Token(Token = "0x600146B")]
	[Address(RVA = "0x966860", Offset = "0x966860", VA = "0x966860", Slot = "7")]
	public override void Unlock(bool showNewFeedback = true)
	{
	}

	[Token(Token = "0x600146C")]
	[Address(RVA = "0x9668F0", Offset = "0x9668F0", VA = "0x9668F0")]
	public ResourceUnlockable()
	{
	}
}
