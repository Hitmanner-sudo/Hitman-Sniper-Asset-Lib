using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000142")]
public class BulletFlyByMemento : AISound
{
	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 Start;

	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x84")]
	public Vector3 End;

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0xA85744", Offset = "0xA85744", VA = "0xA85744")]
	public BulletFlyByMemento(AIEmitter emitter, Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0xA86250", Offset = "0xA86250", VA = "0xA86250", Slot = "9")]
	public override bool CanBeDetectedBy(AISensor sensor)
	{
		return default(bool);
	}
}
