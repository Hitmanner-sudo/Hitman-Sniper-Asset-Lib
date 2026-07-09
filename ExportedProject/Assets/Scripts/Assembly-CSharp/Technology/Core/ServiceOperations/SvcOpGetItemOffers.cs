using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CDF")]
	public class SvcOpGetItemOffers : SvcOpGet
	{
		[Token(Token = "0x4003DFA")]
		private const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x4003DFB")]
		private const string QUERYSTRING_PARAM_LANG_KEY = "s_language";

		[Token(Token = "0x4003DFC")]
		private const string SVCOPNAME = "GetItemOffers";

		[Token(Token = "0x17000A8B")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004FB7")]
			[Address(RVA = "0xD38074", Offset = "0xD38074", VA = "0xD38074", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004FB6")]
		[Address(RVA = "0xD38064", Offset = "0xD38064", VA = "0xD38064")]
		public SvcOpGetItemOffers([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x6004FB8")]
		[Address(RVA = "0xD380B8", Offset = "0xD380B8", VA = "0xD380B8")]
		public void Get(string userid, string languageCode)
		{
		}
	}
}
