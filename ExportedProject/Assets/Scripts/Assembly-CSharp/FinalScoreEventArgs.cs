using System;
using Il2CppDummyDll;

[Token(Token = "0x200028F")]
public class FinalScoreEventArgs : EventArgs
{
	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0x10")]
	public int Score;

	[Token(Token = "0x4000E6C")]
	[FieldOffset(Offset = "0x18")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x954710", Offset = "0x954710", VA = "0x954710")]
	public FinalScoreEventArgs()
	{
	}
}
