using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CC1")]
	public sealed class SvcOpRefreshFacebookFriends : SvcOpGetFacebook
	{
		[Token(Token = "0x4003DB0")]
		private const string SVCOPNAME = "RefreshFacebookFriends";

		[Token(Token = "0x17000A69")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F3B")]
			[Address(RVA = "0xD3E9EC", Offset = "0xD3E9EC", VA = "0xD3E9EC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F3A")]
		[Address(RVA = "0xD3E9E8", Offset = "0xD3E9E8", VA = "0xD3E9E8")]
		public SvcOpRefreshFacebookFriends([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F3C")]
		[Address(RVA = "0xD3EA30", Offset = "0xD3EA30", VA = "0xD3EA30")]
		public new void Get(string uid)
		{
		}
	}
}
