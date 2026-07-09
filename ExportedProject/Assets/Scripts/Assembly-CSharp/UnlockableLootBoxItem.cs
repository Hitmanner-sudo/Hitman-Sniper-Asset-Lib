using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

[Token(Token = "0x20003D6")]
public class UnlockableLootBoxItem : LootBoxItem
{
	[Token(Token = "0x4001578")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int _count;

	[Token(Token = "0x4001579")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LazyUnlockable[] _unlockables;

	[Token(Token = "0x170003D0")]
	public LazyUnlockable[] Unlockables
	{
		[Token(Token = "0x60017C3")]
		[Address(RVA = "0xB9C3D8", Offset = "0xB9C3D8", VA = "0xB9C3D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60017C4")]
	[Address(RVA = "0xB9C3E0", Offset = "0xB9C3E0", VA = "0xB9C3E0", Slot = "4")]
	public override bool IsValid(bool fromSkip = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60017C5")]
	[Address(RVA = "0xB9C4A0", Offset = "0xB9C4A0", VA = "0xB9C4A0", Slot = "5")]
	public override LootBoxDroppedItem[] ChooseDrop(float roll)
	{
		return null;
	}

	[Token(Token = "0x60017C6")]
	[Address(RVA = "0xB9C5EC", Offset = "0xB9C5EC", VA = "0xB9C5EC")]
	private static bool IsUnlockableValid(LazyUnlockable lazyUnlockable)
	{
		return default(bool);
	}

	[Token(Token = "0x60017C7")]
	[Address(RVA = "0xB9C860", Offset = "0xB9C860", VA = "0xB9C860", Slot = "7")]
	public override void Restore(JSONNode data)
	{
	}

	[Token(Token = "0x60017C8")]
	[Address(RVA = "0xB9C8A0", Offset = "0xB9C8A0", VA = "0xB9C8A0")]
	public UnlockableLootBoxItem()
	{
	}
}
