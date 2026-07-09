using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C1C")]
	public class SvcOpSegmentInfocastElement : SvcOpPost
	{
		[Token(Token = "0x4003C47")]
		private const string SVCOPNAME = "SegmentInfocastElement";

		[Token(Token = "0x4003C48")]
		public const string QUERYSTRING_PARAM_ABTEST_KEY = "s_abtest";

		[Token(Token = "0x4003C49")]
		public const string QUERYSTRING_PARAM_SEGMENT_KEY = "s_segment";

		[Token(Token = "0x4003C4A")]
		public const string QUERYSTRING_PARAM_TYPE_KEY = "s_type";

		[Token(Token = "0x4003C4B")]
		public const string QUERYSTRING_PARAM_START_KEY = "d_start";

		[Token(Token = "0x4003C4C")]
		public const string QUERYSTRING_PARAM_END_KEY = "d_end";

		[Token(Token = "0x170009BE")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004C7E")]
			[Address(RVA = "0xB47630", Offset = "0xB47630", VA = "0xB47630", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C7D")]
		[Address(RVA = "0xB4761C", Offset = "0xB4761C", VA = "0xB4761C")]
		public SvcOpSegmentInfocastElement([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004C7F")]
		[Address(RVA = "0xB47674", Offset = "0xB47674", VA = "0xB47674")]
		public void Post(string abtest, string segment, string type, string start, string end, string jsonParams)
		{
		}
	}
}
