using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.ServiceOperations
{
	[Token(Token = "0x2000B91")]
	public class SvcOpPushNotificationList : SvcOpPost
	{
		[Token(Token = "0x4003A86")]
		private const string SVCOPNAME = "PushNotificationList";

		[Token(Token = "0x4003A87")]
		private const string QUERYSTRING_PARAM_MESSAGE_ID = "s_messageId";

		[Token(Token = "0x17000939")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x600498F")]
			[Address(RVA = "0xD3E62C", Offset = "0xD3E62C", VA = "0xD3E62C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600498E")]
		[Address(RVA = "0xD3E5B0", Offset = "0xD3E5B0", VA = "0xD3E5B0")]
		public SvcOpPushNotificationList([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004990")]
		[Address(RVA = "0xD3E670", Offset = "0xD3E670", VA = "0xD3E670")]
		public void Post(string jsonParams, string messageId)
		{
		}
	}
}
