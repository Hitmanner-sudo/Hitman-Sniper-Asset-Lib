using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000939")]
public class SvcOpUpdateItemTemplate : SvcOpPost
{
	[Token(Token = "0x4003214")]
	private const string SVCOPNAME = "UpdateItemTemplate";

	[Token(Token = "0x4003215")]
	private const string QUERYSTRING_PARAM_ID_KEY = "i32_templateid";

	[Token(Token = "0x17000767")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A7D")]
		[Address(RVA = "0xB48F84", Offset = "0xB48F84", VA = "0xB48F84", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A7C")]
	[Address(RVA = "0xB48F04", Offset = "0xB48F04", VA = "0xB48F04")]
	public SvcOpUpdateItemTemplate([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A7E")]
	[Address(RVA = "0xB48FC8", Offset = "0xB48FC8", VA = "0xB48FC8")]
	public void Post(string jsonParams, string templateId)
	{
	}
}
