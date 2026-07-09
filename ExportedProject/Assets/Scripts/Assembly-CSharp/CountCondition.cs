using Il2CppDummyDll;

[Token(Token = "0x200027C")]
public class CountCondition
{
	[Token(Token = "0x200027D")]
	public enum CountConditionType
	{
		[Token(Token = "0x4000DC5")]
		Ignored = 0,
		[Token(Token = "0x4000DC6")]
		One = 1,
		[Token(Token = "0x4000DC7")]
		Two = 2,
		[Token(Token = "0x4000DC8")]
		Three = 3,
		[Token(Token = "0x4000DC9")]
		Four = 4,
		[Token(Token = "0x4000DCA")]
		Five = 5,
		[Token(Token = "0x4000DCB")]
		Six = 6,
		[Token(Token = "0x4000DCC")]
		Seven = 7,
		[Token(Token = "0x4000DCD")]
		Eight = 8,
		[Token(Token = "0x4000DCE")]
		Nine = 9,
		[Token(Token = "0x4000DCF")]
		Ten = 10,
		[Token(Token = "0x4000DD0")]
		Eleven = 11,
		[Token(Token = "0x4000DD1")]
		Twelve = 12,
		[Token(Token = "0x4000DD2")]
		Thirteen = 13,
		[Token(Token = "0x4000DD3")]
		Fourteen = 14,
		[Token(Token = "0x4000DD4")]
		Fifteen = 15,
		[Token(Token = "0x4000DD5")]
		Sixteen = 16,
		[Token(Token = "0x4000DD6")]
		Seventeen = 17,
		[Token(Token = "0x4000DD7")]
		Eighteen = 18,
		[Token(Token = "0x4000DD8")]
		Nineteen = 19,
		[Token(Token = "0x4000DD9")]
		Twenty = 20,
		[Token(Token = "0x4000DDA")]
		Max = 21
	}

	[Token(Token = "0x6000EFF")]
	[Address(RVA = "0xD8078C", Offset = "0xD8078C", VA = "0xD8078C")]
	public static bool ValidateCondition(CountConditionType type, int actualValue, int maxValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F00")]
	[Address(RVA = "0xD807B8", Offset = "0xD807B8", VA = "0xD807B8")]
	public CountCondition()
	{
	}
}
