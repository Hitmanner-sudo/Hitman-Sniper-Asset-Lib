using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C1E")]
	public class SvcOpUpdateInfocastElementInstanceSegmentation : SvcOpGet
	{
		[Token(Token = "0x4003C4F")]
		private const string SVCOPNAME = "UpdateInfocastElementInstanceSegmentation";

		[Token(Token = "0x4003C50")]
		private const string QUERYSTRING_PARAM_INFOCASTID_KEY = "s_infocastid";

		[Token(Token = "0x4003C51")]
		private const string QUERYSTRING_PARAM_ABTEST_KEY = "s_abtest";

		[Token(Token = "0x4003C52")]
		private const string QUERYSTRING_PARAM_SEGMENT_KEY = "s_segment";

		[Token(Token = "0x170009C0")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004C84")]
			[Address(RVA = "0xB48B64", Offset = "0xB48B64", VA = "0xB48B64", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C83")]
		[Address(RVA = "0xB48AE4", Offset = "0xB48AE4", VA = "0xB48AE4")]
		public SvcOpUpdateInfocastElementInstanceSegmentation([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004C85")]
		[Address(RVA = "0xB48BA8", Offset = "0xB48BA8", VA = "0xB48BA8")]
		public void Get(string infocastID, string abtest, string segment)
		{
		}
	}
}
