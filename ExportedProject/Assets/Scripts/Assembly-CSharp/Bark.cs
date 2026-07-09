using System;
using Il2CppDummyDll;
using Technology;

[Serializable]
[Token(Token = "0x200016C")]
public class Bark : SoundContainer
{
	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0x78")]
	public string[] Subtitle;

	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0x80")]
	public int Priority;

	[Token(Token = "0x40007A4")]
	[FieldOffset(Offset = "0x84")]
	public bool CanBeQueued;

	[Token(Token = "0x600097E")]
	[Address(RVA = "0xC0CBBC", Offset = "0xC0CBBC", VA = "0xC0CBBC")]
	public Bark()
	{
	}
}
