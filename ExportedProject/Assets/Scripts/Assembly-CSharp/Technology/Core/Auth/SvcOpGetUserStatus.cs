using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DC8")]
	public sealed class SvcOpGetUserStatus : SvcOpGetPlayerProfile
	{
		[Token(Token = "0x40041C9")]
		private const string SVCOPNAME = "GetUserStatus";

		[Token(Token = "0x17000B45")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054DC")]
			[Address(RVA = "0xD3A938", Offset = "0xD3A938", VA = "0xD3A938", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054DB")]
		[Address(RVA = "0xD3A934", Offset = "0xD3A934", VA = "0xD3A934")]
		public SvcOpGetUserStatus([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60054DD")]
		[Address(RVA = "0xD3A97C", Offset = "0xD3A97C", VA = "0xD3A97C")]
		public new void Get(string userid, string language)
		{
		}
	}
}
