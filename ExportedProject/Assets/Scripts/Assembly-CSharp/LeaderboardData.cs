using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004A9")]
public class LeaderboardData : ScriptableObject, ISaveable
{
	[Token(Token = "0x4001911")]
	[FieldOffset(Offset = "0x18")]
	public int TopRivalCount;

	[Token(Token = "0x4001912")]
	[FieldOffset(Offset = "0x1C")]
	public int BottomRivalCount;

	[Token(Token = "0x4001913")]
	[FieldOffset(Offset = "0x20")]
	public int MinimumListCount;

	[Token(Token = "0x4001914")]
	[FieldOffset(Offset = "0x24")]
	public int RivalScoreStep;

	[Token(Token = "0x4001915")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6E34", Offset = "0x5B6E34")]
	[SerializeField]
	public HackerPreventionData HackerPreventionData;

	[Token(Token = "0x4001916")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6E6C", Offset = "0x5B6E6C")]
	private PostedScoreData _postedScoreData;

	[Token(Token = "0x4001917")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6E7C", Offset = "0x5B6E7C")]
	private LeaderboardProgressionData _progressionData;

	[Token(Token = "0x17000469")]
	public LeaderboardProgressionData ProgressionData
	{
		[Token(Token = "0x6001C5C")]
		[Address(RVA = "0x99E14C", Offset = "0x99E14C", VA = "0x99E14C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x99DF84", Offset = "0x99DF84", VA = "0x99DF84")]
	public DateTime GetLastScoreReportTime(int leaderboardId)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6001C5A")]
	[Address(RVA = "0x99DFA0", Offset = "0x99DFA0", VA = "0x99DFA0")]
	public void SetLastScoreReportTime(int leaderboardId, DateTime time)
	{
	}

	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x99DFBC", Offset = "0x99DFBC", VA = "0x99DFBC")]
	public bool IsPlayerConsideredActive(int leaderboardId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x99E154", Offset = "0x99E154", VA = "0x99E154")]
	public bool IsHacker(int score, TimeSpan gameTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C5E")]
	[Address(RVA = "0x99E204", Offset = "0x99E204", VA = "0x99E204", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001C5F")]
	[Address(RVA = "0x99E28C", Offset = "0x99E28C", VA = "0x99E28C", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001C60")]
	[Address(RVA = "0x99E304", Offset = "0x99E304", VA = "0x99E304")]
	public LeaderboardData()
	{
	}
}
