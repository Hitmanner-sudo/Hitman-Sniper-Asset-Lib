using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200020E")]
public class GroupScoreDescription
{
	[Token(Token = "0x4000BC9")]
	[FieldOffset(Offset = "0x10")]
	public int MaxValidScore;

	[Token(Token = "0x4000BCA")]
	[FieldOffset(Offset = "0x18")]
	public string DescriptionLoc;

	[Token(Token = "0x6000C75")]
	[Address(RVA = "0xC8A078", Offset = "0xC8A078", VA = "0xC8A078")]
	public GroupScoreDescription()
	{
	}
}
