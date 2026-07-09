using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DCC")]
	public class SvcOpTransferFacebookId : SvcOpGet
	{
		[Token(Token = "0x40041CE")]
		private const string SVCOPNAME = "TransferFacebookId";

		[Token(Token = "0x40041CF")]
		public const string QUERYSTRING_PARAM_UID_OLD = "s_uidOld";

		[Token(Token = "0x40041D0")]
		public const string QUERYSTRING_PARAM_UID_NEW = "s_uidNew";

		[Token(Token = "0x40041D1")]
		public const string QUERYSTRING_PARAM_FBID = "s_fbid";

		[Token(Token = "0x17000B49")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054E8")]
			[Address(RVA = "0xB48268", Offset = "0xB48268", VA = "0xB48268", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054E7")]
		[Address(RVA = "0xB48254", Offset = "0xB48254", VA = "0xB48254")]
		public SvcOpTransferFacebookId([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60054E9")]
		[Address(RVA = "0xB482AC", Offset = "0xB482AC", VA = "0xB482AC")]
		public void Get(string uidOld, string uidNew, string fbid)
		{
		}
	}
}
