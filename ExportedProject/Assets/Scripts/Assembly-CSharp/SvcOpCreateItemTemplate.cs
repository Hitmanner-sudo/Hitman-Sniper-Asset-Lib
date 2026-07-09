using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000935")]
public class SvcOpCreateItemTemplate : SvcOpPost
{
	[Token(Token = "0x4003209")]
	private const string SVCOPNAME = "CreateItemTemplate";

	[Token(Token = "0x400320A")]
	private const string QUERYSTRING_PARAM_TYPE_KEY = "s_type";

	[Token(Token = "0x400320B")]
	private const string QUERYSTRING_PARAM_CLASS_KEY = "s_class";

	[Token(Token = "0x400320C")]
	private const string QUERYSTRING_PARAM_PREMIUM_KEY = "b_premium";

	[Token(Token = "0x17000763")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A71")]
		[Address(RVA = "0xD3631C", Offset = "0xD3631C", VA = "0xD3631C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A70")]
	[Address(RVA = "0xD362A0", Offset = "0xD362A0", VA = "0xD362A0")]
	public SvcOpCreateItemTemplate([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A72")]
	[Address(RVA = "0xD36360", Offset = "0xD36360", VA = "0xD36360")]
	public void Post(string jsonParams, string itemType, string itemClass, string premium)
	{
	}
}
