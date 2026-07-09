using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000363")]
public interface UpgradablePowerUp
{
	[Token(Token = "0x170002FF")]
	int GetCost
	{
		[Token(Token = "0x6001464")]
		get;
	}

	[Token(Token = "0x17000300")]
	int MaxLevel
	{
		[Token(Token = "0x6001465")]
		get;
	}

	[Token(Token = "0x6001463")]
	void SetLevel(int level);

	[Token(Token = "0x6001466")]
	List<List<string>> GetLevelStats();
}
