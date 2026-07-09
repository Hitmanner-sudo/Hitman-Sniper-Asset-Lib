using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C1B")]
	public class SvcOpQueueInfocastElement : SvcOpPost
	{
		[Token(Token = "0x4003C43")]
		private const string SVCOPNAME = "QueueInfocastElement";

		[Token(Token = "0x4003C44")]
		public const string QUERYSTRING_PARAM_TYPE_KEY = "s_type";

		[Token(Token = "0x4003C45")]
		public const string QUERYSTRING_PARAM_START_KEY = "d_start";

		[Token(Token = "0x4003C46")]
		public const string QUERYSTRING_PARAM_END_KEY = "d_end";

		[Token(Token = "0x170009BD")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004C7B")]
			[Address(RVA = "0xD3E78C", Offset = "0xD3E78C", VA = "0xD3E78C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C7A")]
		[Address(RVA = "0xD3E77C", Offset = "0xD3E77C", VA = "0xD3E77C")]
		public SvcOpQueueInfocastElement([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004C7C")]
		[Address(RVA = "0xD3E7D0", Offset = "0xD3E7D0", VA = "0xD3E7D0")]
		public void Post(string type, string start, string end, string jsonParams)
		{
		}
	}
}
