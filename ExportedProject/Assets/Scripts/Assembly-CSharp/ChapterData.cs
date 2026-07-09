using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003F3")]
public class ChapterData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20003F4")]
	public class ChapterInfo
	{
		[Token(Token = "0x40015E8")]
		[FieldOffset(Offset = "0x10")]
		public int NumberOfMissions;

		[Token(Token = "0x40015E9")]
		[FieldOffset(Offset = "0x18")]
		public string LocName;

		[Token(Token = "0x6001845")]
		[Address(RVA = "0x8618B0", Offset = "0x8618B0", VA = "0x8618B0")]
		public ChapterInfo()
		{
		}
	}

	[Token(Token = "0x40015E7")]
	[FieldOffset(Offset = "0x18")]
	public ChapterInfo[] ChaptersInfo;

	[Token(Token = "0x6001841")]
	[Address(RVA = "0xAFA088", Offset = "0xAFA088", VA = "0xAFA088")]
	public int GetChapterIndex(int missionIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6001842")]
	[Address(RVA = "0xAFA118", Offset = "0xAFA118", VA = "0xAFA118")]
	public int GetMissionIndex(int missionIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6001843")]
	[Address(RVA = "0xAFA19C", Offset = "0xAFA19C", VA = "0xAFA19C")]
	public ChapterInfo GetChapterInfo(int missionIndex)
	{
		return null;
	}

	[Token(Token = "0x6001844")]
	[Address(RVA = "0xAFA1E4", Offset = "0xAFA1E4", VA = "0xAFA1E4")]
	public ChapterData()
	{
	}
}
