using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C17")]
	public class SvcOpGetActiveMessagesOfTheDay : SvcOpGet
	{
		[Token(Token = "0x4003C39")]
		private const string SVCOPNAME = "GetActiveMessagesOfTheDay";

		[Token(Token = "0x4003C3A")]
		private const string QUERYSTRING_PARAM_DEVICEID_KEY = "s_uid";

		[Token(Token = "0x4003C3B")]
		private const string QUERYSTRING_PARAM_LANGUAGE_KEY = "s_language";

		[Token(Token = "0x170009B9")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004C6F")]
			[Address(RVA = "0xD36DB0", Offset = "0xD36DB0", VA = "0xD36DB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C6E")]
		[Address(RVA = "0xD36D34", Offset = "0xD36D34", VA = "0xD36D34")]
		public SvcOpGetActiveMessagesOfTheDay([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004C70")]
		[Address(RVA = "0xD36DF4", Offset = "0xD36DF4", VA = "0xD36DF4")]
		public void Get(string deviceID = "", string language = "")
		{
		}
	}
}
