using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DC3")]
	public class SvcOpGetMigrationData : SvcOpGet
	{
		[Token(Token = "0x40041BA")]
		private const string SVCOPNAME = "GetMigrationData";

		[Token(Token = "0x40041BB")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x40041BC")]
		public const string QUERYSTRING_PARAM_PASSPHRASE_KEY = "s_passphrase";

		[Token(Token = "0x17000B3F")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054C5")]
			[Address(RVA = "0xD38E20", Offset = "0xD38E20", VA = "0xD38E20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054C4")]
		[Address(RVA = "0xD38E10", Offset = "0xD38E10", VA = "0xD38E10")]
		public SvcOpGetMigrationData([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60054C6")]
		[Address(RVA = "0xD38E64", Offset = "0xD38E64", VA = "0xD38E64")]
		public void Get(string uid, string passphrase)
		{
		}
	}
}
