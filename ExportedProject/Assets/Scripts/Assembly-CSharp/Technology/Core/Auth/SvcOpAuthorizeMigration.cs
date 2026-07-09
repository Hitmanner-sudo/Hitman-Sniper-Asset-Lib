using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DBB")]
	public class SvcOpAuthorizeMigration : SvcOpGet
	{
		[Token(Token = "0x40041A7")]
		private const string SVCOPNAME = "AuthorizeMigration";

		[Token(Token = "0x40041A8")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x40041A9")]
		public const string QUERYSTRING_PARAM_PASSPHRASE_KEY = "s_passphrase";

		[Token(Token = "0x17000B37")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054AD")]
			[Address(RVA = "0xD354A0", Offset = "0xD354A0", VA = "0xD354A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054AC")]
		[Address(RVA = "0xD35490", Offset = "0xD35490", VA = "0xD35490")]
		public SvcOpAuthorizeMigration([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60054AE")]
		[Address(RVA = "0xD354E4", Offset = "0xD354E4", VA = "0xD354E4")]
		public void Get(string uid, string passphrase, bool bypassUID = false)
		{
		}
	}
}
