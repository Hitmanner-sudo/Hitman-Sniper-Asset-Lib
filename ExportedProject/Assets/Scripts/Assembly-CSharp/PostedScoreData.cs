using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Token(Token = "0x20004C5")]
public class PostedScoreData : ISaveable
{
	[Token(Token = "0x20004C6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594DA0", Offset = "0x594DA0")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x400198F")]
		[FieldOffset(Offset = "0x10")]
		public int leaderboardId;

		[Token(Token = "0x6001D3B")]
		[Address(RVA = "0x8B151C", Offset = "0x8B151C", VA = "0x8B151C")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6001D3C")]
		[Address(RVA = "0x8B1524", Offset = "0x8B1524", VA = "0x8B1524")]
		internal bool _003CFind_003Eb__0(PostedScore s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400198E")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7294", Offset = "0x5B7294")]
	private List<PostedScore> _scores;

	[Token(Token = "0x6001D35")]
	[Address(RVA = "0x93FA98", Offset = "0x93FA98", VA = "0x93FA98")]
	public DateTime GetTime(int leaderboardId)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6001D36")]
	[Address(RVA = "0x93FC1C", Offset = "0x93FC1C", VA = "0x93FC1C")]
	public void SetTime(int leaderboardId, DateTime time)
	{
	}

	[Token(Token = "0x6001D37")]
	[Address(RVA = "0x93FB2C", Offset = "0x93FB2C", VA = "0x93FB2C")]
	private PostedScore Find(int leaderboardId)
	{
		return null;
	}

	[Token(Token = "0x6001D38")]
	[Address(RVA = "0x93FD00", Offset = "0x93FD00", VA = "0x93FD00", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001D39")]
	[Address(RVA = "0x93FD88", Offset = "0x93FD88", VA = "0x93FD88", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001D3A")]
	[Address(RVA = "0x93FE00", Offset = "0x93FE00", VA = "0x93FE00")]
	public PostedScoreData()
	{
	}
}
