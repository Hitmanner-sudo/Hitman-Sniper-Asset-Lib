using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using Technology.Shop;

[Token(Token = "0x20007FB")]
public class DDNABundle : ISaveable
{
	[Token(Token = "0x20007FC")]
	public class CreditSaveData : ISaveable
	{
		[Token(Token = "0x4002CBB")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB1DC", Offset = "0x5BB1DC")]
		public string ItemId;

		[Token(Token = "0x4002CBC")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB1EC", Offset = "0x5BB1EC")]
		public int Quantity;

		[Token(Token = "0x600343A")]
		[Address(RVA = "0x86591C", Offset = "0x86591C", VA = "0x86591C")]
		public CreditSaveData()
		{
		}

		[Token(Token = "0x600343B")]
		[Address(RVA = "0x865978", Offset = "0x865978", VA = "0x865978")]
		public CreditSaveData(string itemId, int quantity)
		{
		}

		[Token(Token = "0x600343C")]
		[Address(RVA = "0x8659B4", Offset = "0x8659B4", VA = "0x8659B4", Slot = "4")]
		private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x600343D")]
		[Address(RVA = "0x865A3C", Offset = "0x865A3C", VA = "0x865A3C", Slot = "5")]
		private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
		{
			return null;
		}
	}

	[Token(Token = "0x4002CB3")]
	private const string BUNDLE_ITEM_ID = "Bundle";

	[Token(Token = "0x4002CB4")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB17C", Offset = "0x5BB17C")]
	public long StartDateTimestamp;

	[Token(Token = "0x4002CB5")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB18C", Offset = "0x5BB18C")]
	public long EndDateTimestamp;

	[Token(Token = "0x4002CB6")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB19C", Offset = "0x5BB19C")]
	public readonly List<CreditSaveData> CreditSaveDatas;

	[Token(Token = "0x4002CB7")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB1AC", Offset = "0x5BB1AC")]
	public int PricePoint;

	[Token(Token = "0x4002CB8")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<Credit> _credits;

	[Token(Token = "0x4002CB9")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB1BC", Offset = "0x5BB1BC")]
	private DateTime _003CStartDate_003Ek__BackingField;

	[Token(Token = "0x4002CBA")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB1CC", Offset = "0x5BB1CC")]
	private DateTime _003CEndDate_003Ek__BackingField;

	[Token(Token = "0x170006B0")]
	public DateTime StartDate
	{
		[Token(Token = "0x6003430")]
		[Address(RVA = "0xBC0F80", Offset = "0xBC0F80", VA = "0xBC0F80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622FE0", Offset = "0x622FE0")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6003431")]
		[Address(RVA = "0xBC0F88", Offset = "0xBC0F88", VA = "0xBC0F88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622FF0", Offset = "0x622FF0")]
		private set
		{
		}
	}

	[Token(Token = "0x170006B1")]
	public DateTime EndDate
	{
		[Token(Token = "0x6003432")]
		[Address(RVA = "0xBC0F90", Offset = "0xBC0F90", VA = "0xBC0F90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623000", Offset = "0x623000")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6003433")]
		[Address(RVA = "0xBC0F98", Offset = "0xBC0F98", VA = "0xBC0F98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623010", Offset = "0x623010")]
		private set
		{
		}
	}

	[Token(Token = "0x170006B2")]
	public List<Credit> Credits
	{
		[Token(Token = "0x6003434")]
		[Address(RVA = "0xBC0FA0", Offset = "0xBC0FA0", VA = "0xBC0FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003435")]
	[Address(RVA = "0xBC0FA8", Offset = "0xBC0FA8", VA = "0xBC0FA8")]
	public DDNABundle()
	{
	}

	[Token(Token = "0x6003436")]
	[Address(RVA = "0xBC10B4", Offset = "0xBC10B4", VA = "0xBC10B4")]
	public DDNABundle(DateTime startDate, DateTime endDate, List<Credit> credits, int pricePoint)
	{
	}

	[Token(Token = "0x6003437")]
	[Address(RVA = "0xBC115C", Offset = "0xBC115C", VA = "0xBC115C")]
	public void Unlock()
	{
	}

	[Token(Token = "0x6003438")]
	[Address(RVA = "0xBC12C0", Offset = "0xBC12C0", VA = "0xBC12C0", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6003439")]
	[Address(RVA = "0xBC14E0", Offset = "0xBC14E0", VA = "0xBC14E0", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}
}
