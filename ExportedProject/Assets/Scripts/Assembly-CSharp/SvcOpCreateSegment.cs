using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x200092B")]
public class SvcOpCreateSegment : SvcOpPost
{
	[Token(Token = "0x40031F4")]
	private const string SVCOPNAME = "CreateSegment";

	[Token(Token = "0x40031F5")]
	private const string QUERYSTRING_PARAM_NAME_KEY = "s_name";

	[Token(Token = "0x17000759")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A53")]
		[Address(RVA = "0xD36580", Offset = "0xD36580", VA = "0xD36580", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A52")]
	[Address(RVA = "0xD36504", Offset = "0xD36504", VA = "0xD36504")]
	public SvcOpCreateSegment([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A54")]
	[Address(RVA = "0xD365C4", Offset = "0xD365C4", VA = "0xD365C4")]
	public void Post(string jsonParams, string segmentName)
	{
	}
}
