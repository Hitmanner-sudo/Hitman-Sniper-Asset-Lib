using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000931")]
public class SvcOpGetSegmentsFromPlayer : SvcOpGet
{
	[Token(Token = "0x4003201")]
	private const string SVCOPNAME = "GetSegmentsFromPlayer";

	[Token(Token = "0x1700075F")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A65")]
		[Address(RVA = "0xD39EB4", Offset = "0xD39EB4", VA = "0xD39EB4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A64")]
	[Address(RVA = "0xD39E38", Offset = "0xD39E38", VA = "0xD39E38")]
	public SvcOpGetSegmentsFromPlayer([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A66")]
	[Address(RVA = "0xD39EF8", Offset = "0xD39EF8", VA = "0xD39EF8")]
	public new void Get()
	{
	}
}
