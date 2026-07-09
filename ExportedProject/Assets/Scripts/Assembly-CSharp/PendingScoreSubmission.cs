using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Serializable]
[Token(Token = "0x2000290")]
public class PendingScoreSubmission : ISaveable
{
	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3A04", Offset = "0x5B3A04")]
	public int Score;

	[Token(Token = "0x4000E6E")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3A14", Offset = "0x5B3A14")]
	public int LeaderboardId;

	[Token(Token = "0x4000E6F")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3A24", Offset = "0x5B3A24")]
	public string GameCenterLeaderboardID;

	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x8FCD28", Offset = "0x8FCD28", VA = "0x8FCD28")]
	public bool HasPendingScore()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x8FCD38", Offset = "0x8FCD38", VA = "0x8FCD38")]
	public void ClearPendingScore()
	{
	}

	[Token(Token = "0x6000F78")]
	[Address(RVA = "0x8FCD90", Offset = "0x8FCD90", VA = "0x8FCD90", Slot = "6")]
	public virtual void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6000F79")]
	[Address(RVA = "0x8FCE18", Offset = "0x8FCE18", VA = "0x8FCE18", Slot = "7")]
	public virtual JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6000F7A")]
	[Address(RVA = "0x8FCE90", Offset = "0x8FCE90", VA = "0x8FCE90")]
	public PendingScoreSubmission()
	{
	}
}
