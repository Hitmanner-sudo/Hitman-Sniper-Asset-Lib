using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C19")]
	public class SvcOpGetInfocastElementInstance : SvcOpGet
	{
		[Token(Token = "0x4003C3F")]
		private const string SVCOPNAME = "GetInfocastElementInstance";

		[Token(Token = "0x4003C40")]
		private const string QUERYSTRING_PARAM_INFOCASTID_KEY = "s_infocastid";

		[Token(Token = "0x170009BB")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004C75")]
			[Address(RVA = "0xD37D68", Offset = "0xD37D68", VA = "0xD37D68", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C74")]
		[Address(RVA = "0xD37CEC", Offset = "0xD37CEC", VA = "0xD37CEC")]
		public SvcOpGetInfocastElementInstance([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004C76")]
		[Address(RVA = "0xD37DAC", Offset = "0xD37DAC", VA = "0xD37DAC")]
		public void Get(string infocastID)
		{
		}
	}
}
