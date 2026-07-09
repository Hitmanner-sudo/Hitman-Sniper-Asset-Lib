using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DC6")]
	public sealed class SvcOpGetUserProfileCountry : SvcOpGetPlayerProfile
	{
		[Token(Token = "0x40041C6")]
		private const string SVCOPNAME = "GetUserProfileCountry";

		[Token(Token = "0x17000B42")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054D4")]
			[Address(RVA = "0xD3A524", Offset = "0xD3A524", VA = "0xD3A524", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054D3")]
		[Address(RVA = "0xD277C4", Offset = "0xD277C4", VA = "0xD277C4")]
		public SvcOpGetUserProfileCountry([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60054D5")]
		[Address(RVA = "0xD3A568", Offset = "0xD3A568", VA = "0xD3A568")]
		public new void Get(string userid)
		{
		}
	}
}
