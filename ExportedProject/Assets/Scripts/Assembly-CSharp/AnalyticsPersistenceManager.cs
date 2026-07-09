using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Token(Token = "0x20007E4")]
public class AnalyticsPersistenceManager : Singleton<AnalyticsPersistenceManager>, ISaveable
{
	[Token(Token = "0x20007E5")]
	public enum AnalyticSaveGameFlags
	{
		[Token(Token = "0x4002C0C")]
		IsFinishedTutorial = 0,
		[Token(Token = "0x4002C0D")]
		MadeFBInvite = 1,
		[Token(Token = "0x4002C0E")]
		FBLiked = 2,
		[Token(Token = "0x4002C0F")]
		OpenedCurrencyShop = 3,
		[Token(Token = "0x4002C10")]
		OpenedStarterPackShop = 4,
		[Token(Token = "0x4002C11")]
		MadeAPurchase = 5,
		[Token(Token = "0x4002C12")]
		PurchasedStarterPack = 6,
		[Token(Token = "0x4002C13")]
		PurchasedSmallGold = 7,
		[Token(Token = "0x4002C14")]
		PurchasedMediumGold = 8,
		[Token(Token = "0x4002C15")]
		PurchasedLargeGold = 9,
		[Token(Token = "0x4002C16")]
		PurchasedSmallTokens = 10,
		[Token(Token = "0x4002C17")]
		PurchasedMediumTokens = 11,
		[Token(Token = "0x4002C18")]
		PurchasedLargeTokens = 12,
		[Token(Token = "0x4002C19")]
		PurchasedGoldPack = 13,
		[Token(Token = "0x4002C1A")]
		PurchasedTokensPack = 14,
		[Token(Token = "0x4002C1B")]
		PurchasedAria = 15,
		[Token(Token = "0x4002C1C")]
		PurchasedAriaGold = 16,
		[Token(Token = "0x4002C1D")]
		PurchasedBrutus = 17,
		[Token(Token = "0x4002C1E")]
		PurchasedJaeger = 18,
		[Token(Token = "0x4002C1F")]
		PurchasedMerryMaker = 19,
		[Token(Token = "0x4002C20")]
		PurchasedExorcist = 20,
		[Token(Token = "0x4002C21")]
		PurchasedDragun = 21,
		[Token(Token = "0x4002C22")]
		PurchasedLargo = 22,
		[Token(Token = "0x4002C23")]
		PurchasedLongsword = 23,
		[Token(Token = "0x4002C24")]
		PurchasedPatriot = 24
	}

	[Token(Token = "0x4002BF9")]
	public const string SAVE_NAME = "SNIPER_ANALYTICS_SAVE";

	[Token(Token = "0x4002BFA")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB04C", Offset = "0x5BB04C")]
	public long SaveGameFlagValue;

	[Token(Token = "0x4002BFB")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB05C", Offset = "0x5BB05C")]
	public int SequenceNumber;

	[Token(Token = "0x4002BFC")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB06C", Offset = "0x5BB06C")]
	public int SessionSequenceNumber;

	[Token(Token = "0x4002BFD")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB07C", Offset = "0x5BB07C")]
	public int ViewSequenceNumber;

	[Token(Token = "0x4002BFE")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB08C", Offset = "0x5BB08C")]
	public int ModeSequenceNumber;

	[Token(Token = "0x4002BFF")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB09C", Offset = "0x5BB09C")]
	public int PopupSequenceNumber;

	[Token(Token = "0x4002C00")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB0AC", Offset = "0x5BB0AC")]
	public long LastPurchaseDateTime;

	[Token(Token = "0x4002C01")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB0BC", Offset = "0x5BB0BC")]
	public int TimesFailed;

	[Token(Token = "0x4002C02")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB0CC", Offset = "0x5BB0CC")]
	public int MaxProgressionAttempted;

	[Token(Token = "0x4002C03")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB0DC", Offset = "0x5BB0DC")]
	public string UserID;

	[Token(Token = "0x4002C04")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB0EC", Offset = "0x5BB0EC")]
	public int GunsPurchased;

	[Token(Token = "0x4002C05")]
	[FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB0FC", Offset = "0x5BB0FC")]
	public int SeasonalGunsPurchased;

	[Token(Token = "0x4002C06")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB10C", Offset = "0x5BB10C")]
	public int TotalPurchases;

	[Token(Token = "0x4002C07")]
	[FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB11C", Offset = "0x5BB11C")]
	public int PerksCompleted;

	[Token(Token = "0x4002C08")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB12C", Offset = "0x5BB12C")]
	public int PerksClaimed;

	[Token(Token = "0x4002C09")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB13C", Offset = "0x5BB13C")]
	private long _lastActivityDate;

	[Token(Token = "0x4002C0A")]
	[FieldOffset(Offset = "0x68")]
	private long _currentActivityStartDate;

	[Token(Token = "0x170006A7")]
	public DateTime LastActivityDate
	{
		[Token(Token = "0x60033A2")]
		[Address(RVA = "0xD61108", Offset = "0xD61108", VA = "0xD61108")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x60033A3")]
	[Address(RVA = "0xD61170", Offset = "0xD61170", VA = "0xD61170")]
	public void UpdateLastActivityDate()
	{
	}

	[Token(Token = "0x60033A4")]
	[Address(RVA = "0xD6117C", Offset = "0xD6117C", VA = "0xD6117C")]
	public void RecordActivityStartDate()
	{
	}

	[Token(Token = "0x60033A5")]
	[Address(RVA = "0xD61200", Offset = "0xD61200", VA = "0xD61200")]
	public void Save()
	{
	}

	[Token(Token = "0x60033A6")]
	[Address(RVA = "0xD61374", Offset = "0xD61374", VA = "0xD61374")]
	public void Load()
	{
	}

	[Token(Token = "0x60033A7")]
	[Address(RVA = "0xD61484", Offset = "0xD61484", VA = "0xD61484", Slot = "4")]
	public void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x60033A8")]
	[Address(RVA = "0xD612FC", Offset = "0xD612FC", VA = "0xD612FC", Slot = "5")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x60033A9")]
	[Address(RVA = "0xD6150C", Offset = "0xD6150C", VA = "0xD6150C")]
	public bool IsSaveGameFlagSet(AnalyticSaveGameFlags saveGameFlag)
	{
		return default(bool);
	}

	[Token(Token = "0x60033AA")]
	[Address(RVA = "0xD61520", Offset = "0xD61520", VA = "0xD61520")]
	public void SetSaveGameFlag(AnalyticSaveGameFlags saveGameFlag, bool done)
	{
	}

	[Token(Token = "0x60033AB")]
	[Address(RVA = "0xD61540", Offset = "0xD61540", VA = "0xD61540")]
	public AnalyticsPersistenceManager()
	{
	}
}
