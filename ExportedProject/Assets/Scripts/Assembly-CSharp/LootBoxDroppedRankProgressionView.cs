using Il2CppDummyDll;

[Token(Token = "0x2000697")]
public class LootBoxDroppedRankProgressionView : LootBoxDroppedItemView
{
	[Token(Token = "0x40024DC")]
	[FieldOffset(Offset = "0xA0")]
	private LootBoxDroppedRankProgression _item;

	[Token(Token = "0x17000596")]
	public override LootBoxDroppedItem Item
	{
		[Token(Token = "0x6002B2C")]
		[Address(RVA = "0x9E36F0", Offset = "0x9E36F0", VA = "0x9E36F0", Slot = "15")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002B2D")]
		[Address(RVA = "0x9E36F8", Offset = "0x9E36F8", VA = "0x9E36F8", Slot = "16")]
		protected set
		{
		}
	}

	[Token(Token = "0x6002B2E")]
	[Address(RVA = "0x9E386C", Offset = "0x9E386C", VA = "0x9E386C", Slot = "17")]
	public override bool CanHandle(LootBoxDroppedItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B2F")]
	[Address(RVA = "0x9E38E8", Offset = "0x9E38E8", VA = "0x9E38E8")]
	public LootBoxDroppedRankProgressionView()
	{
	}
}
