using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.ServiceOperations
{
	[Token(Token = "0x2000B93")]
	public class SvcOpUnregisterNotification : SvcOpPost
	{
		[Token(Token = "0x4003A8A")]
		private const string SVCOPNAME = "UnregisterNotification";

		[Token(Token = "0x4003A8B")]
		private const string QUERYSTRING_PARAM_MESSAGE_ID = "s_messageId";

		[Token(Token = "0x1700093B")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004995")]
			[Address(RVA = "0xB484B4", Offset = "0xB484B4", VA = "0xB484B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004994")]
		[Address(RVA = "0xB48434", Offset = "0xB48434", VA = "0xB48434")]
		public SvcOpUnregisterNotification([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004996")]
		[Address(RVA = "0xB484F8", Offset = "0xB484F8", VA = "0xB484F8")]
		public void Post(string messageId)
		{
		}
	}
}
