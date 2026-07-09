using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DCE")]
	public sealed class SvcOpUpdateUserProfileGameSpecific : SvcOpPost
	{
		[Token(Token = "0x40041D3")]
		private const string SVCOPNAME = "UpdateUserProfileGameSpecific";

		[Token(Token = "0x17000B4B")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054EE")]
			[Address(RVA = "0xB493F8", Offset = "0xB493F8", VA = "0xB493F8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054ED")]
		[Address(RVA = "0xB493E4", Offset = "0xB493E4", VA = "0xB493E4")]
		public SvcOpUpdateUserProfileGameSpecific([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60054EF")]
		[Address(RVA = "0xB4943C", Offset = "0xB4943C", VA = "0xB4943C")]
		public void Post(string userid, KeyValuePair<string, string>[] pairs, [Optional] BitArray disableValueQuotesArray)
		{
		}
	}
}
