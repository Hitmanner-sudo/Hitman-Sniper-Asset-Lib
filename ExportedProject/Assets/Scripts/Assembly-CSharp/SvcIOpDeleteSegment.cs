using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x200092D")]
public class SvcIOpDeleteSegment : SvcOpGet
{
	[Token(Token = "0x40031F9")]
	private const string SVCOPNAME = "DeleteSegment";

	[Token(Token = "0x40031FA")]
	private const string QUERYSTRING_PARAM_NAME_KEY = "s_name";

	[Token(Token = "0x1700075B")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A59")]
		[Address(RVA = "0xD30D58", Offset = "0xD30D58", VA = "0xD30D58", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A58")]
	[Address(RVA = "0xD30CDC", Offset = "0xD30CDC", VA = "0xD30CDC")]
	public SvcIOpDeleteSegment([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A5A")]
	[Address(RVA = "0xD30D9C", Offset = "0xD30D9C", VA = "0xD30D9C")]
	public void Get(string segmentName)
	{
	}
}
