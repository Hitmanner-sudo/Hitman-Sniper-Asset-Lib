using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DC0")]
	public class SvcOpDisconnectFacebookId : SvcOpGet
	{
		[Token(Token = "0x40041B4")]
		private const string SVCOPNAME = "DisconnectFacebookId";

		[Token(Token = "0x40041B5")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x17000B3C")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054BC")]
			[Address(RVA = "0xD36AA4", Offset = "0xD36AA4", VA = "0xD36AA4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054BB")]
		[Address(RVA = "0xD36A94", Offset = "0xD36A94", VA = "0xD36A94")]
		public SvcOpDisconnectFacebookId([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60054BD")]
		[Address(RVA = "0xD36AE8", Offset = "0xD36AE8", VA = "0xD36AE8")]
		public void Get(string uid)
		{
		}
	}
}
