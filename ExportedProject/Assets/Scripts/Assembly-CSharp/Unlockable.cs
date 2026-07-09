using System;
using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000369")]
public class Unlockable : ScriptableObject
{
	[Token(Token = "0x40012D9")]
	[FieldOffset(Offset = "0x18")]
	public bool HideFromStore;

	[Token(Token = "0x40012DA")]
	[FieldOffset(Offset = "0x1C")]
	public Rarity ItemRarity;

	[Token(Token = "0x40012DB")]
	[FieldOffset(Offset = "0x20")]
	public string NameLocalizationKey;

	[Token(Token = "0x40012DC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OfferReference _offer;

	[Token(Token = "0x40012DD")]
	[FieldOffset(Offset = "0x30")]
	public string ShopItemID;

	[Token(Token = "0x40012DE")]
	[FieldOffset(Offset = "0x38")]
	public string DescriptionLocalizationKey;

	[Token(Token = "0x40012DF")]
	[FieldOffset(Offset = "0x40")]
	public LazyTexture2D TextureRef;

	[Token(Token = "0x40012E0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LazyTexture2D _lootBoxItemTexture;

	[NonSerialized]
	[Token(Token = "0x40012E1")]
	[FieldOffset(Offset = "0x50")]
	public UnlockableSaveData UnlockableData;

	[Token(Token = "0x17000301")]
	public virtual string Name
	{
		[Token(Token = "0x600146E")]
		[Address(RVA = "0xB9BB98", Offset = "0xB9BB98", VA = "0xB9BB98", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000302")]
	public virtual string Description
	{
		[Token(Token = "0x600146F")]
		[Address(RVA = "0xB9BC30", Offset = "0xB9BC30", VA = "0xB9BC30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000303")]
	public Texture2D Texture
	{
		[Token(Token = "0x6001470")]
		[Address(RVA = "0xB9BCC8", Offset = "0xB9BCC8", VA = "0xB9BCC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000304")]
	public Texture2D LootBoxItemTexture
	{
		[Token(Token = "0x6001471")]
		[Address(RVA = "0xB9BE5C", Offset = "0xB9BE5C", VA = "0xB9BE5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000305")]
	public LazyTexture2D LootBoxItemLazyTexture
	{
		[Token(Token = "0x6001472")]
		[Address(RVA = "0xB9BFF0", Offset = "0xB9BFF0", VA = "0xB9BFF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000306")]
	public virtual bool Unlocked
	{
		[Token(Token = "0x6001473")]
		[Address(RVA = "0xB9BFF8", Offset = "0xB9BFF8", VA = "0xB9BFF8", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000307")]
	public string ProductID
	{
		[Token(Token = "0x6001474")]
		[Address(RVA = "0xB9C0A4", Offset = "0xB9C0A4", VA = "0xB9C0A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000308")]
	public int Price
	{
		[Token(Token = "0x6001475")]
		[Address(RVA = "0xB9C10C", Offset = "0xB9C10C", VA = "0xB9C10C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000309")]
	public int OriginalPrice
	{
		[Token(Token = "0x6001476")]
		[Address(RVA = "0xB9C120", Offset = "0xB9C120", VA = "0xB9C120")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700030A")]
	public Wallet.Currency Currency
	{
		[Token(Token = "0x6001477")]
		[Address(RVA = "0xB9C134", Offset = "0xB9C134", VA = "0xB9C134")]
		get
		{
			return default(Wallet.Currency);
		}
	}

	[Token(Token = "0x1700030B")]
	public Offer Offer
	{
		[Token(Token = "0x6001478")]
		[Address(RVA = "0xB9C148", Offset = "0xB9C148", VA = "0xB9C148")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700030C")]
	public OfferReference OfferReference
	{
		[Token(Token = "0x6001479")]
		[Address(RVA = "0xB9C164", Offset = "0xB9C164", VA = "0xB9C164")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600147A")]
	[Address(RVA = "0xB9C16C", Offset = "0xB9C16C", VA = "0xB9C16C", Slot = "7")]
	public virtual void Unlock(bool showNewFeedback = true)
	{
	}

	[Token(Token = "0x600147B")]
	[Address(RVA = "0xB9C238", Offset = "0xB9C238", VA = "0xB9C238", Slot = "8")]
	public virtual void Equip(PlayerController player)
	{
	}

	[Token(Token = "0x600147C")]
	[Address(RVA = "0xB9C23C", Offset = "0xB9C23C", VA = "0xB9C23C", Slot = "9")]
	public virtual void UnEquip()
	{
	}

	[Token(Token = "0x600147D")]
	[Address(RVA = "0xB9C240", Offset = "0xB9C240", VA = "0xB9C240")]
	public int GetUnlockLevel()
	{
		return default(int);
	}

	[Token(Token = "0x600147E")]
	[Address(RVA = "0xB9C340", Offset = "0xB9C340", VA = "0xB9C340")]
	public Unlockable()
	{
	}
}
