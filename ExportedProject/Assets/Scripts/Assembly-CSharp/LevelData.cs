using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004AB")]
public class LevelData
{
	[Token(Token = "0x400191A")]
	[FieldOffset(Offset = "0x10")]
	public int RankStarGoal;

	[Token(Token = "0x400191B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[LootBoxReference]
	private LootBox _lootBox;

	[Token(Token = "0x1700046A")]
	public LootBox LootBox
	{
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x9C8610", Offset = "0x9C8610", VA = "0x9C8610")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001C67")]
	[Address(RVA = "0x9C8618", Offset = "0x9C8618", VA = "0x9C8618")]
	public void Unlock()
	{
	}

	[Token(Token = "0x6001C68")]
	[Address(RVA = "0x9C87FC", Offset = "0x9C87FC", VA = "0x9C87FC")]
	public LevelData()
	{
	}
}
