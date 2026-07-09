using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DC9")]
	public sealed class SvcOpReplaceCharacter : SvcOpGetPlayerProfile
	{
		[Token(Token = "0x40041CA")]
		private const string SVCOPNAME = "ReplaceCharacter";

		[Token(Token = "0x17000B46")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054DF")]
			[Address(RVA = "0xD3EEF0", Offset = "0xD3EEF0", VA = "0xD3EEF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054DE")]
		[Address(RVA = "0xD3EEEC", Offset = "0xD3EEEC", VA = "0xD3EEEC")]
		public SvcOpReplaceCharacter([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60054E0")]
		[Address(RVA = "0xD3EF34", Offset = "0xD3EF34", VA = "0xD3EF34")]
		public void Get(string userid, string name, KeyValuePair<string, string>[] pairs)
		{
		}
	}
}
