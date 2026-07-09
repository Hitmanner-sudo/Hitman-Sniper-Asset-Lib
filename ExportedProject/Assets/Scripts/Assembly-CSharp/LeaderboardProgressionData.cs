using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Token(Token = "0x20004AA")]
public class LeaderboardProgressionData : ISaveable
{
	[Token(Token = "0x4001918")]
	[FieldOffset(Offset = "0x10")]
	private readonly HashSet<string> _openedLootBoxes;

	[Token(Token = "0x4001919")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "SaveableAttribute", RVA = "0x5B6E8C", Offset = "0x5B6E8C")]
	private List<string> _openedLootBoxData;

	[Token(Token = "0x6001C61")]
	[Address(RVA = "0x99D3A8", Offset = "0x99D3A8", VA = "0x99D3A8")]
	public bool HasLootBoxBeenOpened(LootBox box)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C62")]
	[Address(RVA = "0x99D420", Offset = "0x99D420", VA = "0x99D420")]
	public bool LootBoxOpened(LootBox box)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C63")]
	[Address(RVA = "0x9A5DF8", Offset = "0x9A5DF8", VA = "0x9A5DF8", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001C64")]
	[Address(RVA = "0x9A5EF4", Offset = "0x9A5EF4", VA = "0x9A5EF4", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001C65")]
	[Address(RVA = "0x99E3C8", Offset = "0x99E3C8", VA = "0x99E3C8")]
	public LeaderboardProgressionData()
	{
	}
}
