using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200068D")]
public class LootBoxDroppedCurrencyView : LootBoxDroppedItemView
{
	[Token(Token = "0x40024BB")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private LazyTexture2D[] _currenciesVisual;

	[Token(Token = "0x40024BC")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private UITexture _currencyTexture;

	[Token(Token = "0x40024BD")]
	[FieldOffset(Offset = "0xB0")]
	private LootBoxDroppedCurrency _item;

	[Token(Token = "0x17000582")]
	public override LootBoxDroppedItem Item
	{
		[Token(Token = "0x6002AEE")]
		[Address(RVA = "0x9E2730", Offset = "0x9E2730", VA = "0x9E2730", Slot = "15")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002AEF")]
		[Address(RVA = "0x9E2738", Offset = "0x9E2738", VA = "0x9E2738", Slot = "16")]
		protected set
		{
		}
	}

	[Token(Token = "0x6002AF0")]
	[Address(RVA = "0x9E2A64", Offset = "0x9E2A64", VA = "0x9E2A64", Slot = "17")]
	public override bool CanHandle(LootBoxDroppedItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AF1")]
	[Address(RVA = "0x9E2AE0", Offset = "0x9E2AE0", VA = "0x9E2AE0")]
	public LootBoxDroppedCurrencyView()
	{
	}
}
