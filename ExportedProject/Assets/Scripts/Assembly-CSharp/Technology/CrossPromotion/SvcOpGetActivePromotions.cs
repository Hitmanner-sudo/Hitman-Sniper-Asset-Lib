using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C18")]
	public class SvcOpGetActivePromotions : SvcOpGet
	{
		[Token(Token = "0x4003C3C")]
		private const string SVCOPNAME = "GetActivePromotions";

		[Token(Token = "0x4003C3D")]
		private const string QUERYSTRING_PARAM_DEVICEID_KEY = "s_uid";

		[Token(Token = "0x4003C3E")]
		private const string QUERYSTRING_PARAM_LANGUAGE_KEY = "s_language";

		[Token(Token = "0x170009BA")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004C72")]
			[Address(RVA = "0xD36FB0", Offset = "0xD36FB0", VA = "0xD36FB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C71")]
		[Address(RVA = "0xD36F34", Offset = "0xD36F34", VA = "0xD36F34")]
		public SvcOpGetActivePromotions([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004C73")]
		[Address(RVA = "0xD36FF4", Offset = "0xD36FF4", VA = "0xD36FF4")]
		public void Get(string deviceID = "", string language = "")
		{
		}
	}
}
