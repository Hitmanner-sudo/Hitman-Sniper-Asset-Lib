using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x200092C")]
public class SvcIOpDeleteItemOfferSegment : SvcOpGet
{
	[Token(Token = "0x40031F6")]
	private const string SVCOPNAME = "DeleteItemOfferSegment";

	[Token(Token = "0x40031F7")]
	private const string QUERYSTRING_PARAM_OFFER_ID_KEY = "i32_offerid";

	[Token(Token = "0x40031F8")]
	private const string QUERYSTRING_PARAM_SEGMENT_KEY = "s_segment";

	[Token(Token = "0x1700075A")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A56")]
		[Address(RVA = "0xD309A4", Offset = "0xD309A4", VA = "0xD309A4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A55")]
	[Address(RVA = "0xD30928", Offset = "0xD30928", VA = "0xD30928")]
	public SvcIOpDeleteItemOfferSegment([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A57")]
	[Address(RVA = "0xD309E8", Offset = "0xD309E8", VA = "0xD309E8")]
	public void Get(string offerId, string segmentName)
	{
	}
}
