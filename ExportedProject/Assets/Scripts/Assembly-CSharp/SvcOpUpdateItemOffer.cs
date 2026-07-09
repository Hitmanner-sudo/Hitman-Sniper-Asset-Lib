using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000928")]
public class SvcOpUpdateItemOffer : SvcOpPost
{
	[Token(Token = "0x40031EF")]
	private const string SVCOPNAME = "UpdateItemOffer";

	[Token(Token = "0x40031F0")]
	private const string QUERYSTRING_PARAM_ID_KEY = "i32_offerid";

	[Token(Token = "0x17000756")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A4A")]
		[Address(RVA = "0xB48DB0", Offset = "0xB48DB0", VA = "0xB48DB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A49")]
	[Address(RVA = "0xB48D30", Offset = "0xB48D30", VA = "0xB48D30")]
	public SvcOpUpdateItemOffer([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A4B")]
	[Address(RVA = "0xB48DF4", Offset = "0xB48DF4", VA = "0xB48DF4")]
	public void Post(string jsonParams, string itemId)
	{
	}
}
