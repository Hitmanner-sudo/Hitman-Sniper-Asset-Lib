using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000933")]
public class SvcOpSetItemOfferSegment : SvcOpPost
{
	[Token(Token = "0x4003204")]
	private const string SVCOPNAME = "SetItemOfferSegment";

	[Token(Token = "0x4003205")]
	private const string QUERYSTRING_PARAM_OFFER_ID_KEY = "i32_offerid";

	[Token(Token = "0x4003206")]
	private const string QUERYSTRING_PARAM_SEGMENT_KEY = "s_segment";

	[Token(Token = "0x17000761")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A6B")]
		[Address(RVA = "0xB47BC8", Offset = "0xB47BC8", VA = "0xB47BC8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A6A")]
	[Address(RVA = "0xB47B48", Offset = "0xB47B48", VA = "0xB47B48")]
	public SvcOpSetItemOfferSegment([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A6C")]
	[Address(RVA = "0xB47C0C", Offset = "0xB47C0C", VA = "0xB47C0C")]
	public void Post(string jsonParams, string offerId, string segmentName)
	{
	}
}
