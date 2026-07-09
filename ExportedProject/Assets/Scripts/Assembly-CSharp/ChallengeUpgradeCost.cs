using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20003F2")]
public class ChallengeUpgradeCost
{
	[Token(Token = "0x40015E4")]
	[FieldOffset(Offset = "0x10")]
	public int[] NormalCost;

	[Token(Token = "0x40015E5")]
	[FieldOffset(Offset = "0x18")]
	public int[] HardCost;

	[Token(Token = "0x40015E6")]
	[FieldOffset(Offset = "0x20")]
	public int[] ExpertCost;

	[Token(Token = "0x600183C")]
	[Address(RVA = "0xAF6510", Offset = "0xAF6510", VA = "0xAF6510")]
	public int GetCostForCurrentDifficulty(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600183D")]
	[Address(RVA = "0xAF665C", Offset = "0xAF665C", VA = "0xAF665C")]
	public int GetLengthForCurrentDifficulty()
	{
		return default(int);
	}

	[Token(Token = "0x600183E")]
	[Address(RVA = "0xAF6558", Offset = "0xAF6558", VA = "0xAF6558")]
	public int[] GetCostsForCurrentDifficulty()
	{
		return null;
	}

	[Token(Token = "0x600183F")]
	[Address(RVA = "0xAF667C", Offset = "0xAF667C", VA = "0xAF667C")]
	public int[] GetCostsForDifficulty(ContractDataModel.DifficultyType difficulty)
	{
		return null;
	}

	[Token(Token = "0x6001840")]
	[Address(RVA = "0xAF66B4", Offset = "0xAF66B4", VA = "0xAF66B4")]
	public ChallengeUpgradeCost()
	{
	}
}
