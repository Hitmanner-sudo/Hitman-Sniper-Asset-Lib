using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DCD")]
	public sealed class SvcOpUpdateCharacter : SvcOpGetPlayerProfile
	{
		[Token(Token = "0x40041D2")]
		private const string SVCOPNAME = "UpdateCharacter";

		[Token(Token = "0x17000B4A")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054EB")]
			[Address(RVA = "0xB48744", Offset = "0xB48744", VA = "0xB48744", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054EA")]
		[Address(RVA = "0xB4873C", Offset = "0xB4873C", VA = "0xB4873C")]
		public SvcOpUpdateCharacter([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60054EC")]
		[Address(RVA = "0xB48788", Offset = "0xB48788", VA = "0xB48788")]
		public void Get(string userid, string name, KeyValuePair<string, string>[] pairs)
		{
		}
	}
}
