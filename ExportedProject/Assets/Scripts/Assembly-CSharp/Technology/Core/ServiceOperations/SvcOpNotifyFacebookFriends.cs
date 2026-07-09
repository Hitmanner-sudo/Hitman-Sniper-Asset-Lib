using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CC0")]
	public sealed class SvcOpNotifyFacebookFriends : SvcOpGetFacebook
	{
		[Token(Token = "0x4003DAF")]
		private const string SVCOPNAME = "NotifyFacebookFriends";

		[Token(Token = "0x17000A68")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F38")]
			[Address(RVA = "0xD3CD0C", Offset = "0xD3CD0C", VA = "0xD3CD0C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F37")]
		[Address(RVA = "0xD3CD08", Offset = "0xD3CD08", VA = "0xD3CD08")]
		public SvcOpNotifyFacebookFriends([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F39")]
		[Address(RVA = "0xD3CD50", Offset = "0xD3CD50", VA = "0xD3CD50")]
		public new void Get(string userid, string notificationId, string[] messageParams)
		{
		}
	}
}
