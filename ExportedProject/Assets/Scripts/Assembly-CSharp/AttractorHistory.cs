using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20000E2")]
public class AttractorHistory
{
	[Token(Token = "0x4000520")]
	[FieldOffset(Offset = "0x10")]
	public List<Attractor> Started;

	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x18")]
	public List<Attractor> Unreachable;

	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<Attractor, int> CompletionCount;

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0xC079E4", Offset = "0xC079E4", VA = "0xC079E4")]
	public AttractorHistory()
	{
	}
}
