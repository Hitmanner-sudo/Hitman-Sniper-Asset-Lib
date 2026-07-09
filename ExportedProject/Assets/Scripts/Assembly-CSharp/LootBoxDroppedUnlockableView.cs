using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000698")]
public class LootBoxDroppedUnlockableView : LootBoxDroppedItemView
{
	[Token(Token = "0x40024DD")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UITexture _texture;

	[Token(Token = "0x40024DE")]
	[FieldOffset(Offset = "0xA8")]
	private LootBoxDroppedUnlockable _item;

	[Token(Token = "0x17000597")]
	public override LootBoxDroppedItem Item
	{
		[Token(Token = "0x6002B30")]
		[Address(RVA = "0x9E3F24", Offset = "0x9E3F24", VA = "0x9E3F24", Slot = "15")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002B31")]
		[Address(RVA = "0x9E3F2C", Offset = "0x9E3F2C", VA = "0x9E3F2C", Slot = "16")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000598")]
	protected virtual string ItemName
	{
		[Token(Token = "0x6002B32")]
		[Address(RVA = "0x9E40A4", Offset = "0x9E40A4", VA = "0x9E40A4", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002B33")]
	[Address(RVA = "0x9E40D0", Offset = "0x9E40D0", VA = "0x9E40D0", Slot = "17")]
	public override bool CanHandle(LootBoxDroppedItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B34")]
	[Address(RVA = "0x9E2224", Offset = "0x9E2224", VA = "0x9E2224")]
	public LootBoxDroppedUnlockableView()
	{
	}
}
