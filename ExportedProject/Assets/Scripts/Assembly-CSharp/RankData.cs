using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004CA")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x594DC0", Offset = "0x594DC0")]
public class RankData
{
	[Token(Token = "0x4001995")]
	[FieldOffset(Offset = "0x10")]
	public LevelData[] Levels;

	[Token(Token = "0x4001996")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _localizedName;

	[Token(Token = "0x17000483")]
	public string Name
	{
		[Token(Token = "0x6001D4F")]
		[Address(RVA = "0xB3F4AC", Offset = "0xB3F4AC", VA = "0xB3F4AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000484")]
	public LevelData Item
	{
		[Token(Token = "0x6001D50")]
		[Address(RVA = "0xB3F514", Offset = "0xB3F514", VA = "0xB3F514")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001D51")]
		[Address(RVA = "0xB3F550", Offset = "0xB3F550", VA = "0xB3F550")]
		private set
		{
		}
	}

	[Token(Token = "0x6001D52")]
	[Address(RVA = "0xB3F5C8", Offset = "0xB3F5C8", VA = "0xB3F5C8")]
	public RankData()
	{
	}
}
