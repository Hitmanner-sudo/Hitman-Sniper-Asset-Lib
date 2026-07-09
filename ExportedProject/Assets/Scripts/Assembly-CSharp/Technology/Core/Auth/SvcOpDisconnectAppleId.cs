using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DC1")]
	public class SvcOpDisconnectAppleId : SvcOpGet
	{
		[Token(Token = "0x40041B6")]
		private const string SVCOPNAME = "DisconnectAppleId";

		[Token(Token = "0x40041B7")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x17000B3D")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054BF")]
			[Address(RVA = "0xD3695C", Offset = "0xD3695C", VA = "0xD3695C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054BE")]
		[Address(RVA = "0xD3694C", Offset = "0xD3694C", VA = "0xD3694C")]
		public SvcOpDisconnectAppleId([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60054C0")]
		[Address(RVA = "0xD369A0", Offset = "0xD369A0", VA = "0xD369A0")]
		public void Get(string uid)
		{
		}
	}
}
