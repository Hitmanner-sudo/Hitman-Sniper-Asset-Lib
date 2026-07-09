using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.ServiceOperations
{
	[Token(Token = "0x2000B92")]
	public class SvcOpRegisterNotification : SvcOpPost
	{
		[Token(Token = "0x4003A88")]
		private const string SVCOPNAME = "RegisterNotification";

		[Token(Token = "0x4003A89")]
		private const string QUERYSTRING_PARAM_MESSAGE_ID = "s_messageId";

		[Token(Token = "0x1700093A")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004992")]
			[Address(RVA = "0xD3EAB0", Offset = "0xD3EAB0", VA = "0xD3EAB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004991")]
		[Address(RVA = "0xD3EA34", Offset = "0xD3EA34", VA = "0xD3EA34")]
		public SvcOpRegisterNotification([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004993")]
		[Address(RVA = "0xD3EAF4", Offset = "0xD3EAF4", VA = "0xD3EAF4")]
		public void Post(string jsonParams, string messageId)
		{
		}
	}
}
