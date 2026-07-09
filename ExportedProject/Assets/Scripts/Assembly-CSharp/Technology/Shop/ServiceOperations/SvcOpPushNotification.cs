using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.ServiceOperations
{
	[Token(Token = "0x2000B8F")]
	public class SvcOpPushNotification : SvcOpPost
	{
		[Token(Token = "0x4003A81")]
		private const string SVCOPNAME = "PushNotification";

		[Token(Token = "0x4003A82")]
		private const string QUERYSTRING_PARAM_MESSAGE_ID = "s_messageId";

		[Token(Token = "0x4003A83")]
		private const string QUERYSTRING_PARAM_USER_ID = "s_uid";

		[Token(Token = "0x17000937")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004989")]
			[Address(RVA = "0xD3DF48", Offset = "0xD3DF48", VA = "0xD3DF48", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004988")]
		[Address(RVA = "0xD3DECC", Offset = "0xD3DECC", VA = "0xD3DECC")]
		public SvcOpPushNotification([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x600498A")]
		[Address(RVA = "0xD3DF8C", Offset = "0xD3DF8C", VA = "0xD3DF8C")]
		public void Post(string jsonParams, string messageId, string userId)
		{
		}
	}
}
