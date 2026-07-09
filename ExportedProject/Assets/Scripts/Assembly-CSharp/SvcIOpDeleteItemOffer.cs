using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000926")]
public class SvcIOpDeleteItemOffer : SvcOpGet
{
	[Token(Token = "0x40031EC")]
	private const string SVCOPNAME = "DeleteItemOffer";

	[Token(Token = "0x40031ED")]
	private const string QUERYSTRING_PARAM_ID_KEY = "i32_offerid";

	[Token(Token = "0x17000754")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A44")]
		[Address(RVA = "0xD304C0", Offset = "0xD304C0", VA = "0xD304C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A43")]
	[Address(RVA = "0xD3038C", Offset = "0xD3038C", VA = "0xD3038C")]
	public SvcIOpDeleteItemOffer([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A45")]
	[Address(RVA = "0xD30504", Offset = "0xD30504", VA = "0xD30504")]
	public void Get(string offerId)
	{
	}
}
