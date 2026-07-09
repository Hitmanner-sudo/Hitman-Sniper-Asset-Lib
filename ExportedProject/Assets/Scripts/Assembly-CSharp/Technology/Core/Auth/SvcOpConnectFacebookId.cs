using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DBC")]
	public class SvcOpConnectFacebookId : SvcOpGet
	{
		[Token(Token = "0x40041AA")]
		private const string SVCOPNAME = "ConnectFacebookId";

		[Token(Token = "0x40041AB")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x40041AC")]
		public const string QUERYSTRING_PARAM_FBID_KEY = "s_fbid";

		[Token(Token = "0x17000B38")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054B0")]
			[Address(RVA = "0xD35DB0", Offset = "0xD35DB0", VA = "0xD35DB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054AF")]
		[Address(RVA = "0xD35DA0", Offset = "0xD35DA0", VA = "0xD35DA0")]
		public SvcOpConnectFacebookId([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60054B1")]
		[Address(RVA = "0xD35DF4", Offset = "0xD35DF4", VA = "0xD35DF4")]
		public void Get(string uid, string fbid)
		{
		}
	}
}
