using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DC7")]
	public sealed class SvcOpGetUserProfileGameSpecific : SvcOpGetPlayerProfile
	{
		[Token(Token = "0x40041C7")]
		private const string SVCOPNAME = "GetUserProfileGameSpecific";

		[Token(Token = "0x40041C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<HttpStatusCode> AcceptableCodes;

		[Token(Token = "0x17000B43")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054D7")]
			[Address(RVA = "0xD3A570", Offset = "0xD3A570", VA = "0xD3A570", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B44")]
		public override List<HttpStatusCode> AcceptableNonSuccessCodes
		{
			[Token(Token = "0x60054D8")]
			[Address(RVA = "0xD3A5B4", Offset = "0xD3A5B4", VA = "0xD3A5B4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054D6")]
		[Address(RVA = "0xD3A56C", Offset = "0xD3A56C", VA = "0xD3A56C")]
		public SvcOpGetUserProfileGameSpecific([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60054D9")]
		[Address(RVA = "0xD3A618", Offset = "0xD3A618", VA = "0xD3A618")]
		public void Get(string userid, bool useIfModifiedSince)
		{
		}
	}
}
