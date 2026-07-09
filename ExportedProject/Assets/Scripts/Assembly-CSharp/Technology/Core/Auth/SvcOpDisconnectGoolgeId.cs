using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DC2")]
	public class SvcOpDisconnectGoolgeId : SvcOpGet
	{
		[Token(Token = "0x40041B8")]
		private const string SVCOPNAME = "DisconnectGoogleId";

		[Token(Token = "0x40041B9")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x17000B3E")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054C2")]
			[Address(RVA = "0xD36BEC", Offset = "0xD36BEC", VA = "0xD36BEC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054C1")]
		[Address(RVA = "0xD36BDC", Offset = "0xD36BDC", VA = "0xD36BDC")]
		public SvcOpDisconnectGoolgeId([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60054C3")]
		[Address(RVA = "0xD36C30", Offset = "0xD36C30", VA = "0xD36C30")]
		public void Get(string uid)
		{
		}
	}
}
