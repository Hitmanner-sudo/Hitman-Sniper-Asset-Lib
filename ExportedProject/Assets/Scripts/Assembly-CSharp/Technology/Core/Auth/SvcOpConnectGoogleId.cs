using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DBD")]
	public class SvcOpConnectGoogleId : SvcOpGet
	{
		[Token(Token = "0x40041AD")]
		private const string SVCOPNAME = "ConnectGoogleId";

		[Token(Token = "0x40041AE")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x40041AF")]
		public const string QUERYSTRING_PARAM_FBID_KEY = "s_gpid";

		[Token(Token = "0x17000B39")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054B3")]
			[Address(RVA = "0xD35F44", Offset = "0xD35F44", VA = "0xD35F44", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054B2")]
		[Address(RVA = "0xD35F34", Offset = "0xD35F34", VA = "0xD35F34")]
		public SvcOpConnectGoogleId([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60054B4")]
		[Address(RVA = "0xD35F88", Offset = "0xD35F88", VA = "0xD35F88")]
		public void Get(string uid, string fbid)
		{
		}
	}
}
