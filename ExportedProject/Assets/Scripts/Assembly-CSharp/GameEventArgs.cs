using System;
using Il2CppDummyDll;

[Token(Token = "0x2000234")]
public class GameEventArgs : EventArgs
{
	[Token(Token = "0x4000C65")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3488", Offset = "0x5B3488")]
	private GameEventsManager.GameEventType _003CEventType_003Ek__BackingField;

	[Token(Token = "0x1700020A")]
	public GameEventsManager.GameEventType EventType
	{
		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0xD957EC", Offset = "0xD957EC", VA = "0xD957EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614764", Offset = "0x614764")]
		get
		{
			return default(GameEventsManager.GameEventType);
		}
		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0xD957F4", Offset = "0xD957F4", VA = "0xD957F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614774", Offset = "0x614774")]
		set
		{
		}
	}

	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0xD957FC", Offset = "0xD957FC", VA = "0xD957FC")]
	public GameEventArgs()
	{
	}
}
