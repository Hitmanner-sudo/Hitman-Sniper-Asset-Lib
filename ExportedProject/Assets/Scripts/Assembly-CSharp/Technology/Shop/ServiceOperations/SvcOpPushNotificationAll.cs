using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.ServiceOperations
{
	[Token(Token = "0x2000B90")]
	public class SvcOpPushNotificationAll : SvcOpPost
	{
		[Token(Token = "0x4003A84")]
		private const string SVCOPNAME = "PushNotificationAll";

		[Token(Token = "0x4003A85")]
		private const string QUERYSTRING_PARAM_MESSAGE_ID = "s_messageId";

		[Token(Token = "0x17000938")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x600498C")]
			[Address(RVA = "0xD3E160", Offset = "0xD3E160", VA = "0xD3E160", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600498B")]
		[Address(RVA = "0xD3E0E4", Offset = "0xD3E0E4", VA = "0xD3E0E4")]
		public SvcOpPushNotificationAll([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x600498D")]
		[Address(RVA = "0xD3E1A4", Offset = "0xD3E1A4", VA = "0xD3E1A4")]
		public void Post(string jsonParams, string messageId)
		{
		}
	}
}
