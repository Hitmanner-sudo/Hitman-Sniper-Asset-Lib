using System;
using Il2CppDummyDll;

[Token(Token = "0x2000235")]
public class ContractEndedArgs : EventArgs
{
	[Token(Token = "0x4000C66")]
	[FieldOffset(Offset = "0x10")]
	public GameEventsManager.GameEndResult Result;

	[Token(Token = "0x1700020B")]
	public bool Success
	{
		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x8E6FF4", Offset = "0x8E6FF4", VA = "0x8E6FF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x8E7004", Offset = "0x8E7004", VA = "0x8E7004")]
	public ContractEndedArgs()
	{
	}
}
