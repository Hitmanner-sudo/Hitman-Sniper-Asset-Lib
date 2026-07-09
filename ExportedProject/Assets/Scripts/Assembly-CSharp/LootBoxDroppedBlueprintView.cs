using Il2CppDummyDll;

[Token(Token = "0x200068C")]
public class LootBoxDroppedBlueprintView : LootBoxDroppedUnlockableView
{
	[Token(Token = "0x17000581")]
	protected override string ItemName
	{
		[Token(Token = "0x6002AEB")]
		[Address(RVA = "0x9E1F8C", Offset = "0x9E1F8C", VA = "0x9E1F8C", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002AEC")]
	[Address(RVA = "0x9E214C", Offset = "0x9E214C", VA = "0x9E214C", Slot = "17")]
	public override bool CanHandle(LootBoxDroppedItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AED")]
	[Address(RVA = "0x9E221C", Offset = "0x9E221C", VA = "0x9E221C")]
	public LootBoxDroppedBlueprintView()
	{
	}
}
