using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200040D")]
public class RogueSpawnData
{
	[Token(Token = "0x40016AD")]
	[FieldOffset(Offset = "0x10")]
	public float SpawnTime;

	[Token(Token = "0x40016AE")]
	[FieldOffset(Offset = "0x14")]
	public float DespawnTime;

	[Token(Token = "0x60018FB")]
	[Address(RVA = "0x9734F8", Offset = "0x9734F8", VA = "0x9734F8")]
	public RogueSpawnData()
	{
	}
}
