using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DBE")]
	public class SvcOpConnectAppleId : SvcOpGet
	{
		[Token(Token = "0x40041B0")]
		private const string SVCOPNAME = "ConnectAppleId";

		[Token(Token = "0x40041B1")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x40041B2")]
		public const string QUERYSTRING_PARAM_FBID_KEY = "s_gcid";

		[Token(Token = "0x17000B3A")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054B6")]
			[Address(RVA = "0xD35C1C", Offset = "0xD35C1C", VA = "0xD35C1C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054B5")]
		[Address(RVA = "0xD35C0C", Offset = "0xD35C0C", VA = "0xD35C0C")]
		public SvcOpConnectAppleId([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60054B7")]
		[Address(RVA = "0xD35C60", Offset = "0xD35C60", VA = "0xD35C60")]
		public void Get(string uid, string fbid)
		{
		}
	}
}
