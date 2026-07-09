using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x200092F")]
public class SvcOpGetSegmentList : SvcOpGet
{
	[Token(Token = "0x40031FF")]
	private const string SVCOPNAME = "GetSegmentList";

	[Token(Token = "0x1700075D")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A5F")]
		[Address(RVA = "0xD39D2C", Offset = "0xD39D2C", VA = "0xD39D2C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A5E")]
	[Address(RVA = "0xD39CB0", Offset = "0xD39CB0", VA = "0xD39CB0")]
	public SvcOpGetSegmentList([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A60")]
	[Address(RVA = "0xD39D70", Offset = "0xD39D70", VA = "0xD39D70")]
	public new void Get()
	{
	}
}
