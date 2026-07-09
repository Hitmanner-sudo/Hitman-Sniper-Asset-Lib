using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000208")]
public class PerformanceBonus
{
	[Token(Token = "0x4000BBB")]
	[FieldOffset(Offset = "0x10")]
	public double RequiredValue;

	[Token(Token = "0x4000BBC")]
	[FieldOffset(Offset = "0x18")]
	public int Bonus;

	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x8FD220", Offset = "0x8FD220", VA = "0x8FD220")]
	public PerformanceBonus()
	{
	}
}
