using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DCB")]
	public sealed class SvcOpSetUserProfileGameSpecific : SvcOpPost
	{
		[Token(Token = "0x40041CC")]
		private const string SVCOPNAME = "SetUserProfileGameSpecific";

		[Token(Token = "0x40041CD")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x17000B48")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054E5")]
			[Address(RVA = "0xB480D4", Offset = "0xB480D4", VA = "0xB480D4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054E4")]
		[Address(RVA = "0xB480C0", Offset = "0xB480C0", VA = "0xB480C0")]
		public SvcOpSetUserProfileGameSpecific([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60054E6")]
		[Address(RVA = "0xB48118", Offset = "0xB48118", VA = "0xB48118")]
		public void Post(string userid, KeyValuePair<string, string>[] pairs)
		{
		}
	}
}
