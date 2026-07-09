using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C1A")]
	public class SvcOpGetInfocastElementInstances : SvcOpGet
	{
		[Token(Token = "0x4003C41")]
		private const string SVCOPNAME = "GetInfocastElementInstances";

		[Token(Token = "0x4003C42")]
		private const string QUERYSTRING_PARAM_TYPE_KEY = "s_type";

		[Token(Token = "0x170009BC")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004C78")]
			[Address(RVA = "0xD37F2C", Offset = "0xD37F2C", VA = "0xD37F2C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C77")]
		[Address(RVA = "0xD37EB0", Offset = "0xD37EB0", VA = "0xD37EB0")]
		public SvcOpGetInfocastElementInstances([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004C79")]
		[Address(RVA = "0xD37F70", Offset = "0xD37F70", VA = "0xD37F70")]
		public void Get(string type)
		{
		}
	}
}
