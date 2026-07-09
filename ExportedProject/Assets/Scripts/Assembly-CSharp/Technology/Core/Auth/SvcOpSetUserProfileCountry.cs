using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DCA")]
	public sealed class SvcOpSetUserProfileCountry : SvcOpGetPlayerProfile
	{
		[Token(Token = "0x40041CB")]
		private const string SVCOPNAME = "SetUserProfileCountry";

		[Token(Token = "0x17000B47")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054E2")]
			[Address(RVA = "0xB48074", Offset = "0xB48074", VA = "0xB48074", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054E1")]
		[Address(RVA = "0xB4806C", Offset = "0xB4806C", VA = "0xB4806C")]
		public SvcOpSetUserProfileCountry([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60054E3")]
		[Address(RVA = "0xB480B8", Offset = "0xB480B8", VA = "0xB480B8")]
		public new void Get(string userid, string country)
		{
		}
	}
}
