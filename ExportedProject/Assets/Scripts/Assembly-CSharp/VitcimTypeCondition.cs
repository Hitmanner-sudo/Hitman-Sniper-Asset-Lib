using Il2CppDummyDll;

[Token(Token = "0x200027E")]
public class VitcimTypeCondition
{
	[Token(Token = "0x200027F")]
	public enum VitcimType
	{
		[Token(Token = "0x4000DDC")]
		Enemy = 0,
		[Token(Token = "0x4000DDD")]
		Ally = 1,
		[Token(Token = "0x4000DDE")]
		Anyone = 2
	}

	[Token(Token = "0x6000F01")]
	[Address(RVA = "0x9792A8", Offset = "0x9792A8", VA = "0x9792A8")]
	public static bool ValidateCondition(VitcimType type, Faction killer, Faction victim)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F02")]
	[Address(RVA = "0x9792EC", Offset = "0x9792EC", VA = "0x9792EC")]
	public VitcimTypeCondition()
	{
	}
}
