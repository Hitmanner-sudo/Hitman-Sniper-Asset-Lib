using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CDE")]
	public class SvcOpAppleValidateReceipt : SvcOpPost
	{
		[Token(Token = "0x4003DF8")]
		private const string QUERYSTRING_PARAM_UID = "s_uid";

		[Token(Token = "0x4003DF9")]
		private const string SVCOPNAME = "AppleValidateReceipt_Post";

		[Token(Token = "0x17000A8A")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004FB4")]
			[Address(RVA = "0xD35338", Offset = "0xD35338", VA = "0xD35338", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004FB3")]
		[Address(RVA = "0xD35328", Offset = "0xD35328", VA = "0xD35328")]
		public SvcOpAppleValidateReceipt([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x6004FB5")]
		[Address(RVA = "0xD3537C", Offset = "0xD3537C", VA = "0xD3537C")]
		public void Get(string receiptData, string uid)
		{
		}
	}
}
