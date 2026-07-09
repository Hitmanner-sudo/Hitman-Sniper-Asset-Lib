using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Token(Token = "0x20004C7")]
public class PostedScore : ISaveable
{
	[Token(Token = "0x4001990")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B72A4", Offset = "0x5B72A4")]
	public int LeaderboardId;

	[Token(Token = "0x4001991")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B72B4", Offset = "0x5B72B4")]
	private long _time;

	[Token(Token = "0x17000482")]
	public DateTime Time
	{
		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0x93F930", Offset = "0x93F930", VA = "0x93F930")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6001D40")]
		[Address(RVA = "0x93F900", Offset = "0x93F900", VA = "0x93F900")]
		set
		{
		}
	}

	[Token(Token = "0x6001D3D")]
	[Address(RVA = "0x93F820", Offset = "0x93F820", VA = "0x93F820")]
	public PostedScore()
	{
	}

	[Token(Token = "0x6001D3E")]
	[Address(RVA = "0x93F8B4", Offset = "0x93F8B4", VA = "0x93F8B4")]
	public PostedScore(int leaderboardId, DateTime time)
	{
	}

	[Token(Token = "0x6001D41")]
	[Address(RVA = "0x93F998", Offset = "0x93F998", VA = "0x93F998", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001D42")]
	[Address(RVA = "0x93FA20", Offset = "0x93FA20", VA = "0x93FA20", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}
}
