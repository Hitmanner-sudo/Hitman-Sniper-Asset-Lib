using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DC4")]
	public class SvcOpGetMigrationFacebookUser : SvcOpGet
	{
		[Token(Token = "0x40041BD")]
		private const string SVCOPNAME = "GetMigrationFacebookUser";

		[Token(Token = "0x40041BE")]
		public const string QUERYSTRING_PARAM_TOKEN = "s_token";

		[Token(Token = "0x17000B40")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054C8")]
			[Address(RVA = "0xD38FB4", Offset = "0xD38FB4", VA = "0xD38FB4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054C7")]
		[Address(RVA = "0xD38FA4", Offset = "0xD38FA4", VA = "0xD38FA4")]
		public SvcOpGetMigrationFacebookUser([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60054C9")]
		[Address(RVA = "0xD38FF8", Offset = "0xD38FF8", VA = "0xD38FF8")]
		public void Get(string token)
		{
		}
	}
}
