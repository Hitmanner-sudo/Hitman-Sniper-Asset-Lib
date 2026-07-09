using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000936")]
public class SvcIOpDeleteItemTemplate : SvcOpGet
{
	[Token(Token = "0x400320D")]
	private const string SVCOPNAME = "DeleteItemTemplate";

	[Token(Token = "0x400320E")]
	private const string QUERYSTRING_PARAM_ID_KEY = "i32_templateid";

	[Token(Token = "0x17000764")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A74")]
		[Address(RVA = "0xD30BA4", Offset = "0xD30BA4", VA = "0xD30BA4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A73")]
	[Address(RVA = "0xD30B28", Offset = "0xD30B28", VA = "0xD30B28")]
	public SvcIOpDeleteItemTemplate([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A75")]
	[Address(RVA = "0xD30BE8", Offset = "0xD30BE8", VA = "0xD30BE8")]
	public void Get(string templateId)
	{
	}
}
