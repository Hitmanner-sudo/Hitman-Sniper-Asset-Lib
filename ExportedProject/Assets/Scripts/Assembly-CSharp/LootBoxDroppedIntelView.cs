using Il2CppDummyDll;

[Token(Token = "0x200068E")]
public class LootBoxDroppedIntelView : LootBoxDroppedUnlockableView
{
	[Token(Token = "0x17000583")]
	protected override string ItemName
	{
		[Token(Token = "0x6002AF2")]
		[Address(RVA = "0x9E2AF0", Offset = "0x9E2AF0", VA = "0x9E2AF0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002AF3")]
	[Address(RVA = "0x9E2CA4", Offset = "0x9E2CA4", VA = "0x9E2CA4", Slot = "17")]
	public override bool CanHandle(LootBoxDroppedItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AF4")]
	[Address(RVA = "0x9E2D74", Offset = "0x9E2D74", VA = "0x9E2D74")]
	public LootBoxDroppedIntelView()
	{
	}
}
